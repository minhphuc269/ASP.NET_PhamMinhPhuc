namespace PhamMinhPhuc_2122110044.Model
{
    public class Banner
    {
        public int Id { get; set; }                     // ID banner
        public string Title { get; set; }               // Tiêu đề banner
        public string ImageUrl { get; set; }            // Đường dẫn hình ảnh
        public string Link { get; set; }                // Liên kết khi nhấn banner
        public bool IsActive { get; set; }              // Trạng thái hiển thị
        public DateTime CreatedAt { get; set; }         // Ngày tạo
        public DateTime UpdatedAt { get; set; }         // Ngày cập nhật
    }
}
