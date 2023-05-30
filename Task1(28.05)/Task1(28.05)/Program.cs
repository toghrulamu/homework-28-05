namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region employee
            //Employee employee = new Employee();
            //employee.FullName = "Arthur Morgan";
            //employee.saLary = 400;

            //Console.WriteLine(employee.FullName + " " + employee.saLary);
            #endregion
            double avrgSalary = 0;

            Engineer[] engiNeer = new Engineer[1];
            Engineer eng = new Engineer();
            avrgSalary = eng.getAvrgSlry(engiNeer, avrgSalary);
            Console.WriteLine($"Avarage Salary: {avrgSalary}");

            Console.ReadLine();

        }
    }
}