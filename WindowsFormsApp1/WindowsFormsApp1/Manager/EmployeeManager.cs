using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class EmployeeManager
    {
        public static Employee Employee
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
                foreach(var Iter in EmployeeRoleCollection)
                {
                    if(Iter.RoleID == value.EmpRoleID)
                    {
                        RoleName = Iter.RoleName;
                        break;
                    }
                }
            }
        }

        public static string RoleName { private set;  get; }

        public static List<int> GetTeamMembersID()
        {
            List<int> ResultEmployees = new List<int>();
            int superiorID = Employee.EmployeeID;

            ResultEmployees.Add(superiorID);
            foreach (var Iter in EmployeeCollection)
            {
                if(Iter.EmpSuperiorID == superiorID)
                {
                    ResultEmployees.Add(Iter.EmployeeID);
                }
            }

            return ResultEmployees;
        }

        public static List<Employee> GetTeamMembers()
        {
            List<Employee> ResultEmployees = new List<Employee>();
            int superiorID = Employee.EmployeeID;

            foreach (var Iter in EmployeeCollection)
            {
                if (Iter.EmpSuperiorID == superiorID)
                {
                    ResultEmployees.Add(Iter);
                }
            }

            return ResultEmployees;
        }

        public static int GetSuperiorID(int memberID)
        {
            foreach(var Iter in EmployeeCollection)
            {
                if(Iter.EmployeeID == memberID)
                {
                    return Iter.EmpSuperiorID;
                }
            }

            return -1;
        }

        public static void SetEmployee(string email)
        {
            foreach(var Iter in EmployeeCollection)
            {
                if(Iter.EmpEmail == email)
                {
                    Employee = Iter;
                    break;
                }
            }
        }

        public static void AssignEmployeeRole()
        {
            EmployeeRoleCollection = new List<EmployeeRole>();
            EmployeeRoleCollection.Add(new EmployeeRole()
            {
                RoleID = 101,
                RoleName = "Director"
            });

            EmployeeRoleCollection.Add(new EmployeeRole()
            {
                RoleID = 102,
                RoleName = "Senior Manager"
            });
            EmployeeRoleCollection.Add(new EmployeeRole()
            {
                RoleID = 103,
                RoleName = "Team Leader"
            });

            EmployeeRoleCollection.Add(new EmployeeRole()
            {
                RoleID = 104,
                RoleName = "Senior Developer"
            });

            EmployeeRoleCollection.Add(new EmployeeRole()
            {
                RoleID = 105,
                RoleName = "Junior Developer"
            });
        }

        public static void AssignEmployee()
        {
            EmployeeCollection = new List<Employee>();
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 1,
                EmployeeName = "Pugazh",
                EmpRoleID = 104,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpSuperiorID = 17,
                EmpEmail = "pugazhenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 2,
                EmployeeName = "Ilam",
                EmpRoleID = 104,
                EmpSuperiorID = 18,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "ilamugunthan@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 3,
                EmployeeName = "Anbarasu",
                EmpRoleID = 104,
                EmpSuperiorID = 17,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "anbarasu@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 4,
                EmployeeName = "AAA",
                EmpRoleID = 104,
                EmpSuperiorID = 16,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthwiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 5,
                EmployeeName = "BBB",
                EmpRoleID = 104,
                EmpSuperiorID = 18,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenqthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 6,
                EmployeeName = "CCC",
                EmpRoleID = 104,
                EmpSuperiorID = 18,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhentthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 7,
                EmployeeName = "DDD",
                EmpRoleID = 104,
                EmpSuperiorID = 17,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhentjhiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 8,
                EmployeeName = "EEE",
                EmpRoleID = 104,
                EmpSuperiorID = 16,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazahenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 9,
                EmployeeName = "FFF",
                EmpRoleID = 104,
                EmpSuperiorID = 16,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthhiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 10,
                EmployeeName = "GGG",
                EmpRoleID = 105,
                EmpSuperiorID = 18,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthiair2a002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 11,
                EmployeeName = "HHH",
                EmpRoleID = 105,
                EmpSuperiorID = 17,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhfenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 12,
                EmployeeName = "III",
                EmpRoleID = 105,
                EmpSuperiorID = 17,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 13,
                EmployeeName = "JJJ",
                EmpRoleID = 105,
                EmpSuperiorID = 16,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 14,
                EmployeeName = "KKK",
                EmpRoleID = 105,
                EmpSuperiorID = 18,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 15,
                EmployeeName = "LLL",
                EmpRoleID = 105,
                EmpSuperiorID = 16,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "pugazhenthiir2002@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 16,
                EmployeeName = "MMM",
                EmpRoleID = 103,
                EmpSuperiorID = 19,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "aaa@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 17,
                EmployeeName = "NNN",
                EmpRoleID = 103,
                EmpSuperiorID = 19,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "bbb@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 18,
                EmployeeName = "OOO",
                EmpRoleID = 103,
                EmpSuperiorID = 19,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "ooo@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 19,
                EmployeeName = "PPP",
                EmpRoleID = 102,
                EmpSuperiorID = 20,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "abcd@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
            EmployeeCollection.Add(new Employee()
            {
                EmployeeID = 20,
                EmployeeName = "QQQ",
                EmpRoleID = 101,
                EmpDOB = new DateTime(2002, 10, 11),
                EmpEmail = "qqq@gmail.com",
                EmpPassword = "1234",
                EmpProfile = ""
            });
        }

        private static Employee employee;
        public static List<EmployeeRole> EmployeeRoleCollection;
        public static List<Employee> EmployeeCollection;
    }
}
