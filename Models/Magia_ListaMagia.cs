using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Magia_ListaMagia
{
    public int IdMagia { get; set; }
    public Magia Magia { get; set; }


    public int IdListaMagia { get; set; }
    public ListaMagia ListaMagia { get; set; }

    public int Ciclo { get; set; }
}