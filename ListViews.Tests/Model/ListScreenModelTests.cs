using ListViews.Model.Contracts;
using ListViews.Model.UI;
using ListViews.Presenter;
using ListViews.Tests.Infrastructure;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ListViews.Tests.Model
{
    public class ListScreenModelTests
    {
        [SetUp]
        public void Setup()
        {
        }
        protected List<IItem> GetNewItemList(int itemAmount = 0)
        {
            var itemList = new List<IItem>();

            for(int i = 0; i< itemAmount; i++)
            {
                itemList.Add(new Item());
            }

            return itemList;
        }
        protected IItemSpawner GetItemSpawner(List<IItem> itemList)
        {
            return An.IItemSpawner
                .WithItemlist(itemList)
                .Build();
        }
        protected ListScreenModel ListScreenModel => A.ListScreenModel;
        protected ListScreenModel GetListScreenModel(IItemSpawner itemSpawner)
        {
            return A.ListScreenModel
                .WithIItemSpawner(itemSpawner);
        }
        protected ListScreenModel GetListScreenModel(List<IItem> itemList)
        {
            return A.ListScreenModel
                .WithItemList(itemList);
        }
        public class TheAddItemMethod : ListScreenModelTests
        {
            [TestCase(0)]
            [TestCase(1)]
            [TestCase(5)]
            public void Given_Empty_Itemlist_When_Item_Added_Amount_Times_Then_Item_Count_Is_(int amount)
            {
                var itemList = GetNewItemList();
                var itemSpawner = GetItemSpawner(itemList);
                var listScreen = GetListScreenModel(itemSpawner);

                for (int i = 0; i < amount; i++)
                { 
                    listScreen.AddItem(); 
                }

                Assert.AreEqual(amount, itemList.Count);
            }
            [Test]
            public void Given_Empty_Itemlist_When_Item_Is_Added_Then_OnRefreshedItemList_Action_Is_Triggered()
            {
                var count = 0;
                var listScreen = ListScreenModel;

                listScreen.OnRefreshedItemList += () =>
                {
                    count++;
                };

                listScreen.AddItem();
                listScreen.AddItem();

                
                Assert.AreEqual(2, count);
            }
        }
        public class TheDeleteItemMethod : ListScreenModelTests
        {
            [Test]
            public void Given_Itemlist_When_ItemIndex_To_Delete_Is_Greater_Than_Itemlist_Count_Then_ArgumentOutOfRangeException_Is_Thrown()
            {
                var itemList = GetNewItemList(1);
                var listScreen = GetListScreenModel(itemList);

                Assert.Throws<ArgumentOutOfRangeException>(()=> listScreen.DeleteItem(2));
            }
            [Test]
            public void Given_Itemlist_When_ItemIndex_To_Delete_Is_Negative_Then_ArgumentOutOfRangeException_Is_Thrown()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ListScreenModel.DeleteItem(-1));
            }
            [TestCase(0)]
            [TestCase(1)]
            [TestCase(2)]
            public void Given_Itemlist_With_3_Items_When_ItemIndex_To_Delete_Is_Lower_Or_Equal_To_Itemlist_Count_Then_Itemlist_Is_Reduced(int index)
            {
                var itemList = GetNewItemList(3);
                var listScreen = GetListScreenModel(itemList);

                listScreen.DeleteItem(index);

                Assert.AreEqual(2, itemList.Count);    
            }
        }
    }
}