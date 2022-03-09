namespace eCommerce.Backend.Extensions;

public static class CategoryDataInitializer
{
    public static void SeedCategoryData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category() { ID = 1, Name = "Áo", SeoTitle = "ao", ParentId = null, Status = Status.Show },
            new Category() { ID = 2, Name = "Quần", SeoTitle = "quan", ParentId = null, Status = Status.Show },
            new Category() { ID = 3, Name = "Khác", SeoTitle = "khac", ParentId = null, Status = Status.Show },
            new Category() { ID = 4, Name = "Áo khoác", SeoTitle = "ao-khoac", ParentId = 1, Status = Status.Show },
            new Category() { ID = 5, Name = "Áo dài tay", SeoTitle = "ao-dai-tay", ParentId = 1, Status = Status.Show },
            new Category() { ID = 6, Name = "Áo Polo", SeoTitle = "ao-polo", ParentId = 1, Status = Status.Show },
            new Category() { ID = 7, Name = "Áo T-Shirt", SeoTitle = "ao-t-shirt", ParentId = 1, Status = Status.Show },
            new Category() { ID = 8, Name = "Áo sơ mi", SeoTitle = "ao-so-mi", ParentId = 1, Status = Status.Show },
            new Category() { ID = 9, Name = "Áo thể thao", SeoTitle = "ao-the-thao", ParentId = 1 },
            new Category() { ID = 10, Name = "Áo in hình", SeoTitle = "ao-in-hinh", ParentId = 1 },
            new Category() { ID = 11, Name = "Quần sọt", SeoTitle = "quan-sot", ParentId = 2 },
            new Category() { ID = 12, Name = "Quần dài", SeoTitle = "quan-dai", ParentId = 2 },
            new Category() { ID = 13, Name = "Quần lót nam", SeoTitle = "quan-lot", ParentId = 2 },
            new Category() { ID = 14, Name = "Tất (vớ)", SeoTitle = "tat", ParentId = 3 },
            new Category() { ID = 15, Name = "Phụ kiện", SeoTitle = "phu-kien", ParentId = 3 }
            );
    }
}