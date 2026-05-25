// System.Console.WriteLine("//////// This variable may be null ////////");

// string? region = null;

// Console.WriteLine(region?.ToUpper());

// System.Console.WriteLine("//////// Null Coalescing(If null, use fallback) ////////");

// string display = region ?? "Unassigned";

// Console.WriteLine(display);

// System.Console.WriteLine("//////// Null Coalescing Assignment(Assign only if currently null.) ////////");

// region ??= "Addis Ababa";

// Console.WriteLine(region);





// System.Console.WriteLine("//////////// double stores values in binary approximation. ////////////");
// double grant = 1999.99;
// double total = grant * 100000;

// Console.WriteLine(total);

// System.Console.WriteLine("//////////// Correct: Use decimal ////////////");
// decimal money = 1999.99m;
// decimal final = money * 100000m;

// Console.WriteLine(final);



// System.Console.WriteLine("//////////// Create Models(provide Immutable behavior also prevent database corruption) ////////////");
// var enrollment1 =
//     new EnrollmentRecord(
//         "STU-001",
//         "CS-401",
//         DateTime.UtcNow
//     );

// var enrollment2 =
//     new EnrollmentRecord(
//         "STU-101",
//         "CS-502",
//         DateTime.UtcNow
//     );

// Console.WriteLine(enrollment1);
// Console.WriteLine(enrollment2);




Console.WriteLine("=== COURSE VALIDATION ===");

var course = new Course
{
    Code = "CS-401",
    Title = "Advanced C#",
    Capacity = 30
};

Console.WriteLine($"Course: {course.Title}");

Console.WriteLine($"Capacity: {course.Capacity}");

Console.WriteLine();

Console.WriteLine("=== INVALID CAPACITY ===");

try
{
    course.Capacity = -5;
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(
        $"Caught Error: {ex.Message}"
    );
}

Console.WriteLine();

Console.WriteLine("=== INVALID TITLE ===");

try
{
    course.Title = "";
}
catch (ArgumentException ex)
{
    Console.WriteLine(
        $"Caught Error: {ex.Message}"
    );
}