using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;


namespace Projeto.Controllers;

public class FichaController : Controller
{
    private DataContext _db;
    public FichaController(DataContext db)
    {
        _db = db;
    } 
    public ActionResult Exibir(int IdPersonagem)
    {
        ViewBagdeCria();
        var personagem = _db.Personagens.Find(IdPersonagem);
        return View(personagem);
    }
    public void ViewBagdeCria(){
        var listaraca = _db.Racas.AsNoTracking().ToList();
        var listausuario = _db.Usuarios.AsNoTracking().ToList();
        var listasubraca = _db.SubRacas.AsNoTracking().ToList();
        var listaitem = _db.Itens.AsNoTracking().ToList();
        var listaitempersonagem = _db.Personagens_Itens.AsNoTracking().ToList();
        var listaarma = _db.Armas.AsNoTracking().ToList();
        var listaarmapersonagem = _db.Personagens_Armas.AsNoTracking().ToList();
        var listaarmadura = _db.Armaduras.AsNoTracking().ToList();
        var listaarmadurapersonagem = _db.Personagens_Armaduras.AsNoTracking().ToList();
        var listatipoarma = _db.TiposArmas.AsNoTracking().ToList();
        var listatipoarmadura = _db.TiposArmaduras.AsNoTracking().ToList();
        var listaclasse = _db.Classes.AsNoTracking().ToList();
        var listatraco = _db.TracosdeClasse.AsNoTracking().ToList();
        var listaarquetipo = _db.Arquetipos.AsNoTracking().ToList();
        var listaclassetracosdeclasse = _db.Classes_TracosdeClasses.AsNoTracking().ToList();
        var listatracodeclassearquetipo = _db.TracosdeClasse_Arquetipos.AsNoTracking().ToList();
        var listaantecedente = _db.Antecedentes.AsNoTracking().ToList();
        var listahabilidade = _db.HabilidadesRaciais.AsNoTracking().ToList();
        var listahabilidaderaca = _db.HabilidadesRaciais_Racas.AsNoTracking().ToList();
        var listahabilidadesubraca = _db.HabilidadesRaciais_SubRacas.AsNoTracking().ToList();
        var listaproficienciaarma = _db.Proficiencias_Armas.AsNoTracking().ToList();
        var listaproficienciaarmadura = _db.Proficiencias_Armaduras.AsNoTracking().ToList();
        var listaproficienciaitem = _db.Proficiencias_Itens.AsNoTracking().ToList();
        ViewBag.listaclasse = listaclasse;
        ViewBag.listatraco = listatraco;
        ViewBag.listaarquetipo = listaarquetipo;
        ViewBag.listaclassetracosdeclasse = listaclassetracosdeclasse;
        ViewBag.listatracodeclassearquetipo = listatracodeclassearquetipo;
        ViewBag.listaitem = listaitem;
        ViewBag.listaitempersonagem = listaitempersonagem;
        ViewBag.listaarma = listaarma;
        ViewBag.listaarmapersonagem = listaarmapersonagem;
        ViewBag.listaarmadura = listaarmadura;
        ViewBag.listaarmadurapersonagem = listaarmadurapersonagem;
        ViewBag.listatipoarma = listatipoarma;
        ViewBag.listatipoarmadura = listatipoarmadura;
        ViewBag.listaraca = listaraca;
        ViewBag.listausuario = listausuario;
        ViewBag.listasubraca = listasubraca;
        ViewBag.listaantecedente = listaantecedente;
        ViewBag.listahabilidade = listahabilidade;
        ViewBag.listahabilidaderaca = listahabilidaderaca;
        ViewBag.listahabilidadesubraca = listahabilidadesubraca;
        ViewBag.listaproficienciaarma = listaproficienciaarma;
        ViewBag.listaproficienciaarmadura = listaproficienciaarmadura;
        ViewBag.listaproficienciaitem = listaproficienciaitem;
    }
    
}