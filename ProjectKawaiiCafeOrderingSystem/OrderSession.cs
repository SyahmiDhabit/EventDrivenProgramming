using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKawaiiCafeOrderingSystem
{
    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public override string ToString()
        {
            return $"{Name} x{Quantity} - RM {TotalPrice:F2}";
        }
    }

    public static class OrderSession
    {
        public static List<OrderItem> OrderedItems = new List<OrderItem>();
        public static string CurrentUsername { get; set; }

        public static void Clear()
        {
            OrderedItems.Clear();
        }

    }

}
