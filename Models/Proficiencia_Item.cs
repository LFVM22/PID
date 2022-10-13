using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Keyless]
public class Proficiencia_Item{
    public int IdPersonagem { get; set; }
    public int IdItem { get; set; }

    public void SetProficiencia(int IdP, int IdI){
        this.IdPersonagem = IdP;
        this.IdItem = IdI;
    }
}