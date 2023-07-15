using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Support.V4.App;
using System;

namespace MPLAndroidVersion
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText tp, rs, rag, tag, tfm;
        TextView result;
        Button btnc;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            tp = FindViewById<EditText>(Resource.Id.editText1);
            rs = FindViewById<EditText>(Resource.Id.editText2);
            rag = FindViewById<EditText>(Resource.Id.editText3);
            tag = FindViewById<EditText>(Resource.Id.editText4);
            tfm = FindViewById<EditText>(Resource.Id.editText5);
            result = FindViewById<TextView>(Resource.Id.textView1);
            btnc = FindViewById<Button>(Resource.Id.button1);

            btnc.Click += Btnc_Click;
        }

        private void Btnc_Click(object sender, EventArgs e)
        {
            double TP = Double.Parse(tp.Text);
            double RS = Double.Parse(rs.Text);
            double RAG = Double.Parse(rag.Text);
            double TAG = Double.Parse(tag.Text);
            double TFM = Double.Parse(tfm.Text);
            double g = RAG + TAG;
            double mpl = TP - RS + g - TFM;
            result.Text = Convert.ToString(mpl);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}