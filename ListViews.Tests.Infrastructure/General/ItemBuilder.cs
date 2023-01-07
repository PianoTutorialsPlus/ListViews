using ListViews.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.General
{
    public class ItemBuilder : TestDataBuilder<Item>
    {
        public ItemBuilder()
        {
        }

        public override Item Build()
        {
            return new Item();
        }
    }
}
