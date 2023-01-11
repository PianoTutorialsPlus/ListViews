using ListViews.Model.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ListViews.Model.UI
{
    public class ListScreenModel : IListScreenModel
    {
        private Settings _settings;
        private IItemSpawner _itemSpawner;
        private IItemList _itemList;
        private List<IItemList> _itemCollectionList;

        public List<string> CollectionList => _itemCollectionList != null
            ? _itemCollectionList.Select(itemList => itemList.Name).ToList()
            : new List<string>();
        public List<string> ItemList => _itemList != null 
            ? _itemList.Items.Select(itemName => itemName.Name).ToList() 
            : new List<string>();

        public event Action OnRefreshedCollectionList;
        public event Action OnRefreshedItemList;


        public ListScreenModel(
            Settings settings,
            IItemSpawner itemSpawner 
            )
        {
            _settings = settings;
            _itemSpawner = itemSpawner;
            _itemCollectionList = _settings.ItemListCollection;
            _itemList = _settings.ItemListCollection[0];

        }
        public void AddList()
        {
            _itemCollectionList = _itemSpawner.SpawnList(_itemCollectionList);
            RefreshCollectionList();
        }
        public void DeleteList(int listIndex)
        {
            if (listIndex < 0 || _itemCollectionList.Count < listIndex)
                throw new ArgumentOutOfRangeException("List Index");

            _itemCollectionList.RemoveAt(listIndex);
            _itemList = null;

            RefreshItemList();
            RefreshCollectionList();
        }
        private void RefreshCollectionList()
        {
            OnRefreshedCollectionList?.Invoke();
        }
        public void AddItem()
        {
            _itemList = _itemSpawner.SpawnItem(_itemList);

            RefreshItemList();
        }
        public void DeleteItem(int itemIndex)
        {
            if(itemIndex < 0 || _itemList.Items.Count < itemIndex)
                throw new ArgumentOutOfRangeException("Item Index");

            _itemList.Items.RemoveAt(itemIndex);

            RefreshItemList();
        }
        private void RefreshItemList()
        {
            OnRefreshedItemList?.Invoke();
        }
        public void ShowItemList(int listIndex)
        {
            if (listIndex < 0 || _itemCollectionList.Count < listIndex)
                throw new ArgumentOutOfRangeException("List Index");

            _itemList = _itemCollectionList[listIndex]; 
            RefreshItemList();
        }

        public void SaveFile()
        {
            using (Stream stream = File.Create("Test.dat"))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, _settings);
            }
        }

        public void LoadFile()
        {
            using (Stream stream = File.OpenRead("Test.dat"))
            {
                var binaryFormatter = new BinaryFormatter();
                _settings = (Settings)binaryFormatter.Deserialize(stream);

                _itemCollectionList = _settings.ItemListCollection;
                _itemList = _settings.ItemListCollection[0];

                RefreshItemList();
                RefreshCollectionList();
            }
        }

        [Serializable]
        public class Settings
        {
            public List<IItemList> ItemListCollection;
        }
    }
}
