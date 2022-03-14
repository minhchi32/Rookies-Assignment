namespace eCommerce.Backend.ViewModel.Categories;

public class CategoryUpdateRequest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public Status Status { get; set; }
    public string SeoTitle { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}
