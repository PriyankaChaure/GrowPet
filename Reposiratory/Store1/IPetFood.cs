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
    public  interface IPetFood : IGeneric<PetFood>
    {
        RepoResult AddPetFood(PetFoodVM rec);
        PetFoodVM GetByPetFoodId(Int64 id);
        RepoResult EditPetFood(PetFoodVM rec);
        RepoResult DeletePetFood(PetFoodVM rec);
        List<PetFood> SearchByFoodProperty(string foodname);
        List<PetFood> GetAllByStoreId(Int64 storeid);
    }
}
