using ListViews.Model.Contracts;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.Factories
{
    public class IItemSpawnerBuilder : TestDataBuilder<IItemSpawner>
    {
        public override IItemSpawner Build()
        {
            var itemSpawner = Substitute.For<IItemSpawner>();
            return itemSpawner;
        }
    }
}
