#pragma checksum "..\..\..\Controls\ucNotebookTitle.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1E55BEDE972E71997F0FA726F046E5A7ADEA1FACC5E707789703E8046C56DBE3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Shell;


namespace OP.Notes.Controls {
    
    
    /// <summary>
    /// ucNotebookTitle
    /// </summary>
    public partial class ucNotebookTitle : System.Windows.Controls.ListBoxItem, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Controls\ucNotebookTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel itemNotebook;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Controls\ucNotebookTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitle;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\ucNotebookTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblModified;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\ucNotebookTitle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDelete;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OP.Notes;component/controls/ucnotebooktitle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\ucNotebookTitle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.itemNotebook = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.txtTitle = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\Controls\ucNotebookTitle.xaml"
            this.txtTitle.SelectionChanged += new System.Windows.RoutedEventHandler(this.txtTitle_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Controls\ucNotebookTitle.xaml"
            this.txtTitle.GotFocus += new System.Windows.RoutedEventHandler(this.txtTitle_GotFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Controls\ucNotebookTitle.xaml"
            this.txtTitle.LostFocus += new System.Windows.RoutedEventHandler(this.txtTitle_LostFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Controls\ucNotebookTitle.xaml"
            this.txtTitle.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtTitle_KeyUp);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Controls\ucNotebookTitle.xaml"
            this.txtTitle.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.txtTitle_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblModified = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.imgDelete = ((System.Windows.Controls.Image)(target));
            
            #line 12 "..\..\..\Controls\ucNotebookTitle.xaml"
            this.imgDelete.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.imgDelete_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

