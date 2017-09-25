using System;
using Xamarin.Forms;

namespace MedicomPrototype.Controls
{
    public class PasswordCell : EntryCell
    {
		public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create("IsPassword", typeof(bool), typeof(PasswordCell), false);

		public bool IsPassword
		{
		    get { return (bool)GetValue(IsPasswordProperty); }
		    set { SetValue(IsPasswordProperty, value); }
		}

        public PasswordCell()
        {
        }
    }
    //public class PasswordCell : ViewCell
    //{
    //    public Label Label
    //    {
    //        get;
    //        set;
    //    }

    //    public Entry Entry
    //    {
    //        get;
    //        set;
    //    }

    //    public PasswordCell()
    //    {
    //        Label = new Label();
    //        Label.Text = "Password";
    //        Entry = new Entry();
    //        Entry.IsPassword = true;
    //        View = new StackLayout()
    //        {
    //            Children =
    //            {
    //                Label,
    //                Entry
    //            },
    //            Orientation = StackOrientation.Horizontal
    //        };
    //    }

    //}
}
