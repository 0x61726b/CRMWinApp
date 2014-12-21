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
    public partial class EditCriminal : UserControl, IUserPermissionDisable
    {
        private Models.Criminal selectedCriminal;

        private Image frontImage;
        private Image leftImage;
        private Image rightImage;
        private Image noImage;

        CRMDataModel context = new CRMDataModel();
        public EditCriminal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditCriminal_Load(object sender, EventArgs e)
        {
            if (selectedCriminal != null)
            {
                nameTB.Text = selectedCriminal.Name;
                surnameTB.Text = selectedCriminal.Surname;
                hairColorTB.Text = selectedCriminal.HairColor;
                raceTB.Text = selectedCriminal.Race;
                heightTB.Text = selectedCriminal.Height.ToString();
                weightTB.Text = selectedCriminal.Weight.ToString();
                genderCB.SelectedItem = selectedCriminal.Gender;

                countryTB.Text = selectedCriminal.Country;
                stateTB.Text = selectedCriminal.State;

                noImage = Image.FromFile("..\\..\\Textures\\nophoto.jpg");

                CheckIfImageExist(selectedCriminal.PictureFront, photoFront);

                CheckIfImageExist(selectedCriminal.PictureLeft, photoLeft);

                CheckIfImageExist(selectedCriminal.PictureRight, photoRight);


            }
            else
            {
                MessageBox.Show("Invalid Criminal.");
            }
        }
        void CheckIfImageExist(byte[] i, PictureBox b)
        {
            if (i == null)
            {
                b.Image = noImage;
            }
            else if (i.Length > 0)
            {
                b.Image = ByteToImage(i);
            }
        }
        public Image ByteToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        void DisableControls(bool t)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = t;
            }
        }

        public void Disable(List<Permission> permissions)
        {
            DisableControls(false);
            foreach (Permission p in permissions)
            {
                if (p.Name == "CAN_UPDATE_CRIMINAL_CRIME")
                {
                    DisableControls(true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty(nameTB))
                return;
            selectedCriminal.Name = nameTB.Text;

            if (CheckIfEmpty(surnameTB))
                return;
            selectedCriminal.Surname = surnameTB.Text;

            if (CheckIfEmpty(heightTB))
                return;
            selectedCriminal.Height = Int32.Parse(heightTB.Text);

            if (CheckIfEmpty(weightTB))
                return;
            selectedCriminal.Weight = Int32.Parse(weightTB.Text);

            selectedCriminal.Gender = genderCB.SelectedItem.ToString();

            if (CheckIfEmpty(hairColorTB))
                return;
            selectedCriminal.HairColor = (hairColorTB.Text);

            if (CheckIfEmpty(raceTB))
                return;
            selectedCriminal.Race = (raceTB.Text);

            if (CheckIfEmpty(countryTB))
                return;
            selectedCriminal.Country = (countryTB.Text);

            if (CheckIfEmpty(stateTB))
                return;
            selectedCriminal.State = (stateTB.Text);

            if (frontImage != null)
            {
                byte[] bFrontPicture = ImageToByteArray(frontImage);
                selectedCriminal.PictureFront = bFrontPicture;
            }
            if (leftImage != null)
            {
                byte[] bLeftPicture = ImageToByteArray(leftImage);
                selectedCriminal.PictureLeft = bLeftPicture;
            }
            if (rightImage != null)
            {
                byte[] bRightPicture = ImageToByteArray(rightImage);
                selectedCriminal.PictureRight = bRightPicture;
            }

            try
            {

                context.Entry(context.Criminals.Where(x => x.Id == selectedCriminal.Id).FirstOrDefault()).CurrentValues.SetValues(selectedCriminal);


                context.SaveChanges();
                MessageBox.Show("Criminal Updated succesfully.");


            }
            catch (Exception ex)
            {
                MessageBox.Show("U SCREWED UP LULZ " + ex.Message);
            }
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
                return true;
            }
            return false;
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
