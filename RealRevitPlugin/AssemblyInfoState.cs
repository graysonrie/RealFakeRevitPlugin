using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RealRevitPlugin {
    internal class AssemblyInfoState {
        public static string? Assembly;
        public static string GetAssembly() {
            if(Assembly is null) {
                throw new NullReferenceException("App assembly has not been set. Please call ResourceAccessor.SetExecutingAssembly(Assembly.GetExecutingAssembly().GetName().Name)");
            }
            return Assembly;
        }
        public static void SetAssembly(string assembly) {
            Assembly = assembly;
        }
    }
}
