using ListViews.Model.Contracts;
using System;

namespace ListViews.Presenter
{
    [Serializable]
    public class Item : IItem
    {
        public string Name { get; set; }
    }
}
