// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace App_XamarinCrossPlatformNative.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CallButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CnTestButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EditCodeText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TranslateButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CallButton != null) {
                CallButton.Dispose ();
                CallButton = null;
            }

            if (CnTestButton != null) {
                CnTestButton.Dispose ();
                CnTestButton = null;
            }

            if (EditCodeText != null) {
                EditCodeText.Dispose ();
                EditCodeText = null;
            }

            if (TranslateButton != null) {
                TranslateButton.Dispose ();
                TranslateButton = null;
            }
        }
    }
}