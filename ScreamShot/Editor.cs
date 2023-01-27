using System.Drawing.Imaging;

namespace ScreamShot
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            this.Hide();
            Bitmap captureBitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);

            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

            Graphics captureGraphics = Graphics.FromImage(captureBitmap);

            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
            this.BackgroundImage = captureBitmap;
            this.Show();
        }

        private void Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Editor_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}