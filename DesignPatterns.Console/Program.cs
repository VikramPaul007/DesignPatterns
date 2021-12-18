// See https://aka.ms/new-console-template for more information
using DesignPatterns.Console;

Console.WriteLine("Hello, World!");

#region Test Singleton
Console.WriteLine("\nTesting Singleton Design Pattern: Start\n");
// Synchronous execution
Singleton singleton = Singleton.Instance;
singleton.WriteToConsole("Object created inside User class.");

Singleton singleton2 = Singleton.Instance;
singleton2.WriteToConsole("Object created inside Product class.");

// Parallel invoke to check for multi-threaded access
Parallel.Invoke(() =>
{
    Singleton singleton = Singleton.Instance;
    singleton.WriteToConsole("Object created inside User class.");

    Singleton singleton2 = Singleton.Instance;
    singleton2.WriteToConsole("Object created inside Product class.");
});

// Lazy initialization
Parallel.Invoke(() =>
{
    LazySingleton lazySingleton = LazySingleton.Instance;
    lazySingleton.WriteToConsole("Object created inside User class.");

    LazySingleton lazySingleton2 = LazySingleton.Instance;
    lazySingleton2.WriteToConsole("Object created inside Product class.");
});

Console.WriteLine("\nTesting Singleton Design Pattern: End\n");
#endregion

Console.ReadLine();
