using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã hoá đơn không được bỏ trống")]
        [DisplayName("Mã hoá đơn")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Mã tài khoản không được bỏ trống")]
        [DisplayName("Khách hàng")]
        public int AccountId { get; set; }

        [DisplayName("Khách hàng")]
        public Account Account { get; set; }

        [Required(ErrorMessage = "Bạn chưa chọn ngày")]
        [DataType(DataType.Date)]
        [DisplayName("Ngày lập")]
        public DateTime IssuedDate { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        [DisplayName("Địa chỉ giao hàng")]
        public string ShippingAddress { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống"), RegularExpression("/^\\d+$/", ErrorMessage = "Chỉ nhập số"), MinLength(10, ErrorMessage = "Tối thiểu 10 số"), MaxLength(40, ErrorMessage = "Tối đa 12 số")]
        [DisplayName("Số điện thoại giao hàng")]
        public string ShippingPhone { get; set; }

        [Required(ErrorMessage = "Tổng tiền được bỏ trống"), Range(0, int.MaxValue, ErrorMessage = "Tổng tiền lớn hơn bằng 0")]
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [DisplayName("Tổng tiền")]
        public int Total { get; set; }

        [DisplayName("Trạng thái")]
        public int Status { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
