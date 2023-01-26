﻿using System;

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
