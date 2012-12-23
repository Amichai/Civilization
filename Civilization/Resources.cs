using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ZoomAndPanSample {
	public class Resources : Dictionary<string, int> {
		public Resources(int food, int gold, int wood, int silver, int oil = 25) {
			this.Add("Food", food);
			this.Add("Gold", gold);
			this.Add("Wood", wood);
			this.Add("Silver", silver);
			this.Add("Oil", oil);
		}
	}

	public class Attributes : Dictionary<string, int> {
		public Attributes(int hitPoints, int attack, int range, int rateOfFire, bool multifire = false, int rateOfRegeneration = 0) {
			this.Add("Hit Points", hitPoints);
			this.Add("Attack", attack);
			this.Add("Range", range);
			this.Add("Rate of fire", rateOfFire);
		}
	}

	public class Property : INotifyPropertyChanged {
		private string _type;

		public string Type {
			get { return _type; }
			set {
				_type = value;
				RaisePropertyChanged("Type");
			}
		}

		private double _amount;

		public double Amount {
			get { return _amount; }


			set {
				_amount = value;
				RaisePropertyChanged("Amount");
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
