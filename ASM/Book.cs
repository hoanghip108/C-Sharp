using System;
public class Book 
{
    public int ID { get; set; }
    public string title { get; set; }
    public string author { get; set; }
    private static int id = 1;
    static int generateId()
    {
        return id++;
    }
        public Book(string Title, string Author)
        {   ID =generateId();
            title = Title;
            author = Author;
        }
}

