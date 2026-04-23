using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TableViewer.DbLayer
{
    [Table("Products")]
    public class DbProduct
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public int Price { get; set; }
        
        public int ViewCount { get; set; }
        
        public int PurchaseCount { get; set; }
    }
}