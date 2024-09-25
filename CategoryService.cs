﻿using Ecom.Models.Entities;
using Ecom.Models.Repositories.IRepositories;
using Ecom.Models.Services.IServices;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Ecom.Models.Services
{
    public class CategoryService:ICategoryService
    {
        private ModelStateDictionary? _modelState;
        private ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }
       
        public List<Category> GetCategoryList()
        {
            return _repository.ToList();
        }
    }
}
