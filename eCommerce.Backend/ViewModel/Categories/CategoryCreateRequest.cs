namespace eCommerce.Backend.ViewModel.Categories;

public class CategoryCreateRequest
{
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public string SeoTitle { get; set; }
    public DateTime CreatedAt { get; set; }
}
