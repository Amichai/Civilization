using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ZoomAndPanSample {
	/// <summary>
	/// Interaction logic for HelpTextWindow.xaml
	/// </summary>
	public partial class WarRoom : Window {
		public WarRoom() {
			InitializeComponent();
			this.lb.ItemsSource = new Resources(5, 10, 0, 4);
			ObjectLibrary = getAllBuildOptions();
			this.BuildOptions.ItemsSource = ObjectLibrary;
			this.BuildOptions.SelectionChanged += new SelectionChangedEventHandler(BuildOptions_SelectionChanged);
		}

		void BuildOptions_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			SelectedItemIdx = (sender as ListView).SelectedIndex;
		}

		public static BoardObject GetSelectedBoardObject() {
			return WarRoom.ObjectLibrary[WarRoom.SelectedItemIdx];
		}
		public static List<BoardObject> ObjectLibrary;
		public static int SelectedItemIdx = 0;

		List<BoardObject> getAllBuildOptions() {
			List<BoardObject> buildOptions = new List<BoardObject>();
			buildOptions.Add(new BoardObject("House 1", new Resources(5, 10, 0, 4), 100, 100, Assets.House1, "Gets you lots of oil!", 
				new Attributes(10,20,30, 2)));
			buildOptions.Add(new BoardObject("House 2", new Resources(5, 10, 0, 4), 100, 100, Assets.House2, "Shoots arrows of fire",
				new Attributes(10,20,30, 2)));
			buildOptions.Add(new BoardObject("House 3", new Resources(5, 10, 0, 4), 100, 100, Assets.House3, "Generates some soldiers",
				new Attributes(10,20,30, 2)));
			return buildOptions;
		}
	}
}
