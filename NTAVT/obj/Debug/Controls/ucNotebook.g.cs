#pragma checksum "..\..\..\Controls\ucNotebook.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "03642B5C53F971F09CF19F7171C7213DEC624B276CFA9F809318AFB2915F991A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OP.Notes.Controls;
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
    /// ucNotebook
    /// </summary>
    public partial class ucNotebook : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OP.Notes.Controls.ucNotebook mySelf;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbTags;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem liAll;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem liTodo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgClearFilter;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilterNotes;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OP.Notes.Controls.ExtScrollViewer scrollNotes;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Controls\ucNotebook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlNotes;
        
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
            System.Uri resourceLocater = new System.Uri("/OP.Notes;component/controls/ucnotebook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\ucNotebook.xaml"
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
            this.mySelf = ((OP.Notes.Controls.ucNotebook)(target));
            return;
            case 2:
            this.lbTags = ((System.Windows.Controls.ListBox)(target));
            
            #line 11 "..\..\..\Controls\ucNotebook.xaml"
            this.lbTags.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbTags_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.liAll = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 4:
            this.liTodo = ((System.Windows.Controls.ListBoxItem)(target));
            return;
            case 5:
            this.imgClearFilter = ((System.Windows.Controls.Image)(target));
            
            #line 18 "..\..\..\Controls\ucNotebook.xaml"
            this.imgClearFilter.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.imgClearFilter_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtFilterNotes = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Controls\ucNotebook.xaml"
            this.txtFilterNotes.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtFilterNotes_KeyUp);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\Controls\ucNotebook.xaml"
            this.txtFilterNotes.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtFilterNotes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.scrollNotes = ((OP.Notes.Controls.ExtScrollViewer)(target));
            return;
            case 8:
            this.pnlNotes = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

