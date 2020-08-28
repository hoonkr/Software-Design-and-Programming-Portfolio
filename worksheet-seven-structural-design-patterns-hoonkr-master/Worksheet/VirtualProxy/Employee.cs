namespace VirtualProxy
{
    public sealed class Employee
    {
        public string EmployeeName { get; }
        public decimal EmployeeSalary { get; }
        public string EmployeeDesignation { get; }

        public Employee(string employeeName, decimal employeeSalary, string employeeDesignation)
        {
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
            EmployeeDesignation = employeeDesignation;
        }

        public override string ToString()
        {
            return "Employee Name: " + EmployeeName + ", EmployeeDesignation: " + EmployeeDesignation
                   + ", Employee Salary: " + EmployeeSalary;
        }
    }
}