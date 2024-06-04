using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Admin;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    public class PetVC:ViewComponent
    {
        IPetType ipt;
        IPet ip;
        IPetFamily ipf;
        public PetVC( IPetFamily ipf, IPetType ipt, IPet ip)
        {
            this.ipt = ipt;
            this.ipf = ipf;
            this.ip = ip;
        }
        public IViewComponentResult Invoke(List<Pet> rec)
        {
            if (rec == null)
            {
                var v = this.ip.GetAll();
                ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName");
                ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName");

                return View(v);
            }
            else
                ViewBag.PetTypeId = new SelectList(this.ipt.GetAll(), "PetTypeId", "PetTypeName");
                ViewBag.PetFamilyId = new SelectList(this.ipf.GetAll(), "PetFamilyId", "PetFamilyName");
            return View(rec);
        }
    }
}
