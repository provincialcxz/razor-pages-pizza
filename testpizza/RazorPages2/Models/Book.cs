namespace RazorPages2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public BookGenre Genre { get; set; }
        public decimal Price { get; set; }
    }

    public enum BookGenre
    {
        Fiction,
        NonFiction,
        Science,
        Fantasy,
        Mystery,
        Biography,
        Romantic, 
        Horor,
        Detective
    }
}
