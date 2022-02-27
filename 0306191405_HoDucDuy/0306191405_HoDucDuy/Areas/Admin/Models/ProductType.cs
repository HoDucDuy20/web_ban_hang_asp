using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm không được bỏ trống"), MinLength(5, ErrorMessage = "Tối thiểu 5 ký tự"), MaxLength(50, ErrorMessage = "Tối đa 50 ký tự")]
        [DisplayName("Tên loại sản phẩm")]
        public string Name { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }

        public List<Product> Products { get; set; }
    }
}
