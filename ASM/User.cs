using System;
namespace ASM
{
    public  abstract class User
    {
        public string Fullname  { get; set; }
        public string Dob { get; set; }   
        public string Phone { get; set; }
        public string Gender { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public static List<Book> listBook = new List<Book>();
        public static List<RegisteredUser> users = new List<RegisteredUser>();
        public User()
        {
                this.Fullname = "";
                this.Dob = "";
                this.Phone = "";
                this.Gender = "";
                this.Username = "";
                this.Password = "";
        }
        
        public User(string Fullname,string Dob,string Phone,string Gender,string Username,string Password)
        {
                this.Fullname = Fullname;
                this.Dob = Dob;
                this.Phone = Phone;
                this.Gender = Gender;
                this.Username = Username;
                this.Password = Password;

        }
        public void viewBook()
        { 
            listBook.Add(new Book());
            listBook.Add(new Book{title="sach 2",author="John"});
            listBook.ForEach(i => Console.Write("{0}\t", i.title));
        }
        public string Search()
        {
            return "1";
        }
        
    }
}