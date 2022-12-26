using System;
namespace ASM
{
    public class GeneralUser:User
    {
        public static string role { get; set; }
        public static RegisteredUser Register()
        {
            role = "Registered";
            Console.WriteLine("Enter your name: ");
            string Fullname = Console.ReadLine();
            if (string.IsNullOrEmpty(Fullname)) 
           Console.WriteLine("Your entry was blank");
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
            return new RegisteredUser(Fullname, Dob, Phone, Gender, Username, Password,role);
        }
    }
}