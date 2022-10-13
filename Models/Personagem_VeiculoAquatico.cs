using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Personagem_VeiculoAquatico
{
    public int IdPersonagem { get; set; }

    public int IdVeiculoAquatico { get; set; }
    

    public void SetPersonagem_VeiculoAquatico(int ida, int idp){
        this.IdVeiculoAquatico = ida;
        this.IdPersonagem = idp;
    }

}