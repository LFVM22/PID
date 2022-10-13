using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Personagem_ASVTracao
{
    public int IdPersonagem { get; set; }

    public int IdASVTracao { get; set; }
    

    public void SetPersonagem_ASVTracao(int idasvtracao, int idp){
        this.IdASVTracao = idasvtracao;
        this.IdPersonagem = idp;
    }
}