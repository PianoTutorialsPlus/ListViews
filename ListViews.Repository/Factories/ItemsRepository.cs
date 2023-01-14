using ListViews.Model.Contracts;
using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListViews.Service.Contracts;
using ListViews.Database.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static ListViews.Service.UI.ListScreenService;

namespace ListViews.Repository.Factories
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

        public void AddItem()
        {
            _itemList?.Items.Add(new Item()
            {
                Name = "item " + (_itemList.Items.Count + 1)
            });
        }

        public void AddList()
        {
            _itemListsDB.ItemListCollection?.Add(new ItemList()
            {
                Name = "List" + (_itemListsDB.ItemListCollection.Count + 1),
                Items = new List<IItem>()
            });
        }

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
    }
}
