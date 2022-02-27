using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class Rate
    {
        [Key]
        public int Id { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required(ErrorMessage = "Số sao"), Range(0, 5, ErrorMessage = "Số sao từ 0-5")]
        [DisplayName("Số sao")]
        public int Star { get; set; }

        [Required(ErrorMessage = "Thông tin sản phẩm không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [DisplayName("Nội dung")]
        public string Description { get; set; }

        [DisplayName("Thời gian")]
        public DateTime Time { get; set; }
    }
}
