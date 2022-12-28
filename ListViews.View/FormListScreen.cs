using System;
using System.Windows.Forms;

namespace ListViews.View
{
    public partial class FormListScreen : Form
    {

        public event Action OnAddItem;
        public FormListScreen()
        {
            InitializeComponent();
        }


        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            OnAddItem.Invoke();
        }
    }
}
