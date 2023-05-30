using System;
namespace task1
{
    public class Employee
    {
        public string FullName;
        public double Salary;


        #region slaryEncup
        private double _salary;

        public double saLary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 300)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("salary 300den asagi ola bilmez");
                }
            }
        }
        #endregion
    }
}
