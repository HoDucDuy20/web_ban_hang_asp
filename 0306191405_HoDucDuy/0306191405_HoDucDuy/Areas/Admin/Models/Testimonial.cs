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
    public class Testimonial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên không được bỏ trống"), MinLength(4, ErrorMessage = "Tối thiểu 4 ký tự"), MaxLength(30, ErrorMessage = "Tối đa 30 ký tự")]
        [DisplayName("Họ và Tên")]
        public string Name { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }

        [NotMapped]
        //[Required(ErrorMessage = "Bạn chưa chọn hình")]
        [DisplayName("Ảnh đại diện")]
        public IFormFile AvatarFile { get; set; }

        [Required(ErrorMessage = "Công việc không được bỏ trống"), MinLength(4, ErrorMessage = "Tối thiểu 4 ký tự"), MaxLength(30, ErrorMessage = "Tối đa 30 ký tự")]
        [DisplayName("Công việc")]
        public string Job { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống"), MinLength(4, ErrorMessage = "Tối thiểu 4 ký tự")]
        [DisplayName("Nội dung")]
        public string Description { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    }
}
