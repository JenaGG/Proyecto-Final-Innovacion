#pragma checksum "..\..\InterfazPrincipal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92F01984ED4EFD31BCE94623E115B1A7CB7A4BCB6AE5AFD6C6EADF6F5A8CDC83"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using AsistenteVirtualSTABLE;
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


namespace AsistenteVirtualSTABLE {
    
    
    /// <summary>
    /// InterfazPrincipal
    /// </summary>
    public partial class InterfazPrincipal : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AsistenteVirtualSTABLE.InterfazPrincipal window;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Rectangle_BackTrans;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle rec_onoff;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_pantalla;
        
        #line default
        #line hidden
        
        
        #line 277 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar pb_Audio;
        
        #line default
        #line hidden
        
        
        #line 287 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_NomAsisstant;
        
        #line default
        #line hidden
        
        
        #line 288 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnComando;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRecordatorio;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAlarma;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\InterfazPrincipal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSerial_Port;
        
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
            System.Uri resourceLocater = new System.Uri("/AsistenteVirtual;component/interfazprincipal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InterfazPrincipal.xaml"
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
            this.window = ((AsistenteVirtualSTABLE.InterfazPrincipal)(target));
            
            #line 8 "..\..\InterfazPrincipal.xaml"
            this.window.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\InterfazPrincipal.xaml"
            this.window.Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            
            #line 8 "..\..\InterfazPrincipal.xaml"
            this.window.Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Rectangle_BackTrans = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.rec_onoff = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.lbl_pantalla = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.pb_Audio = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 277 "..\..\InterfazPrincipal.xaml"
            this.pb_Audio.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.pb_Audio_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_NomAsisstant = ((System.Windows.Controls.Button)(target));
            
            #line 287 "..\..\InterfazPrincipal.xaml"
            this.Btn_NomAsisstant.Click += new System.Windows.RoutedEventHandler(this.Btn_NomAsisstant_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnComando = ((System.Windows.Controls.Button)(target));
            
            #line 288 "..\..\InterfazPrincipal.xaml"
            this.BtnComando.Click += new System.Windows.RoutedEventHandler(this.BtnComando_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnRecordatorio = ((System.Windows.Controls.Button)(target));
            
            #line 289 "..\..\InterfazPrincipal.xaml"
            this.BtnRecordatorio.Click += new System.Windows.RoutedEventHandler(this.BtnRecordatorio_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnAlarma = ((System.Windows.Controls.Button)(target));
            
            #line 291 "..\..\InterfazPrincipal.xaml"
            this.BtnAlarma.Click += new System.Windows.RoutedEventHandler(this.BtnAlarma_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnSerial_Port = ((System.Windows.Controls.Button)(target));
            
            #line 292 "..\..\InterfazPrincipal.xaml"
            this.BtnSerial_Port.Click += new System.Windows.RoutedEventHandler(this.BtnSerial_Port_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

