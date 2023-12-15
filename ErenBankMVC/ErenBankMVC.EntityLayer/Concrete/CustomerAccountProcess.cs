using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenBankMVC.EntityLayer.Concrete
{
    // Hesap hareketleri burada tutulacak

    public class CustomerAccountProcess 
    {
        public int CustomerAccountProcessID { get; set; }
        public string ProcessType { get; set; } // İşlem Türü
        public decimal Amount { get; set; } // Tutar
        public DateTime ProcessDate { get; set; } // İşlem Tarihi

    }
}
