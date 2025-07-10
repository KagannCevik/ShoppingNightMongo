
namespace ShoppingNightMongo.Dtos.CategoryDtos
{
    public class ResultCategoryDto
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public static implicit operator List<object>(ResultCategoryDto v)
        {
            throw new NotImplementedException();
        }
    }
}
