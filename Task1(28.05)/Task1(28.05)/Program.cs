namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region employee
            //    Employee employee = new Employee();
            //    Console.WriteLine("enter full name");
            //    string fullName = Console.ReadLine();
            //    employee.FullName = fullName;
            //getsalary:
            //    Console.WriteLine("enter salary:");
            //    string strSalary = Console.ReadLine();
            //    int slry;
            //    while (!int.TryParse(strSalary, out slry))
            //    {
            //        goto getsalary;
            //    }
            //    if (slry < 300)
            //    {
            //        goto getsalary;
            //    }

            //    employee.Salary = slry;

            //    Console.WriteLine(employee.FullName + employee.Salary);
            #endregion

            #region processWithWhile
            double avrgSalary = 0;

            Engineer[] engiNeer = new Engineer[1];
            for (int i = 0; i < engiNeer.Length; i++)
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
                avrgSalary += slry;
                //Console.WriteLine($"{engineer.FullName} {engineer.Salary}");
                engiNeer[i] = engineer;
                Console.WriteLine("Do you want to add engineer \ny/n");
                string checker = Console.ReadLine();
                if (checker == "n")
                {
                    break;
                }
                Array.Resize(ref engiNeer, engiNeer.Length + 1);
            }
            Console.WriteLine($"Avarage Salary: {avrgSalary / engiNeer.Length}");
            //for (int i = 0; i < engiNeer.Length; i++)
            //{
            //    Console.WriteLine($"FUllNAME:{engiNeer[i].FullName} SALARY:{engiNeer[i].Salary}");
            //}
            

            //Console.WriteLine(engiNeer[0].FullName + engiNeer[0].Salary);
            #endregion

            #region test
            //    Engineer engineer = new Engineer();
            //    Console.WriteLine("enter full name");
            //    string fullName = Console.ReadLine();
            //    engineer.FullName = fullName;
            //    Console.WriteLine("enter salary:");
            //getsalary:
            //    string strSalary = Console.ReadLine();
            //    int slry;
            //    while (!int.TryParse(strSalary, out slry))
            //    {
            //        Console.WriteLine("enter true type salary:");
            //        goto getsalary;
            //    }
            //    if (slry < 1000)
            //    {
            //        Console.WriteLine("Salary cannot be less than 1000");
            //        goto getsalary;
            //    }

            //    engineer.Salary = slry;

            //    //Console.WriteLine($"{engineer.FullName} {engineer.Salary}");
            //    engiNeer[0] = engineer;
            #endregion

            #region encup
            //Employee employee = new Employee();
            //Employee[] emp = new Employee[2];

            //for(int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine("enter full name");
            //    string fullName = Console.ReadLine();
            //    employee.FullName = fullName;
            //getsalary:
            //    Console.WriteLine("enter salary:");

            //    string strSalary = Console.ReadLine();
            //    int slry;
            //    while (!int.TryParse(strSalary, out slry))
            //    {
            //        Console.WriteLine("enter true type salary:");
            //        goto getsalary;
            //    }
            //    employee.saLary = slry;

            //    //Console.WriteLine($"FullName: {employee.FullName} Salary: {employee.saLary}");
            //    if (employee.saLary == 0)
            //    {
            //        goto getsalary;
            //    }
            //    else
            //    {
            //        employee.Salary = employee.saLary;
            //        emp[i].FullName = employee.FullName;
            //        emp[i].Salary = employee.Salary;
            //    }

            //}
            //Console.WriteLine(emp[0].FullName + emp[0].Salary);
            //Console.WriteLine(emp[1].FullName + emp[1].Salary);

            #endregion
            Console.ReadLine();

        }
    }
}