
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp_razor.Data;
using webapp_razor.Models;

namespace webapp_razor.Pages.Categories
{
    public class IndexModel: PageModel{
    private readonly ApplicationDbContext _db;

    public IEnumerable<Category> Categories {get; set;}
    public IndexModel(ApplicationDbContext db){
        _db=db;
    }
    public void OnGet(){
        Categories=_db.Category;
        Console.WriteLine();
    }

}
}
