using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    public partial class Program
    {
        public static void Main()
        {
            InitializeComponent();
            ClickMeButton.Click += (s, e) => MessageBox.Show("Hello");
        }

        private static void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
