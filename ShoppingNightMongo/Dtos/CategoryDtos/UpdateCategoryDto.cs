﻿namespace ShoppingNightMongo.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }

        public string ImageUrl { get; set; }
    }
}
