
using src;

// ---------- 1) Students and courses in generic stores ----------
var students = new Store<Student>();
students.Add(new Student { Id = 1, Name = "Aya" });
students.Add(new Student { Id = 2, Name = "Omar" });
students.Add(new Student { Id = 3, Name = "Salma" });
students.Add(new Student { Id = 4, Name = "Youssef" });
students.Add(new Student { Id = 5, Name = "Nour" });

var courses = new Store<Course>();
courses.Add(new Course { Id = 10, Title = "C# Basics", Price = 500m });
courses.Add(new Course { Id = 11, Title = "OOP", Price = 750m });
courses.Add(new Course { Id = 12, Title = "Collections", Price = 600m });

Console.WriteLine("--- Get one student and one course by id ---");
Console.WriteLine($"  Student 3: {students.GetById(3)?.Name}");
Console.WriteLine($"  Course 11: {courses.GetById(11)?.Title}");

Console.WriteLine();
Console.WriteLine();

// ---------- 2) Duplicate id ----------
Console.WriteLine();
Console.WriteLine("--- Add a student with an Id that already exists (Id 2) ---");
try
{
    students.Add(new Student { Id = 2, Name = "Duplicate" });
    Console.WriteLine("  No exception was thrown (unexpected)");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"  Exception caught as expected: {ex.Message}");
}
Console.WriteLine();
Console.WriteLine(); ;  
// ---------- 3) Page 2, size 2 ----------
Console.WriteLine();
Console.WriteLine("--- Students: page 2, page size 2 ---");
foreach (var s in students.GetAll().Page(2, 2))
    Console.WriteLine($"  {s.Id}: {s.Name}");
Console.WriteLine();
Console.WriteLine();

// ---------- 4) FindById on a plain List<Course> ----------
Console.WriteLine();
Console.WriteLine("--- FindById(12) on a plain List<Course> ---");
var plainCourses = new List<Course>
{
    new() { Id = 10, Title = "C# Basics", Price = 500m },
    new() { Id = 11, Title = "OOP", Price = 750m },
    new() { Id = 12, Title = "Collections", Price = 600m }
};
Console.WriteLine($"  Found: {plainCourses.FindById(12)?.Title}");
Console.WriteLine();
Console.WriteLine();

// ---------- 5) Must NOT compile ----------
 var names = new Store<string>();   // must NOT compile: string does not implement IHasId

#region Test
//var list = new List<Student>
//{
//    new() { Id = 1, Name = "A" }, new() { Id = 2, Name = "B" },
//    new() { Id = 3, Name = "C" }, new() { Id = 4, Name = "D" },
//    new() { Id = 5, Name = "E" }
//};

//foreach (var s in list.Page(2, 2)) Console.WriteLine(s.Name);   
//Console.WriteLine(list.FindById(4)?.Name);                      
//Console.WriteLine(list.ToIdDictionary()[5].Name);               

//try { list.Page(0, 2); }
//catch (ArgumentOutOfRangeException ex) 
//{
//    Console.WriteLine($"exception thrown as expected: {ex.Message}");
//}
#endregion