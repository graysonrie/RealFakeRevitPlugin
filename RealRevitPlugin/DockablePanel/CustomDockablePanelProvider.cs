//using Autodesk.Revit.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RealRevitPlugin.DockablePanel {
//    public class CustomDockablePanelProvider : IDockablePaneProvider{
//        private CustomDockablePanel _pane;

//        public void SetupDockablePane(DockablePaneProviderData data) {
//            _pane = new();
//            data.FrameworkElement = _pane;
//            data.InitialState = new DockablePaneState {
//                DockPosition = DockPosition.Left,
//            };
//        }
//    }
//}
