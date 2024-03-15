using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TKWebAPI.Data;
using TKWebAPI.Models;

namespace TKWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private AppDbContext _appDbContext;

        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /*public static List<CategoryModel> listOfCategories = new List<CategoryModel>
        {
            new CategoryModel
            {
                CatID = 1,
                CatName = "Electronics"
            },
            new CategoryModel
            {
                CatID = 2,
                CatName = "Pharma"
            },
            new CategoryModel
            {
                CatID = 3,
                CatName = "Daily Products"
            }

        };*/

        [HttpGet]
        public IEnumerable<CategoryModel> GetCategories()
        {
            return _appDbContext.Categories;
        }

        [HttpGet("{id}")]
        public CategoryModel GetCategory(int id)
        {
            return _appDbContext.Categories.FirstOrDefault(x => x.CatID == id);
        }

        [HttpPost]
        public void PostCategories([FromBody] CategoryModel category) {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void UpdateCategory(int id, [FromBody] CategoryModel category)
        {
            var catfromDb = _appDbContext.Categories.Find(id);
            if (catfromDb != null)
            {
                _appDbContext.Categories.Update(catfromDb);
                _appDbContext.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            var catfromDb = _appDbContext.Categories.Find(id);
            if (catfromDb != null)
            {
                _appDbContext.Categories.Remove(catfromDb);
                _appDbContext.SaveChanges();
            }
        }
    }
}
