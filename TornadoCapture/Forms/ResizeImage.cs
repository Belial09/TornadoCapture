#region

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#endregion

namespace TornadoCapture.Forms
{
    public partial class ResizeImage : Form
    {
        internal Mainform MyForm;
        internal Image MyPicture;

        public ResizeImage()
        {
            InitializeComponent();
        }

        private void NumbersChecked(Object o, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    var myfield = (TextBox) o;
                    if (myfield.Text.Length + 1 >= 5)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void ResizeImage_Load(object sender, EventArgs e)
        {
            lblCurrentSize.Text = MyPicture.Size.Width.ToString(CultureInfo.InvariantCulture) + @" x " +
                                  MyPicture.Size.Height.ToString(CultureInfo.InvariantCulture);
            lblNewSize.Text = MyPicture.Size.Width.ToString(CultureInfo.InvariantCulture) + @" x " +
                              MyPicture.Size.Height.ToString(CultureInfo.InvariantCulture);
            txtWidthStatic.Text = MyPicture.Size.Width.ToString(CultureInfo.InvariantCulture);
            txtHeightStatic.Text = MyPicture.Size.Height.ToString(CultureInfo.InvariantCulture);
        }

        public void SetPicture(Image pic, Mainform form)
        {
            MyPicture = pic;
            MyForm = form;
        }

        private void SetRadioButton(object sender, EventArgs e)
        {
            var myButton = (RadioButton) sender;
            if (!myButton.Checked) return;
            switch (myButton.Name)
            {
                case "rbtStatic":
                    rbtPercent.Checked = false;
                    txtPercentHeight.Enabled = false;
                    txtPercentWidth.Enabled = false;
                    txtHeightStatic.Enabled = true;
                    txtWidthStatic.Enabled = true;
                    break;
                case "rbtPercent":
                    rbtStatic.Checked = false;
                    txtHeightStatic.Enabled = false;
                    txtWidthStatic.Enabled = false;
                    txtPercentHeight.Enabled = true;
                    txtPercentWidth.Enabled = true;
                    break;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdResize_Click(object sender, EventArgs e)
        {
            var newSize = new Size();

            if (rbtStatic.Checked)
            {
                newSize = new Size(Convert.ToInt32(txtWidthStatic.Text), Convert.ToInt32(txtHeightStatic.Text));
            }
            else if (rbtPercent.Checked)
            {
                var width = Convert.ToDouble(Convert.ToDouble(MyPicture.Size.Width)/100);
                width = width*Convert.ToDouble(txtPercentWidth.Text);
                width = Math.Round(width);

                var height = Convert.ToDouble(Convert.ToDouble(MyPicture.Size.Height)/100);
                height = height*Convert.ToDouble(txtPercentHeight.Text);
                height = Math.Round(height);
                newSize = new Size(Convert.ToInt32(width), Convert.ToInt32(height));
            }
            Image newImage = ImageManipulation.ResizeImage(MyForm.pictureBox1.Image, newSize);
            if (newImage != null)
            {
                MyForm.pictureBox1.Image = newImage;
            }
            else
            {
                MessageBox.Show(@"TornadoCapture v3", @"Error Resizing Image! Maybe new Image is too big!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbtStatic.Checked)
            {
                lblNewSize.Text = txtWidthStatic.Text.ToString(CultureInfo.InvariantCulture) + @" x " +
                                  txtHeightStatic.Text.ToString(CultureInfo.InvariantCulture);
            }
            else if (rbtPercent.Checked)
            {
                var width = Convert.ToDouble(Convert.ToDouble(MyPicture.Size.Width)/100);
                width = width*Convert.ToDouble(txtPercentWidth.Text);
                width = Math.Round(width);

                var height = Convert.ToDouble(Convert.ToDouble(MyPicture.Size.Height)/100);
                height = height*Convert.ToDouble(txtPercentHeight.Text);
                height = Math.Round(height);

                lblNewSize.Text = width.ToString(CultureInfo.InvariantCulture);
                lblNewSize.Text += @" x ";
                lblNewSize.Text += height.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}