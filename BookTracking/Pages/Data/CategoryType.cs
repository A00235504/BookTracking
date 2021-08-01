using System;
using System.ComponentModel.DataAnnotations;

namespace BookTracking.Pages.Data
{
    public class CategoryType
    {
        [Key]
        public string Type { get; set; }

        public string Name { get; set; }
    }
}
