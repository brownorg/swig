// Swig
// Copyright (c) 2023 brown org.
// See the LICENSE file for more information.

using System;
// using System.Threading;
// using System.Xml;

namespace Brown.Swig;

public class Program
{
    protected static void Unimplemented()
    {
        Console.WriteLine("Currently, this feature is not supported.");
        Console.WriteLine("Press any key to continue... ");
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        // Quick Open
        if (args.Length == 1)
            Unimplemented();

        // Main Interface
        Console.WriteLine(" == Swig == ");
        Console.WriteLine("Copyright (c) 2023 brown org.");
        Console.WriteLine("See the LICENSE file for more information.");
        Console.WriteLine();

        // Option List
        Console.WriteLine("Choose an option:");
        Console.WriteLine("[1] Open File");
        Console.WriteLine("[2] Tools");
        // Read chosen option
        int option = Convert.ToInt32(Console.ReadKey());

        // Check for option
        switch (option)
        {
            case 1:
                Unimplemented();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine(" == Tools == ");
                Unimplemented();
                break;
            default:
                Console.WriteLine("Bad option.");
                break;
        }
    }
}
