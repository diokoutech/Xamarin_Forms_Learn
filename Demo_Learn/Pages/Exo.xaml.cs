using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_Learn.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exo : ContentPage
	{
		public List<string> ExoList { get; set; } = new List<string>
		{
            "Lorem Ipsum is simply dummy text of the printing and typesetting",
            "Lorem Ipsum is simply dummy text of the printing and typesetting",
            "Lorem Ipsum is simply dummy text of the printing and typesetting",
            "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
			"Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
			"when an unknown printer took a galley of type and scrambled it to make a type "
        };
		public Exo ()
		{
			InitializeComponent ();
			this. slider.Value = 10;
			this.textShow.Text = getTexteRandom();
		}
		public string getTexteRandom()
		{
			return ExoList[new Random().Next(0, ExoList.Count)];
		}
		public void ChangeText(object sender, EventArgs args)
		{
			this.textShow.Text = getTexteRandom();
		}

    }
}