﻿using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public interface CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category category)
        {
            if (category.CategoryName == "" || category.CategoryName.Length <= 3 || category.CategoryDescription == "" || category.CategoryName.Length >= 51)
            {
                //Hata Mesajı
            }
            else
            {
                repo.Insert(category);
            }
        }
    }
}
