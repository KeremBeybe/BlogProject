using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using services.Query;

namespace webapi.Blog
{
    public class HavaDurumuMap
    {
        public static void AddMap(WebApplication app) {
            app.MapGet("havadurumu", (IMediator mediator) => {
                return mediator.Send(new HavaDurumuQuery());
            });
        }
    }
}