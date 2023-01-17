using ListViews.Model.Contracts;
using ListViews.Model;
using System;
using System.Collections.Generic;
using ListViews.Service.Contracts;
using ListViews.Database.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace ListViews.Repository
{
    public class ItemsRepository : IItemsRepository
    {
        private ItemListsDB _itemListsDB = new ItemListsDB();
        private ItemList _itemList = new ItemList();

        public ItemsRepository()
        {
            _itemListsDB.ItemListCollection = new List<IItemList>();
            //SpawnList(_itemListsDB.ItemListCollection);
        }

        public void DeleteItem(int itemIndex)
        {
            if (itemIndex < 0 || _itemList.Items.Count < itemIndex)
                throw new ArgumentOutOfRangeException("Item Index");

            _itemList.Items.RemoveAt(itemIndex);
        }

        public void DeleteList(int listIndex)
        {
            if (listIndex < 0 || _itemListsDB.ItemListCollection.Count < listIndex)
                throw new ArgumentOutOfRangeException("List Index");

            _itemListsDB.ItemListCollection.RemoveAt(listIndex);
            _itemList = null;
        }

        public IEnumerable<IItem> GetAllItems() => _itemList?.Items;
        public IEnumerable<IItemList> GetAllLists() => _itemListsDB?.ItemListCollection;

        public void SetListFromCollectionId(int listIndex)
        {
            if (listIndex < 0 || _itemListsDB.ItemListCollection.Count < listIndex)
                throw new ArgumentOutOfRangeException("List Index");

            _itemList = (ItemList)_itemListsDB.ItemListCollection[listIndex];
        }

        public void AddItem(IItem item) => _itemList?.Items.Add(item);
        public void AddList(IItemList itemList) => _itemListsDB.ItemListCollection?.Add(itemList);

        public void SaveFile()
        {
            using (Stream stream = File.Create("Test.dat"))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, _itemListsDB);
            }
        }

        public void LoadFile()
        {
            using (Stream stream = File.OpenRead("Test.dat"))
            {
                var binaryFormatter = new BinaryFormatter();
                _itemListsDB = (ItemListsDB)binaryFormatter.Deserialize(stream);

            }
        }

        public ItemList NewItemList => new ItemList()
        {
            Name = "List" + (_itemListsDB.ItemListCollection?.Count + 1),
            Items = new List<IItem>()
        };

        public Item NewItem => new Item()
        {
            Name = "item " + (_itemList?.Items.Count + 1)
        };
    }
}
