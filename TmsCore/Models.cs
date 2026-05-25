// Immutable Enrollment Record

public record EnrollmentRecord(
    string StudentId,
    string CourseCode,
    DateTime EnrolledAt
);