﻿using ShoppingNightMongo.Dtos.ProductImageDtos;

namespace ShoppingNightMongo.Services.ProductImageService
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
        Task<GetProductImageDto> GetProductImageByIdAsync(string id);
    }
}
