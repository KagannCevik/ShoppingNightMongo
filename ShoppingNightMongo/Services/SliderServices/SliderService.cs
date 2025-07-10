using AutoMapper;
using MongoDB.Driver;
using ShoppingNightMongo.Dtos.SliderDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingNightMongo.Services.SliderServices
{
    public class SliderService : ISliderService
    {

        private readonly IMapper _mapper;
        private readonly IMongoCollection<Slider> _sliderCollection;

        public SliderService(IMapper mapper, IDataBaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sliderCollection = database.GetCollection<Slider>(_databaseSettings.SliderCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            await _sliderCollection.InsertOneAsync(value);
        }

        public async Task DeleteSliderDto(string id)
        {
            await _sliderCollection.DeleteOneAsync(x => x.SliderId == id);
        }

        public async Task<List<ResultSliderDto>> GetAllSliderAsync()
        {
            var value = await _sliderCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSliderDto>>(value);
        }

        public async Task<GetSliderDto> GetSliderByIdAsync(string id)
        {
            var value = await _sliderCollection.Find(x => x.SliderId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetSliderDto>(value);
        }

        public async Task UpdateSliderAync(UpdateSliderDto updateSliderDto)
        {
            var slider = _mapper.Map<Slider>(updateSliderDto);
            await _sliderCollection.FindOneAndReplaceAsync(x => x.SliderId == updateSliderDto.SliderId, slider);
        }
    }
}
