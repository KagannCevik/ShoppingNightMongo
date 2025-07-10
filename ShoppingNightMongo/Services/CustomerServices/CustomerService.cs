using AutoMapper;
using MongoDB.Driver;
using ShoppingNightMongo.Dtos.CustomerDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingNightMongo.Services.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Customer> _customerCollection;

        public CustomerService(IMapper mapper, IDataBaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _customerCollection = database.GetCollection<Customer>(_databaseSettings.CustomerCollectionName);
            _mapper = mapper;

        }
        public async Task CreateCustomerAsync(CreateCustomerDto createCustomerDto)
        {
            var value = _mapper.Map<Customer>(createCustomerDto);
            await _customerCollection.InsertOneAsync(value);
        }

        public Task DeleteCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultCustomerDto>> GetAllCustomerAsync()
        {
            var values = await _customerCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCustomerDto>>(values);
        }

        public async Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerId)
        {
            var value = _customerCollection.Find(x => x.CustomerId == customerId).FirstOrDefaultAsync();
            return _mapper.Map<GetCustomerByIdDto>(value);

        }
            public async Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto)
        {
            var value = _mapper.Map<Customer>(updateCustomerDto);
            await _customerCollection.FindOneAndReplaceAsync(x => x.CustomerId == updateCustomerDto.CustomerId, value);
        }
    }
}
