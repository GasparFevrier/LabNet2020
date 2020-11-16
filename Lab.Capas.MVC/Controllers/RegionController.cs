using Lab.Capas.Entities;
using Lab.Capas.Logic;
using Lab.Capas.MVC.Models;
using Lab.Capas.RerourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.MVC.Controllers
{
    public class RegionController : Controller
    {
        // GET: Region
        public ActionResult Index(string inpBuscar)
        {
            var logic     = new RegionLogic();
            var regiones  = logic.Regions(inpBuscar);
            return View(regiones);
        }

            public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(RegionView region)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    var logic = new RegionLogic();
                    var oRegion = new Region();
                    oRegion.RegionDescription = region.Descripcion;
                    logic.AgregarRegion(oRegion);

                    Request.Flash("success", "Region Agregada");

                    return Redirect("/Region");
                }
                else
                {
                    Request.Flash("warning", "No se ha agragado la Region");
                    return View();
                }
                

            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);                
            }
        }

        public ActionResult DeleteRegion(int id)
        {
            var logic   = new RegionLogic();
            logic.DeleteRegion(id);
            Request.Flash("success", "Region Eliminada");

            return RedirectToAction("index");

        }

        public ActionResult Editar(int Id)
        {
            RegionView model  = new RegionView();
            var logic         = new RegionLogic();                         

            var oRegion       = logic.Regions(Id);
            model.Id          = oRegion.RegionID;
            model.Descripcion = oRegion.RegionDescription.TrimEnd();
            
            return View(model);            
        }
                
        [HttpPost]
        public ActionResult Editar(RegionView model)
        {       
            try
            {
                if (ModelState.IsValid)
                {
                        var logic = new RegionLogic();
                        var oRegion = logic.Regions(model.Id);
                        oRegion.RegionDescription = model.Descripcion;
                        logic.UpdateRegion(oRegion);

                        Request.Flash("success", "Region Actualizada");

                    return Redirect("/Region");
                }
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}


