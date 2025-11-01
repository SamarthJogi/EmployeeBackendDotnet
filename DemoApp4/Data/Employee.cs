using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp4.Data
{
    [Table("Employee")]  // ✅ Exact MySQL table name
    public class Employee
    {
        [Key]
        [Column("empno")]
        public int EmpNo { get; set; }

        [Column("ename")]
        public string? EName { get; set; }

        [Column("sal")]
        public decimal? Sal { get; set; }

        [Column("comm")]
        public decimal? Comm { get; set; }

        [Column("deptno")]
        public int? DeptNo { get; set; }

        [ForeignKey("DeptNo")] 
        public Dept? Dept { get; set; }
    }
}
