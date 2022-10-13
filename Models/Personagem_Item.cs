using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models;
[Keyless]
public class Personagem_Item
{
    public int IdPersonagem { get; set; }

    public int IdItem { get; set; }


    public void SetPersonagem_Item(int idi, int idp)
    {
        this.IdItem = idi;
        this.IdPersonagem = idp;
    }
}