using Owin;

namespace Project.Http.Auth
{
    public interface IStartup
    {
        void Configuration(IAppBuilder app); 
    }
}