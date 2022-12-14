using System;
namespace ASM
{
    public class RegisteredUser:User
    {
        public RegisteredUser(){
            this.Fullname = "hoang";
                this.Dob = "hoang";
                this.Phone = "hoang";
                this.Gender = "hoang";
                this.Username = "hoanghip108";
                this.Password = "123123";
        }
        //public List<RegisteredUser> users = GeneralUser.users;
        //public List<Book> rentbooks = new List<Book>();
        public RegisteredUser(string Fullname,string Dob,string Phone,string Gender,string Username,string Password)
        {
                this.Fullname = Fullname;
                this.Dob = Dob;
                this.Phone = Phone;
                this.Gender = Gender;
                this.Username = Username;
                this.Password = Password;
        }
        public void Login()
        {                        
            string check = "hoanghip108";          
            foreach (var user in users)
            {
                if(check == user.Username)
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
        }
        public void RentBooks()
        {
            System.Console.WriteLine("Enter name of book: ");
            string name = Console.ReadLine();
            foreach (var book in User.listBook) 
            {
                if(name==book.title)
                {
                    string author = book.author;
                    //rentbooks.Add(new Book(name, author));
                    System.Console.WriteLine("Rent successfully!");
                }
                else
                {
                    Console.WriteLine("Our library does not contains that book!");
                }
            }
        }
        public void ReturnBooks()
        {
            System.Console.WriteLine("Enter name of book: ");
            string name = Console.ReadLine();
                rentbooks.Remove( rentbooks.Single( s => s.title == name ) );
                System.Console.WriteLine("Rent successfully!");
        }
    }
}
