using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.tables;
using MediatR;
using data.uows;
using Microsoft.EntityFrameworkCore;

namespace services.Query
{
    public class HavaDurumuQuery: IRequest<List<HavaDurumu>>
    {
        //public int id {get;set;}

        public class Handler : IRequestHandler<HavaDurumuQuery,List<HavaDurumu>>
        {
            public async Task<List<HavaDurumu>> Handle(HavaDurumuQuery request, CancellationToken cancellationToken)
            {
                var uow = new BlogUnitOfWork();
                var HavaDurumu = await uow.havaDurumuRepository.GetQuery()
                .ToListAsync();
                return HavaDurumu;
            }
        }
    }
}