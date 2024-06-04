using Core;
using Microsoft.AspNetCore.Mvc;
using Reposiratory.Store1;

namespace Web.ViewComponents
{
    public class ProductVC:ViewComponent
    {
        IPetProduct ipp;
        public ProductVC(IPetProduct ipp)
        {
            this.ipp = ipp;
        }
        public IViewComponentResult Invoke(List<PetProduct> rec)
        {
            if (rec == null)
            {
                var v = this.ipp.GetAll();
                return View(v);
            }
            else
                return View(rec);
        }
    }
}
