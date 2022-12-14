using System;
namespace ASM
{
    public class Manger:User
    {
        public int ID { get; set; }
        
        public Manger()
        {
                ID = 1;
                this.Fullname = "Manager 1";
                this.Dob = "10/08/2000";
                this.Phone = "0333804202";
                this.Gender = "Nam";
                this.Username = "hoanghip108";
                this.Password = "123123";
        }
        public void AddBook(string title,string author){
            
            listBook.Add(new Book(title,author));
            foreach (var book in listBook)
            {
                Console.WriteLine(book.title);
            }
        }
        public void AddCategory(){}
    }
}