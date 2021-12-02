using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;
using Ficha4.Models;

namespace Ficha4.AppCode
{
    public class ConverteAppCode
    {
        static public List<SelectListItem> SelectListItem_UnidadesMonetarias(List<UnidadeMonetaria> lista)
        {
            var p = lista.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Codigo }).ToList();
            return p;
        }

        static public List<SelectListItem> SelectListItem_UnidadesMonetarias2(List<UnidadeMonetaria> lista)
        {
            var p = new SelectList(lista, "Id", "Codigo").ToList();
            return p;
        }
    }
}
