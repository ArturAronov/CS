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

- Methods as Arguments & Lambda Expressions:

  **lambda expression:**

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

## Advanced

- Array Declaration:

  ```
    int[] luckyNumbers = { 13, 88, 420 };
  ```

  _or:_

  ```
  int[] luckyNumbers;
  luckyNumbers = new int[] { 13, 88, 420 };
  ```

  _or:_

  ```
  // luckyNumbers will be equal to [0, 0, 0]
  int[] luckyNumbers = new int[3];
  ```

- Fields:

  A field is a variable of any type that is declared directly in a class or struct. Fields are members of their containing type.
  It is common practice to name fields using all lowercase (`name` instead of `Name`).

- Properties:

  A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they're public data members, but they're special methods called accessors. This feature enables data to be accessed easily and still helps promote the safety and flexibility of methods.

  - A `get` property accessor is used to return the property value, and a `set` property accessor is used to assign a new value.
  - The `value` keyword is used to define the value being assigned by the `set` or `init` accessor.
  - Properties can be _read-write_ (they have both a `get` and a `set` accessor)
    - _read-only_ (they have a `get` accessor but no `set` accessor)
    - _write-only_ (they have a `set` accessor, but no `get` accessor).  
      Write-only properties are rare and are most commonly used to restrict access to sensitive data.
  - Simple properties that require no custom accessor code can be implemented either as expression body definitions or as auto-implemented properties.

- Automatic Properties:

For `get` and `set` that have no inherit values, automatic properties can be used.
**from:**

```
public string size;
public string Size
{
  get { return size; }
  set { size = value; }
}
```

**to:**

```
public string Size { get; set; }
```

- Field vs. Property:

  ```
  f.Age = 32; // using property
  f.age = -1; // using field
  ```

- Public vs. Private:

  `public` - a public member that can be accessed by any class
  `private` - a private member can only be accessed by bode in the same class

- Get-Only property:

  If we want programs to get the value of property, byt we don't want programs to set value of the property. Then we either:

  - don't include `set()` method, or
    ```
    public string Area
    {
      get { return area; }
    }
    ```
  - make the `set()` method private
    ```
    public int Area
    {
      get { return area; }
      private set { area = value; }
    }
    ```

- Constructors:

  So far, we created a new object and set the property values one by one. It would be nice if we could write a method that’s run every time an object is created to set those values at once. This is where constructors come to play.

  ```
  class Forest
  {
    public int Area;

    public Forest(int area)
    {
      Area = area;
    }
  }
  ```

- `this`:  
  It’s good to be explicit when writing code so that there is no room for misinterpretation. We can refer to the current instance of a class with the `this` keyword.

  ```
  class Forest
  {
    public int Area
    { /* property omitted */ }

    public Forest(int area)
    {
      this.Area = area;
    }
  }
  ```

  `this.Area = area` means “when this constructor is used to make a new instance, use the argument `area` to set the value of this new instance’s `Area` field”.

- Overloading Constructors:

  Just like other methods, constructors can be overloaded. For example, we may want to define an additional constructor that takes one argument:

  ```
  public Forest(int area, string country)
  {
    this.Area = area;
    this.Country = country;
  }

  public Forest(int area)
  {
    this.Area = area;
    this.Country = "Unknown";
  }
  ```

  Notice how we’ve written duplicate code for our second constructor: `this.Area = area;`. Later on, if we need to adjust the constructor, we’ll need to find every copy of the code and make the exact same change. That means more work and chances for errors.

  We have two options to resolve this. In either case we will remove the duplicated code:

  - Use default argument:

    ```
    public Forest(int area, string country = "Unknown")
    {
      this.Area = area;
      this.Country = country;
    }
    ```

  - Use `: this()`:

    ```
    public Forest(int area, string country)
    {
      this.Area = area;
      this.Country = country;
    }

    public Forest(int area) : this(area, "Unknown")
    {
      Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
    }
    ```
