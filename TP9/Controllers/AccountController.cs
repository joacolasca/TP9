using Microsoft.AspNetCore.Mvc;
using TP9.Models;

namespace TP9.Controllers;

public class AccountController : Controller
{
   public IActionResult Index()
    {
        return View();
    }
    public IActionResult Registro()
    {
        return View("Registro");
    }
    public IActionResult IngresarRegistro(Usuario usuario)
    {
      BD.InsertarUsuario(usuario);
      return View("Index");
    }
     public IActionResult Login(string UserName, string Contraseña)
     {
        ViewBag.Usuario = BD.ObtenerUsuario(UserName, Contraseña);
        if(ViewBag.Usuario != null){
         return View("Bienvenida");
        }
        else{
         ViewBag.Error = "La contraseña no coincide con el usuario";
         return View("Index");
        }
        
     }
     public IActionResult CambiarContraseña(string UserName, string Contraseña)
     {
        BD.CambiarContraseña(UserName, Contraseña);
        return View("Index");
     }
      public IActionResult IrCambiarContraseña()
      {
         return View("OlvideContraseña");
      }
      public IActionResult Bienvenida()
      {
         return View();
      }
}