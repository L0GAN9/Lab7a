using System;

class Program {
  public static double CalculateCharges(double hours)
  {
    double charge = 0;
    if (hours > 19)
    {
      charge = 10;
    }
    else if (hours >= 3)
    {
      charge = (((hours - 3) * .5)+2); 
    }
    else if (hours < 3)
    {
      charge = 2;
    }
    return charge;
  }
  
  public static void Main (string[] args)
  {
    Console.WriteLine("Enter Number of Customers");
    int amo = Convert.ToInt32(Console.ReadLine());
    string[] custnam = new string[amo];
    for (int i = 0; i < custnam.Length; i++)
    {
      Console.WriteLine("Enter Customer Name; If Finished, Enter No");
      custnam[i] = Console.ReadLine();
      
      if (custnam[i] == "no")
     {
       break;
     }
     else if (custnam[i] == "NO")
     {
       break;
     }
     else if (custnam[i] == "No")
     {
       break;
     }
     else if (custnam[i] == "nO")
     {
       break;
     }
     else
     {
       continue;
     }
    }
    double[] hours = new double[amo];
    for (int i = 0; i < custnam.Length; i++)
    {
      if (custnam[i] == "no")
     {
       break;
     }
     else if (custnam[i] == "NO")
     {
       break;
     }
     else if (custnam[i] == "No")
     {
       break;
     }
     else if (custnam[i] == "nO")
     {
       break;
     }
     else
     {
       Console.WriteLine("Enter Hours for " + custnam[i]);
       hours[i] = Convert.ToDouble(Console.ReadLine());
       double charge = CalculateCharges(hours[i]);
       Console.WriteLine("Parking Charge is $" + charge);
     }
    }
  }
}