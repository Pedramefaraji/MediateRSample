using MediatR;

namespace Application.Features.Student.Commands
{
        public class RegisterStudent : IRequest<int>
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string LName { get; set; }
    }
}
