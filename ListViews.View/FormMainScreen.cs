using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViews
{
    public partial class FormMainScreen : Form, IMainScreenView
    {
        public event Action OnNewListCreated;
        public event Action OnLoadedFile;
        public FormMainScreen()
        {
            InitializeComponent();
            
        }

        private void buttonNewList_Click(object sender, EventArgs e)
        {
            OnNewListCreated?.Invoke();
        }

        private void buttonLoadList_Click(object sender, EventArgs e)
        {
            OnLoadedFile?.Invoke();
        }
    }
}
