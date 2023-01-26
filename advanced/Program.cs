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
// <== Main.cs ==>
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
// <== Main.cs ==>
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
