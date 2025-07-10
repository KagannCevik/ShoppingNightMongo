using ShoppingNightMongo.Dtos.SliderDtos;

namespace ShoppingNightMongo.Services.SliderServices
{
    public interface ISliderService
    {
        Task<List<ResultSliderDto>> GetAllSliderAsync();
        Task CreateSliderAsync(CreateSliderDto createSliderDto);
        Task UpdateSliderAync(UpdateSliderDto updateSliderDto);
        Task DeleteSliderDto(string id);
        Task<GetSliderDto> GetSliderByIdAsync(string id);
    }
}
