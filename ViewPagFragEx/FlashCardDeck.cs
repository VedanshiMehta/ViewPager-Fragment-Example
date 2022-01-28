using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewPagFragEx
{
    public class FlashCard
    {
        public FlashCard(string problem, string answer)
        {
            Problem = problem;
            Answer = answer;
        }

        public string Problem { get; }
        public string Answer { get; }
    }
    class FlashCardDeck
    {

        private static string multiply = "\u00D7";
        private static string divide = "\u00F7";
        private static string plus = "\u002B";
        private static string minus = "\u2212";

        static FlashCard[] inBuiltQue = {

            new FlashCard(problem:"30" + multiply + "20", answer: "600"),
            new FlashCard(problem:"15" + divide + "5", answer: "3"),
            new FlashCard(problem:"250" + plus + "350", answer: "600"),
            new FlashCard(problem:"50" + minus + "30", answer: "20"),
        };

        public FlashCard[] myQue;

        public FlashCardDeck()
        {
            myQue = inBuiltQue;
        }

        public int NumCards
        {
            get { return myQue.Length; }
        }

        public FlashCard this[int i]
        { 
            get { return myQue[i]; }
        }
    }
}