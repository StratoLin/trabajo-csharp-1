using Microsoft.AspNetCore.Mvc;
using Evaluacion01.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Evaluacion01.Controllers
{
    public class LinaresEC01Controller : Controller
    {
        BDTRANSITO22Context db = new BDTRANSITO22Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PapeletasAnios(int fecha1, int fecha2) 
        {
            var papeletas = db.Papeletas
                            .Include(p => p.CodpolNavigation)
                            .Where(f => f.Fechapap.Value.Year >= fecha1 &&
                                        f.Fechapap.Value.Year <= fecha2)
                            .ToList();

            ViewBag.total = papeletas.Count;
            

            return View(papeletas);
        }

        public IActionResult PapeletasPoliciaFecha(string pol, DateTime? fecha)
        {
            var papel = db.Papeletas
                        .Include(i => i.CodinfNavigation)
                        .Where( p => p.Codpol.Equals(pol) &&
                                     p.Fechapap >= fecha)
                        .ToList();

            ViewBag.ListaPolicias = new SelectList(
                db.Policias.ToList(),
                "Codpol",
                "Nompol"
                );

            ViewBag.total = papel.Count;
            ViewBag.suma = papel.Sum(x => x.CodinfNavigation.Importe);

            return View(papel);
        }
    }

    
}
