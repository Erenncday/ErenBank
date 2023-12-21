﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenBankMVC.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetByID(int id);
        List<T> GetList();
    }
}