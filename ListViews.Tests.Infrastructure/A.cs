using ListViews.Tests.Infrastructure.Factories;
using ListViews.Tests.Infrastructure.ListScreen;

namespace ListViews.Tests.Infrastructure
{
    public class A
    {
        public static ListScreenModelBuilder ListScreenModel => new ListScreenModelBuilder();
        public static ListScreenPresenterBuilder ListScreenPresenter => new ListScreenPresenterBuilder();
    }

    public class An
    {
        public static IListScreenViewBuilder IListScreenView => new IListScreenViewBuilder();
        public static IListScreenModelBuilder IListScreenModel => new IListScreenModelBuilder();
        public static IItemSpawnerBuilder IItemSpawner => new IItemSpawnerBuilder();
    }
}
