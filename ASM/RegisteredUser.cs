using System;
namespace ASM
{
    public class RegisteredUser:User
    {
        public override int Role
    {
        get { return 2; }
        set { value = 2; }
    }
        //public List<RegisteredUser> users = GeneralUser.users;
        public static List<Book> rentbooks = new List<Book>();
        public RegisteredUser(string Fullname,string Dob,string Phone,string Gender,string Username,string Password)
        {       
                this.Fullname = Fullname;
                this.Dob = Dob;
                this.Phone = Phone;
                this.Gender = Gender;
                this.Username = Username;
                this.Password = Password;
               
        }
    }
}
