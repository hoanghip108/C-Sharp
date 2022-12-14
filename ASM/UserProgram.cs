using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM
{
    public class UserProgram : MenuProgram
    {
        private List<User> users;
        public List<Book> rentbooks = new List<Book>();
        public UserProgram()
        {
            users = new List<User>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Register");
            System.Console.WriteLine("2. Login");
            System.Console.WriteLine("3. Add Saler");
            System.Console.WriteLine("4. Display All Employees");
            System.Console.WriteLine("0. Exit");
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: Register();                            break;
                case 2: Login();                               break;               
                case 3: RentBooks();                           break;
                case 4: ReturnBooks();                         break;
                case 5: DisplayAllMebers();                    break;
                case 0: Console.WriteLine("Bye!");             break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
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
                    rentbooks.Add(new Book(name, author));
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
            System.Console.WriteLine("successfully!");
        }
        private void DisplayAllMebers()
        {
            foreach (User e in users)
            {
                Console.WriteLine(e.Fullname);
            }
        }
    }
}