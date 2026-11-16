namespace sess08_namespaces_and_exceptions.Payroll
{
    /// <summary>
    /// SalaryDetails class in a NESTED namespace (sess08_namespaces_and_exceptions.Payroll),
    /// so DemoEmployee needs "using sess08_namespaces_and_exceptions.Payroll;" to use it.
    /// </summary>
    public class SalaryDetails
    {
        public double EmployeeSalary { get; set; }

        public override string ToString()
        {
            return $"Salary: {EmployeeSalary:N2}";
        }
    }
}
