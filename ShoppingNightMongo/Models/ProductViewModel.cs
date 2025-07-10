using ShoppingNightMongo.Dtos.CategoryDtos;
using ShoppingNightMongo.Dtos.ProductDtos;
using ShoppingNightMongo.Entities;


namespace ShoppingMongo.Models
{
    public class ProductViewModel
    {
        public List<ResultProductDto> Products { get; set; }
        public List<ResultCategoryDto> Categories { get; set; }
    }
}