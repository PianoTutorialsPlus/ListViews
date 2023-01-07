using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ListViews.View
{
    public partial class FormListScreen : Form, IListScreenView
    {
        public event Action OnAddedList;
        public event Action<int> OnDeletedList;
        public event Action OnAddedItem;
        public event Action<int> OnDeletedItem;
        public event Action<int> OnShowItemList;

        public string TextboxItemCount 
        {
            get => textBoxItemCount.Text;
            set => textBoxItemCount.Text =  value; 
        }   

        public List<string> ItemList 
        {
            get => listBoxItems.Items.Cast<string>().ToList();

            set
            {
                listBoxItems.Items.Clear();
                listBoxItems.Items.AddRange(value.ToArray());
            }
        }
        public List<string> CollectionList
        {
            get => listBoxCollection.Items.Cast<string>().ToList();
            set
            {
                listBoxCollection.Items.Clear();
                listBoxCollection.Items.AddRange(value.ToArray());
            }
        }


        public FormListScreen()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            OnAddedItem?.Invoke();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectionMode == SelectionMode.One &&
                listBoxItems.SelectedIndex >= 0)
            {
                OnDeletedItem?.Invoke(listBoxItems.SelectedIndex);
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            OnAddedList?.Invoke();
        }

        private void buttonDeleteList_Click(object sender, EventArgs e)
        {
            if (listBoxCollection.SelectionMode == SelectionMode.One &&
                listBoxCollection.SelectedIndex >= 0)
            {
                OnDeletedList?.Invoke(listBoxCollection.SelectedIndex);
            }
        }

        private void Refresh(object sender, EventArgs e)
        {
            if (listBoxCollection.SelectionMode == SelectionMode.One &&
                listBoxCollection.SelectedIndex >= 0)
            {
                OnShowItemList?.Invoke(listBoxCollection.SelectedIndex);
            }
        }
    }
}
