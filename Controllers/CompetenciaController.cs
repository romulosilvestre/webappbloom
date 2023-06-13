
using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.ViewModels;
namespace WebAppBloom.Controllers;
public class CompetenciaController:Controller{
    
   public IActionResult Index(){

         Competencia competencia = new Competencia();
         competencia.ColunaBloom = "Memorizar";
         competencia.LinhaBloom = "Listar";
         ViewData["titulo"] = "Compreender o funcionamento do Razor";
         ViewData["tablebloom"] = competencia;
         return View();
   }

   public IActionResult RelatorioCompe(){
      
      var competencia = new Competencia(){
           ColunaBloom = "Teste Coluna",
           LinhaBloom = "Teste Linha"
      };
      
      var viewModel = new DetalhesCompViewModel(){
            Competencia = competencia,
            TituloPagina = "Página de Teste"
      };
      return View(viewModel);




   }

}