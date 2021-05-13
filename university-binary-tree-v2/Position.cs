using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeUniversity
{
    class Position
    {
        private string name;
        private float salary;
        private float taxValue;
        private float percentage;

        public string Name { get => name; set => name = value; }
        public float Salary { get => salary; set => salary = value; }
        public float TaxValue { get => taxValue; set => taxValue = value; }
        public float Percentage { get => percentage; set => percentage = comparar(value); }

        public static float TaxValuCalculate(float salary, float percentage)
        {
            return (salary * percentage) / 100;
        }
        private float comparar(float tax)
        {
            if (tax < 0 || tax > 30) return 0;
            else return tax;
        }
    }


}

