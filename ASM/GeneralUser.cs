using System;
namespace ASM
{
    public class GeneralUser:User
    {
        //public  static List<RegisteredUser> users = new List<RegisteredUser>();
        public GeneralUser(){}
        public void Register()
        {
            Console.WriteLine("Enter your name: ");
            string Fullname = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth: ");
            string Dob = Console.ReadLine();
            Console.WriteLine("Enter your phonenumber: ");
            string Phone = Console.ReadLine();
            Console.WriteLine("Enter your Gender: ");
            string Gender = Console.ReadLine();
            Console.WriteLine("Enter your Username: ");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string Password = Console.ReadLine();
            users.Add(new RegisteredUser(Fullname, Dob, Phone, Gender, Username, Password));
        }
        public void print()
        {
            string check = "hoanghip108";
            
            foreach (var user in users)
            {
                if(check == user.Username)
                {
                    Console.WriteLine("Found");
                }
            }
        }
    }
}