using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator
{
    public class MathCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var model= parameter as ViewModel;
            if (model!=null)
            {
                model.Result = model.Param1 / model.Param2;
                int a = 0;
                int result = 10 / a;
            }
           
        }
    }
}
