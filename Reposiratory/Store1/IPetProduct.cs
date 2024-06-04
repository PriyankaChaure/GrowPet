using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public interface IPetProduct: IGeneric<PetProduct>
    {
        RepoResult AddPetProduct(PetProductVM rec);
        PetProductVM GetByPetProductId(Int64 id);
        RepoResult EditPetProduct(PetProductVM rec);
        RepoResult DeletePetProduct(PetProductVM rec);
        List<PetProduct> SearchByProductProperty(string productname);
        List<PetProduct> GetAllByStoreId(Int64 storeid);
    }
}
