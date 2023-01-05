using System;
using System.Collections.Generic;

namespace ListViews.View.Contracts
{
    public interface IListScreenView
    {
        event Action OnAddedItem;
        event Action<int> OnDeletedItem;
        void RefreshItemList(List<object> itemNames);
    }
}
