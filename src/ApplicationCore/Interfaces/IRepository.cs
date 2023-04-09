using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();    //bütün hepsini döndürür.

        Task<List<T>> GetAllAsync(ISpecification<T> specification);

        Task<T> AddAsync(T entity);    //hem ürün ekler hemde aynısını döndürür.

        Task UpdateAsync(T entity);   //ürünü ekler döndürmez

        Task DeleteAsync(T entity);    //ürünü siler döndürmez.

        Task<int> CountAsync(ISpecification<T> specification);

        Task<T> FirstAsync(ISpecification<T> specification);

        Task<T?> FirstOrDefaultAsync(ISpecification<T> specification);

    }
}
