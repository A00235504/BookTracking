using System;
using System.ComponentModel.DataAnnotations;

namespace BookTracking.Pages.Data
{
    public class Book
    {
        
            [Key]
            public string ISBN { get; set; }

            public string Title { get; set; }

            public int CategoryID { get; set; }

            public string Author { get; set; }

    }
}
