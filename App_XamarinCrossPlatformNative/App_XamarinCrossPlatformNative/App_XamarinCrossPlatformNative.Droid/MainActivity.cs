using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace App_XamarinCrossPlatformNative.Droid
{
	[Activity (Label = "App_XamarinCrossPlatformNative.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button TranslateButton = FindViewById<Button> (Resource.Id.TRANSLATENUMBER);
            Button CallButton = FindViewById<Button>(Resource.Id.CALL);
            Button CnButton = FindViewById<Button>(Resource.Id.CNBUTTON);
            EditText PhoneNumberText = FindViewById<EditText>(Resource.Id.PHONENUMBEREDIT);
            TextView RemindInfo = FindViewById<TextView>(Resource.Id.REMINDTEXT);
            CallButton.Enabled = false;

            string strTarget = string.Empty;

            TranslateButton.Click += (object sender,EventArgs e) =>{
                strTarget = TranslatePhone.ToNumberOrTranslate(PhoneNumberText.Text);
                if (string.IsNullOrWhiteSpace(strTarget))
                {
                    CallButton.Text = "Call";
                    CallButton.Enabled = false;
                    return;
                }
                CallButton.Text = "Call " + strTarget + " now?";
                CallButton.Enabled = true;
            };
            CallButton.Click += delegate
              {
                  var alertDlg = new AlertDialog.Builder(this);
                  alertDlg.SetMessage("Intend to call " + strTarget + ", are you sure???");
                  alertDlg.SetNeutralButton("yes", delegate
                  {
                      Android.Net.Uri uri = Android.Net.Uri.Parse("tel:" + strTarget);
                      Intent intent = new Intent(Intent.ActionCall, uri);
                      StartActivity(intent);
                  }
                      );
                  alertDlg.SetNegativeButton("no", delegate { });
                  alertDlg.Show();
              };






            //java android 发短信,打电话
        //class SendMsgClickListener implements OnClickListener
        //        {
        //        public void onClick(View v)
        //        {
        //            //调用Android系统API发送短信
        //            Uri uri = Uri.parse("smsto:15800001234");
        //            Intent intent = new Intent(Intent.ACTION_SENDTO, uri);
        //            intent.putExtra("sms_body", "android...");
        //            startActivity(intent);
        //        }
        //    }

        //    //打电话
        //    class SendCallClickListener implements OnClickListener
        //    {
        //        iphone5
        //        public void onClick(View v)
        //    {
        //        //调用Android系统API打电话
        //        Uri uri = Uri.parse("tel:15800001234");
        //        Intent intent = new Intent(Intent.ACTION_CALL, uri);
        //        startActivity(intent);
        //    }
        //}
        //2. [代码]
        //最后不要忘了做这些操作是需要授权的,需要在AndroidManifest.xml中加入两行配置
        //?
        //1
        //2
        //<uses-permission android:name="android.permission.CALL_PHONE" />
        //<uses-permission android:name="android.permission.SEND_SMS"/>

        }
	}
}


