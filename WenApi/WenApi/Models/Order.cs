using System.ComponentModel.DataAnnotations.Schema;

namespace WenApi.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string OrderNo { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string PMethod { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal GTotal { get; set; }
    }
}
