using System;
using Xamarin.Forms;

namespace TadweerMediaCenter
{
	public class App
	{
		public static Page GetMainPage ()
		{	

				
			ContentPage profilePage = new ContentPage {
				Title = "Profile",
				//Icon = "Profile.png",
				Content = new StackLayout {
					Spacing = 20, Padding = 50,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Entry { Placeholder = "Username" },
						new Entry { Placeholder = "Password", IsPassword = true },
						new Button {
							Text = "Login",
							TextColor = Color.White,
							BackgroundColor = Color.FromHex("77D065") }}}
			};

			ContentPage settingsPage = new ContentPage {
				Title = "Settings",
				Content=new StackLayout{
					Children={
						new Label{
							Text="Settings",
							VerticalOptions=LayoutOptions.CenterAndExpand,
							HorizontalOptions=LayoutOptions.CenterAndExpand,
						}
					}
				}

			};
			CarouselPage pages = new CarouselPage {
				//IsBusy=true,    //this add progressBar to ActionBar
				Children={ settingsPage, profilePage },

			};

			ToolbarItem firstItem = new ToolbarItem {

				Name = "Profile",
				Order = ToolbarItemOrder.Primary,
			};

			ToolbarItem SecondItem = new ToolbarItem {
				Name = "Settings",
				Order = ToolbarItemOrder.Primary,
			};
			pages.CurrentPage = settingsPage;
			firstItem.Activated += (sender, e) => {
				pages.CurrentPage=profilePage;

			};
			SecondItem.Activated +=(sender, e) => {
				pages.CurrentPage =settingsPage;

			};
			pages.ToolbarItems.Add (firstItem);
			pages.ToolbarItems.Add (SecondItem);

			//TabbedPage tabbedPages = new TabbedPage {
			//
			//	Children={profilePage,settingsPage},
			//
			//};

			NavigationPage nav = new NavigationPage (pages);


			return nav;



		}
	}
}




 

