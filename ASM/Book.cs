using System;
public class Book 
{
    public int ID { get; set; }
    public string title { get; set; }
    public string author { get; set; }
  
    public Book()
    {
        
        title = "Sach 1";
        author = "Unknow";
        
    }
        public Book(string Title, string Author)
        {
            
            title = Title;
            author = Author;
        }
}

