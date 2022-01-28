
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewPagFragEx
{
    class FlashCardFragment : Fragment
    {
        private static string FLASH_CARD_QUESTION = "card_question";
        private static string FLASH_CARD_ANSWER = "card_answer";
        TextView questionBox;

        public FlashCardFragment() { }

        public static FlashCardFragment newInstance(String question, String answer)
        {
            FlashCardFragment fragment = new FlashCardFragment();

            Bundle args = new Bundle();
            args.PutString(FLASH_CARD_QUESTION, question);
            args.PutString(FLASH_CARD_ANSWER, answer);
            fragment.Arguments = args;
            return fragment;
        }
        public override View OnCreateView(
            LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            string question = Arguments. GetString(FLASH_CARD_QUESTION,"");
            string answer = Arguments.GetString(FLASH_CARD_ANSWER,"");

            View view = inflater.Inflate(Resource.Layout.FlashCardDeckFragmentL, container, false);
            questionBox = (TextView)view.FindViewById(Resource.Id.flash_card_question);
            questionBox.Text = question;

            questionBox.Click += delegate
            {
                Toast.MakeText(Activity.ApplicationContext,"Answer:" + answer,ToastLength.Short).Show();
            };

            return view;
            
           
            
        }

        

    }
}