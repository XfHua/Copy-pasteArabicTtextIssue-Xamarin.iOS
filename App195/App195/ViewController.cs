using Foundation;
using System;
using UIKit;

namespace App195
{
    public partial class ViewController : UIViewController
    {

        public UILabel myLabel;
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.


            myLabel = new UILabel();
            myLabel.Frame = new CoreGraphics.CGRect(0, 250, 200, 200);
            myLabel.Text = "myLabel";
            myLabel.Lines = 0;
            myLabel.Font = UIFont.SystemFontOfSize(16);
            View.Add(myLabel);

            UITextView myTextView = new UITextView();
            myTextView.Frame = new CoreGraphics.CGRect(0,20,200,200);
            myTextView.Text = "myTextView";
            myTextView.Font = UIFont.SystemFontOfSize(16);
            myTextView.Delegate = new myTextViewDelegate(myLabel);
            View.Add(myTextView);


            UITextView myTextView2 = new UITextView();
            myTextView2.Frame = new CoreGraphics.CGRect(200, 20, 200, 200);
            myTextView2.Text = "click me to endediting myTextView";

            View.Add(myTextView2);

            //The text that is copied is on https://r12a.github.io/scripts/tutorial/summaries/arabic under sample(arabic).
        }

        public class myTextViewDelegate : UITextViewDelegate {

            public UILabel myLabel;

            public myTextViewDelegate(UILabel label) {

                myLabel = label;
            }

            public override bool ShouldEndEditing(UITextView textView)
            {
                myLabel.Text = textView.Text;
                return true;
            }

            public override void EditingEnded(UITextView textView)
            {
                myLabel.Text = textView.Text;
            }
        }

    }
}