using Microsoft.AspNetCore.Mvc;
using TP4_biss.Models;

namespace TP4_biss.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
         ViewBag.ListaPaises = Info.ListarPaises();
        return View("index");
    }
    public IActionResult DetallePais(string Pais)
    {
        ViewBag.PaisBuscado = Info.DetallePais(Pais);

        return View("detallepais");
    }
}
