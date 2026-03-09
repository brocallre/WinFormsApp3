using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Diagnostics;
using System.Drawing;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Image _defaultBackground;
        private Image _alternateBackground;
        private bool _isAlternateBackground = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cache the two images to toggle between
            _defaultBackground = this.BackgroundImage;
            try
            {
                var rm = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                Image? alt = rm.GetObject("뚠뚠보노") as Image;
                if (alt == null)
                    alt = rm.GetObject("뚠뚠보노.Image") as Image;

                // fallback to pictureBox image if the named resource is not found
                _alternateBackground = alt ?? pictureBox1?.Image;
            }
            catch
            {
                _alternateBackground = pictureBox1?.Image;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            }
            catch { }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(200));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/brocallre/WinFormsApp3/tree/main?tab=readme-ov-file",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open link: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Toggle between the cached background images
            try
            {
                if (!_isAlternateBackground)
                {
                    if (_alternateBackground != null)
                        this.BackgroundImage = _alternateBackground;
                    _isAlternateBackground = true;
                }
                else
                {
                    this.BackgroundImage = _defaultBackground;
                    _isAlternateBackground = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지를 변경할 수 없습니다: {ex.Message}");
            }
        }
    }
}

