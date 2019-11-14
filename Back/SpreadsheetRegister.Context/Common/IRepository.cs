using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.Context.Common
{
    public interface IRepository<T>
    {
        void Add(T instance);

        void Update(T instance);

        List<T> SelectAll();

        T FindById();

    }
}
