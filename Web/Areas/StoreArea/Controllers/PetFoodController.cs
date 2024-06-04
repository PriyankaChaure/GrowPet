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
    public class PetFoodController : Controller
    {
        IPetFood ipf;
        IWebHostEnvironment env;
        public PetFoodController(IPetFood ipf,IWebHostEnvironment env)
        {
            this.ipf = ipf;                         
            this.env = env;
        }
        public IActionResult Index()
        {
            return View(this.ipf.GetAll());
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(PetFoodVM rec)
        {
            if (ModelState.IsValid)
            {

                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.env.WebRootPath, "PetFoodImages");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine(@"\PetFoodImages", filename);
                        rec.PhotoPath = logicalpath;
                    }
                }

                var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
                rec.StoreId = storeid;
                this.ipf.AddPetFood(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ipf.GetByPetFoodId(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(PetFoodVM rec)
        {
            if (ModelState.IsValid)
            {
                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {

                        string filename = rec.ActualFile.FileName;
                        string folderpath = Path.Combine(this.env.WebRootPath, "PetFoodImages");
                        string uploadpath = Path.Combine(folderpath, filename);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\PetFoodImages", filename);
                        rec.PhotoPath = logicalpath;
                    }
                }
                var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
                rec.StoreId = storeid;
                this.ipf.EditPetFood(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            var rec = this.ipf.GetByPetFoodId(id);
            return View(rec);
        }
        [HttpPost]
        public IActionResult Delete(PetFoodVM rec)
        {
            this.ipf.DeletePetFood(rec);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.ipf.GetByPetFoodId(id); 
            return View(rec);
        }
    }
}
