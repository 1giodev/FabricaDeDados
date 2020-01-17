using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FabricaDeDadosWeb.Controllers
{
    public class EmpresaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consultar(int id)
        {
            Models.GioDevDadosContext Contexto = new Models.GioDevDadosContext();
            Models.Empresa DadosEmpresa = Contexto.Empresa.Where(x => x.Id == id).FirstOrDefault();
            return View(DadosEmpresa);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Alterar(int id)
        {
            Models.GioDevDadosContext Contexto = new Models.GioDevDadosContext();
            Models.Empresa DadosEmpresa = Contexto.Empresa.Where(x => x.Id == id).FirstOrDefault();
            return View(DadosEmpresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Excluir(int id)
        {
            Models.GioDevDadosContext Contexto = new Models.GioDevDadosContext();
            Models.Empresa DadosEmpresa = Contexto.Empresa.Where(x => x.Id == id).FirstOrDefault();
            return View(DadosEmpresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}