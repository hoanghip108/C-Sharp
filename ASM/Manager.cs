using System;
namespace ASM
{
    
    public class Manager:User
    {
        public string role { get; set; }
        
        public Manager():base()
        {       role="admin";
                this.Fullname = "Manager 1";
                this.Dob = "10/08/2000";
                this.Phone = "0333804202";
                this.Gender = "Nam";
                this.Username = "Quan";
                this.Password = "123123";
        }
        public bool Login()
        {                          
            Console.WriteLine("Please re-enter your username");        
            string? checkusr = Console.ReadLine();
            Console.WriteLine("Please re-enter your password");
            string? checkpass = Console.ReadLine();  
                if(checkusr == Username && checkpass == Password)
                {
                    Console.WriteLine("successfully logged in");
                    UserProgram.Logged=true;
                    return true;
                }
                else
                {
                    
                    return false;
                }
            
        }
        public void AddBook()
        {
            if(Login()==false)
            {
                System.Console.WriteLine("You don't have permission'");
            }
            else
            {
                Console.WriteLine("Enter title: " );
                string? title = Console.ReadLine();
                Console.WriteLine("Enter Author: " );
                string? author = Console.ReadLine();
                listBook.Add(new Book(title,author));          
            }
        }
        public void DelBook()
        {
            if(Login()==false)
            {
                System.Console.WriteLine("You don't have permission'");
            }
            else
            {
                Console.WriteLine("Enter title: " );
                string? title = Console.ReadLine();
                Console.WriteLine("Enter Author: " );
                string? author = Console.ReadLine();
                listBook.Remove( User.listBook.Single( s => s.title == title ) );  
            }
        }       
    }
}