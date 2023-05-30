using System;
namespace task2
{
	public class User
	{
		public string UserName;
		public string Password;

		public User(string username)
		{
			UserName = username;
			//Password = Console.ReadLine();

		}

		private string _passWord;


        public string passWord

		{
			get
			{
				return _passWord;
			}
			set
			{
				if(value.Length >= 8 && value.Any(char.IsUpper) && value.Any(char.IsLower) && value.Any(char.IsNumber))
				{
                    _passWord = value;
				}
				else
				{
					Console.WriteLine("The password must have a minimum of 8 characters and contain 1 uppercase and 1 lowercase letters and 1 number");
				}
			}
		}
	}
}

