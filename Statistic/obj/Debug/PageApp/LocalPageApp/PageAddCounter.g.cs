﻿#pragma checksum "..\..\..\..\PageApp\LocalPageApp\PageAddCounter.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "879AAD64EE5BE058593240F53A343D5E774BC04E3711AC405D4F046D69D6C6BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Statistic.PageApp.LocalPageApp;
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


namespace Statistic.PageApp.LocalPageApp {
    
    
    /// <summary>
    /// PageAddCounter
    /// </summary>
    public partial class PageAddCounter : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 78 "..\..\..\..\PageApp\LocalPageApp\PageAddCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTitle;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\PageApp\LocalPageApp\PageAddCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPrice;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\PageApp\LocalPageApp\PageAddCounter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbTypeCounter;
        
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
            System.Uri resourceLocater = new System.Uri("/Statistic;component/pageapp/localpageapp/pageaddcounter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageApp\LocalPageApp\PageAddCounter.xaml"
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
            this.TxtTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CmbTypeCounter = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 90 "..\..\..\..\PageApp\LocalPageApp\PageAddCounter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClEventAddMeters);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

