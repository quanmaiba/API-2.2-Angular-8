using System.ComponentModel.DataAnnotations;

namespace WenApi.Models
{
    public class OrderItems
    {
        [Key]
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ItemID { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
