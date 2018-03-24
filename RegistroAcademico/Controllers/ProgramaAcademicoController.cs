using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroAcademico.Controllers
{
    public class ProgramaAcademicoController : Controller
    {
        // GET: ProgramaAcademico
        public ActionResult index()
        {
            return View();
        }

        public ActionResult crear()
        {
            return View();
        }

    }
}