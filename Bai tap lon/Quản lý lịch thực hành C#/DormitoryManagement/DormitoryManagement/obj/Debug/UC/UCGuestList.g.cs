#pragma checksum "..\..\..\UC\UCGuestList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABBB46607368E79C95D0DFD024BC8E36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DormitoryManagement.UC {
    
    
    /// <summary>
    /// UCGuestList
    /// </summary>
    public partial class UCGuestList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\UC\UCGuestList.xaml"
        internal System.Windows.Controls.ListView lvGuestList;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UC\UCGuestList.xaml"
        internal System.Windows.Controls.Button btAddGuest;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UC\UCGuestList.xaml"
        internal System.Windows.Controls.Button btEditGuest;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UC\UCGuestList.xaml"
        internal System.Windows.Controls.Button btDeleteGuest;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DormitoryManagement;component/uc/ucguestlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCGuestList.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\UC\UCGuestList.xaml"
            ((DormitoryManagement.UC.UCGuestList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lvGuestList = ((System.Windows.Controls.ListView)(target));
            
            #line 14 "..\..\..\UC\UCGuestList.xaml"
            this.lvGuestList.Loaded += new System.Windows.RoutedEventHandler(this.lvGuestList_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btAddGuest = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UC\UCGuestList.xaml"
            this.btAddGuest.Click += new System.Windows.RoutedEventHandler(this.btAddGuest_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btEditGuest = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UC\UCGuestList.xaml"
            this.btEditGuest.Click += new System.Windows.RoutedEventHandler(this.btEditGuest_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btDeleteGuest = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UC\UCGuestList.xaml"
            this.btDeleteGuest.Click += new System.Windows.RoutedEventHandler(this.btDeleteGuest_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
