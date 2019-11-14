using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpreadsheetRegister.Context;
using SpreadsheetRegister.Context.Interface;
using SpreadsheetRegister.Context.Repository;
using SpreadsheetRegister.Service.Application;
using SpreadsheetRegister.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadsheetRegister.IoC
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Context
            services.AddDbContext<SpreadsheetRegisterContext>(options => options
                        .UseSqlite("Data Source=c:\\SpreadsheetRegisterDatabase.db"));

            // Services
            services.AddScoped<IUserService, UserService>();

            // Repositories
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
