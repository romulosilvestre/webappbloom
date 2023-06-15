
namespace WebAppBloom.Models;
public class Competencia{    
    public int Id { get; set; }
    
    public string? ColunaBloom { get; set; }

    public string? LinhaBloom { get; set; }
    
    public Competencia(){
        
    }
    public Competencia(string? colunaBloom, string? linhaBloom)
    {        
        ColunaBloom = colunaBloom;
        LinhaBloom = linhaBloom;
    }
}

