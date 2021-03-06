﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4.Data;

namespace WebApplication4.Pages.Usuarios
{
    public class CadastrarModel : PageModel
    {
      public  static List<Usuario> usuarios = new List<Usuario>();

        [BindProperty(SupportsGet = true)]
        public Usuario usuario { get; set; }

        public void OnGet()
        {
            if (usuario == null)
            {
                usuario = new Usuario();
            }
        }
        [HttpPost]
        public void onPost()
        {
            if (ModelState.IsValid)
            {
                usuarios.Add(usuario);
            }
        }
    }
}