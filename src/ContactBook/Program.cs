namespace ContactBook;

public class Program
{
    public static void Main()
    {
        var c1 = new Contact("Yedriel", "Laureano", "939-409-5525", "y.laureano2006@gmail.com");
        var c2 = new Contact("Yedriela", "Laureane", "939-409-5526", "y.laureano206@gmail.com");
        var cb = new ContactBook(new List<Contact>{ c1, c2 });
        cb.Start();
    }
}