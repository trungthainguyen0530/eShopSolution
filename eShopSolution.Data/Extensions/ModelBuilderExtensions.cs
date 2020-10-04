using eShopSolution.Data.Entities;
using eShopSolution.Data.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is home page description of eShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is home page keyword of eShop" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tieng Viet", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,

                },

                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Ao Nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "San pham ao thoi trang nam",
                    SeoTitle = "Ao Nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Men T-Shirt",
                    SeoDescription = "T-Shirt for men",
                    SeoTitle = "Men T-Shirt"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Ao Nu",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "San pham ao thoi trang nu",
                    SeoTitle = "Ao nu"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "Women T-Shirt",
                    SeoDescription = "T-Shirt for Women",
                    SeoTitle = "Women T-Shirt"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 10000,
                    Price = 15000,
                    Stock = 0,
                    ViewCount = 0,
                }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Ao Nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "San pham ao thoi trang nam",
                    SeoTitle = "Ao Nam",
                    Details = "Mo ta san pham",
                    Description = ""
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "T-Shirt",
                    SeoDescription = "T-Shirt for men",
                    SeoTitle = "T-Shirt",
                    Details = "Description of product",
                    Description = ""
                }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}
