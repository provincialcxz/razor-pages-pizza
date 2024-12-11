using RazorPages2.Models;

namespace RazorPages2.Services
{
  public static class PizzaServices
  {
    static List<MPizza> Pizzas { get; }
    static int id = 3;
    static PizzaServices()
    {
      Pizzas = new List<MPizza>
      {
        new MPizza{Id = 1, Name = "Peperoni", Price=20.0M, Size = PizzaSize.Medium, IsGlutenFree = false},
        new MPizza{Id = 2, Name = "Wegeterian", Price=15.0M, Size = PizzaSize.Medium, IsGlutenFree = false}
      };
    }

    public static List<MPizza> GetAll() => Pizzas;
    public static MPizza? Get(int id) => Pizzas.FirstOrDefault(x => x.Id == id);
    public static void Add(MPizza p)
    {
      p.Id = id++;
      Pizzas.Add(p);
    }
    public static void Delete(int id)
    {
      var p = Get(id);
      if (p != null)
        Pizzas.Remove(p);
      else return;
    }
    public static void Update(MPizza p)
    {
      var index = Pizzas.FindIndex(x => x.Id == p.Id);
      if (index == -1) return;
      Pizzas[index] = p;
    }
  }
}
