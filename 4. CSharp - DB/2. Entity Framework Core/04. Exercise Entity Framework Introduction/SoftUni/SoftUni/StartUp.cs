using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new SoftUniContext();

            // 03.
            //Console.WriteLine(GetEmployeesFullInformation(context));

            // 04.
            //Console.WriteLine(GetEmployeesWithSalaryOver50000(context));

            // 05.
            //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context));

            // 06.
            //Console.WriteLine(AddNewAddressToEmployee(context));

            // 07.
            //Console.WriteLine(GetEmployeesInPeriod(context));

            // 08.
            //Console.WriteLine(GetAddressesByTown(context));

            // 09.
            //Console.WriteLine(GetEmployee147(context));

            // 10.
            //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));

            // 11.
            //Console.WriteLine(GetLatestProjects(context));

            // 12.
            //Console.WriteLine(IncreaseSalaries(context));

            // 13.
            //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));

            // 14.
            //Console.WriteLine(DeleteProjectById(context));

            // 15.
            Console.WriteLine(RemoveTown(context));



        }

        // 03.
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            //return string.Join("\n", context.Employees
            //    .Select(e => $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}")
            //    .ToList());

            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // 04.
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ToList();

            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // 05.
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary,
                    e.Department
                })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToList();

            var sb = new StringBuilder();
            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // 06.
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address address = new() 
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            var nakov = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            if (nakov != null)
            {
                nakov.Address = address;
                context.SaveChanges();

            }

            //var employees = context.Employees
            //    .Select(e => new { e.Address, e.AddressId })
            //    .OrderByDescending(e => e.AddressId)
            //    .Take(10)
            //    .ToList();

            //var sb = new StringBuilder();
            //foreach (var e in employees)
            //{
            //    sb.AppendLine(e.Address.AddressText);
            //}

            //return sb.ToString().TrimEnd();

            var employeesAddresses = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToList();

            return string.Join("\n", employeesAddresses);
        }

        // 07.
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var topEmployees = context.Employees
                .Take(10)
                .Select(e => new
                {
                    EmployeeNames = $"{e.FirstName} {e.LastName}",
                    ManagerNames = $"{e.Manager.FirstName} {e.Manager.LastName}",
                    Projects = e.EmployeesProjects
                        .Where(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003)
                        .Select(ep => new
                        {
                            ProjectName = ep.Project.Name,
                            ep.Project.StartDate,
                            EndDate = ep.Project.EndDate.HasValue ? 
                                ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : 
                                "not finished"
                        })
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var e in topEmployees)
            {
                sb.AppendLine($"{e.EmployeeNames} - Manager: {e.ManagerNames}");
                if (e.Projects.Any())
                {
                    foreach (var p in e.Projects)
                    {
                        sb.AppendLine($"--{p.ProjectName} - {p.StartDate:M/d/yyyy h:mm:ss tt} - {p.EndDate}");
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }

        // 08.
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .Select(a => new
                {
                    a.AddressText,
                    TownName = a.Town.Name,
                    EmployeeCount = a.Employees.Count
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var a in addresses)
            {
                sb.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
            }

            return sb .ToString().TrimEnd();
        }

        // 09.
        public static string GetEmployee147(SoftUniContext context)
        {
            var employee147 = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    EmployeeInfo = $"{e.FirstName} {e.LastName} - {e.JobTitle}",
                    EmployeeProjects = e.EmployeesProjects
                        .OrderBy(ep => ep.Project.Name)
                        .Select(ep => new { ep.Project.Name })
                        .ToList()
                })
                .ToList();

            var sb = new StringBuilder();
            sb.AppendLine($"{employee147.First().EmployeeInfo}");

            foreach (var project in employee147.First().EmployeeProjects)
            {
                sb.AppendLine($"{project.Name}");
            }

            return sb.ToString().TrimEnd();
        }

        // 10.
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    ManagerName = $"{d.Manager.FirstName} {d.Manager.LastName}",
                    Employees = d.Employees
                        .OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName)
                        .Select(e => new 
                        {
                            EmployeeName = $"{e.FirstName} {e.LastName}",
                            e.JobTitle
                        }).ToList()
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var d in departments)
            {
                sb.AppendLine($"{d.DepartmentName} - {d.ManagerName}");
                foreach (var e in d.Employees)
                {
                    sb.AppendLine($"{e.EmployeeName} - {e.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        // 11.
        public static string GetLatestProjects(SoftUniContext context)
        {
            var lastProjects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)                
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt")
                })
                .ToList();

            var sb = new StringBuilder();

            foreach (var p in lastProjects)
            {
                sb.AppendLine(p.Name);
                sb.AppendLine(p.Description);
                sb.AppendLine(p.StartDate);
            }

            return sb.ToString().TrimEnd();
        }

        // 12.
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var specificEmployees = context.Employees
                .Where(e => (new string[] {"Engineering", "Tool Design", "Marketing", "Information Services"})
                    .Contains(e.Department.Name))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            var sb = new StringBuilder();

            foreach (var e in specificEmployees)
            {
                e.Salary *= 1.12m;
                sb.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        // 13.
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employeesSa = context.Employees
                .Where(e => e.FirstName.ToLower().StartsWith("sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new 
                {
                    Name = $"{e.FirstName} {e.LastName}",
                    e.JobTitle,
                    e.Salary
                })
                .ToList();

            var sb = new StringBuilder();
            foreach (var e in employeesSa)
            {
                sb.AppendLine($"{e.Name} - {e.JobTitle} - (${e.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }

        // 14.
        public static string DeleteProjectById(SoftUniContext context)
        {
            var project = context.Projects.Find(2);
            var idsEmployeesProjects = context.EmployeesProjects
                .Where(ep => ep.ProjectId == 2)
                .ToList();

            if (idsEmployeesProjects.Any())
            {
                context.EmployeesProjects.RemoveRange(idsEmployeesProjects);
                context.SaveChanges();
            }

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();

            return string.Join(Environment.NewLine, projects);

        }

        // 15.
        public static string RemoveTown(SoftUniContext context)
        {
            string removeTownName = "Seattle";
            Town townSeattle = context.Towns.FirstOrDefault(t => t.Name == removeTownName);
            int addressesRemoved = 0;

            var employeesSeattle = context.Employees
                .Where(e => e.Address.Town == townSeattle) 
                .ToList();

            foreach (var employee in employeesSeattle)
            {
                employee.AddressId = null;
            }
            context.SaveChanges();

            var addressesSeattle = context.Addresses
                .Where(a => a.Town.Name == removeTownName)
                .ToList();

            if (addressesSeattle.Any())
            {
                addressesRemoved = addressesSeattle.Count;
                context.Addresses.RemoveRange(addressesSeattle);
                context.Towns.RemoveRange(townSeattle);
                context.SaveChanges();
            }

            return $"{addressesRemoved} addresses in Seattle were deleted";
        }
    }
}
