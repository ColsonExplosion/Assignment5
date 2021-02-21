using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Book class and all of its properties. Set BookId as key.
//Created a RegEx to make sure ISBN is in proper format

namespace Assignment5.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{10})$", ErrorMessage = "Please enter valid ISBN ###-##########")]
        public string ISBN { get; set; }
        public string Classification { get; set; }

        public double Price { get; set; }

    }
}
