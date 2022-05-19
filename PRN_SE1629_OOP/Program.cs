using System.Collections;
using static System.Console;
namespace PRN_SE1629;

public class Program
{
    public static void Main()
    {
        /*1. Create a new project*/
        /*Employee e = new Employee();
        e.Id = 1;
        e.Name = "HA";
        e.Salary = 150.55d;*/

        /*Employee e = new Employee(1, "Ha", 15.44d);
        e.Name = "Arubedo";
        WriteLine(e);*/

        /*2. create a list employees and display them*/
        /*ArrayList listEmp = new ArrayList();
        listEmp.Add(new Employee(1, "Arubedo", 222));
        listEmp.Add(new Employee(2, "b", 2));
        listEmp.Add(new Employee(3,"c", 3));
        listEmp.Add(new Employee(4, "diluc", 44));
        listEmp.Add(new Employee(5, "e", 55555));
        listEmp.Add("Harro");*/

        /* Display (listEmp);*/
        Employee a = new Employee(1, "nhung", 220, new DateOnly(), new Address
            (13, "Vo Oanh", "Hiep Binh Chanh", "Thu Duc", "HCMC"));


        WriteLine(a);

        
        ReadLine();

    }
    private static void Display(ArrayList listData)
    {
        /*foreach (Employee e in listData)
        {
            WriteLine (e);
        }*/
        for (int i = 0; i < listData.Count; i++)
        {
            WriteLine(listData[i]);
        }
        
    }
    
}