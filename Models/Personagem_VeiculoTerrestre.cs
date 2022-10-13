using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Personagem_VeiculoTerrestre
{
    public int IdPersonagem { get; set; }

    public int IdVeiculoTerrestre { get; set; }
    

    public void SetPersonagem_VeiculoTerrestre(int idi, int idp){
        this.IdVeiculoTerrestre = idi;
        this.IdPersonagem = idp;
    }
}