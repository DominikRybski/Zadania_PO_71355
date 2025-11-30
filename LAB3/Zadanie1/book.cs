namespace Zadanie1;

    internal class Book
{
    private string title;
    Person author;
    private DateTime publicationYear;

    

    public void View()
    {
        Console.WriteLine($"Title: {title}, Author: {author}, Publication Year: {publicationYear.Year}");
    }
    public Book(string title, Person author, DateTime publicationYear)
        {
        this.author = author;
        this.title = title;
        this.publicationYear = publicationYear;
        }

}