using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã tài khoản không được bỏ trống")]
        [DisplayName("Khách hàng")]
        public int AccountId { get; set; }

        [DisplayName("Khách hàng")]
        public Account Account { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được bỏ trống")]
        [DisplayName("Sản phẩm")]
        public int ProductId { get; set; }

        [DisplayName("Sản phẩm")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "Số lượng không được bỏ trống"), Range(1, int.MaxValue, ErrorMessage = "Số lượng lớn hơn 0")]
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
