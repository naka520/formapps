using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace formapps
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            Form fm = new Form();
            fm.Text = "ƒTƒ“ƒvƒ‹";

            PictureBox pb = new PictureBox();
            pb.Image = Image.FromFile("C:\\Users\\yashi\\source\\repos\\Csharpebooks\\formapps\\car.bmp");
            pb.Top = pb.Top + 10;
            pb.Left = pb.Left + 10;
            pb.Parent = fm;

            Application.Run(fm);
        }
    }



}