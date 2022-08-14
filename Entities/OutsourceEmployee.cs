using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_POO_Polimorfismo.Entities
{
    // Não pode ser herdada
    // Herdar da classe Employee
    sealed class OutsourceEmployee : Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }
        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) :
            base(name, hours, valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
            AdditionalCharge = additionalCharge;
        }

        public override double Payment(int percent)
        {
            double res=0;
            if (percent > 0) { res= base.Payment() + ((AdditionalCharge * percent) / 100); }
            return res;
        }
    }
}
