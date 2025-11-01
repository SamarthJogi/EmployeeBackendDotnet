using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp4.Data
{
    [Table("Dept")] 
    public class Dept
    {
        [Key]
        [Column("deptno")]  
        public int DeptNo { get; set; }

        [Column("dname")]
        public string? DName { get; set; }

        [Column("loc")]
        public string? Loc { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
