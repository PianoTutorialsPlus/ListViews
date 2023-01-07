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
        protected ItemList GetNewItemList(int itemAmount = 0)
        {
            return An.ItemList
                .WithItems(itemAmount);
        }
        private List<IItemList> GetNewItemCollectionList(int itemAmount = 0)
        {
            var itemCollectionList = new List<IItemList>();
            for(int i = 0; i< itemAmount; i++)
            {
                itemCollectionList.Add(GetNewItemList());
            }

            return itemCollectionList;
        }
        private List<IItemList> GetNewItemCollectionList(ItemList itemList)
        {
            var itemCollectionList = new List<IItemList>
            {
                itemList
            };

            return itemCollectionList;
        }
        protected IItemSpawner GetItemSpawner(ItemList itemList)
        {
            return An.IItemSpawner
                .WithItemlist(itemList)
                .Build();
        }
        protected IItemSpawner GetItemSpawner(List<IItemList> itemCollection)
        {
            return An.IItemSpawner
                .WithItemListCollection(itemCollection)
                .Build();
        }
        protected ListScreenModel ListScreenModel => A.ListScreenModel;
        protected ListScreenModel GetListScreenModel(IItemSpawner itemSpawner)
        {
            return A.ListScreenModel
                .WithIItemSpawner(itemSpawner);
        }
        protected ListScreenModel GetListScreenModel(ItemList itemList)
        {
            return A.ListScreenModel
                .WithItemList(itemList);
        }
        protected ListScreenModel GetListScreenModel(List<IItemList> itemLists)
        {
            return A.ListScreenModel
                .WithItemListCollection(itemLists);
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

                Assert.AreEqual(amount, itemList.Items.Count);
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

                Assert.AreEqual(2, itemList.Items.Count);    
            }
        }
        public class TheAddListMethod : ListScreenModelTests
        {
            [TestCase(0)]
            [TestCase(1)]
            [TestCase(5)]
            public void Given_Empty_ItemCollectionlist_When_List_Added_Amount_Times_Then_List_Count_Is_(int amount)
            {
                var itemCollectionList = GetNewItemCollectionList();
                var itemSpawner = GetItemSpawner(itemCollectionList);
                var listScreen = GetListScreenModel(itemSpawner);

                for (int i = 0; i < amount; i++)
                {
                    listScreen.AddList();
                }

                Assert.AreEqual(amount, itemCollectionList.Count);
            }
            [Test]
            public void Given_Empty_ItemCollectionlist_When_List_Is_Added_Then_OnRefreshedCollectionList_Action_Is_Triggered()
            {
                var count = 0;
                var listScreen = ListScreenModel;

                listScreen.OnRefreshedCollectionList += () =>
                {
                    count++;
                };

                listScreen.AddList();
                listScreen.AddList();

                Assert.AreEqual(2, count);
            }
        }
        public class TheDeleteListMethod : ListScreenModelTests
        {
            [Test]
            public void Given_ItemCollectionlist_When_ListIndex_To_Delete_Is_Greater_Than_ItemCollectionlist_Count_Then_ArgumentOutOfRangeException_Is_Thrown()
            {
                var itemCollectionList = GetNewItemCollectionList(1);
                var listScreen = GetListScreenModel(itemCollectionList);

                Assert.Throws<ArgumentOutOfRangeException>(() => listScreen.DeleteList(2));
            }
            [Test]
            public void Given_ItemCollectionlist_When_ListIndex_To_Delete_Is_Negative_Then_ArgumentOutOfRangeException_Is_Thrown()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => ListScreenModel.DeleteList(-1));
            }
            [TestCase(0)]
            [TestCase(1)]
            [TestCase(2)]
            public void Given_ItemCollectionlist_With_3_Items_When_ListIndex_To_Delete_Is_Lower_Or_Equal_To_ItemCollectionlist_Count_Then_Itemlist_Is_Reduced(int index)
            {
                var itemCollection = GetNewItemCollectionList(3);
                var listScreen = GetListScreenModel(itemCollection);

                listScreen.DeleteList(index);

                Assert.AreEqual(2, itemCollection.Count);
            }
            [Test]
            public void Given_Itemlist_With_3_Items_When_ListIndex_To_Delete_Is_Lower_Or_Equal_To_ItemCollectionlist_Count_Then_Itemlist_Is_Reduced()
            {
                var itemList = GetNewItemList(3);
                var itemCollection = GetNewItemCollectionList(itemList);
                var listScreen = GetListScreenModel(itemCollection);

                listScreen.DeleteList(0);

                Assert.AreEqual(0, listScreen.ItemList.Count);
            }
        }
    }
}