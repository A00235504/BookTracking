using System;
using System.ComponentModel.DataAnnotations;

namespace BookTracking.Pages.Data
{
    public class Category
    {
        [Key]
        public string NameToken { get; set; }

        public int TypeID { get; set; }

        public string Description { get; set; }

    }
}
