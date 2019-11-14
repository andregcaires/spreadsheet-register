using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Context.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private SpreadsheetRegisterContext _context;
        private DbSet<T> _dbSet;

        public Repository(SpreadsheetRegisterContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T instance)
        {
            throw new NotImplementedException();
        }
    }
}
