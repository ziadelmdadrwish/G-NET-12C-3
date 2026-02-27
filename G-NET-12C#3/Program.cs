using System;

class Program
{
    static void Main()
    {

        #region Q1
        // Prints: 9
        // Explanation: Casting from double to int truncates (removes decimal part).
        double d = 9.99;
        int x = (int)d;
        Console.WriteLine(x);
        #endregion


        #region Q2
        // Smallest fix:
        int n = 5;
        double d2 = n / 2.0;   // make one operand double
        Console.WriteLine(d2); // Prints 2.5
        #endregion


        #region Q3
        // Correct line to read age as int:
        int age = int.Parse(Console.ReadLine());
        #endregion


        #region Q4
        // Throws FormatException
        // Because "12a" cannot be converted to int.
        string s = "12a";
        int x4 = int.Parse(s);
        Console.WriteLine(x4);
        #endregion


        #region Q5
        string s5 = "12a";
        if (int.TryParse(s5, out int result))
            Console.WriteLine(result);
        else
            Console.WriteLine("Invalid");
        #endregion


     

        #region Q9
        // Prints: (empty line)
        // Because null conditional operator returns null
        string? name = null;
        Console.WriteLine(name?.Length);
        #endregion






        #region Q10
        // Prints: 0
        // name2?.Length returns null → ?? gives 0
        string? name2 = null;
        int length = name2?.Length ?? 0;
        Console.WriteLine(length);
        #endregion
    }
    #region Q14
    string? s14 = null;

    // B → prints 0
    int b14 = Convert.ToInt32(s14);
    Console.WriteLine(b14);
#endregion


#region Q15
string? user = null;

    Console.WriteLine(user?.ToUpper() ?? "Guest");
#endregion

    }
}



