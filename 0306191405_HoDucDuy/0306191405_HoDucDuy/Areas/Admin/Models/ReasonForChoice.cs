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
    public class ReasonForChoice
    {
        public int id { get; set; }

        [DisplayName("Icon")]
        public string Image { get; set; }

        [NotMapped]
        //[Required(ErrorMessage = "Bạn chưa chọn icon")]
        [DisplayName("Icon")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Lý do lựa chọn không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [DisplayName("Lý do lựa chọn")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(250, ErrorMessage = "Tối đa 250 ký tự")]
        [DisplayName("Nội dung")]
        public string Description { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }
    }
}
