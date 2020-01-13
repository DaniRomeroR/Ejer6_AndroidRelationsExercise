using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;

namespace Ejer6_AndroidRelations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private Button _button1;
        private Button _button2;
        private Button _button3;
        private Button _button4;
        private Button _button5;
        private Button _button6;
        private Button _button7;
        private Button _button8;
        private Button _button9;
        private EditText _editText1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            /*Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);*/

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            AddBindForLayout();
        }
        private void AddBindForLayout()
        {
            _button1 = FindViewById<Button>(Resource.Id.button1);
            _button2 = FindViewById<Button>(Resource.Id.button2);
            _button3 = FindViewById<Button>(Resource.Id.button3);
            _button4 = FindViewById<Button>(Resource.Id.button4);
            _button5 = FindViewById<Button>(Resource.Id.button5);
            _button6 = FindViewById<Button>(Resource.Id.button6);
            _button7 = FindViewById<Button>(Resource.Id.button7);
            _button8 = FindViewById<Button>(Resource.Id.button8);
            _button9 = FindViewById<Button>(Resource.Id.button9);
            _editText1 = FindViewById<EditText>(Resource.Id.editText1);

            _button1.Click += añadirTexto;
            _button2.Click += añadirTexto;
            _button3.Click += añadirTexto;
            _button4.Click += añadirTexto;
            _button5.Click += añadirTexto;
            _button6.Click += añadirTexto;
            _button7.Click += añadirTexto;
            _button8.Click += añadirTexto;
            _button9.Click += añadirTexto;
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        private void añadirTexto(object sender, EventArgs e)
        {
            Button butttonPulsado=(Button)sender;
            _editText1.Text = _editText1.Text + butttonPulsado.Text;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }
            return base.OnOptionsItemSelected(item);
        }
        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
    }
}
