using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ParcialprogramacionV.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "El campo Dni es obligatorio")]
        public string? Dni { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string? Correo { get; set; }

    }
}