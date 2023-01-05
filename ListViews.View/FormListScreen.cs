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

        public event Action OnAddedItem;
        public event Action<int> OnDeletedItem;

        public string TextboxItemCount 
        {
            get => textBoxItemCount.Text;
            set => textBoxItemCount.Text =  value; 
        }   

        public List<string> ItemList 
        {
            get => itemListView.Items.Cast<string>().ToList();

            set
            {
                itemListView.Items.Clear();
                itemListView.Items.AddRange(value.ToArray());
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
            if (itemListView.SelectionMode == SelectionMode.One &&
                itemListView.SelectedIndex >= 0)
            {
                OnDeletedItem?.Invoke(itemListView.SelectedIndex);
            }
        }
    }
}
