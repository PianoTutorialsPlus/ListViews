﻿using System;
using System.Collections.Generic;

namespace ListViews.View.Contracts
{
    public interface IListScreenView
    {
        event Action OnAddedItem;
        event Action<int> OnDeletedItem;
        event Action OnAddedList;
        event Action<int> OnDeletedList;
        event Action<int> OnShowedItemList;
        event Action OnSavedFile;
        event Action OnClosedForm;

        List<string> ItemList { get; set; }
        string TextboxItemCount { get; set; }
        List<string> CollectionList { get; set; }

        void Show();
    }
}
