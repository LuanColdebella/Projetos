using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }


        public override string PriceTag()
        {
            return $"{Name} $ {(Price + CustomsFee)} (Customs fee: $ {CustomsFee.ToString("N2")})";
        }

    }
}
