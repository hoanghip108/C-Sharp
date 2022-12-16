using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM
{
    public class UserProgram : MenuProgram
    {       
        public List<Book> listBook = User.listBook;    
        Manager manager1 = new Manager();
        public static bool Logged = false;
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Register");
            System.Console.WriteLine("2. Login");
            System.Console.WriteLine("3. Rent Book");
            System.Console.WriteLine("4. Return book");
            System.Console.WriteLine("5. Display all members");
            System.Console.WriteLine("6. Display all book");
            System.Console.WriteLine("7. Add New Book");
            System.Console.WriteLine("8. Delete Book");
            System.Console.WriteLine("9. Logout");
            System.Console.WriteLine("0. Exit");           
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: GeneralUser.Register();                break;
                case 2: Login();                               break;               
                case 3: RentBooks();                           break;
                case 4: ReturnBooks();                         break;
                case 5: DisplayAllMembers();                   break;
                case 6: DisplayAllBooks();                     break;
                case 7: manager1.AddBook();                    break;
                case 8: manager1.DelBook();                    break;
                case 9: Logout();                              break;
                case 0: Console.WriteLine("Bye!");             break;
                default: Console.WriteLine("Invalid choice!"); break;                
            }           
        }
        public void Logout(){
            if(Logged==true) {
                System.Console.WriteLine("See you latter!!!");
                Logged = false;
            }
        }
        public void DisplayAllBooks()
        {Console.WriteLine("*******************");
            foreach(var item in listBook)
            {   
                Console.Write(item.title);
                Console.Write("||");
                Console.WriteLine(item.author);
                Console.WriteLine("|--------------------------------|");
            }
        }
        public void Login()
        {                          
            Console.WriteLine("Enter username");        
            string? checkusr = Console.ReadLine();
            Console.WriteLine("Enter password");
            string? checkpass = Console.ReadLine();
            
            foreach (var user in User.users)
            {
                if(checkusr == manager1.Username && checkpass == manager1.Password)
                {
                    Console.WriteLine(" successfully logged in");
                    Logged = true;
                }
                else
                {
                    Console.WriteLine("Wrong username or password");
                }
            }
        }     
        public void RentBooks()
        {
            if(Logged==false)
            {
               System.Console.WriteLine("please Loggin first"); 
            }
            else
            {
                System.Console.WriteLine("Enter name of book: ");
                string? name = Console.ReadLine();
                foreach (var book in User.listBook) 
                {
                    if(name==book.title)
                    {
                        string author = book.author;
                        RegisteredUser.rentbooks.Add(new Book(name, author));
                        System.Console.WriteLine("Rent successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Our library does not contains that book!");
                    }
                }
            }
        }
        public void ReturnBooks()
        {
            System.Console.WriteLine("Enter name of book: ");
            string? name = Console.ReadLine();
            RegisteredUser.rentbooks.Remove( RegisteredUser.rentbooks.Single( s => s.title == name ) );
            System.Console.WriteLine("successfully!");
        }
        private void DisplayAllMembers()
        {
            
            if(User.users.Count() == 0){
                System.Console.WriteLine("There is no user in database");
            }
            else
            {
                foreach (User e in User.users)
                {   Console.WriteLine("**********");
                    Console.Write("*Fullname: ");
                    Console.WriteLine(e.Fullname);
                    Console.Write("*Date of birth: ");
                    Console.WriteLine(e.Dob);
                    Console.Write("*Phonenumber: ");
                    Console.WriteLine(e.Phone);
                    Console.Write("*Gender: ");
                    Console.WriteLine(e.Gender);
                    Console.Write("*Username: ");
                    Console.WriteLine(e.Username);
                    Console.WriteLine("**********");
                }
            }
        }
    }
}