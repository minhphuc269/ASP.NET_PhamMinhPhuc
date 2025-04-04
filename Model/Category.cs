namespace PhamMinhPhuc_2122110044.Model
{
    public class Category
    {
        public int Id { get; set; }                     // ID danh mục
        public string Name { get; set; }                // Tên danh mục (tương tự User.Username)
        public string Description { get; set; }         // Mô tả
        public string ImageUrl { get; set; }            // Đường dẫn ảnh (giống Banner.ImageUrl)
        public bool IsActive { get; set; } = true;      // Trạng thái (giống Banner.IsActive)
        public DateTime CreatedAt { get; set; }         // Ngày tạo (đồng bộ)
        public DateTime UpdatedAt { get; set; }         // Ngày cập nhật (đồng bộ)

        // Danh sách sản phẩm
        //public ICollection<Product> Products { get; set; } = new List<Product>();
     }
}