using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã hoá đơn không được bỏ trống")]
        [DisplayName("Mã hoá đơn")]
        public int InvoiceId { get; set; }

        [DisplayName("Mã hoá đơn")]
        public Invoice Invoice { get; set; }

        [Required(ErrorMessage = "Sản phẩm không được bỏ trống")]
        [DisplayName("Sản phẩm")]
        public int ProductId { get; set; }

        [DisplayName("Sản phẩm")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "Số lượng không được bỏ trống"), Range(1, int.MaxValue, ErrorMessage = "Số lượng lớn hơn 0")]
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Đơn giá không được bỏ trống"), Range(0, int.MaxValue, ErrorMessage = "Đơn giá lớn hơn bằng 0")]
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [DisplayName("Đơn giá")]
        public int UnitPrice { get; set; }
    }
}
