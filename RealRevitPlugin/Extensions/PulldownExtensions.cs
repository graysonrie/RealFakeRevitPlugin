using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RealRevitPlugin.Extensions {
    public static class PulldownExtensions {
        public static PulldownButton AddCommand<TCommand>(this PulldownButton button, string name, string? largeImage = null) where TCommand : IExternalCommand, new() {
            var command = typeof(TCommand);
            var pushButtonData = new PushButtonData(command.FullName, name, Assembly.GetAssembly(command).Location, command.FullName);
            var pushButton = button.AddPushButton(pushButtonData);
            if (largeImage is not null) {
                pushButton.LargeImage = ResourceAccessor.GetImage(largeImage);
            }
            return button;
        }
        /// <summary>
        /// Sets the optional small image for this button. Should ideally be 16x16
        /// </summary>
        /// <param name="button"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static PulldownButton SetImage(this PulldownButton button, string path) {
            button.Image = ResourceAccessor.GetImage(path);
            return button;
        }
        /// <summary>
        /// Sets the large image for this button. Should ideally be 32x32
        /// </summary>
        /// <param name="button"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static PulldownButton SetLargeImage(this PulldownButton button, string path) {
            button.LargeImage = ResourceAccessor.GetImage(path);
            return button;
        }

    }
}
