using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Proficiencia_VeiculoAquatico{
    public int IdPersonagem { get; set; }
    public int IdVeiculoAquatico { get; set; }

    public void SetProficiencia(int IdP, int IdVI){
        this.IdPersonagem = IdP;
        this.IdVeiculoAquatico = IdVI;
    }
}