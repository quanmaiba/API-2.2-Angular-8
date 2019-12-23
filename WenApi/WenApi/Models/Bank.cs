using System.ComponentModel.DataAnnotations;

namespace WenApi.Models
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        //[Column(TypeName = "nvachar(100)")]
        public string BankName { get; set; }
    }
}
