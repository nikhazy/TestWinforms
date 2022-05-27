using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinforms
{
    class BoolAlgebra
    {
        private static string Converter(string input)
        {
            string result = input.Replace("∧", "AND").Replace("¬", "NOT ").Replace("∨", "OR").Replace("⇒", "IMPLIES");
            return result;
        }

        public static void CheckClipboard()
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string clipboardText = Clipboard.GetText(TextDataFormat.UnicodeText);
                Clipboard.SetText(BoolAlgebra.Converter(clipboardText));
            }
        }
    }
}
