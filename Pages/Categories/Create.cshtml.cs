using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp_razor.Models;

namespace webapp_razor.Pages.Categories{

    public class CreateModel:PageModel{
        public Category Category {get;set;}

        public void OnGet(){

        }
    }
}