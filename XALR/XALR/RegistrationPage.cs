using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XALR
{
    [Activity(Label = "RegistrationPage")]
    public class RegistrationPage : Activity
    {
        private EditText edtFullname, edtUsername, edtEmail, edtPassword, edtMobile;
        private Button btnCreate, btnBack;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.RegistrationPage);

            edtFullname = FindViewById<EditText>(Resource.Id.edtfullname);
            edtUsername = FindViewById<EditText>(Resource.Id.edtusername);
            edtPassword = FindViewById<EditText>(Resource.Id.edtpassword);
            edtMobile = FindViewById<EditText>(Resource.Id.edtMobile);
            btnCreate = FindViewById<Button>(Resource.Id.btnCreate);
            btnBack = FindViewById<Button>(Resource.Id.btnBack);

            btnBack.Click += delegate { StartActivity(typeof(MainActivity)); };

            btnCreate.Click += delegate
            {

            };
        }
    }
}