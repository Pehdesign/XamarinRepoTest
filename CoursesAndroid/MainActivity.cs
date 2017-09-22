using Android.App;
using Android.Widget;
using Android.OS;

namespace CoursesAndroid
{
    [Activity(Label = "CoursesAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        TextView textDesc;
        ImageView imageCourse;
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            textDesc = FindViewById<TextView>(Resource.Id.textDesc);
            imageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;  
        }

        private void ButtonNext_Click(object sender, System.EventArgs e)
        {
            imageCourse.SetImageResource(Resource.Drawable.img3);
            textTitle.Text = "Next Clicked";
            textDesc.Text = "The description that appears when Next is clicked";
        }

        private void ButtonPrev_Click(object sender, System.EventArgs e)
        {
            imageCourse.SetImageResource(Resource.Drawable.img1);
            textTitle.Text = "Prev Clicked";
            textDesc.Text = "The description that appears when Prev is clicked";
        }
    }
}

