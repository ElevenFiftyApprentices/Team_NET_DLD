using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DLDShoppingList.Startup))]
namespace DLDShoppingList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
