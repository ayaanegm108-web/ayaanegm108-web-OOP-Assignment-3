
using src;


//var store = new StudentStore();
//store.Add(new Student { Id = 1, Name = "Aya" });
//store.Add(new Student { Id = 2, Name = "Omar" });


var StudentStore = new Store<Student>();
StudentStore.Add(new Student { Id = 1, Name = "Aya" });
StudentStore.Add(new Student { Id = 2, Name = "Omar" });

//Console.WriteLine(store.GetById(2)?.Name);   // Omar
//Console.WriteLine(store.GetById(99) is null); // True
//Console.WriteLine(store.Remove(1));           // True
//Console.WriteLine(store.GetAll().Count);      // 1


Console.WriteLine(StudentStore.GetById(2)?.Name);
Console.WriteLine(StudentStore.GetById(99) is null);
Console.WriteLine(StudentStore.Remove(1));
Console.WriteLine(StudentStore.GetAll().Count);

//var courses = new CourseStore();
//courses.Add(new Course { Id = 10, Title = "C# Basics", Price = 500m });
//courses.Add(new Course { Id = 11, Title = "OOP", Price = 750m });

var CoursesStore = new Store<Course>();
CoursesStore.Add(new Course { Id = 10, Title = "C# Basics", Price = 500m });
CoursesStore.Add(new Course { Id = 11, Title = "OOP", Price = 750m });

//Console.WriteLine(CoursesStore.GetById(11)?.Title);  // OOP
//Console.WriteLine(CoursesStore.Remove(10));          // True
//Console.WriteLine(CoursesStore.GetAll().Count);      // 1

Console.WriteLine(CoursesStore.GetById(11)?.Title);
Console.WriteLine(CoursesStore.Remove(10));
Console.WriteLine(CoursesStore.GetAll().Count);