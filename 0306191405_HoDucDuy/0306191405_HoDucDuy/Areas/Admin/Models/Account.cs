using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên tài khoản không được bỏ trống"), MinLength(3, ErrorMessage = "Tối thiểu 3 ký tự"), MaxLength(30, ErrorMessage = "Tối đa 30 ký tự")]
        [DisplayName("Tên tài khoản")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống"), MinLength(6, ErrorMessage = "Tối thiểu 6 ký tự")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống"), RegularExpression("([0-9]+)", ErrorMessage = "Chỉ nhập số")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Họ tên không được bỏ trống"), MinLength(4, ErrorMessage = "Tối thiểu 4 ký tự"), MaxLength(30, ErrorMessage = "Tối đa 30 ký tự")]
        [DisplayName("Họ và Tên")]
        public string FullName { get; set; }

        [DisplayName("Có phải là Admin không?")]
        public bool IsAdmin { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }

        [NotMapped]
        //[Required(ErrorMessage = "Bạn chưa chọn hình")]
        [DisplayName("Ảnh đại diện")]
        public IFormFile AvatarFile { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Invoice> Invoices { get; set; }

        public List<Rate> Rates { get; set; }
    }
}
