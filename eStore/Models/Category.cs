namespace eStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public string? Description { get; set; }
    }
} 