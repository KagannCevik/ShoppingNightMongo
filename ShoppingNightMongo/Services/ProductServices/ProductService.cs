using AutoMapper;
using MongoDB.Driver;
using ShoppingNightMongo.Dtos.CategoryDtos;
using ShoppingNightMongo.Dtos.ProductDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingNightMongo.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMongoCollection<Category> _categoryCollection;
        public ProductService(IMapper mapper, IDataBaseSettings _databasesettings)
        {
            var client = new MongoClient(_databasesettings.ConnectionString);
            var database = client.GetDatabase(_databasesettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databasesettings.ProductCollectionName);
            _mapper = mapper;
        }
        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductId == id);
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await _categoryCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(categories);
        }


        public async Task<List<ResultProductDto>> GetAllProductsAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }
    
        public async Task<GetProductByIdDto> GetProductByIdAsync(string id)
        {
            var value = await _productCollection.Find(x => x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetProductByIdDto>(value);
        }

       

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            // 1. Önce ID'ye göre mevcut ürünü bul
            var existingProduct = await _productCollection
                .Find(x => x.ProductId == updateProductDto.ProductId)
                .FirstOrDefaultAsync();

            if (existingProduct == null)
                throw new Exception("Ürün bulunamadı!");

            // 2. DTO'dan gelen verileri mevcut ürüne aktar
            _mapper.Map(updateProductDto, existingProduct);

            // 3. Güncellenmiş ürünü veritabanına kaydet
            await _productCollection.ReplaceOneAsync(
                x => x.ProductId == updateProductDto.ProductId,
                existingProduct
            );
        }
    }
}
