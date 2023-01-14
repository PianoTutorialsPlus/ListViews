using ListViews.Presenter;
using ListViews.Tests.Infrastructure.Factories;
using ListViews.Tests.Infrastructure.General;
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
        public static ItemBuilder Item => new ItemBuilder();
        public static ItemListBuilder ItemList => new ItemListBuilder();
        public static IListScreenViewBuilder IListScreenView => new IListScreenViewBuilder();
        public static IListScreenModelBuilder IListScreenModel => new IListScreenModelBuilder();
        public static IItemSpawnerBuilder IItemRepository => new IItemSpawnerBuilder();
    }
}
