using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_8_20201001_LEC___Classes
{
    class Coin
    {
        private string sideUp;

        public Coin()  //Constructor
        {
            sideUp = "Head";
        }

        public void Toss()
        {
            MessageBox.Show(sideUp);
        }

        public string getSideUP()
        {
            return sideUp;
        }
    }
}
