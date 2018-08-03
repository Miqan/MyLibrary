using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Data
{
    //T tip parametresi oluşturarak where kısıtlaması yaparız.
    public interface IRepository<T> where T:BaseEntity, new()
    {
        //method tanımlaması
        T Get(string id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(string id);
    }
}
