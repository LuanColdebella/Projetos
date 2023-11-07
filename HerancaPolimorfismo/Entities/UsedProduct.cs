using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }


        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("N2")} (Manufature date : {ManufatureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
