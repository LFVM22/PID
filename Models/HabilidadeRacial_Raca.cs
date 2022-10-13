using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class HabilidadeRacial_Raca
{

    public int IdHabilidadeRacial { get; set; }
    public HabilidadeRacial HabilidadeRacial { get; set; }

    public int IdRaca { get; set; }
    public Raca Raca { get; set; }

}