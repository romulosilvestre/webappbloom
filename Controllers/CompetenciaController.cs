
using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.ViewModels;
using WebAppBloom.Contexts;
namespace WebAppBloom.Controllers;
public class CompetenciaController : Controller
{

    private readonly AppDbContext _context;

    public CompetenciaController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {

        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "Memorizar";
        competencia.LinhaBloom = "Listar";
        ViewData["titulo"] = "Compreender o funcionamento do Razor";
        ViewData["tablebloom"] = competencia;
        return View();
    }

    public IActionResult RelatorioCompe()
    {

        var competencias = _context.Competencias.ToList();
        return View();
    }
    public IActionResult Listar()
    {
        //pega os dados do banco
        var listaCompe = _context.Competencias.ToList();

        //envia o objeto listaCompe (dados do banco)
        //para a ViewModel (ICollection<>   List<>)
        var listaViewModel = new ListaCompetenciaViewModel
        {
            Competencias = listaCompe
        };
        return View(listaViewModel);
    }
    public IActionResult Taxonomia(){
         //pega os dados do banco
        var listaCompe = _context.Competencias.ToList();

        //envia o objeto listaCompe (dados do banco)
        //para a ViewModel (ICollection<>   List<>)
        var listaViewModel = new ListaCompetenciaViewModel
        {
            Competencias = listaCompe
        };
        return View(listaViewModel);
        return View();
    }


    public IActionResult Criar()
    {
        ViewData["Titulo"] = "Cadastrar Taxonomia de Bloom";
        return View();
    }
    [HttpPost]
    public IActionResult Criar(CriarCompetenciaViewModel dados)
    {
        var competencia = new Competencia(dados.ColunaBloom, dados.LinhaBloom);
        _context.Add(competencia);
        _context.SaveChanges();
        //Quero redirecionar para a página Listar.cshtml
        return RedirectToAction(nameof(Listar));

    }
    
    public IActionResult Deletar(int id)
    {

        var competencia = _context.Competencias.Find(id);
        if (competencia is null)
        {
            return NotFound();
        }

        _context.Remove(competencia);
        _context.SaveChanges();
        return RedirectToAction(nameof(Listar));

    }


}