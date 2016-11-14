using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ViewModel:INotifyPropertyChanged
    {
        public ViewModel()
        {
            ButtonClick = new MathCommand();
        }
        public double Param1 { get; set; }
        public double Param2 { get; set; }
        //public double Result { get; set; }
        private double _Result;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Result
        {
            get { return _Result; }
            set { _Result = value;
                if (PropertyChanged!=null)
                {
                    PropertyChanged(this,new PropertyChangedEventArgs("Result"));
                }
            }
        }

        public MathCommand ButtonClick { get; set; }
    }
}
