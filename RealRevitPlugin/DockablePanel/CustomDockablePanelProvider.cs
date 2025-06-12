using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RealRevitPlugin.DockablePanel {
    public class AutoDockablePaneProvider<T> : IDockablePaneProvider where T: UserControl, new(){
        private T? _pane;
        public void SetupDockablePane(DockablePaneProviderData data) {
            _pane = new();
            data.FrameworkElement = _pane;
            data.InitialState = new DockablePaneState {
                DockPosition = DockPosition.Left,
            };
        }
    }
}
