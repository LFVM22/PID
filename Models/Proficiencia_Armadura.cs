using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Proficiencia_Armadura{
    public int IdPersonagem { get; set; }
    public int IdArmadura { get; set; }

    public void SetProficiencia(int IdP, int IdA){
        this.IdPersonagem = IdP;
        this.IdArmadura = IdA;
    }
    public void SetProficienciaTipo(int Idp, int IdT){
        if(IdT == 1)
        {
            for(int i = 1; i<=3; i++){
                this.IdArmadura = i;
                this.IdPersonagem = Idp;
            }
        }
        else if(IdT == 2)
        {
            for(int i = 4; i<=8; i++){
                this.IdArmadura = i;
                this.IdPersonagem = Idp;
            }
        }
        else if(IdT == 3)
        {
            for(int i = 9; i<=12; i++){
                this.IdArmadura = i;
                this.IdPersonagem = Idp;
            }
        }
        else if(IdT == 4)
        {
            for(int i = 13; i<=13; i++){
                this.IdArmadura = i;
                this.IdPersonagem = Idp;
            }
        }
    }
    
    
}