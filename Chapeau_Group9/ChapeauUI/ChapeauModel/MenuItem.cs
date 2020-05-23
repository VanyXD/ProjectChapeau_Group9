using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapeauModel
{
    public class MenuItem 
    {
        public int MenuItemID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool HighVAT { get; set; }
        public bool Lunch { get; set; }
        public CategoryID Category { get; set; }

    }
}
