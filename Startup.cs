﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mw246116_MIS4200.Startup))]
namespace mw246116_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
