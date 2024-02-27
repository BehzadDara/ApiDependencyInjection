using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ApiDependencyInjection
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ApiDependencyInjectionController(
        [FromKeyedServices("Singleton")] IMyClass singletonService1,
        [FromKeyedServices("Singleton")] IMyClass singletonService2,
        [FromKeyedServices("Scoped")] IMyClass scopedService1,
        [FromKeyedServices("Scoped")] IMyClass scopedService2,
        [FromKeyedServices("Transient")] IMyClass transientService1,
        [FromKeyedServices("Transient")] IMyClass transientService2
        ) : ControllerBase
    {
        [HttpGet]
        public string GetInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Singleton:  instance1 is [{singletonService1.GetMyProperty()}] and instance2 is [{singletonService2.GetMyProperty()}]");
            sb.AppendLine($"Scoped:     instance1 is [{scopedService1.GetMyProperty()}] and instance2 is [{scopedService2.GetMyProperty()}]");
            sb.AppendLine($"Transient:  instance1 is [{transientService1.GetMyProperty()}] and instance2 is [{transientService2.GetMyProperty()}]");
        
            return sb.ToString();
        }
    }
}
