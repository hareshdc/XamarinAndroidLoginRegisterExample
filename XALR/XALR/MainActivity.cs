using Android.App;
using Android.Widget;
using Android.OS;
using Client.DB_Helper;
using Android.Database.Sqlite;

namespace XALR
{
    [Activity(Label = "XALR", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private EditText txtUsername, txtPassword;
        private Button btnSignIn, btnCreate;
        Helper helper;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            txtUsername = FindViewById<EditText>(Resource.Id.txtusername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtpassword);
            btnCreate = FindViewById<Button>(Resource.Id.btnSignUp);
            btnSignIn = FindViewById<Button>(Resource.Id.btnSign);
            helper = new Helper(this);

            btnCreate.Click += delegate { StartActivity(typeof(RegistrationPage)); };

            btnSignIn.Click += delegate
            {
                try
                {
                    string Username = txtUsername.Text.ToString();
                    string Password = txtPassword.Text.ToString();
                    var user = helper.Authenticate(this, new Admin(null, Username, null, null, Password, null));

                    if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Username))
                    {
                        Toast.MakeText(this, "Username and Password should not be empty.", ToastLength.Short).Show();
                    }
                    
                    if (user != null)
                    {
                        Toast.MakeText(this, "Login Successful", ToastLength.Short).Show();

                    }
                    else
                    {
                        Toast.MakeText(this, "Login Unsuccessful! Please verify your Username and Password", ToastLength.Short).Show();
                    }
                }
                catch (SQLiteException ex)
                {
                    Toast.MakeText(this, "" + ex, ToastLength.Short).Show();
                }

            };
        }
    }
}

