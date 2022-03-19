namespace eCommerce.Backend.ViewModel.Categories;

public class CategoryVM
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int? ParentId { get; set; }
    public List<ProductVM> Products { get; set; }
}
