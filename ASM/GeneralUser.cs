using System;
namespace ASM
{
    public class GeneralUser:User
    {
        public GeneralUser(){}

        public static void Register()
        {
            Console.WriteLine("Enter your name: ");
            string? Fullname = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth: ");
            string? Dob = Console.ReadLine();
            Console.WriteLine("Enter your phonenumber: ");
            string? Phone = Console.ReadLine();
            Console.WriteLine("Enter your Gender: ");
            string? Gender = Console.ReadLine();
            Console.WriteLine("Enter your Username: ");
            string? Username = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string? Password = Console.ReadLine();
            users.Add(new RegisteredUser(Fullname, Dob, Phone, Gender, Username, Password));
        }
    }
}