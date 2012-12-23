using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Timers;

namespace ZoomAndPanSample {
	public class BoardObject : INotifyPropertyChanged {
		public BoardObject() {
			IsSelected = false;
			this.TargetsInRange = new List<Point>();
		}

		Timer timer;

		public BoardObject(string name, Resources cost, int width, int height, BitmapImage bi, string info, Attributes attributes)
			: this() {
			this.Name = name;
			this.Cost = cost;
			this.Width = width;
			this.Height = height;
			this.Source = bi;
			this.Info = info;
			this.Attributes = attributes;
			timer = new Timer();
			timer.Interval = TimeSpan.FromSeconds(1.0 / attributes["Rate of fire"]).TotalMilliseconds;
			timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
			timer.Start();
		}

		void ShootAt(Point p) {
			throw new NotImplementedException();
		}

		void timer_Elapsed(object sender, ElapsedEventArgs e) {
			if (TargetsInRange != null && TargetsInRange.Count() > 0) {
				ShootAt(TargetsInRange.First());
			}
		}

		private Attributes _attributes;

		public Attributes Attributes {
			get { return _attributes; }
			set { _attributes = value; }
		}
		

		/// other properties include: 
		/// Health, hit-points, defense, attack, range and regeneration, rate of fire

		private bool _isSelected;

		public bool IsSelected {
			get { return _isSelected; }
			set {
				_isSelected = value;
				RaisePropertyChanged("IsSelected");
			}
		}

		private List<Point> _targetsInRange;

		public List<Point> TargetsInRange {
			get { return _targetsInRange; }
			set {
				_targetsInRange = value;
			}
		}
		


		public BoardObject(int x, int y, int width, int height, BitmapImage bi)
			: this() {
			this.X = x;
			this.Y = y;
			this.Width = width;
			this.Height = height;
			this.Source = bi;
		}
		private int _width;

		public int Width {
			get { return _width; }
			set {
				_width = value;
				RaisePropertyChanged("Width");
			}
		}

		private int _height;

		public int Height {
			get { return _height; }
			set {
				_height = value;
				RaisePropertyChanged("Height");
			}
		}

		private double _x;

		public double X {
			get { return _x; }
			set {
				_x = value;
				RaisePropertyChanged("X");
			}
		}

		private double _y;

		public double Y {
			get { return _y; }
			set {
				_y = value;
				RaisePropertyChanged("Y");

			}
		}


		private BitmapImage _source;

		public BitmapImage Source {
			get { return _source; }
			set {
				_source = value;
				RaisePropertyChanged("Source");
			}
		}

		private Resources _cost;

		public Resources Cost {
			get { return _cost; }
			set {
				_cost = value;
				RaisePropertyChanged("Cost");
			}
		}


		private string _name;

		public string Name {
			get { return _name; }
			set {
				_name = value;
				RaisePropertyChanged("Name");
			}
		}

		private string _info;

		public string Info {
			get { return _info; }
			set {
				_info = value;
				RaisePropertyChanged("Info");
			}
		}



		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;
		protected void RaisePropertyChanged(string name) {
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}

		#endregion
	}
}
