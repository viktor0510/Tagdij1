using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tagdij1
{
    static class Program
    {
        public static Taguj taguj = null;
        public static Tagmodositas tagmodositas = null;
        public static Befizetesuj befizetesuj = null;
        public static Befizeteslekerdezese befizeteslekerdezese = null;
        public static Form1 nyito = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            taguj = new Taguj();
            tagmodositas = new Tagmodositas();
            befizetesuj = new Befizetesuj();
            befizeteslekerdezese = new Befizeteslekerdezese();
            nyito = new Form1();
            Application.Run(nyito);
        }
    }
}
