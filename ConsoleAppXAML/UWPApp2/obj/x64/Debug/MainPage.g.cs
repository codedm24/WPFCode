﻿#pragma checksum "F:\Projects\Windows\ConsoleAppXAML\UWPApp2\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "363DDBEB289D21D5489F200B61B26D31EF7D0251440C5865062A87F4E26637A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPApp2
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.dep1 = (global::UWPApp2.MyDependencyObject)(target);
                }
                break;
            case 3: // MainPage.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element3).Tapped += this.Grid_Tapped;
                }
                break;
            case 4: // MainPage.xaml line 68
                {
                    this.stackPanelDependencyPropertyCheck = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // MainPage.xaml line 74
                {
                    this.stackPanelAttachedProperty = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 6: // MainPage.xaml line 75
                {
                    this.buttonAttachedProperty1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonAttachedProperty1).Click += this.buttonAttachedProperty_Click;
                }
                break;
            case 7: // MainPage.xaml line 76
                {
                    this.buttonAttachedProperty = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonAttachedProperty).Click += this.buttonAttachedProperty_Click;
                }
                break;
            case 8: // MainPage.xaml line 77
                {
                    this.list1 = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 9: // MainPage.xaml line 69
                {
                    this.slider1 = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 10: // MainPage.xaml line 71
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // MainPage.xaml line 66
                {
                    this.textStatus = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // MainPage.xaml line 47
                {
                    this.CheckStopRouting = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 13: // MainPage.xaml line 48
                {
                    this.button3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button3).Tapped += this.button3_Tapped;
                }
                break;
            case 14: // MainPage.xaml line 58
                {
                    this.buttonCleanStatus = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonCleanStatus).Click += this.buttonCleanStatus_Click;
                }
                break;
            case 15: // MainPage.xaml line 39
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2).Click += this.button1_Click;
                }
                break;
            case 16: // MainPage.xaml line 35
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
