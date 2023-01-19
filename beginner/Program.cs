using System;

// Example 1: Hello World
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/csharp-hello-world/lessons/csharp-hello-world/exercises/run-some-c-sharp

// namespace HelloWorld
// {
//   class Program
//   {
//     static void Main()
//     {
//       Console.WriteLine("Hello World!");
//     }
//   }
// }


// Example 2: Getting Input
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/csharp-hello-world/lessons/csharp-hello-world/exercises/getting-input

// namespace GettingInput
// {
//   class Program
//   {
//     static void Main()
//     {
//       Console.WriteLine("How old are you?");
//       string input = Console.ReadLine();
//       Console.WriteLine($"Your are {input} years old!");
//     }
//   }
// }


// Example 3: Conversion:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/learn-csharp-module-ii/lessons/csharp-data-types-variables/exercises/converting-data-types-csharp

// namespace FavoriteNumber
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Console.Write("Enter your favorite number!: ");
//       int faveNumber = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }


// Example 4: Numbers and calculations:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/learn-csharp-module-ii/lessons/csharp-working-with-numbers/exercises/arithmetic-operators-csharp

// namespace PlanetCalculations
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       int userAge = 69;
//       double jupiterYears = 11.86;
//       double jupiterAge = userAge / jupiterYears;
//       double journeyToJupiter = 6.142466;
//       double newEarthAge = userAge + journeyToJupiter;
//       double newJupiterAge = newEarthAge / jupiterYears;
// 
//       Console.WriteLine(jupiterAge);    //5.817875210792581
//       Console.WriteLine(newEarthAge);   //75.142466
//       Console.WriteLine(newJupiterAge); //6.335789713322091
//     }
//   }
// }


// Example 4: String Interpolation:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/learn-csharp-module-ii/lessons/csharp-working-with-text/exercises/string-interpolation-csharp

// namespace StoryTime
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string beginning = "Once upon a time,";
//       string middle = "the kid climbed a tree";
//       string end = "everyone lived happily ever after.";
//       string story = $"{beginning} {middle} {end}";
// 
//       Console.WriteLine(story);
//     }
//   }
// }


// Example 5: Parts of String
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/learn-csharp-module-ii/lessons/csharp-working-with-text/exercises/get-parts-of-strings

// namespace DNA
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string startStrand = "ATGCGATGAGCTTAC";
//       int tga = startStrand.IndexOf("TGA");
//       int startPoint = 0;
//       int length = tga + 3;
//       string dna = startStrand.Substring(startPoint, length);
// 
//       Console.WriteLine(dna);
//       Console.WriteLine(dna[3]);
//     }
//   }
// }


// Example 6: Defining methods:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/csharp-methods/lessons/csharp-method-calls-and-input/exercises/define-parameters

// namespace DefineAMethod
// {
//   class Program
//   {
//     static void YourMethodName(string identity, int age) 
//     {
//       Console.WriteLine($"{identity} is {age} years old.");
//     }
//     static void Main(string[] args)
//     {
//       YourMethodName("Artur", 35);
//     }
//   }
// }


// Example 7: Method overloading:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-beginner-c-sharp/modules/csharp-methods/lessons/csharp-method-calls-and-input/exercises/method-overloading

// namespace MethodOverloading
// {
//   class Program
//   {
//     static void NamePets()
//     {
//       Console.WriteLine("Aw, you have no spacefaring pets :(");
//     }

//     static void NamePets(string name1, string name2)
//     {
//       Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
//     }

//     static void NamePets(string name1, string name2, string name3)
//     {
//       Console.WriteLine($"Your pets {name1}, {name2} and {name3} will be joining your voyage across space!");
//     }

//     static void Main(string[] args)
//     {
//       NamePets();
//       NamePets("Laika", "Albert");
//       NamePets("Mango", "Puddy", "Bucket");
//       // Aw, you have no spacefaring pets :(
//       // Your pets Laika and Albert will be joining your voyage across space!
//       // Your pets Mango, Puddy and Bucket will be joining your voyage across space!
//     }
//   }
// }
