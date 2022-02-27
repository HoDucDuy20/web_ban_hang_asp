using _0306191405_HoDucDuy.Areas.Admin.Models;
using _0306191405_HoDucDuy.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0306191405_HoDucDuy.Areas.Admin.Data
{
    public class DataSeeding
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<MinicsContext>();
                context.Database.EnsureCreated();

                //About
                if (!context.Abouts.Any())
                {
                    context.Abouts.AddRange(new List<About>()
                    {
                        new About()
                        {
                            Image = "1.jpg",
                            Title = "We Provide Best For You",
                            Description = "Totam architecto rem beatae veniam, cum officiis adipisci soluta perspiciatis ipsa, expedita maiores quae accusantium. Animi veniam aperiam, necessitatibus mollitia ipsum id optio ipsa odio ab facilis sit labore officia! Repellat expedita, deserunt e"
                        }
                    });
                    context.SaveChanges();
                }
                //ReasonForChoice
                if (!context.ReasonForChoices.Any())
                {
                    context.ReasonForChoices.AddRange(new List<ReasonForChoice>()
                    {
                        new ReasonForChoice()
                        {
                            Reason = "FAST DELIVERY",
                            Description = "variations of passages of Lorem Ipsum available",
                            Image = "1.png"
                        },
                         new ReasonForChoice()
                        {
                            Reason = "FREE SHIPING",
                            Description = "variations of passages of Lorem Ipsum available",
                            Image = "2.png"
                        },
                          new ReasonForChoice()
                        {
                            Reason = "BEST QUALITY",
                            Description = "variations of passages of Lorem Ipsum available",
                            Image = "3.png"
                        }
                    });
                    context.SaveChanges();
                }
                //SlideShow
                if (!context.SlideShows.Any())
                {
                    context.SlideShows.AddRange(new List<SlideShow>()
                    {
                        new SlideShow()
                        {
                            Image = "3.png",
                            Title = "Playstation 5",
                            Description = "Like its Xbox Series X competitor, the PlayStation 5 can be upright or placed horizontally when placed on a shelf. According to the images published by Sony, it can be seen that the heatsink and exhaust slots of the PlayStation 5",
                            Status = true
                        },
                        new SlideShow()
                        {
                            Image = "2.png",
                            Title = "DJI Mavic 3 Flycam",
                            Description = "Recently, DJI - the world famous brand specializing in manufacturing high-quality drones has officially launched the DJI Mavic 3 Flycam. The long-awaited super product does not disappoint for industry enthusiasts. turmeric.",
                            Status = true
                        },
                        new SlideShow()
                        {
                            Image = "1.png",
                            Title = "Iphone 13 Series",
                            Description = "The iPhone 13 Series phone in 2021 is welcomed by many people, after the launch of the iPhone 12 with many upgrades and improvements, iFans are waiting for the next version of the Apple house.",
                            Status = true
                        }
                    });
                    context.SaveChanges();
                }
                //Testimonial
                if (!context.Testimonials.Any())
                {
                    context.Testimonials.AddRange(new List<Testimonial>()
                    {
                        new Testimonial()
                        {
                            Name = "Lisa",
                            Avatar = "2.jpg",
                            Job = "Designer",
                            Description = "Lisa said she was very satisfied with Apple's AAR standard service when shopping at the Minis system. At the store, designers are free to experience – in their hands the new iPhone 13 Pro Max before deciding to buy.",
                            Status = true
                        },
                        new Testimonial()
                        {
                            Name = "JAMES DEW",
                            Avatar = "1.png",
                            Job = "Photographer",
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content her",
                            Status = true
                        }
                    });
                    context.SaveChanges();
                }
                //InfoShop
                if (!context.InfoShops.Any())
                {
                    context.InfoShops.AddRange(new List<InfoShop>()
                    {
                        new InfoShop()
                        {
                            Email = "minicsshop@gmail.com",
                            Phone = "0964743255",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            Info = "Eligendi sunt, provident, debitis nemo, facilis cupiditate velit libero dolorum aperiam enim nulla iste maxime corrupti ad illo libero minus.",
                            Facebook = "https://www.facebook.com/minicsshop/",
                            Instagram = "https://www.instagram.com/minicsshop",
                            Twitter = "",
                            Youtube = ""
                        }
                    });
                    context.SaveChanges();
                }
                //Account
                if (!context.Accounts.Any())
                {
                    context.Accounts.AddRange(new List<Account>()
                    {
                        new Account()
                        {
                            Username = "thuthuy",
                            Password = "87D9BB400C0634691F0E3BAAF1E2FD0D",
                            Email = "lythuthuy123@gmail.com",
                            Phone = "0939595211",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            FullName = "Lý Thu Thuỷ",
                            IsAdmin = false,
                            Avatar = "",
                            Status = true
                        },
                        new Account()
                        {
                            Username = "ducduy",
                            Password = "87D9BB400C0634691F0E3BAAF1E2FD0D",
                            Email = "hoducduy358@gmail.com",
                            Phone = "0939595211",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            FullName = "Hồ Đức Duy",
                            IsAdmin = false,
                            Avatar = "",
                            Status = true
                        },
                          new Account()
                        {
                            Username = "admin",
                            Password = "87D9BB400C0634691F0E3BAAF1E2FD0D",
                            Email = "admin@gmail.com",
                            Phone = "0964743232",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            FullName = "Hồ Đức Duy",
                            IsAdmin = true,
                            Avatar = "1.png",
                            Status = true
                        },
                          new Account()
                        {
                            Username = "vantoan",
                            Password = "87D9BB400C0634691F0E3BAAF1E2FD0D",
                            Email = "",
                            Phone = "0388857399",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            FullName = "Hồ Văn Toàn",
                            IsAdmin = false,
                            Avatar = "",
                            Status = true
                        },
                           new Account()
                        {
                            Username = "trucdao",
                            Password = "87D9BB400C0634691F0E3BAAF1E2FD0D",
                            Email = "hatrucdao98@gmail.com",
                            Phone = "0393929377",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            FullName = "Hà Trúc Đạo",
                            IsAdmin = false,
                            Avatar = "",
                            Status = false
                        },
                           new Account()
                        {
                            Username = "huongly",
                            Password = "87D9BB400C0634691F0E3BAAF1E2FD0D",
                            Email = "",
                            Phone = "0965332171",
                            Address = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            FullName = "Nguyễn Thị Hương Ly",
                            IsAdmin = false,
                            Avatar = "",
                            Status = true
                        }
                    });
                    context.SaveChanges();
                }
                //ProductType
                if (!context.ProductTypes.Any())
                {
                    context.ProductTypes.AddRange(new List<ProductType>()
                    {
                        new ProductType()
                        {
                            Name = "LapTop",
                            Status = true
                        },
                        new ProductType()
                        {
                            Name = "Gaming & Console",
                            Status = true
                        },
                        new ProductType()
                        {
                            Name = "Flycam",
                            Status = true
                        },
                        new ProductType()
                        {
                            Name = "Phone",
                            Status = true
                        },
                        new ProductType()
                        {
                            Name = "Camera",
                            Status = true
                        }
                    });
                    context.SaveChanges();
                }
                //Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            SKU = "1525922034_VNAMZ-6408472688",
                            Name = "CANON EOS R5",
                            Description = "Canon EOS R5 sở hữu cảm biến Full-frame 45MP do chính Canon thiết kế và phát triển, cung cấp hình ảnh và video với độ phân giải cao. Bộ vi xử lý DIGIC X xuất hiện trên chiếc 1DX III cũng được sử dụng cho EOS R5, đem đến khả năng đọc và xử lý dữ liệu",
                            Price = 95500000,
                            Stock = 20,
                            ProductTypeId = 1,
                            Image = "6.png",
                            status = true,
                            Highlights = true
                        },
                        new Product()
                        {
                            SKU = "783100804_VNAMZ-2099728578",
                            Name = "Sony A7R mark IV Body ( ILCE-7RM4)",
                            Description = "Cảm biến: CMOS – BSI 61mpx, 9504 x 6336- Chống rung cảm biến: 5,5 stop- Dải ISO: 100 – 32000, mở rộng tối đa tới 102.400- Hệ thống AF nhận diện pha 567 điểm- Hỗ trợ: Eye AF, Animal Eye AF- Tốc độ chụp liên tiếp: tối đa tới 10 hình/giây- Màn hình Mark",
                            Price = 82990000,
                            Stock = 20,
                            ProductTypeId = 1,
                            Image = "5.png",
                            status = true,
                            Highlights = false
                        },
                        new Product()
                        {
                            SKU = "1587620972_VNAMZ-6777678115",
                            Name = "Samsung Galaxy Z FLIP 3 5G 8GB/128GB",
                            Description = "Sản phẩm chính hãng Samsung Việt Nam, Nguyên seal, Mới 100%, chưa khui hộp Bảo hành 12 tháng tại TTBH của Samsung toàn quốc (tìm TTBH chính hãng tại: https://www.samsung.com/vn/support/center/supportServiceCenter/) Màn hình: Chính: Dynamic AMOLED 2X,",
                            Price = 19490000,
                            Stock = 20,
                            ProductTypeId = 2,
                            Image = "4.png",
                            status = true,
                            Highlights = false
                        },
                        new Product()
                        {
                            SKU = "1109284479_VNAMZ-3880600832",
                            Name = "Samsung Galaxy S21 Ultra 5G (12GB/128GB)",
                            Description = "Màn hình: Dynamic AMOLED 2X 6.8, Quad HD+ Hệ điều hành: Android 11 Camera chính: 108MP + 12MP + 10MP + 10MP Camera trước: 40MP Chipset: Exynos 2100 RAM: 12 GB Bộ nhớ trong: 128 GB Cổng kết nối/sạc: USB Type-C Dung lượng pin: 5.000 mAh, hỗ trợ sạ",
                            Price = 19790000,
                            Stock = 20,
                            ProductTypeId = 2,
                            Image = "3.png",
                            status = true,
                            Highlights = true
                        },new Product()
                        {
                            SKU = "1525577176_VNAMZ-6407500972",
                            Name = "Apple iPhone 13 256GB VN/A",
                            Description = "Hàng Chính Hãng 100% - Có Hóa Đơn VAT xuất bởi Lazada - Mã VN/A Trả Góp 0% qua thẻ, Trả Trước 0đ Mới 100% - Chưa Qua Sử Dụng - Nguyên Seal - Đầy đủ phụ kiện chính hãng Bảo hành 12 Tháng thông qua các trung tâm bảo hành Apple tại Việt Nam. Hình Thức B",
                            Price = 22490000,
                            Stock = 20,
                            ProductTypeId = 2,
                            Image = "2.png",
                            status = true,
                            Highlights = true
                        },
                        new Product()
                        {
                            SKU = "1543336034_VNAMZ-6904379334",
                            Name = "Apple iPhone 13 Pro Max 128GB VN/A",
                            Description = "Màn hình Super Retina XDR 6.7 inch với ProMotion cho cảm giác nhanh nhạy hơn Chế độ Điện Ảnh làm tăng thêm độ sâu trường ảnh nông và tự động thay đổi tiêu cự trong video Hệ thống camera chuyên nghiệp Telephoto, Wide và Ultra Wide 12MP; LiDAR Scanner;",
                            Price = 30890000,
                            Stock = 20,
                            ProductTypeId = 2,
                            Image = "1.png",
                            status = true,
                            Highlights = true
                        },
                         new Product()
                        {
                            SKU = "1700310763_VNAMZ-7556076329",
                            Name = "GoPro HERO 10 Black",
                            Description = "1 GoPro HERO10 Black  Túi đựng GoPro  Tặng kèm 2 pin 1720mAh  Keo dán cong  USB Type-C Cable  Gậy tripod shorty  Kẹp balo Gopro Magnetic Swivel Clip  Mount gài loại cao chữ L",
                            Price = 13300000,
                            Stock = 20,
                            ProductTypeId = 1,
                            Image = "7.png",
                            status = true,
                            Highlights = true
                        },
                          new Product()
                        {
                            SKU = "6482937",
                            Name = "DJI Mavic 3 Pro",
                            Description = "Kết hợp hiệu quả giữa Mavic 2 Pro và Mavic 2 Zoom, DJI Mavic 3 thế hệ mới được tích hợp “hai camera trong một” bao gồm một camera cảm biến lớn 4/3 20MP và một camera zoom lai 28x, mang đến hiệu suất hình ảnh vượt trội cùng khả năng zoom ấn tượng, hỗ",
                            Price = 49900000,
                            Stock = 20,
                            ProductTypeId = 3,
                            Image = "8.png",
                            status = true,
                            Highlights = false
                        },
                          new Product()
                        {
                            SKU = "FL026413",
                            Name = "FLYCAM MAVIC 2 PRO",
                            Description = "Mavic 2 Pro được trang bị cánh giảm ồn , máy có vận tốc tối đa 72 km/h, thời lượng bay tối đa 31 phút với pin dung lượng 3850 mah  Mavic 2 Pro được trang bị công nghệ Ocusync 2.0 với khả năng truyền hình ảnh 1080p với tầm xa tối đa 8km . Công nghệ Oc",
                            Price = 35990000,
                            Stock = 20,
                            ProductTypeId = 3,
                            Image = "9.png",
                            status = true,
                            Highlights = true
                        },
                           new Product()
                        {
                            SKU = "374100254_VNAMZ-624932158",
                            Name = "PlayStation 5 Standard Edition",
                            Description = "CPU:AMD Zen 2 8 nhân 16 luồng, xung nhịp 3.5GHz - GPU:Kiến trúc RDNA 2 của AMD, sức mạnh 10.28 TFLOPS, tốc độ 2.23GHz, hỗ trợ ray-tracing - Bộ nhớ RAM:GDDR5 16GB - Bộ nhớ lưu trữ 825GB SSD tốc độ đạt 5,5 GB/s (nhanh gấp 100 lần PS4) - Ổ đĩa BD/DVD",
                            Price = 23350000,
                            Stock = 20,
                            ProductTypeId = 4,
                            Image = "10.png",
                            status = true,
                            Highlights = true
                        },
                             new Product()
                        {
                            SKU = "1627321854_VNAMZ-7072325684",
                            Name = "Nintendo Switch Oled",
                            Description = "Máy nintendo switch - phiên bản oled mới nhất Phụ kiện Nintendo Switch OLED Model:- 1 máy Nintendo Switch OLED Model - 1 dock gắn tivi.- Joy-con (L), joy-con (R).- 1 cáp HDMI.- 1 Nguồn ac adapter.- 1 joy-con grip.- 2 dây đeo joycon (Straps)Thông tin",
                            Price = 9190000,
                            Stock = 20,
                            ProductTypeId = 4,
                            Image = "11.png",
                            status = true,
                            Highlights = false
                        },
                    });
                    context.SaveChanges();
                }
                //Rate
                if (!context.Rates.Any())
                {
                    context.Rates.AddRange(new List<Rate>()
                    {
                        new Rate()
                        {
                            AccountId = 2,
                            ProductId = 1,
                            Star = 5,
                            Description = "Sản phẩm tốt quá chời luôn á",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 3,
                            ProductId = 1,
                            Star = 4,
                            Description = "Sản phẩm tốt, cầm cấn tay quá nên cho 4sao thoi nha",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 4,
                            ProductId = 1,
                            Star = 5,
                            Description = "Máy cầm xịn lắm",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 2,
                            ProductId = 11,
                            Star = 3,
                            Description = "Máy chơi cũng ok",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 3,
                            ProductId = 10,
                            Star = 5,
                            Description = "Chơi game cả ngày mà không thấy chán luôn",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 4,
                            ProductId = 8,
                            Star = 4,
                            Description = "Máy quây xịn xò lắm",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 2,
                            ProductId = 6,
                            Star = 5,
                            Description = "Chụp phải nói là nét lắm",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 3,
                            ProductId = 4,
                            Star = 2,
                            Description = "Màn hình dễ xước quá",
                            Time = DateTime.Now
                        },
                        new Rate()
                        {
                            AccountId = 4,
                            ProductId = 2,
                            Star = 5,
                            Description = "iphone 13 này nhìn có điểm nhấn hơn ",
                            Time = DateTime.Now
                        },
                    });
                    context.SaveChanges();
                }
                //Cart
                if (!context.Carts.Any())
                {

                }
                //Invoice
                if (!context.Invoices.Any())
                {
                    context.Invoices.AddRange(new List<Invoice>()
                    {
                        new Invoice()
                        {
                            Code = "smTebg8c",
                            AccountId = 2,
                            IssuedDate = DateTime.Now,
                            ShippingAddress = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            ShippingPhone = "0939595211",
                            Total = 64570000,
                            Status = 3,
                        },
                        new Invoice()
                        {
                            Code = "RQWzDHy1",
                            AccountId = 2,
                            IssuedDate = DateTime.Now,
                            ShippingAddress = "65 Đường Huỳnh Thúc Kháng, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                            ShippingPhone = "0939595211",
                            Total = 414380000,
                            Status = 1,
                        }
                    });
                    context.SaveChanges();
                }
                //InvoiceDetail
                if (!context.InvoiceDetails.Any())
                {
                    context.InvoiceDetails.AddRange(new List<InvoiceDetail>()
                    {
                        new InvoiceDetail()
                        {
                            InvoiceId = 2,
                            ProductId = 2,
                            Quantity = 2,
                            UnitPrice = 44980000
                        },
                         new InvoiceDetail()
                        {
                            InvoiceId = 2,
                            ProductId = 4,
                            Quantity = 1,
                            UnitPrice = 19490000
                        },
                        new InvoiceDetail()
                        {
                            InvoiceId = 1,
                            ProductId = 5,
                            Quantity = 1,
                            UnitPrice = 82990000
                        },
                        new InvoiceDetail()
                        {
                            InvoiceId = 1,
                            ProductId = 1,
                            Quantity = 10,
                            UnitPrice = 308900000
                        },
                        new InvoiceDetail()
                        {
                            InvoiceId = 1,
                            ProductId = 2,
                            Quantity = 1,
                            UnitPrice = 22490000
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
