using System.ComponentModel.DataAnnotations.Schema;

namespace WenApi.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Img { get; set; }

    }
}
