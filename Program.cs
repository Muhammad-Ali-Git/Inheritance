// See https://aka.ms/new-console-template for more information
using System;

public class Employee
{
    public string FN = "";
    public string LN = "";

    public void Print()
    {
        Console.WriteLine("{0} {1}", FN, LN);
    }
}

public class Part : Employee
{
    public new void Print()
    {
        Console.Write("{0} {1} - Contractor", FN, LN);
    }
}

public class Full : Employee
{
    
}

class Program
{
    public static void Main()
    {
        Full FTE = new Full();
        FTE.FN = "Muhammad Ali";
        FTE.LN = "GD";
        FTE.Print();

        Employee PTE = new Part();
        PTE.FN = "Muhammad Ali";
        PTE.LN = "GD";
        PTE.Print();
    }
}