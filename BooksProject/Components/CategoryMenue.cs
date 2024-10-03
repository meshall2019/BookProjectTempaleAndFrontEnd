
using Microsoft.AspNetCore.Mvc;


namespace BookStoreProject.Components
{
    public class CategoryMenue:ViewComponent
    {
        

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
           
        }






    }
}
