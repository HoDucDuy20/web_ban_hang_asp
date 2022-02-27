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
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã hàng hoá không được bỏ trống")]
        [DisplayName("Mã hàng hoá")]
        public string SKU { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được bỏ trống"), MinLength(5, ErrorMessage = "Tối thiểu 5 ký tự"), MaxLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Thông tin sản phẩm không được bỏ trống"), MinLength(10, ErrorMessage = "Tối thiểu 10 ký tự")]
        [DisplayName("Thông tin sản phẩm")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Giá không được bỏ trống"), Range(0, int.MaxValue, ErrorMessage = "Giá lớn hơn bằng 0")]
        [DisplayFormat(DataFormatString = "{0:#,##0} VNĐ")]
        [DisplayName("Giá")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Số lượng không được bỏ trống"), Range(0, int.MaxValue, ErrorMessage = "Số lượng lớn hơn bằng 0")]
        [DisplayName("Số lượng")]
        public int Stock { get; set; }

        //[Required(ErrorMessage = "Số sao"), Range(0, 5, ErrorMessage = "Số sao từ 0-5")]
        //[DisplayName("Số sao")]
        //public int Star { get; set; }

        [Required(ErrorMessage = "Loại sản phẩm không được bỏ trống")]
        [DisplayName("Loại sản phẩm")]
        public int ProductTypeId { get; set; }

        //[Required(ErrorMessage = "Loại sản phẩm không được bỏ trống")]
        //[DisplayName("Loại sản phẩm")]
        public ProductType ProductType { get; set; }

        [DisplayName("Ảnh")]
        public string Image { get; set; }

        [NotMapped]
        //[Required(ErrorMessage = "Bạn chưa chọn hình")]
        [DisplayName("Ảnh")]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Nổi bật")]
        public bool Highlights { get; set; }

        [DisplayName("Trạng thái")]
        public bool status { get; set; }

        public List<Cart> Carts { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }

        public List<Rate> Rates { get; set; }
    }
}
