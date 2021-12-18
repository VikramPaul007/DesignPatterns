namespace DesignPatterns.Console
{
    // Sealed class to restrict inheritance
    internal sealed class Singleton
    {
        // Counts the no of instances created of the class
        private static int counter;

        private static readonly object obj = new();

        // Private constructor ensures that object is not
        // initiated anywhere other than within the class itself
        private Singleton()
        {
            counter++;
            System.Console.WriteLine($"Total instance created of Singleton: {counter}");
        }

        // This static property returns the only instance created
        private static Singleton? instance = null;

        // Returns the only created instance of the class
        public static Singleton Instance { 
            get 
            {
                // Double-check locking
                // As locking is an expensive operation,
                // we will only use lock when the instance is null
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            } 
        }

        public void WriteToConsole(string text)
        {
            System.Console.WriteLine(text);
        }

    }

    // Lazy initialization of Singleton class using Lazy keyword
    internal sealed class LazySingleton
    {
        // Counts the no of instances created of the class
        private static int counter;

        // Private constructor ensures that object is not
        // initiated anywhere other than within the class itself
        private LazySingleton()
        {
            counter++;
            System.Console.WriteLine($"Total instance created of LazySingleton: {counter}");
        }

        // This static property returns the only instance created
        private static Lazy<LazySingleton> instance = new Lazy<LazySingleton>(new LazySingleton());

        // Returns the only created instance of the class
        public static LazySingleton Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public void WriteToConsole(string text)
        {
            System.Console.WriteLine(text);
        }

    }
}
