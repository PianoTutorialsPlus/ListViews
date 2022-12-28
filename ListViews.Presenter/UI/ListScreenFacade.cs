using ListViews.Model.UI;
using ListViews.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Presenter.UI
{
    public class ListScreenFacade
    {
        private ListScreenModel _listScreenModel;
        private FormListScreen _listScreenView;

        public ListScreenFacade(
            ListScreenModel listScreenModel, 
            FormListScreen listScreenView)
        {
            _listScreenModel = listScreenModel;
            _listScreenView = listScreenView;

            ConnectEvents();
        }

        private void ConnectEvents()
        {
            _listScreenView.OnAddItem += _listScreenModel.AddItem;
        }
    }
}
