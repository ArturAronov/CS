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
