﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Model.Contracts
{
    public interface IItemSpawner
    {
        List<IItem> Spawn(List<IItem> itemList);
    }
}
