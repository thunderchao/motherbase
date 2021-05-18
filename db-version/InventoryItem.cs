using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_version
{
    public class InventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
        public InventoryItem()
        {
            this.Name = "x";
            this.Quantity = 0;
        }
    }

}
