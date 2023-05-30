using System;
namespace task1
{
	public class Engineer: Employee
	{
        public double getAvrgSlry(Engineer[] eng, double avgSlry)
        {
            for (int i = 0; i < eng.Length; i++)
            {
                Engineer engineer = new Engineer();
                Console.WriteLine("enter full name");
                string fullName = Console.ReadLine();
                engineer.FullName = fullName;

            getsalary:
                Console.WriteLine("enter salary:");
                string strSalary = Console.ReadLine();
                double slry;
                while (!double.TryParse(strSalary, out slry))
                {
                    Console.WriteLine("enter true type salary:");
                    goto getsalary;
                }
                if (slry < 1000)
                {
                    Console.WriteLine("Salary cannot be less than 1000");
                    goto getsalary;
                }

                engineer.Salary = slry;
                avgSlry += slry;
                //Console.WriteLine($"{engineer.FullName} {engineer.Salary}");
                eng[i] = engineer;
                Console.WriteLine("Do you want to add engineer \ny/n");
                string checker = Console.ReadLine();
                if (checker == "n")
                {
                    break;
                }
                Array.Resize(ref eng, eng.Length + 1);
            }
            avgSlry = avgSlry / eng.Length;
            return avgSlry;
        }
    }
}

