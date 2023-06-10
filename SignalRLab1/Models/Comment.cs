using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRLab1.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
