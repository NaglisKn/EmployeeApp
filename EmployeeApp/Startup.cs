﻿using Microsoft.Owin;
using Owin;
using EmployeeApp.DAL;


[assembly: OwinStartupAttribute(typeof(EmployeeApp.Startup))]
namespace EmployeeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
