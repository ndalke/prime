interface Taxable
{
   
    void calcTax();
}

public class Employee:Taxable
{
    float incomeTax = 0.105f;
    float salesTax = 0.07f;
    int empId;
    string name;
    double salary;
    Employee()
    {

    }
   public Employee(int empId,string name,double salary)
    {
        this.empId = empId;
        this.name = name;
        this.salary = salary;
    }
    public void calcTax()
    {
        double tax = salary * incomeTax;
        Console.WriteLine(tax);
    }
}
class Product:Taxable
{
    float salesTax = 0.07f;
    int pid;
    int price;
    int quality;
    Product(int pid,int price,int quality)
    {
        this.pid = pid;
        this.price = price;
        this.quality = quality;
    }
    public void calcTax()
    {
        double tax = price * salesTax;
        Console.WriteLine(tax);
    }
}
class XYZ
{
    public static void Main()
    {
        Console.WriteLine("Enter EmployeId,Name and salary:");
        int empId = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        int pid = int.Parse(Console.ReadLine());
        int price = int.Parse(Console.ReadLine());
        Employee emp = new Employee(empId, name, salary);
        emp.calcTax();
    }
}