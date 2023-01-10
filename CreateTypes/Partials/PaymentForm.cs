using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreateTypes.Partials
{
    public partial class PaymentForm
    {
        public string Name { get; set; }

        partial void ValidatePayment(decimal amount);
         partial void M1(); // Extended partial method
         partial void M2(); // Extended partial method

        
    }
}
