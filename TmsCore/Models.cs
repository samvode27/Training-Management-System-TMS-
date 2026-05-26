// Immutable Enrollment Record

public record EnrollmentRecord(
    string StudentId,
    string CourseCode,
    DateTime EnrolledAt
);

public class Course
{
    public required string Code { get; init; }

    public required string Title
    {
        get;

        set => field =
            !string.IsNullOrWhiteSpace(value)
            ? value
            : throw new ArgumentException(
                "Title cannot be empty.",
                nameof(value)
            );
    }

    public int Capacity
    {
        get;

        set => field =
            value > 0
            ? value
            : throw new ArgumentOutOfRangeException(
                nameof(value),
                "Capacity must be greater than zero."
            );
    }

    public int EnrolledCount { get; set; }
}

public class Student
{
    // Required ID
    public required string Id { get; init; }

    // Validated Name
    public required string Name
    {
        get;

        set => field =
            !string.IsNullOrWhiteSpace(value)
            ? value
            : throw new ArgumentException(
                "Name cannot be empty or whitespace.",
                nameof(value)
            );
    }

    // Validated Age
    public int Age
    {
        get;

        set => field =
            value is >= 16 and <= 100
            ? value
            : throw new ArgumentOutOfRangeException(
                nameof(value),
                "Age must be between 16 and 100."
            );
    }

    // Validated GPA
    public decimal GPA
    {
        get;

        set => field =
            value is >= 0.0m and <= 4.0m
            ? value
            : throw new ArgumentOutOfRangeException(
                nameof(value),
                "GPA must be between 0.0 and 4.0."
            );
    }

    public required string Email
    {
        get;

        set => field =
            !string.IsNullOrWhiteSpace(value)
            && value.Contains("@")
            ? value
            : throw new ArgumentException(
                "Invalid email."
            );
    }
}