﻿using Core;
using Reposiratory.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposiratory.Store1
{
    public interface IOffer: IGeneric<Offer>
    {
        List<Offer> GetAllByStoreId(Int64 storeid);
    }
}