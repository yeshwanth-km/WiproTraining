internal class Program
{
   


    // Delegate declaration
    public delegate int ArithmeticOperation(int a, int b); // Declaring a delegate

    private static void Main(string[] args)
    {
        Program obj = new Program();

        // Create delegate instance for instance method
        ArithmeticOperation addOperation = new ArithmeticOperation(obj.Add);
        int addResult = addOperation(5, 3); // Invoke delegate
        Console.WriteLine($"Addition Result: {addResult}"); // Output: 8

        // Create delegate instance for static method
        ArithmeticOperation multiplyOperation = new ArithmeticOperation(Multiply);
        int multiplyResult = multiplyOperation(5, 3); // Invoke delegate
        Console.WriteLine($"Multiplication Result: {multiplyResult}"); // Output: 15

        // Using delegates dynamically with anonymous methods
        ArithmeticOperation subtractOperation = delegate (int x, int y)
        {
            return x - y;
        };
        int subtractResult = subtractOperation(5, 3);
        Console.WriteLine($"Subtraction Result: {subtractResult}"); // Output: 2

        // Using delegates dynamically with lambda expressions
        ArithmeticOperation divideOperation = (x, y) => x / y;
        int divideResult = divideOperation(10, 2);
        Console.WriteLine($"Division Result: {divideResult}"); // Output: 5
    }

    // Instance Method
    int Add(int x, int y)
    {
        return x + y;
    }

    // Static Method
    static int Multiply(int x, int y)
    {
        return x * y;
    }
}

