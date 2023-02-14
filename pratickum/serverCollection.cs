using Microsoft.Extensions.DependencyInjection;
using repositories.entities;
using repositories.interfaces;
using repositories.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace repositories
{
    public  static class serverCollection
    {

        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
         
            service.AddScoped<IDataRepository<User>,UserRepository>();
            service.AddScoped<IDataRepository<Child>,ChildRepository>();
            return service;
        }


    }
}
