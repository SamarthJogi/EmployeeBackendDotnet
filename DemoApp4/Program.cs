using DemoApp4.Data;
using Microsoft.EntityFrameworkCore;

using var shop = new CompanyDbContext();

if (args.Length == 0)
{
    Console.WriteLine("DeptNo\tLocation");
    foreach (var entry in shop.Depts)
        Console.WriteLine($"{entry.DeptNo}\t{entry.Loc}");
}
else
{
    if (int.TryParse(args[0], out int deptId))
    {
        var dept = shop.Depts
            .Include(d => d.Employees)
            .FirstOrDefault(d => d.DeptNo == deptId);

        if (dept != null)
        {
            Console.WriteLine($"Department: {dept.DName} ({dept.DeptNo})");
            Console.WriteLine("EmpNo\tEName\tSalary");

            foreach (var emp in dept.Employees)
                Console.WriteLine($"{emp.EmpNo}\t{emp.EName}\t{emp.Sal}");
        }
        else
        {
            Console.WriteLine("Department not found!");
        }
    }
    else
    {
        Console.WriteLine(" Please pass a valid department number.");
    }
}
