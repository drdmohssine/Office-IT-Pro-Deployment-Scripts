﻿#pragma checksum "..\..\..\..\Views\GenerateView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8C9270E83CFADE0C63F67783AE5102EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.XmlBrowser;
using MetroDemo.ExampleViews;
using Microsoft.OfficeProPlus.InstallGen.Presentation.ValueConverter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfAnimatedGif;


namespace MetroDemo.ExampleViews {
    
    
    /// <summary>
    /// GenerateView
    /// </summary>
    public partial class GenerateView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Product;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition PublisherRow;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition SpacerRow;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProductInfo;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton InstallMsi;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton InstallExecutable;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignInstallerInfo;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SignInstaller;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenCertificateBrowser;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenCertGenerator;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Publisher;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VersionInfoGen;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown MajorVersion;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown MinorVersion;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.NumericUpDown ReleaseVersion;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SilentInstallInfo;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ToggleSwitch SilentInstall;
        
        #line default
        #line hidden
        
        
        #line 247 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilePathGen;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FileSavePath;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenExeFolderButton;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmbedOfficeInstall;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IncludeBuild;
        
        #line default
        #line hidden
        
        
        #line 295 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SourceFilePath;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SourceFilePathGen;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SourcePathLabel;
        
        #line default
        #line hidden
        
        
        #line 316 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BuildFilePath;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrowseSourcePathButton;
        
        #line default
        #line hidden
        
        
        #line 325 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenFolderButton;
        
        #line default
        #line hidden
        
        
        #line 333 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image WaitImage;
        
        #line default
        #line hidden
        
        
        #line 350 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousButton;
        
        #line default
        #line hidden
        
        
        #line 351 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GenerateButton;
        
        #line default
        #line hidden
        
        
        #line 365 "..\..\..\..\Views\GenerateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.XmlBrowser.XmlBrowserControl xmlBrowser;
        
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
            System.Uri resourceLocater = new System.Uri("/OfficeProPlusInstallToolkit;component/views/generateview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\GenerateView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 9 "..\..\..\..\Views\GenerateView.xaml"
            ((MetroDemo.ExampleViews.GenerateView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.GenerateView_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Product = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MainTabControl = ((MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl)(target));
            return;
            case 4:
            this.PublisherRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 5:
            this.SpacerRow = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 6:
            this.ProductInfo = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Views\GenerateView.xaml"
            this.ProductInfo.Click += new System.Windows.RoutedEventHandler(this.ProductInfo_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.InstallMsi = ((System.Windows.Controls.RadioButton)(target));
            
            #line 82 "..\..\..\..\Views\GenerateView.xaml"
            this.InstallMsi.Checked += new System.Windows.RoutedEventHandler(this.InstallExecutable_OnChecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.InstallExecutable = ((System.Windows.Controls.RadioButton)(target));
            
            #line 86 "..\..\..\..\Views\GenerateView.xaml"
            this.InstallExecutable.Checked += new System.Windows.RoutedEventHandler(this.InstallExecutable_OnChecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SignInstallerInfo = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\..\..\Views\GenerateView.xaml"
            this.SignInstallerInfo.Click += new System.Windows.RoutedEventHandler(this.SignInstallerInfo_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SignInstaller = ((System.Windows.Controls.CheckBox)(target));
            
            #line 123 "..\..\..\..\Views\GenerateView.xaml"
            this.SignInstaller.Checked += new System.Windows.RoutedEventHandler(this.SignWithCert_OnCheck);
            
            #line default
            #line hidden
            
            #line 123 "..\..\..\..\Views\GenerateView.xaml"
            this.SignInstaller.Unchecked += new System.Windows.RoutedEventHandler(this.SignWithCert_OnCheck);
            
            #line default
            #line hidden
            return;
            case 11:
            this.OpenCertificateBrowser = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\..\Views\GenerateView.xaml"
            this.OpenCertificateBrowser.Click += new System.Windows.RoutedEventHandler(this.OpenCertificateBrowser_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.OpenCertGenerator = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\..\Views\GenerateView.xaml"
            this.OpenCertGenerator.Click += new System.Windows.RoutedEventHandler(this.OpenCertGenerator_OnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Publisher = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.VersionInfoGen = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\..\..\Views\GenerateView.xaml"
            this.VersionInfoGen.Click += new System.Windows.RoutedEventHandler(this.VersionInfoGen_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.MajorVersion = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 16:
            this.MinorVersion = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 17:
            this.ReleaseVersion = ((MahApps.Metro.Controls.NumericUpDown)(target));
            return;
            case 18:
            this.SilentInstallInfo = ((System.Windows.Controls.Button)(target));
            
            #line 222 "..\..\..\..\Views\GenerateView.xaml"
            this.SilentInstallInfo.Click += new System.Windows.RoutedEventHandler(this.SilentInstallInfo_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.SilentInstall = ((MahApps.Metro.Controls.ToggleSwitch)(target));
            
            #line 231 "..\..\..\..\Views\GenerateView.xaml"
            this.SilentInstall.Checked += new System.EventHandler<System.Windows.RoutedEventArgs>(this.SilentInstall_OnChecked);
            
            #line default
            #line hidden
            
            #line 231 "..\..\..\..\Views\GenerateView.xaml"
            this.SilentInstall.Unchecked += new System.EventHandler<System.Windows.RoutedEventArgs>(this.SilentInstall_OnChecked);
            
            #line default
            #line hidden
            return;
            case 20:
            this.FilePathGen = ((System.Windows.Controls.Button)(target));
            
            #line 248 "..\..\..\..\Views\GenerateView.xaml"
            this.FilePathGen.Click += new System.Windows.RoutedEventHandler(this.FilePathGen_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.FileSavePath = ((System.Windows.Controls.TextBox)(target));
            
            #line 256 "..\..\..\..\Views\GenerateView.xaml"
            this.FileSavePath.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FileSavePath_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 22:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 259 "..\..\..\..\Views\GenerateView.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.OpenExeFolderButton = ((System.Windows.Controls.Button)(target));
            
            #line 260 "..\..\..\..\Views\GenerateView.xaml"
            this.OpenExeFolderButton.Click += new System.Windows.RoutedEventHandler(this.OpenExeFolderButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 24:
            this.EmbedOfficeInstall = ((System.Windows.Controls.Button)(target));
            
            #line 282 "..\..\..\..\Views\GenerateView.xaml"
            this.EmbedOfficeInstall.Click += new System.Windows.RoutedEventHandler(this.ProductInfo_OnClick);
            
            #line default
            #line hidden
            return;
            case 25:
            this.IncludeBuild = ((System.Windows.Controls.CheckBox)(target));
            
            #line 290 "..\..\..\..\Views\GenerateView.xaml"
            this.IncludeBuild.Checked += new System.Windows.RoutedEventHandler(this.IncludeBuild_OnChecked);
            
            #line default
            #line hidden
            
            #line 290 "..\..\..\..\Views\GenerateView.xaml"
            this.IncludeBuild.Unchecked += new System.Windows.RoutedEventHandler(this.IncludeBuild_OnChecked);
            
            #line default
            #line hidden
            return;
            case 26:
            this.SourceFilePath = ((System.Windows.Controls.Grid)(target));
            return;
            case 27:
            this.SourceFilePathGen = ((System.Windows.Controls.Button)(target));
            
            #line 308 "..\..\..\..\Views\GenerateView.xaml"
            this.SourceFilePathGen.Click += new System.Windows.RoutedEventHandler(this.SourceFilePathGen_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            this.SourcePathLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.BuildFilePath = ((System.Windows.Controls.TextBox)(target));
            
            #line 319 "..\..\..\..\Views\GenerateView.xaml"
            this.BuildFilePath.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BuildFilePath_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 30:
            this.BrowseSourcePathButton = ((System.Windows.Controls.Button)(target));
            
            #line 323 "..\..\..\..\Views\GenerateView.xaml"
            this.BrowseSourcePathButton.Click += new System.Windows.RoutedEventHandler(this.BrowseSourcePathButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 31:
            this.OpenFolderButton = ((System.Windows.Controls.Button)(target));
            
            #line 325 "..\..\..\..\Views\GenerateView.xaml"
            this.OpenFolderButton.Click += new System.Windows.RoutedEventHandler(this.OpenFolderButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 32:
            this.WaitImage = ((System.Windows.Controls.Image)(target));
            return;
            case 33:
            this.PreviousButton = ((System.Windows.Controls.Button)(target));
            
            #line 350 "..\..\..\..\Views\GenerateView.xaml"
            this.PreviousButton.Click += new System.Windows.RoutedEventHandler(this.PreviousButton_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            this.GenerateButton = ((System.Windows.Controls.Button)(target));
            
            #line 351 "..\..\..\..\Views\GenerateView.xaml"
            this.GenerateButton.Click += new System.Windows.RoutedEventHandler(this.GenerateButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 35:
            this.xmlBrowser = ((MahApps.Metro.Controls.XmlBrowser.XmlBrowserControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

