using Microsoft.AspNetCore.Mvc;
using Models;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Projeto.Controllers;

public class ItemController : Controller
{
    private readonly DataContext _db;
    public ItemController(DataContext db)
    {
        _db = db;
    }

    [HttpGet]
    public ActionResult Escolher(int IdPersonagem)
    {
        var personagem = _db.Personagens.Find(IdPersonagem);
        ViewBagdeCria();
        var personagem_arma = new Personagem_Arma();
        var personagem_armadura = new Personagem_Armadura();
        var personagem_item = new Personagem_Item();
        return View(personagem);
    }

    public void ViewBagdeCria()
    {
        var listaitem = _db.Itens.AsNoTracking().ToList();
        var listaarma = _db.Armas.AsNoTracking().ToList();
        var listaarmadura = _db.Armaduras.AsNoTracking().ToList();
        var listatipoarma = _db.TiposArmas.AsNoTracking().ToList();
        var listatipoarmadura = _db.TiposArmaduras.AsNoTracking().ToList();
        ViewBag.listaitem = listaitem;
        ViewBag.listaarma = listaarma;
        ViewBag.listaarmadura = listaarmadura;
        ViewBag.listatipoarma = listatipoarma;
        ViewBag.listatipoarmadura = listatipoarmadura;
    }
    [HttpPost]
    public ActionResult Escolher(Personagem personagem, int IdPersonagem, List<int> armas, List<int> armaduras, List<int> itens)
    {
        var varoriginal = _db.Personagens.Find(IdPersonagem);
        List<int> testearma = new List<int>();
        List<int> testearmadura = new List<int>();
        List<int> testeitem = new List<int>();
        
        
        if(personagem.IdClasse == 1){
            itens.Add(138);
        }
        else if(personagem.IdClasse == 2){
            armaduras.Add(2);
            armas.Add(1);
        }
        else if(personagem.IdClasse == 3){
            armaduras.Add(13);
        }
        else if(personagem.IdClasse == 4)
        {
            armaduras.Add(2);
            itens.Add(138);
        }
        else if(personagem.IdClasse == 5)
        {
            
        }

        foreach (var arma in armas)
        {
            
            var personagem_arma = new Personagem_Arma();
            if (armas is null)
            {
                return RedirectToAction("Index");
            }
            if(!testearma.Contains(arma)){
                personagem_arma.SetPersonagem_Arma(arma, IdPersonagem);
                _db.Personagens_Armas.Add(personagem_arma);
            }
            testearma.Add(arma);
        }
        foreach (var armadura in armaduras)
        {
            var personagem_armadura = new Personagem_Armadura();
            if (armaduras is null)
            {
                return RedirectToAction("Index");
            }
            if(!testearmadura.Contains(armadura)){
                 personagem_armadura.SetPersonagem_Armadura(armadura, IdPersonagem);
            _db.Personagens_Armaduras.Add(personagem_armadura);
            }
           testearmadura.Add(armadura);
            
        }
        foreach (var item in itens)
        {
            var personagem_item = new Personagem_Item();
            if (itens is null)
            {
                return RedirectToAction("Index");
            }
            if(!testearmadura.Contains(item)){
                 personagem_item.SetPersonagem_Item(item, IdPersonagem);
            _db.Personagens_Itens.Add(personagem_item);
            }
           testeitem.Add(item);
        }
        if (varoriginal is null)
        {
            return RedirectToAction("Index");
        }
        _db.SaveChanges();
        return RedirectToAction("ExibirFicha", "Home");
    }
}