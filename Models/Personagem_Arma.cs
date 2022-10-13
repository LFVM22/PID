using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Personagem_Arma
{
    public int IdPersonagem { get; set; }

    public int IdArma { get; set; }
    

    public void SetPersonagem_Arma(int ida, int idp){
        this.IdArma = ida;
        this.IdPersonagem = idp;
    }
}