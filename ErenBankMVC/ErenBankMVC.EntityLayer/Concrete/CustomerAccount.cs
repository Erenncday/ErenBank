using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenBankMVC.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; } // Kullanıcı Hesap Id'si
        public string CustomerAccountNumber { get; set; } // Kullanıcı Hesap Numarası
        public string CustomerAccountCurrency { get; set; } // Hesabın döviz Türü
        public decimal CustomerAccountBalance { get; set; } // Hesapta bulunan bakiye
        public string BankBranch { get; set; } // Hesabın bağlı bulunduğu şube

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
