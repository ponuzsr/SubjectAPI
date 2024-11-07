namespace SubjectAPI.Models
{
    public record CreateSubjectDto( string SubjectName, sbyte NumberOfHours, string Description);
    public record UpdateSubjectDto(string SubjectName, sbyte NumberOfHours, string Description);
}