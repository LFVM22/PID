using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Idioma_Personagem
{
    public int IdIdioma { get; set; }
    public Idioma Idioma { get; set; }

    public int IdPersonagem { get; set; }
    public Personagem Personagem { get; set; }
}