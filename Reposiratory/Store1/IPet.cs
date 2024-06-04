//using Reposiratory.Admin;

using Core;
using Reposiratory.Admin;
using Reposiratory.ViewModels;
using Reposiratory.ViewModels.ChangePassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public interface IPet : IGeneric<Pet>
    {
        RepoResult AddPet(PetVM rec);
        PetVM GetByPetId(Int64 id);
        RepoResult EditPet(PetVM rec);
        RepoResult DeletePet(PetVM rec);
        List<Pet> SearchByProperty(Int64  type =0 ,Int64  family=0);
        List<Pet> GetAllByStoreId(Int64 storeid);

    }
}
