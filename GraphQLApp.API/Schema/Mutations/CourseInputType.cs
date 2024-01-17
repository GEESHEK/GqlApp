using GraphQLApp.API.Schema.Types;

namespace GraphQLApp.API.Schema.Mutations;

public class CourseInputType
{
    public string Name { get; set; }
    public Subject Subject { get; set; }
    public Guid InstructorId { get; set; }
}