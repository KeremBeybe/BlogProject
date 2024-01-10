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
    public class AddHavaDurumuCommand: IRequest<HavaDurumu>
    {
        public HavaDurumu Havadurumu {get;set;}

        public class Handler : IRequestHandler<AddHavaDurumuCommand,HavaDurumu>
        {
            public async Task<HavaDurumu> Handle(AddHavaDurumuCommand request, CancellationToken cancellationToken)
            {
                return await Task.Factory.StartNew( () => {
                    var uow = new BlogUnitOfWork();
                    var Havadurumu = uow.havaDurumuRepository.Add(request.Havadurumu);
                    uow.havaDurumuRepository.Save();
                    return Havadurumu;
                });
               
            }

            
        }
    }
}