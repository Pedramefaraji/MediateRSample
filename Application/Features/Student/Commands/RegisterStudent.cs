using MediatR;

namespace Application.Features.Student.Commands
{
        public class RegisterStudent : IRequest<int>
        {
            public int id { get; set; }
            public int Name { get; set; }
            public int LName { get; set; }
    }
}
