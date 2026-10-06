
using src;

var store = new StudentStore();
store.Add(new Student { Id = 1, Name = "Aya" });
store.Add(new Student { Id = 2, Name = "Omar" });

Console.WriteLine(store.GetById(2)?.Name);   // Omar
Console.WriteLine(store.GetById(99) is null); // True
Console.WriteLine(store.Remove(1));           // True
Console.WriteLine(store.GetAll().Count);      // 1

var courses = new CourseStore();
courses.Add(new Course { Id = 10, Title = "C# Basics", Price = 500m });
courses.Add(new Course { Id = 11, Title = "OOP", Price = 750m });

Console.WriteLine(courses.GetById(11)?.Title);  // OOP
Console.WriteLine(courses.Remove(10));          // True
Console.WriteLine(courses.GetAll().Count);      // 1
