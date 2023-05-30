namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            getUserName:
            Console.WriteLine("enter username:");
            string name = Console.ReadLine();
            if(name.Length < 8)
            {
                Console.WriteLine("username can't be less than 8 character");
                goto getUserName;
            }
            User user = new User(name);
            getPass:
            Console.WriteLine("enter password:");
            string password = Console.ReadLine();
            
            user.passWord = password;
            if(user.passWord == null)
            {
                goto getPass;
            }

            Console.WriteLine($"Username: {user.UserName} Password: {user.passWord}");

            Console.ReadLine();
        }
    }
}