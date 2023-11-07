using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstract.Entities
{
    class IndividualPayer : Payers
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditure) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditure;
        }

        public override double TotalImposto()
        {
            double total = 0;
            if (AnualIncome >= 20000)
            {
                total = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            else
            {
                total = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }

            return total;
        }
    }
}
