using System;
namespace ASM
{
    public  abstract class User
    {
        public int ID{get;set;}
        public string Fullname  { get; set; }
        public string Dob { get; set; }   
        public string Phone { get; set; }
        public string Gender { get; set;}
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        
        public static List<Book> listBook = new List<Book>();      
        public User(){}
  
        public User(string Fullname,string Dob,string Phone,string Gender,string Username,string Password,string role) 
        {             
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