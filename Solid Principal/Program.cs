// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SOLID.Add(1, 2));


#region Single Responsibility Principle (SRP)
/// <summary>
/// Single Responsibility Principle (SRP)
/// The method only performs addition process.
/// </summary>
/// <param name="a"></param>
/// <param name="b"></param>
/// <returns></returns>
public class SOLID
{
    
    public static int Add(int a, int b)
    {
        return a + b;
    }

}
#endregion

#region Open/Closed Principle (OCP)

/// <summary>
/// Open/Closed Principle (OCP)
/// The method is open for extension and close for modification.
/// </summary>
public abstract class SOLIDAbstract
{
    public abstract int Add(int a, int b);
}

public class SOLID1 : SOLIDAbstract
{
    public override int Add(int a, int b)
    {
        return a + b;
    }
}
#endregion

#region MyRegion

public class SuperClass
{
   public static string Farmming = "Farmming";

   public static void DoFarmming()
   {
        Console.WriteLine("I do" + Farmming);
   }
}

public class SubClass :SuperClass
{
    public static string Teaching = "Teaching";

    public static void DoTeaching()
    {
        Console.WriteLine("I do" + Teaching);
    }
}

#endregion