using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using StackExchange.Exceptional;

namespace Samples.MVC4.Tools
{
    public class ModuleRegister
    {
        public static void RigisterExceptionModule()
        {
            DynamicModuleUtility.RegisterModule(typeof(ExceptionalModule));
        }
    }
}