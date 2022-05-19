namespace PRN_SE1629;

public class Employee:Person
{
    /*filed/data*/
    private int _id;

    /*properties*/
    public double Salary { get; set; } //.NET 5
    public int Id { get => _id; set => _id = value; }
  
    public string NameOfCompany { get; } = "FPT Education";
    public Employee(int id, string name, double salary, DateOnly dob, Address address):base(name, dob, address)
    {
        Id = id;
        Name = name;
        Salary = salary;
        
    }
    public Employee()
    {

    }

  
    public override string ToString()
    {
        return $"Id = {this._id}, Name = {Name}, Salary = {Salary}";

    }
}
