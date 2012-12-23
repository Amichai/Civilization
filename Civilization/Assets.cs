using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace ZoomAndPanSample {
	public class Assets {
		public	static BitmapImage House1 = new BitmapImage(new Uri(@"..\..\Assets\House.png", UriKind.Relative));
		public static BitmapImage House2 = new BitmapImage(new Uri(@"..\..\Assets\House2.png", UriKind.Relative));
		public static BitmapImage House3 = new BitmapImage(new Uri(@"..\..\Assets\House3.png", UriKind.Relative));
	}
}
