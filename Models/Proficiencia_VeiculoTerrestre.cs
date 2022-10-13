using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Proficiencia_VeiculoTerrestre{
    public int IdPersonagem { get; set; }
    public int IdVeiculoTerrestre { get; set; }

    public void SetProficiencia(int IdP, int IdVT){
        this.IdPersonagem = IdP;
        this.IdVeiculoTerrestre = IdVT;
    }
}