using RescueMe.Repository;
using RescueMe.Repository.Interface;
using RescueMe.Service;
using RescueMe.Service.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace RescueMeAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            container.RegisterType<IMessageService, MessageService>();
            container.RegisterType<IMessageRepository, MessageRepository>();
        }
    }
}