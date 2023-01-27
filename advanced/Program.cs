using System;

// Example 1: Arrays:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-intermediate-c-sharp/modules/learn-csharp-arrays-and-loops/lessons/csharp-arrays/exercises/built-in-methods

// namespace BuiltInMethods
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] summerStrut;
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
//       int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
//       int threeStarSong = Array.IndexOf(ratings, 3);
//
//       Console.WriteLine($"Song number {threeStarSong + 1} is rated three stars");
//       Console.WriteLine(Array.Find(summerStrut, element => element.Length >= 10));
//
//       Array.Sort(summerStrut);
//       Console.WriteLine(summerStrut[0]);
//       Console.WriteLine(summerStrut[7]);
//     }
//   }
// }


// Example 2: Array Methods:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-intermediate-c-sharp/modules/learn-csharp-arrays-and-loops/lessons/csharp-arrays/exercises/documentation-hunt

// namespace DocumentationHunt
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       string[] summerStrut;
//       summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
//       int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
//       string[] summerStrutCopy = new string[8];
//
//       Array.Copy(summerStrut, summerStrutCopy, 8);
//       Array.Reverse(summerStrut);
//       Array.Clear(ratings, 0, 8);
//
//       Console.WriteLine(summerStrutCopy[0]);
//       Console.WriteLine(summerStrut[0]);
//       Console.WriteLine(ratings[0]);
//     }
//   }
// }


// Example 3: Fields:
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-intermediate-c-sharp/modules/learn-csharp-classes/lessons/csharp-basic-classes/exercises/fields

// <== Forest.cs ==>
// namespace BasicClasses
// {
//   class Forest
//   {
//     public string name;
//     public string biome;
//     public int trees;
//     public int age;
//   }
// }
//
// <== Program.cs ==>
// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.name = "Congo";
//       f.biome = "Tropical";
//       f.trees = 0;
//       f.age = 0;
//
//       Console.WriteLine(f.name);
//       Console.WriteLine(f.biome);
//       Console.WriteLine(f.trees);
//       Console.WriteLine(f.age);
//     }
//   }
// }


// Example 4: Properties (get and set):
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-intermediate-c-sharp/modules/learn-csharp-classes/lessons/csharp-basic-classes/exercises/properties

// <== Forest.cs ==>
// namespace BasicClasses
// {
//   class Forest
//   {
//     public string name;
//     public int trees;
//     public int age;
//     public string biome;
// 
//     public string Name
//     {
//       get { return name; }
//       set { name = value; }
//     }
// 
//     public int Trees
//     {
//       get { return trees; }
//       set { trees = value; }
//     }
// 
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical") { biome = "Tropical"; }
//         else if (value == "Temperate") { biome = "Temperate"; }
//         else if (value == "Boreal") { biome = "Boreal"; }
//         else { biome = "Unknown"; }
//       }
//     }
//   }
// }
// 
// <== Program.cs ==>
// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest f = new Forest();
//       f.Name = "Congo";
//       f.Trees = 0;
//       f.age = 0;
//       f.Biome = "Tropical";
// 
//       Console.WriteLine(f.Name);
//       Console.WriteLine(f.Biome);
//     }
//   }
// }


// Example 5: Classes & Objects:    
// https://www.codecademy.com/paths/build-web-apps-with-asp-net/tracks/build-web-apps-asp-net-intermediate-c-sharp/modules/learn-csharp-classes/lessons/csharp-basic-classes/exercises/basic-review

// <== Forest.cs ==>
// namespace BasicClasses
// {
//   class Forest
//   {
//     public int age;
//     private string biome;
// 
//     public Forest(string name, string biome)
//     {
//       this.Name = name;
//       this.Biome = biome;
//       Age = 0;
//     }
// 
//     public Forest(string name) : this(name, "Unknown")
//     { }
// 
//     public string Name
//     { get; set; }
// 
//     public int Trees
//     { get; set; }
// 
//     public string Biome
//     {
//       get { return biome; }
//       set
//       {
//         if (value == "Tropical" ||
//             value == "Temperate" ||
//             value == "Boreal")
//         {
//           biome = value;
//         }
//         else
//         {
//           biome = "Unknown";
//         }
//       }
//     }
// 
//     public int Age
//     {
//       get { return age; }
//       private set { age = value; }
//     }
// 
//     public int Grow()
//     {
//       Trees += 30;
//       Age += 1;
//       return Trees;
//     }
// 
//     public int Burn()
//     {
//       Trees -= 20;
//       Age += 1;
//       return Trees;
//     }
//   }
// }

// <== Program.cs ==>
// namespace BasicClasses
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Forest amazon = new Forest("Amazon");
// 
//       Console.WriteLine(amazon.Trees);   // returns 0
//       Console.WriteLine(amazon.Grow());  // returns 30
//       Console.WriteLine(amazon.Trees);   // returns 30
//     }
//   }
// }
