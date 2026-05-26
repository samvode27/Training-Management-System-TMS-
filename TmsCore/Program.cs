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




// Console.WriteLine("=== COURSE VALIDATION ===");

// var course = new Course
// {
//     Code = "CS-401",
//     Title = "Advanced C#",
//     Capacity = 30
// };

// Console.WriteLine($"Course: {course.Title}");

// Console.WriteLine($"Capacity: {course.Capacity}");

// Console.WriteLine();

// Console.WriteLine("=== INVALID CAPACITY ===");

// try
// {
//     course.Capacity = -5;
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine(
//         $"Caught Error: {ex.Message}"
//     );
// }

// Console.WriteLine();

// Console.WriteLine("=== INVALID TITLE ===");

// try
// {
//     course.Title = "";
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine(
//         $"Caught Error: {ex.Message}"
//     );
// }





// Console.WriteLine("=== STUDENT MODEL ===");

// var student = new Student
// {
//     Id = "STU-001",
//     Name = "Abeba",
//     Age = 20,
//     GPA = 3.8m,
//     Email = "helen@example.com"
// };

// Console.WriteLine($"ID: {student.Id}");
// Console.WriteLine($"Name: {student.Name}");
// Console.WriteLine($"Age: {student.Age}");
// Console.WriteLine($"GPA: {student.GPA}");
// Console.WriteLine($"Email: {student.Email}");

// Console.WriteLine("=== Invalid Name ===");
// try
// {
//     var s1 = new Student
//     {
//         Id = "S1",
//         Name = "",
//         Age = 20,
//         GPA = 3.0m,
//         Email = "s1@example.com"
//     };
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine(ex.Message);
// }
// Console.WriteLine("=== Invalid Age ===");
// try
// {
//     var s2 = new Student
//     {
//         Id = "S2",
//         Name = "John",
//         Age = 10,
//         GPA = 3.0m,
//         Email = "helen@example.com"
//     };
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine(ex.Message);
// }

// Console.WriteLine("=== Invalid GPA ===");

// try
// {
//     var s3 = new Student
//     {
//         Id = "S3",
//         Name = "Helen",
//         Age = 22,
//         GPA = 5.0m,
//         Email = "helen@example.com"
//     };
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine(ex.Message);
// }

// Console.WriteLine("=== Invalid Email ===");
// try
// {
//     var s4 = new Student{
//         Id = "s4",
//         Name = "Demeke",
//         Age = 21,
//         GPA = 4.0m,
//         Email = "demeke.com" 
//     };
// }
// catch (System.ArgumentException)
// {
//     Console.WriteLine("Invalid email format.");
// }




// void PrintGradeReport(
//     IEnumerable<IGradable> assessments)
// {
//     Console.WriteLine("=== GRADE REPORT ===");

//     foreach (var item in assessments)
//     {
//         Console.WriteLine($"{item.Title}: " + $"{item.CalculateGrade():F2}%");
//     }
// }

// IGradable[] assessments =
// [
//     new Quiz
//     {
//         Title = "C# Basics",
//         CorrectAnswers = 18,
//         TotalQuestions = 20
//     },

//     new LabAssignment
//     {
//         Title = "Registration API",
//         FunctionalityScore = 90m,
//         CodeQualityScore = 85m
//     },

//     new FinalExam
// {
//     Title = "Architecture Exam",
//     Score = 92m
// }                                                                                                
// ];

// PrintGradeReport(assessments);



///////////////// Session Two ////////////////////
/// 
/// Collection Expressions ///
// List<string> frontendCourses = [
//     "HTML & CSS",
//     "JavaScript",
//     "React"
// ];

// foreach (var course in frontendCourses)
// {
//     Console.WriteLine(course);
// }


/// Dictionary Collections ///
// Dictionary<string, string> students = 
//     new()
//     {
//         ["STU-001"] = "Abeba",
//         ["STU-002"] = "John",
//         ["STU-003"] = "Helen"                                                                                                
//     };

// //Add    
// students["STU-004"] = "Dawit";    

// Console.WriteLine(students["STU-004"]);



// Spread Operator(merge collections) //

// string[] backendCourses = ["C#", "Data Structures", "Algorithms"];
// string[] frontendCourses = ["HTML & CSS", "JavaScript", "React"];

// string[] allCourses = [..backendCourses, ..frontendCourses];

// foreach (var course in allCourses)
// {
//     Console.WriteLine(course);
// }



// LINQ(Lists, Arrays, Databases, XML, APIs, Entity Framework Core) //
List<Student> students = [
    new ()
    {
        Id = "STU-001",
        Name = "Abeba",
        Age = 20,
        GPA = 3.8m,
        Email = "abeba@example.com"
    },
    new ()
    {
        Id = "STU-002",
        Name = "John",
        Age = 22,
        GPA = 3.5m,
        Email = "john@example.com"
    },
    new ()
    {
        Id = "STU-003",
        Name = "Helen",
        Age = 21,
        GPA = 4.0m,
        Email = "helen@example.com"
    }
];

var honors = students.Where(s => s.GPA > 3.5m);
 
foreach (var student in honors)
{
    Console.WriteLine($"{student.Name} - GPA: {student.GPA}");
};


// sorting 
var ranked = students.OrderByDescending(s => s.GPA);
Console.WriteLine("/// sorting /////");

foreach (var student in ranked)
{
    Console.WriteLine($"{student.Name} - GPA: {student.GPA}");
};


var leaderboard =
    students.Select(s =>
        new
        {
            s.Name,
            s.GPA
        });

foreach (var entry in leaderboard)
{
    Console.WriteLine($"{entry.Name}: {entry.GPA}");
}



///// Projection(Transform data into another shape)(don't always need FULL object Only select needed fields.) //////
// syntax - collection.Select(item => transformation) //

System.Console.WriteLine("//////// Get only student names /////////");
var names = students.Select(s => s.Name);

foreach (var name in names)
{
    Console.WriteLine(name);
}

System.Console.WriteLine("//////// Projection into Anonymous Object /////////");
var leaderboard2 =
   students.Select(s => 
      new
      {
          s.Name,
          s.GPA                                                                                                
      });
      
foreach (var entry in leaderboard2)
{
   Console.WriteLine($"{entry.Name}: {entry.GPA}");
};


      