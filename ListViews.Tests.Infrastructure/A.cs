using ListViews.Model.Contracts;
using ListViews.Tests.Infrastructure.Factories;
using ListViews.Tests.Infrastructure.ListScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure
{
    public class A
    {
        public static ListScreenModelBuilder ListScreenModel => new ListScreenModelBuilder();
    }

    public class An
    {
        public static IItemSpawnerBuilder IItemSpawner => new IItemSpawnerBuilder();
    }
}
