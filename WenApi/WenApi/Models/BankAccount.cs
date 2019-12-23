using System.ComponentModel.DataAnnotations;

namespace WenApi.Models
{
    public class BankAccount
    {
        [Key]
        public int BankAccountId { get; set; }

        //[Column(TypeName = "nvachar(20)")]
        [Required]
        public string AccountNumber { get; set; }

        //[Column(TypeName = "nvachar(100)")]
        [Required]
        public string AccountHolder { get; set; }

        [Required]
        public int BankId { get; set; }
        public Bank Bank { get; set; }

        [Required]
        //[Column(TypeName = "nvachar(20)")]
        public string IFSC { get; set; }
    }
}
