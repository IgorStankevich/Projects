using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Validators
{
    public class Validator
    {
        private void CheckIntValue(Control control)
        {
            int result;
            string chekValue = control.Text;

            if (chekValue == string.Empty || chekValue.Trim().Length == 0)
            {
                errorProviderWarn.SetError(control, "Пожалуйста введите значение поля");
            }
            else if (!Int32.TryParse(chekValue, out result))
            {
                errorProviderWarn.SetError(control, "Введите целое число");
            }
            else
            {
                errorProviderWarn.SetError(control, "");
            }
        }
    }
}
