using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Classe_TracodeClasse{
    public int IdClasse { get; set; }
    public Classe Classe { get; set; }

    public int IdTracodeClasse { get; set; }
    public TracodeClasse TracodeClasse { get; set; }
    
    public int? Nivel { get; set; }

    
}