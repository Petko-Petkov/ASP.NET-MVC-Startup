namespace Project.Models
{
    using System.ComponentModel.DataAnnotations;
    using Contracts.Models;

    public class Post : BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
