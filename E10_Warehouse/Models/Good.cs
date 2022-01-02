using System.ComponentModel.DataAnnotations;

namespace E10_Warehouse.Models
{
    public class Good
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не вказана назва")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Довжина назви має бути від 3 до 20 символів")]
        public string GoodName { get; set; }
        [Required]
        [RegularExpression(@"\-?\d+(\.\d{0,})?", ErrorMessage = "Має вводитися число")]
        public int Quantity { get; set; }
        public bool IsAvailible { get; set; }
    }
}
