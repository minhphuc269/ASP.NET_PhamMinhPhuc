using Microsoft.EntityFrameworkCore;

namespace PhamMinhPhuc_2122110044.Model
{
    public class Product
    {
        public int Id { get; set; }                     // ID sản phẩm
        public string Name { get; set; }                // Tên sản phẩm (tương tự User.Username)
        public string Description { get; set; }         // Mô tả chi tiết
        public string ImageUrl { get; set; }            // Đường dẫn ảnh (giống Banner.ImageUrl)

        [Precision(18, 2)]                              // Cấu hình cho kiểu decimal
        public decimal Price { get; set; }              // Giá bán

        public DateTime CreatedAt { get; set; }         // Ngày tạo (giống User/Banner)
        public DateTime UpdatedAt { get; set; }         // Ngày cập nhật (giống User/Banner)

        // Khóa ngoại đến Category
        //public int CategoryId { get; set; }            // ID danh mục
        //public Category? Category { get; set; }         // Navigation property (có thể null)
    }
}