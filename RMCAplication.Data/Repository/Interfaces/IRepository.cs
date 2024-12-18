﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCAplication.Data.Repository.Interfaces
{
    public interface IRepository<TType, TId>
    {
        TType GetById(TId id);
        Task <TType> GetByIdAsync(TId id);
        IEnumerable<TType> GetAll();
        IQueryable<TType> GetAllAttached();
        Task<IEnumerable<TType>> GetAllAsync();
        void Add(TType item);
        Task AddAsync(TType item);
        bool Delete(TId id);
        Task<bool> DeleteAsync(TId id);
        bool Update(TType item);
        Task<bool>UpdateAsync(TType item);
    }
}
