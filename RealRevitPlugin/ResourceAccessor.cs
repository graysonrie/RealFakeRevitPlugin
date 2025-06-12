using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RealRevitPlugin{
    public class ResourceAccessor
    {
        /// <summary>
        /// This method already looks inside <c>/Resources/</c>, so the path only needs to be something like "icon32.png" for example
        /// </summary>
        /// <param name="button"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Uri GetResource(string path)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            return new Uri($"pack://application:,,,/{assemblyName};component/Resources/{path}", UriKind.Absolute);
        }
        /// <summary>
        /// This method already looks inside <c>/Resources/</c>, so the path only needs to be something like "icon32.png" for example
        /// </summary>
        /// <param name="button"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static BitmapImage GetImage(string path)
        {
            return new(GetResource(path));
        }
    }
}
