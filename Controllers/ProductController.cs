using CRUD_Task.Data;
using CRUD_Task.Models;
using CRUD_Task.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CRUD_Task.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    Name = viewModel.Name,
                    Price = viewModel.Price,
                    Quantity = viewModel.Quantity
                };
                await dbContext.Products.AddAsync(product);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("List");


            }

            else
            {
                return View();
            }

            
        }



        [HttpGet]
        public async Task<IActionResult> List()
        {
            var products = await dbContext.Products.ToListAsync();
            return View(products);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Product viewModel)
        {
            var product = await dbContext.Products.AsNoTracking().FirstOrDefaultAsync(
                x => x.Id == viewModel.Id);

            if(product is not null)
            {
                dbContext.Products.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List","Product");
        }

        






    }
}
