using Microsoft.AspNetCore.Mvc;

using ParcialprogramacionV.Datos;
using ParcialprogramacionV.Models;

namespace ParcialprogramacionV.Controllers
{
    public class AdministradorController : Controller
    {
         UsuarioDatos _UsuarioDatos = new UsuarioDatos();

        public IActionResult Listar()
        {
            var oLista = _UsuarioDatos.Listar();

            return View(oLista);
        }

        public IActionResult Guardar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Guardar(UsuarioModel oUsuario)
        {
            if (!ModelState.IsValid)
                return View();
            var respuesta = _UsuarioDatos.Guardar(oUsuario);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
      
        public IActionResult Editar(int IdUsuario)
        {
            var oUsuario = _UsuarioDatos.Obtener(IdUsuario);
            return View(oUsuario);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel oUsuario)
        {
            if (!ModelState.IsValid)
                return View(oUsuario); 

            var respuesta = _UsuarioDatos.Editar(oUsuario);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View(oUsuario); 
        }


        public IActionResult Eliminar(int IdUsuario)
        {
         
            var ousuario = _UsuarioDatos.Obtener(IdUsuario);
            return View(ousuario);
        }

        [HttpPost]
        public IActionResult Eliminar(UsuarioModel oUsuario)
        {
            var respuesta = _UsuarioDatos.Eliminar(oUsuario.IdUsuario);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}
