using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Proficiencia_ASVTracao{
    public int IdPersonagem { get; set; }
    public int IdASVTracao { get; set; }

    public void SetProficiencia(int IdP, int IdASVTRacao){
        this.IdPersonagem = IdP;
        this.IdASVTracao = IdASVTRacao;
    }
    
    
}