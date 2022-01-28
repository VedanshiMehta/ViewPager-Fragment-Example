
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewPagFragEx
{
    class FlashCardAdapter : FragmentPagerAdapter
    {
        FlashCardDeck flashCard;

        [Obsolete]
        public FlashCardAdapter(FragmentManager fm, FlashCardDeck flashCard) : base(fm) => this.flashCard = flashCard;

        public override int Count { get { return flashCard.NumCards; } }

        public override Fragment GetItem(int position)
        {
            return (Fragment)
            FlashCardFragment.newInstance(flashCard[position].Problem, flashCard[position].Answer);
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String("Problem" + (position+1));
        }
    }
}