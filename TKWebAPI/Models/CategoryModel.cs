using System.ComponentModel.DataAnnotations;

namespace TKWebAPI.Models
{
    public class CategoryModel
    {
        [Key]
        public int CatID { get; set; }
        
        [Required]
        public string CatName { get; set; }


    }
}
