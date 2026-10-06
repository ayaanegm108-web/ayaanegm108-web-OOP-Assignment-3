using src;

Console.WriteLine("Hello, World!");

var cases = new (string? Input, string Method, bool Expected)[]
{
    ("01012345678",    "Phone", true),
    ("+201512345678",  "Phone", true),
    ("01312345678",    "Phone", false),  
    ("0101234567",     "Phone", false),  
    ("0101234567a",    "Phone", false),  
    ("29901011234567", "NationalId", true),
    ("19901011234567", "NationalId", false), 
    ("2990101123456",  "NationalId", false),
    (null,  "Phone", false),
    ("",    "Phone", false),
    ("   ", "NationalId", false),
};

foreach (var (input, method, expected) in cases)
{
    var actual = method == "Phone"
        ? input.IsValidEgyptianPhone()
        : input.IsValidEgyptianNationalId();

    var status = actual == expected ? "PASS" : "FAIL";
    Console.WriteLine($"{status}  {method,-10} \"{input}\" -> {actual} (expected {expected})");
}