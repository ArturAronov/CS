# C#

## Beginner

- `dotnet new console / classlib / blazorserver / webapp, razor`
- `dotnet run`
- .NET -> a platform
- ASP.NET -> a framework
- Data Types:
  |Type |Description |Size (bytes) |.NET type |Range |
  |---------------|-----------------------|---------------|---------------|---------------------------------------------------------------|
  |int |Whole Numbers |4 |System.Int32 |-2,147,483,648<br/>to<br/>2,147,483,647 |
  |long |Whole Numbers |8 |System.Int64 |-9,223,372,036,854,775,808<br/>to<br/>9,223,372,036,854,775,807|
  |float |Floating Point Numbers |4 |System.Single |+/-3.4 x 10^38 |
  |double |Double Prevision FP |8 |System.Double |+/-1.7 x 10^308 |
  |decimal |Monetary Values |16 |System.Decimal |28 significant figures |
  |char |Single Character |2 |System.Char |N/A |
  |bool |Boolean |1 |System.Boolean |True or False |
  |DateTime |Moments in time |8 |System.DateTime|0:0:00 on 01/01/0001<br/>to<br/>23:59:59 on 12/31/9999 |
  |string |Sequence of Chars |2 per char |System.String |N/A |
- Converting types
  When converting types C# checks to make sure that when we convert data types from one to another that we’re not losing any data, because that could cause problems in our code. Therefore, we can't convert from `double` to `int`, but can convert from `int` to `double`.

  ```
  // This won't work
  double myDouble = 3.2;
  int myInt = myDouble;
  ```

  - _implicit_ conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.
    ```
    int myInt = 3;
    double myDouble = myInt;
    ```
  - _explicit_ conversion: requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int, we could use the operator (int).
    ```
    double myDouble = 3.2;
    int myInt = (int)myDouble;
    ```
  - _Built-in converting methods_: https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.7.2

- Numbers:

  - Float (32bits) - 7 digits
  - Double (64bits) - 15 digits
  - Decimal (128bits) - 28 digits

- String Interpolation:
  The `$` special character identifies a string literal as an _interpolated string_. An interpolated string is a string literal that might contain _interpolation expressions_. When an interpolated string is resolved to a result string, items with interpolation expressions are replaced by the string representations of the expression results.

- Optional parameters in methods:

  ```
  static void Main(string[] args)
  {
    YourMethodName("I'm hungry", "!");  // prints "I'm hungry!"
    YourMethodName("I'm hungry");       // prints "I'm hungry."
  }

  static void YourMethodName(string message, string punctuation = ".")
  {
    Console.WriteLine(message + punctuation);
  }
  ```

- Named arguments in methods:
  Named arguments are required when you have more than one optional parameter in the method, to accurately assign a value for the right argument.
  ```
  static void YourMethodName(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0) {...}
  YourMethodName(d: 4, b: 1, a: 2);
  YourMethodName(d: 4, 2, 1) // Error!
  ```
- Method / Member Overloading:
  Member overloading means creating two or more members on the same type that differ only in the number or type of parameters but have the same name. For example, in the following, the WriteLine method is overloaded:

  ```
  public static class Console
  {
    public void WriteLine();
    public void WriteLine(string value);
    public void WriteLine(bool value);
    ...
  }
  ```

  Because only methods, constructors, and indexed properties can have parameters, only those members can be overloaded.

- `out`
  The `out` keyword causes arguments to be passed by reference. It makes the formal parameter as alias for the argument, which must be a variable. In other words, any operation on the parameter is made on the argument. It's like a `ref` keyword, except that `ref` requires that the variable be initialized before it's passed. It is also like the `in` keyword, except that `in` does not allow the called method to modify the argument value. To use an `out` parameter, both the method definition and the calling method must explicitly use the `out` keyword.

  The `in`, `ref`, and `out` keywords are not considered part of the method signature for the purpose of overload resolution. Therefore, methods cannot be overloaded if the only difference is that one method takes a `ref` or `in` argument and the other takes an `out` argument.

  Overloading is legal, however, if one method takes a `ref`, `in`, or `out` argument and the other has none of those modifiers

- Expression-bodied Definitions:
  **from:**

  ```
  bool IsEven(int num)
  {
    return num % 2 == 0;
  }
  ```

  **to:**

  ```
  bool isEven(int num) => num % 2 == 0;
  ```

  This also works for methods that return nothing, aka `void`:

  ```
  void Shout(string x) => Console.WriteLine(x.ToUpperCase());
  ```

  This type of definition can only be used when a method contains one expression. This helps us remember the name: _expression_-bodied definitions are method definitions with one _expression_.

- Methods as Arguments"

  ```
  namespace Test
  {
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = { 1, 3, 5, 6, 7, 8 };
      Console.WriteLine(Array.Exists(numbers, element => element % 2 == 0));
    }
  }
  }
  ```

  **method as argument:**

  ```
  namespace Test
  {
    class Program
    {
      static bool IsEven(int num) => num % 2 == 0;

      static void Main(string[] args)
      {
        int[] numbers = { 1, 3, 5, 6, 7, 8 };
        Console.WriteLine(Array.Exists(numbers, IsEven));
      }
    }
  }
  ```
