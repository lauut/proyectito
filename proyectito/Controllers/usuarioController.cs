using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using proyectito.Models;

namespace proyectito.Controllers
{
    public class usuarioController : Controller
    {
        private readonly proyectitoContext _proyectitoContext;

        public usuarioController(proyectitoContext proyectitoContext)
        {
            _proyectitoContext = proyectitoContext;
        }


        public IActionResult Index()
        {
            var listarol = (from r in _proyectitoContext.roles
                                select r).ToList();
            ViewData["listrol"] = new SelectList(listarol, "id_rol", "rol");

            var listausuariorol = (from u in _proyectitoContext.usuario
                                   join r in _proyectitoContext.roles on u.rol_id equals r.id_rol
                                   select new
                                   {
                                       nombre = u.nombre_usuario,
                                       direccion = u.direccion,
                                       curso = u.curso,
                                       rol = r.id_rol
                                   }).ToList();
            ViewData["listusuariorol"] = listausuariorol;


            return View();
        }
        public IActionResult crearusuario(usuario nuevouser)
        {
            _proyectitoContext.Add(nuevouser);
            _proyectitoContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
