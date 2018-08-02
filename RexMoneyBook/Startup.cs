using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RexMoneyBook.Startup))]
namespace RexMoneyBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
