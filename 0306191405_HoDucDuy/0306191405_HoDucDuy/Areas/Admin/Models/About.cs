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
    public class About
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ảnh")]
        public string Image { get; set; }

        [NotMapped]
        //[Required(ErrorMessage = "Bạn chưa chọn hình")]
        [DisplayName("Ảnh")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được bỏ trống"), MinLength(5, ErrorMessage = "Tối thiểu 5 ký tự"), MaxLength(40, ErrorMessage = "Tối đa 40 ký tự")]
        [DisplayName("Tiêu đề")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự")]
        [DisplayName("Nội dung")]
        public string Description { get; set; }
    }
}
