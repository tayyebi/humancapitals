using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Root : Form
    {
        public static SoundPlayer PLAYER;
        #region Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        private static Font FONT;
        #endregion

        public Root()
        {
            InitializeComponent();

            PLAYER = new SoundPlayer(Properties.Resources.BEEP);
            #region Font
            byte[] fontData = Properties.Resources.FONT;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.FONT.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.FONT.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            FONT = new Font(fonts.Families[0], 7.0F);
            #endregion
        }

        private void Root_Load(object sender, EventArgs e)
        {
            // Check if we are in design mode
            if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1
                || DesignMode)
                return;

            // Set font
            Font = FONT;

            // Set background image
            string backgroundImageFile = Directory.GetCurrentDirectory() + "\\Resources\\logo.jpg";
            pictureBox1.BackgroundImage = new Bitmap(backgroundImageFile);
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show(@"
برنامه نویس:                محمدرضا طیبی
تلفن:                  09120982276
نسخه ی برنامه:                      1.0.0.0
سایت:                        www.tyyi.net
");
                return true;    // indicate that you handled this keystroke
            }
            return false;
        }
    }
}