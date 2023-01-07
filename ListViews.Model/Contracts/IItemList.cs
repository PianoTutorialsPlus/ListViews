using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Model.Contracts
{
    public interface IItemList
    {
        string Name { get; set; }
        List<IItem> Items { get; set; }
    }
}
