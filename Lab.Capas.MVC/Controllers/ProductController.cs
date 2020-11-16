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
    public class ProductController : Controller
    {
        // GET: Products
        public ActionResult Index(string inpBuscar)
        {
            var logic      = new ProductLogic();
            var productos  = logic.Productos(inpBuscar);
            return View(productos);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ProductView product)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    var logic = new ProductLogic();
                    var oProd = new Products();
                    oProd.ProductName = product.Descripcion;
                    oProd.UnitPrice   = product.Precio;

                    logic.AgregarProducto(oProd);                                   

                    return Redirect("/Product");
                }

                return View();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    
        public ActionResult DeleteProducto(int id)
        {
            var logic   = new ProductLogic();
            logic.DeleteProducto(id);

            return RedirectToAction("index");

        }

        
        public ActionResult Editar(int Id)
        {
            ProductView model  = new ProductView();
            var logic          = new ProductLogic();                         

            var oProd         = logic.Productos(Id);
            model.Id          = oProd.ProductID;
            model.Descripcion = oProd.ProductName.TrimEnd();
            model.Precio      = (decimal)oProd.UnitPrice;
            
            return View(model);            
        }
                
        [HttpPost]
        public ActionResult Editar(ProductView model)
        {       
            try
            {
                if (ModelState.IsValid)
                {  
                        var logic      = new ProductLogic();
                        var oProd      = logic.Productos(model.Id);

                        oProd.ProductName  = model.Descripcion;
                        oProd.UnitPrice = model.Precio;
                        logic.UpdateProducto(oProd);
         
                    return Redirect("/Product");
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