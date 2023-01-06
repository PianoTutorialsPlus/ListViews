using ListViews.View.Contracts;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class IListScreenViewBuilder : TestDataBuilder<IListScreenView>
    {
        private List<string> _itemList;

        public IListScreenViewBuilder(List<string> itemList)
        {
            _itemList = itemList;
        }

        public IListScreenViewBuilder() : this(new List<string>())
        {
        }

        public IListScreenViewBuilder WithItemlist(List<string> itemList)
        {
            _itemList = itemList;
            return this;
        }
        public override IListScreenView Build()
        {
            var listScreenView = Substitute.For<IListScreenView>();
            listScreenView.TextboxItemCount.Returns(_itemList.Count.ToString());

            return listScreenView;
        }

    }
}
