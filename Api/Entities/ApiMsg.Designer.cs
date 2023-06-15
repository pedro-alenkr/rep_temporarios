using System.Resources;
using System.Reflection;

namespace Api.Entities
{
    public static class ApiMsg
    {
        private static readonly ResourceManager resourceManager= new ResourceManager("Api.Entities.ApiMsg",Assembly.GetExecutingAssembly());

        public static string EXC0001
        {
            get {return resourceManager.GetString("EXC0001");}
        }

        public static string EXC0002
        {
            get {return resourceManager.GetString("EXC0002");}
        }

        public static string EXC0003
        {
            get {return resourceManager.GetString("EXC0003");}
        }

        public static string EXC0004
        {
            get {return resourceManager.GetString("EXC0004");}
        }

        public static string EXC0005
        {
            get {return resourceManager.GetString("EXC0005");}
        }
        
    }
}