﻿#pragma checksum "C:\AMB\aSoftware\aCore\aPowerBox\aPowerIdea\View\MapLab.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9ECC1B4F6EA7D82AF38E319BACBBCC85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aPowerIdea.View
{
    partial class MapLab : 
        global::Albert.Flex.Runtime.Page10x, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.map = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 2:
                {
                    this.cmb = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 23 "..\..\..\View\MapLab.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cmb).SelectionChanged += this.cmb_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnFind = (global::Albert.Flex.Runtime.PushButton)(target);
                    #line 32 "..\..\..\View\MapLab.xaml"
                    ((global::Albert.Flex.Runtime.PushButton)this.btnFind).Click += this.btnFind_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

