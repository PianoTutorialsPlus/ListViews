using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListViews.View
{
    public partial class FormListScreen : Form
    {

        public event Action OnAddedItem;
        public event Action<int> OnDeletedItem;
        
        public FormListScreen()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            OnAddedItem?.Invoke();
        }

        public void RefreshItemList(List<object> itemNames)
        {
            itemListView.Items.Clear();

            foreach (object itemName in itemNames)
            {
                itemListView.Items.Add(itemName);
            }

            UpdateItemCountText();
        }

        private void UpdateItemCountText()
        {
            textBoxItemCount.Text = itemListView.Items.Count.ToString();
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
