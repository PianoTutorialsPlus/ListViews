using ListViews.Model.Contracts;
using ListViews.Presenter.UI;
using ListViews.Service.Contracts;
using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class ListScreenPresenterBuilder : TestDataBuilder<ListScreenPresenter>
    {
        private IListScreenView _listScreenView;
        private IListScreenService _listScreenModel;

        public ListScreenPresenterBuilder() : this(An.IListScreenView.Build(),An.IListScreenModel.Build())
        {
        }
        public ListScreenPresenterBuilder(IListScreenView listScreenView, IListScreenService listScreenModel)
        {
            _listScreenView = listScreenView;
            _listScreenModel = listScreenModel;
        }

        public ListScreenPresenterBuilder WithListScreenView(IListScreenView listScreenView)
        {
            _listScreenView = listScreenView;
            return this;
        }
        public ListScreenPresenterBuilder WithListScreenModel(IListScreenService listScreenModel)
        {
            _listScreenModel = listScreenModel;
            return this;
        }
        public override ListScreenPresenter Build()
        {
            return new ListScreenPresenter(_listScreenModel, _listScreenView);
        }
    }
}
