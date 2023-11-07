using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstract.Entities
{
    class CompanyPayer : Payers
    {
        public int NumberEmployes{ get; set; }

        public CompanyPayer(string name, double anualIncome, int numberEmployes) : base(name, anualIncome)
        {
            NumberEmployes = numberEmployes;
        }

        public override double TotalImposto()
        {
            double total = 0;

            if (NumberEmployes > 10)
            {
                total = (AnualIncome * 0.14); 
            }
            else
            {
                total = (AnualIncome * 0.16);
            }

            return total;
        }
    }
}
