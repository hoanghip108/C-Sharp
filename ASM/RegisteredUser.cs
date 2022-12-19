using System;
namespace ASM
{
    public class RegisteredUser:User
    {
        public static List<Book> rentbooks = new List<Book>();
        public static int id = 1;
        static int generateId()
        {
            return id++;
        }
        public RegisteredUser(string Fullname,string Dob,string Phone,string Gender,string Username,string Password,string role) 
        {       ID = generateId();
                this.Fullname = Fullname;
                this.Dob = Dob;
                this.Phone = Phone;
                this.Gender = Gender;
                this.Username = Username;
                this.Password = Password; 
                Role = role;            
        }
    }
}
