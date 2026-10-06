
using src;

var store = new StudentStore();
store.Add(new Student { Id = 1, Name = "Aya" });
store.Add(new Student { Id = 2, Name = "Omar" });

Console.WriteLine(store.GetById(2)?.Name);   // Omar
Console.WriteLine(store.GetById(99) is null); // True
Console.WriteLine(store.Remove(1));           // True
Console.WriteLine(store.GetAll().Count);      // 1
