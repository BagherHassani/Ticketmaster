using System.Text.Json.Serialization;

namespace Web.Models;



public class SingleData
{
    [JsonPropertyName("data")]
    public Employee Employee { get; set; }
}



public class Data
{
    [JsonPropertyName("data")]
    public IEnumerable<Employee> Employees { get; set; }
}


public class Employee
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("employee_name")]
    public string EmployeeName { get; set; }
}



public class Createemployee
{
    public string Name { get; set; }
    public string Salary { get; set; }
    public string Age { get; set; }
}