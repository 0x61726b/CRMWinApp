using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMWinApp.Models;
using System.IO;
namespace CRMWinApp.UserControls
{
    public partial class RegisterCriminal : UserControl, IUserPermissionDisable
    {
        public delegate void PassUser(Criminal c);
        public PassUser passControl;
        public delegate void ControlUpdateDel(UserControl uc);
        public ControlUpdateDel PassControl;
        CRMDataModel context = new CRMDataModel();

        private Image frontImage;
        private Image leftImage;
        private Image rightImage;
        public RegisterCriminal()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Criminal newCriminal = new Criminal();

            try
            {
                if (CheckIfEmpty(nameTB))
                    return;
                newCriminal.Name = nameTB.Text;

                if (CheckIfEmpty(surnameTB))
                    return;
                newCriminal.Surname = surnameTB.Text;

                if (CheckIfEmpty(heightTB))
                    return;
                newCriminal.Height = Int32.Parse(heightTB.Text);

                if (CheckIfEmpty(weightTB))
                    return;
                newCriminal.Weight = Int32.Parse(weightTB.Text);

                newCriminal.Gender = genderCB.SelectedItem.ToString();

                if (CheckIfEmpty(hairColorTB))
                    return;
                newCriminal.HairColor = (hairColorTB.Text);

                if (CheckIfEmpty(raceTB))
                    return;
                newCriminal.Race = (raceTB.Text);

                if (CheckIfEmpty(countryTB))
                    return;
                newCriminal.Country = (countryTB.Text);

                if (CheckIfEmpty(stateTB))
                    return;
                newCriminal.State = (stateTB.Text);

                if (CheckIfEmpty(ageTB))
                    return;
                newCriminal.Age = Int32.Parse(ageTB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if( frontImage != null )
            {
                byte[] bFrontPicture = ImageToByteArray(frontImage);
                newCriminal.PictureFront = bFrontPicture;
            }
            if( leftImage != null )
            {
                byte[] bLeftPicture = ImageToByteArray(leftImage);
                newCriminal.PictureLeft = bLeftPicture;
            }

            if (rightImage != null)
            {
                byte[] bRightPicture = ImageToByteArray(rightImage);
                newCriminal.PictureRight = bRightPicture;
            }

            
            
            
            context.Criminals.Add(newCriminal);
            try
            {
                context.SaveChanges();
                MessageBox.Show("Criminal Added succesfully.");

                if (passControl != null)
                {
                    passControl(newCriminal);
                    PassControl(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                newCriminal = null;
            }

        }
        public Image ByteToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();


        }
        bool CheckIfEmpty(TextBox tb)
        {
            if (tb.Text == String.Empty)
            {
                ShowMsg();
                return true;
            }
            return false;
        }
        void ShowMsg()
        {
            MessageBox.Show("Please FILL IN THE BLANKS.");
        }

        public void Disable(List<Permission> permissions)
        {
            bool t = false;
            foreach (Permission p in permissions)
            {
                if (p.Name == "CAN_REGISTER_CRIME_CRIMINAL")
                    t = true;
            }
            groupBox1.Enabled = t;
        }

        private void photoFront_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(openFileDialog1.FileName);
                frontImage = i;
                photoFront.Image = i;
            }
        }

        private void photoLeft_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(openFileDialog1.FileName);
                leftImage = i;
                photoLeft.Image = i;
            }
        }

        private void photoRight_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(openFileDialog1.FileName);
                rightImage = i;
                photoRight.Image = i;
            }
        }
    }
}
