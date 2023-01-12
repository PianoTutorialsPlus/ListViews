using ListViews.Model.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace ListViews.Model
{
    [Serializable]
    public class Item : IItem
    {
        public int ItemID { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Item ID is required")]
        public string Name { get; set; }
        
    }
}
