using ErenBankMVC.BusinessLayer.Abstract;
using ErenBankMVC.DataAccessLayer.Abstract;
using ErenBankMVC.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenBankMVC.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDAL _customerAccountProcessDAL;

        public CustomerAccountProcessManager(ICustomerAccountProcessDAL customerAccountProcessDAL)
        {
            _customerAccountProcessDAL = customerAccountProcessDAL;
        }

        public void TDelete(CustomerAccountProcess t)
        {
            _customerAccountProcessDAL.Delete(t);
        }

        public CustomerAccountProcess TGetByID(int id)
        {
            return _customerAccountProcessDAL.GetByID(id);
        }

        public List<CustomerAccountProcess> TGetList()
        {
            return _customerAccountProcessDAL.GetList();
        }

        public void TInsert(CustomerAccountProcess t)
        {
            _customerAccountProcessDAL.Insert(t);
        }

        public void TUpdate(CustomerAccountProcess t)
        {
            _customerAccountProcessDAL.Update(t);
        }
    }
}
