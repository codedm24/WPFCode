﻿#pragma checksum "F:\Projects\Windows\UWPApp1\UWPApp1\FifthPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0F3B6BFDDFF191845F9951EE96E86FE3F174B13BEC5228AEC954E25EB988EB38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPApp1
{
    partial class FifthPage : 
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
            case 2: // FifthPage.xaml line 14
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3: // FifthPage.xaml line 27
                {
                    this.MediumState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // FifthPage.xaml line 40
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // FifthPage.xaml line 63
                {
                    this.buttonNavPrev = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonNavPrev).Click += this.buttonNavPrev_Click;
                }
                break;
            case 6: // FifthPage.xaml line 65
                {
                    this.buttonNavNext = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonNavNext).Click += this.buttonNavNext_Click;
                }
                break;
            case 7: // FifthPage.xaml line 67
                {
                    this.FirstNameLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // FifthPage.xaml line 68
                {
                    this.FirstNameText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // FifthPage.xaml line 69
                {
                    this.LastNameLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // FifthPage.xaml line 70
                {
                    this.LastNameText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // FifthPage.xaml line 72
                {
                    this.Image = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 12: // FifthPage.xaml line 73
                {
                    this.OptionalImage = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
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

