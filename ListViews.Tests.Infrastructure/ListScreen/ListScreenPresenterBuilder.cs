using ListViews.Model.Contracts;
using ListViews.Presenter.UI;
using ListViews.View.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class ListScreenPresenterBuilder : TestDataBuilder<ListScreenFacade>
    {
        private IListScreenView _listScreenView;
        private IListScreenModel _listScreenModel;

        public ListScreenPresenterBuilder() : this(An.IListScreenView.Build(),An.IListScreenModel.Build())
        {
        }
        public ListScreenPresenterBuilder(IListScreenView listScreenView, IListScreenModel listScreenModel)
        {
            _listScreenView = listScreenView;
            _listScreenModel = listScreenModel;
        }

        public ListScreenPresenterBuilder WithListScreenView(IListScreenView listScreenView)
        {
            _listScreenView = listScreenView;
            return this;
        }
        public ListScreenPresenterBuilder WithListScreenModel(IListScreenModel listScreenModel)
        {
            _listScreenModel = listScreenModel;
            return this;
        }
        public override ListScreenFacade Build()
        {
            return new ListScreenFacade(_listScreenModel, _listScreenView);
        }
    }
}
