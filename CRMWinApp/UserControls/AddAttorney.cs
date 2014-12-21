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
    public partial class AddAttorney : UserControl
    {
        private Attorney selectedAttorney;
        private Image img;

        private CRMDataModel context = new CRMDataModel();
        public AddAttorney()
        {
            InitializeComponent();
        }

        private void AddAttorney_Load(object sender, EventArgs e)
        {
            if( selectedAttorney == null )
            {
                //Adding

                
            }
            else
            {
                //Editing
                nameTB.Text = selectedAttorney.Name;
                surnameTB.Text = selectedAttorney.Surname;
                ageTB.Text = selectedAttorney.Age.ToString();
                graduateSchoolTB.Text = selectedAttorney.GraduateSchool;
                pictureBox1.Image = ByteToImage(selectedAttorney.Picture);


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            if (selectedAttorney == null)
            {
                Attorney att = new Attorney();
                att.Name = nameTB.Text;
                att.Surname = surnameTB.Text;
                att.Age = Int32.Parse(ageTB.Text);
                att.GraduateSchool = graduateSchoolTB.Text;
                if (img != null)
                    att.Picture = ImageToByteArray(img);
                try
                {
                    context.Attorneys.Add(att);
                    context.SaveChanges();
                    MessageBox.Show("Added succesfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                selectedAttorney.Name = nameTB.Text;
                selectedAttorney.Surname = surnameTB.Text;
                selectedAttorney.Age = Int32.Parse(ageTB.Text);
                selectedAttorney.GraduateSchool = graduateSchoolTB.Text;
                if (img != null)
                    selectedAttorney.Picture = ImageToByteArray(img);

                try
                {
                    context.Entry(context.Attorneys.Where(a => a.Id == selectedAttorney.Id)).CurrentValues.SetValues(selectedAttorney);
                    context.SaveChanges();
                    MessageBox.Show("Attorney updated.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void findAtt_Click(object sender, EventArgs e)
        {
            Forms.FindAtt fa = new Forms.FindAtt();
            fa.PassAttorney = new Forms.FindAtt.SendAttorneyBackDel(SetAttorney);
            fa.Show();
        }
        void SetAttorney( Attorney a )
        {
            selectedAttorney = a;
            AddAttorney_Load(null, null);
        }
    }
}
