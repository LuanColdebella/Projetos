using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstract.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }


        public abstract double TotalImposto();
    }
}
