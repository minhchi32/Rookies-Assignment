namespace eCommerce.Backend.Extensions;

public static class CategoryDataInitializer
{
    public static void SeedCategoryData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category() { ID = 1, Name = "Áo",  ParentId = null, Status = Status.Show },
            new Category() { ID = 2, Name = "Quần",  ParentId = null, Status = Status.Show },
            new Category() { ID = 3, Name = "Khác",  ParentId = null, Status = Status.Show },
            new Category() { ID = 4, Name = "Áo khoác", ParentId = 1, Status = Status.Show },
            new Category() { ID = 5, Name = "Áo dài tay", ParentId = 1, Status = Status.Show },
            new Category() { ID = 6, Name = "Áo Polo", ParentId = 1, Status = Status.Show },
            new Category() { ID = 7, Name = "Áo T-Shirt", ParentId = 1, Status = Status.Show },
            new Category() { ID = 8, Name = "Áo sơ mi", ParentId = 1, Status = Status.Show },
            new Category() { ID = 9, Name = "Áo thể thao", ParentId = 1 },
            new Category() { ID = 10, Name = "Áo in hình", ParentId = 1 },
            new Category() { ID = 11, Name = "Quần sọt", ParentId = 2 },
            new Category() { ID = 12, Name = "Quần dài", ParentId = 2 },
            new Category() { ID = 13, Name = "Quần lót nam", ParentId = 2 },
            new Category() { ID = 14, Name = "Tất (vớ)", ParentId = 3 },
            new Category() { ID = 15, Name = "Phụ kiện", ParentId = 3 }
            );
    }
}