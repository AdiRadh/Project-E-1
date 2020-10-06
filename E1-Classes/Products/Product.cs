using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace E1_Classes.Products
{
    public class Product
    {
        public Guid ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Tag> Tags { get; set; }

    }
}
