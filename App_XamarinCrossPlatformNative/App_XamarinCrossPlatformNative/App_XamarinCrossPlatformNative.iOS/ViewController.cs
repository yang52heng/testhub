using System;

using UIKit;
using CallKit;
namespace App_XamarinCrossPlatformNative.iOS
{
	public partial class ViewController : UIViewController
	{
		//int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


            string strTarget=string.Empty;
   
            //TranslateButton.AccessibilityIdentifier = "Identifier";
            //CallButton.AccessibilityIdentifier = "Identifier";
            CallButton.Enabled = false;



            TranslateButton.TouchUpInside += delegate {
                strTarget = TranslatePhone.ToNumberOrTranslate(EditCodeText.Text);
                if (string.IsNullOrWhiteSpace(strTarget))
                {
                    CallButton.SetTitle("Call", UIControlState.Normal);
                    CallButton.Enabled = false;
                    return;
                }
                CallButton.SetTitle("Call " + strTarget + " now?", UIControlState.Normal);
                CallButton.Enabled = true;
                //var title = string.Format ("{0} clicks!", count++);
                //bbbb1.SetTitle (title, UIControlState.Normal);
            };
            CallButton.TouchUpInside += delegate
              {
                  UIAlertController alertController;
                  UIAlertAction aAction1, aAction2;
                  Action<UIAlertAction> aActEventHandler1 = new Action<UIAlertAction>(delegate {
                      Uri uri = Uri.par;
                      CXCallController
                      Intents.
                  });
                  Action<UIAlertAction> aActEventHandler2 = new Action<UIAlertAction>(delegate { });
                  Action act= new Action(delegate { });
                  alertController = UIAlertController.Create("info","Call "+ strTarget + " now!",UIAlertControllerStyle.Alert);
                  aAction1 = UIAlertAction.Create("Call", UIAlertActionStyle.Default, aActEventHandler1);
                  aAction2 = UIAlertAction.Create("Abort", UIAlertActionStyle.Cancel, aActEventHandler2);
                  alertController.AddAction(aAction1);
                  alertController.AddAction(aAction2);
                  this.PresentViewController(alertController, false, act);
                  //var dlg = new Messages.MSMessage();
                  //dlg.Invoke
              };


            EditCodeText.AccessibilityIdentifier = "Identifier";
        }

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}

