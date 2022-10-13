using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class TracodeClasse_Arquetipo
{
    public int IdTracodeClasse { get; set; }
    public TracodeClasse TracodeClasse { get; set; }

    public int IdArquetipo { get; set; }
    public Arquetipo Arquetipo { get; set; }
}