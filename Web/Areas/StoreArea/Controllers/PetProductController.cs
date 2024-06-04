using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.Store1;
using Reposiratory.ViewModels;
using Web.StoreFilter;

namespace Web.Areas.StoreArea.Controllers
{
    [Area("StoreArea")]
    [StoreAutho]
    public class PetProductController : Controller
    {
        IPetProduct ipp;
        IWebHostEnvironment env;
        public PetProductController(IPetProduct ipp ,IWebHostEnvironment env)
        {
            this.ipp = ipp; 
            this.env = env;
        }
        public IActionResult Index()
        {
            return View(this.ipp.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PetProductVM rec)
        {
         
            if (ModelState.IsValid)
            {

                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.env.WebRootPath, "PetImages");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine(@"\PetImages", filename);
                        rec.PhotoPath = logicalpath;
                    }
                }

                var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
                rec.StoreId = storeid;
                this.ipp.AddPetProduct(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ipp.GetByPetProductId(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(PetProductVM rec)
        {
            if (ModelState.IsValid)
            {
                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {

                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.env.WebRootPath, "PetImages");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\PetImages", filename);
                        rec.PhotoPath = logicalpath;
                    }
                }
                var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
                rec.StoreId = storeid;
                this.ipp.EditPetProduct(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.ipp.GetByPetProductId(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Delete(PetProductVM rec)
        {
            this.ipp.DeletePetProduct(rec);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.ipp.GetByPetProductId(id);  
            return View(rec);
        }
    }
}
