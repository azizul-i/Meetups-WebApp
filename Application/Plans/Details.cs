using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Plans
{
    public class Details
    {
        public class Query : IRequest<Plan>
        {
            public Guid Id { get; set; }
        };

        public class Handler : IRequestHandler<Query, Plan>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }

            public async Task<Plan> Handle(Query request, CancellationToken cancellationToken)
            {
                var plan = await _context.Plans.FindAsync(request.Id);
                return plan;
            }
        }
    }
}