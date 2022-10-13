using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Personagem_Armadura
{
    public int IdPersonagem { get; set; }

    public int IdArmadura { get; set; }
    

    public void SetPersonagem_Armadura(int ida, int idp){
        this.IdArmadura = ida;
        this.IdPersonagem = idp;
    }

}