using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Model.Contracts
{
    public interface IItem
    {
        string Name { get; set; }
        int ItemID { get; set; }
    }
}
