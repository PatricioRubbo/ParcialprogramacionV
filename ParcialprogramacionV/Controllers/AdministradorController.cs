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
            //LA VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _UsuarioDatos.Listar();

            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //METODO SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(UsuarioModel oUsuario)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
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
            //METODO SOLO DEVUELVE LA VISTA
            var ousuario = _UsuarioDatos.Obtener(IdUsuario);
            return View(ousuario);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel oUsuario)
        {
            if (!ModelState.IsValid)
                return View();
            var respuesta = _UsuarioDatos.Editar(oUsuario);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }


        public IActionResult Eliminar(int IdUsuario)
        {
            //METODO SOLO DEVUELVE LA VISTA
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
