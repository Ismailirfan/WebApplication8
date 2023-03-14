using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication8.Models
{
    public class Salary
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string ename { get; set; }
        [StringLength(50)]
        public string fname { get; set; }
        public int age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOJ { get; set; }
    }
}
