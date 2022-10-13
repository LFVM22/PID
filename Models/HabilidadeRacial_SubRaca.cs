using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class HabilidadeRacial_SubRaca
{
    public int IdHabilidadeRacial { get; set; }
    public HabilidadeRacial HabilidadeRacial { get; set; }

    public int IdSubRaca { get; set; }
    public SubRaca SubRaca { get; set; }

}