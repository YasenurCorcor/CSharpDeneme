using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet-- available codes
    class Product //Entity
    {
        public int Id { get; set; } //basic key seperetad
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

        // use english in sector
        public int UnitsInStock { get; set; }


    }
}
