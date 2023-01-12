using ListViews.Model.Contracts;
using ListViews.Presenter;
using ListViews.Presenter.UI;
using ListViews.Service.Contracts;
using ListViews.Tests.Infrastructure;
using ListViews.Tests.Infrastructure.ListScreen;
using ListViews.View.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Presenter
{
    public class ListScreenFacadeTests
    {
        [SetUp]
        public void Setup()
        {

        }
        private IListScreenView GetListScreenView(
            List<string> itemList = null)
        {
            return An.IListScreenView
                .WithItemlist(itemList).Build();
        }
        private IListScreenService GetListScreenModel(
            List<string> itemList)
        {
            return An.IListScreenModel
                .WithItemList(itemList).Build();
        }
        private ListScreenFacade ListScreenPresenter => A.ListScreenPresenter;
        private ListScreenFacade GetListScreenPresenter(
            IListScreenService listScreenModel, 
            IListScreenView listScreenView)
        {
            return A.ListScreenPresenter
                .WithListScreenModel(listScreenModel)
                .WithListScreenView(listScreenView);
        }
        protected List<string> GetNewItemList(int itemAmount = 0)
        {
            var itemList = new List<string>();

            for (int i = 0; i < itemAmount; i++)
            {
                itemList.Add( "item" + i);
            }

            return itemList;
        }
        public class TheRefreshItemlistMethod : ListScreenFacadeTests
        {
            [TestCase(0)]
            [TestCase(1)]
            [TestCase(5)]
            public void Given_Filled_ItemList_When_ItemList_Has_Amount_Items_Then_TextboxItemCount_Is(int amount)
            {
                var itemList = GetNewItemList(amount);
                var listScreenView = GetListScreenView(itemList);
                var listScreenModel = GetListScreenModel(itemList);
                var listScreenFacade = GetListScreenPresenter(listScreenModel,listScreenView);

                listScreenFacade.RefreshItemList();

                Assert.AreEqual(amount.ToString(), listScreenView.TextboxItemCount);
            }


        }
    }
}
