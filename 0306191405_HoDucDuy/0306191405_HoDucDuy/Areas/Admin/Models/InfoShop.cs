using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class InfoShop
    {
        public int Id { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống"), RegularExpression("([0-9]+)", ErrorMessage = "Chỉ nhập số")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(70, ErrorMessage = "Tối đa 70 ký tự")]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Thông không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự"), MaxLength(200, ErrorMessage = "Tối đa 200 ký tự")]
        [DisplayName("Thông tin")]
        public string Info { get; set; }

        [DisplayName("Facebook")]
        public string Facebook { get; set; }

        [DisplayName("Instagram")]
        public string Instagram { get; set; }
        
        [DisplayName("Twitter")]
        public string Twitter { get; set; }

        [DisplayName("Youtube")]
        public string Youtube { get; set; }
    }
}
