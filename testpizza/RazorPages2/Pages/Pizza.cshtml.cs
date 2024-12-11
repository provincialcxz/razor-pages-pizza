using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages2.Models;
using static RazorPages2.Services.PizzaServices;

namespace RazorPages2.Pages
{
  public class PizzaModel : PageModel
  {
    [BindProperty]
    public MPizza NewPizza { get; set; }
    public List<MPizza> pizzas = new List<MPizza>();
    public void OnGet()
    {
      pizzas = GetAll();
    }
    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }
      Add(NewPizza);
      return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
      Delete(id);
      return RedirectToAction("Get");
    }
  }
}
