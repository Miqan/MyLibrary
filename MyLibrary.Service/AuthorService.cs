using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;

namespace MyLibrary.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> repository;
        public AuthorService(IRepository<Author> repository)
        {
            this.repository = repository;
        }
        public void Delete(string id)
        {
            repository.Delete(id);
        }

        public Author Get(string id)
        {
            return repository.Get(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return repository.GetAll();
        }

        public void Insert(Author entity)
        {
            repository.Insert(entity);
        }

        public void Update(Author entity)
        {
            repository.Update(entity);
        }
    }

    public interface IAuthorService
    {
        Author Get(string id);
        IEnumerable<Author> GetAll();
        void Insert(Author entity);
        void Update(Author entity);
        void Delete(string id);
    }
}