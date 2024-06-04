using Core;
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
    public class PetController : Controller
    {
        IPet ip;
        IPetType ipt;
        IPetFamily ipf;
        IWebHostEnvironment env;

        public PetController(IPet ip, IPetFamily ipf,IPetType ipt, IWebHostEnvironment env)
        {
            this.ip = ip;
            this.ipf = ipf;
            this.ipt = ipt;
            this.env = env;
        }
        public IActionResult Index()
        {
            var storeid = Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
            return View(this.ip.GetAllByStoreId(storeid));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName");
            ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(PetVM rec)
        {
            ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName",rec.PetTypeId);
            ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName",rec.PetFamilyId);


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
              
              var storeid=  Convert.ToInt64(HttpContext.Session.GetString("StoreId"));
                rec.StoreId = storeid;
                this.ip.AddPet(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.ip.GetByPetId(id);
            ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName", rec.PetTypeId);
            ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName", rec.PetFamilyId);

            return View(rec);
        }
        [HttpPost]
        public IActionResult Edit(PetVM rec)
        {
            ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName", rec.PetTypeId);
            ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName", rec.PetFamilyId);
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
                this.ip.EditPet(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
        [HttpGet]
        public IActionResult Delete(Int64 id)
        { 
            var rec = this.ip.GetByPetId(id);
            ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName", rec.PetTypeId);
            ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName", rec.PetFamilyId);

            return View(rec);
        }
        [HttpPost]
        public IActionResult Delete(PetVM rec)
        {
            this.ip.DeletePet(rec);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.ip.GetByPetId(id);
            ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName",rec.PetTypeId);
            ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName",rec.PetFamilyId);

            return View(rec);
        }
    }
}
