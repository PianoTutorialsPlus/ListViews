using ListViews.Model.Contracts;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.Tests.Infrastructure.ListScreen
{
    public class IListScreenModelBuilder : TestDataBuilder<IListScreenModel>
    {
        private List<string> _itemList;

        public IListScreenModelBuilder(List<string> itemList)
        {
            _itemList = itemList;
        }

        public IListScreenModelBuilder() : this(new List<string>())
        {
        }

        public IListScreenModelBuilder WithItemList(List<string> itemList)
        {
            _itemList = itemList;
            return this;
        }
        public override IListScreenModel Build()
        {
            var listScreenModel = Substitute.For<IListScreenModel>();
            listScreenModel.ItemList.Returns(_itemList);

            return listScreenModel;
        }

    }
}
