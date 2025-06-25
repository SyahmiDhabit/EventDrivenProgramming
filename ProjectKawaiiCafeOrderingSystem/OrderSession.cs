using System.Collections.Generic;

namespace ProjectKawaiiCafeOrderingSystem
{
    public class OrderItem
    {
        public int MenuID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsMerchandise { get; set; }
        public int MerchID { get; set; }

        public override string ToString()
        {
            return $"{Quantity} x {Name} - RM {TotalPrice:F2}";
        }
    }

    public static class OrderSession
    {
      
        // For food, drinks, desserts
        public static List<OrderItem> OrderedItems = new List<OrderItem>();

        // For merchandise
        public static List<OrderItem> OrderedMerchandise = new List<OrderItem>();

        public static string username { get; set; }
        public static int custID { get; set; }

        public static void Clear()
        {
            OrderedItems.Clear();
            OrderedMerchandise.Clear();
            username = null;
            custID = 0;
        }
    }
}
