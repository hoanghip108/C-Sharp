using System;
namespace ASM
{
    public  abstract class User
    {
        abstract  public  int Role { get; set;}
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
                listBook.AddRange
            (
                new List<Book>
                            {
                                new Book("Book 1", "John Doe" ),
                                new Book("Book 2", "John Doe" ),
                                new Book("Book 3", "nguyễn Đạt" ),
                                new Book("Book 4", "Đỗ Huy" ),
                                new Book("Book 5", "Đỗ Huy" ),
                            }
            );
                
        }
  
        public User(string Fullname,string Dob,string Phone,string Gender,string Username,string Password)
        {
                this.Fullname = Fullname;
                this.Dob = Dob;
                this.Phone = Phone;
                this.Gender = Gender;
                this.Username = Username;
                this.Password = Password;
                listBook.AddRange
            (
                new List<Book>
                            {
                                new Book("Sách 1", "John Doe" ),
                                new Book("Sách 2", "John Doe" ),
                                new Book("Sách 3", "nguyễn Đạt" ),
                                new Book("Sách 4", "Đỗ Huy" ),
                                new Book("Sách 5", "Đỗ Huy" ),
                            }
            );

        }

        
    }
}