using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    public class FoodVC:ViewComponent
    {
        IPetFood ipf;
        public FoodVC(IPetFood ipf)
        {
            this.ipf = ipf;
        }
        public IViewComponentResult Invoke(List<PetFood> rec)
        {
            if (rec == null)
            {
                var v = this.ipf.GetAll();
                return View(v);
            }
            else
              return View(rec);
        }
    }
}
