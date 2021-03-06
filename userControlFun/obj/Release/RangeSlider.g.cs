﻿#pragma checksum "..\..\RangeSlider.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD5B8CEBD98D862CB7815F30CDE235B38DB58C4C9B9DCFD71510B31E2DD8F6F8"
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
using System.Windows.Interactivity;
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
using UserControlFun.Fun;


namespace UserControlFun {
    
    
    /// <summary>
    /// RangeSlider
    /// </summary>
    public partial class RangeSlider : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\RangeSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal UserControlFun.RangeSlider root;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\RangeSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid sliderGrid;
        
        #line default
        #line hidden
        
        
        #line 287 "..\..\RangeSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\RangeSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider LowerSlider;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\RangeSlider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider UpperSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/Testproject;component/rangeslider.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RangeSlider.xaml"
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
            this.root = ((UserControlFun.RangeSlider)(target));
            return;
            case 2:
            this.sliderGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 284 "..\..\RangeSlider.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Input.FocusManager.LostFocusEvent, new System.Windows.RoutedEventHandler(this.LowerValueTextBox_LostFocus));
            
            #line default
            #line hidden
            
            #line 285 "..\..\RangeSlider.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.border = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.LowerSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 292 "..\..\RangeSlider.xaml"
            this.LowerSlider.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.LowerSlider_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 296 "..\..\RangeSlider.xaml"
            this.LowerSlider.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.LowerSlider_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UpperSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 308 "..\..\RangeSlider.xaml"
            this.UpperSlider.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.UpperSlider_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 311 "..\..\RangeSlider.xaml"
            this.UpperSlider.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.UpperSlider_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 324 "..\..\RangeSlider.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 325 "..\..\RangeSlider.xaml"
            ((System.Windows.Controls.TextBox)(target)).AddHandler(System.Windows.Input.FocusManager.LostFocusEvent, new System.Windows.RoutedEventHandler(this.HigherValueTextBox_LostFocus));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

