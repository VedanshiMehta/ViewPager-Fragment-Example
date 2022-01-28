using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using AndroidX.Fragment.App;
using AndroidX.ViewPager.Widget;

namespace ViewPagFragEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity :FragmentActivity
    {
        private ViewPager myViewPager;
        private FlashCardDeck flashcard;
        private FlashCardAdapter flashCardAdapter;

        [System.Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            myViewPager = FindViewById<ViewPager>(Resource.Id.myVp);
            flashcard = new FlashCardDeck();

            flashCardAdapter = new FlashCardAdapter(SupportFragmentManager,flashcard);
            myViewPager.Adapter = flashCardAdapter;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}