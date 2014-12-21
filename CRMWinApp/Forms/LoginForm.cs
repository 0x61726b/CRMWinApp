using SharpDX.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMWinApp.Forms
{
    public partial class LoginForm :Form
    {
        CRMDataModel context = new CRMDataModel();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string pass = textBox2.Text;

            if (userName == String.Empty || pass == String.Empty)
            {
                MessageBox.Show("Please enter your user name or password.");
            }
            else
            {
                var q = context.Users.SingleOrDefault(linq => linq.Name == userName && linq.Pass == pass);
                if (q != null)
                {
                    MainForm mf = new MainForm();

                    mf.SetUser((Models.User)q);

                    mf.Show();

                    this.Hide();

                    RenderLoop.RenderCallback callback = new RenderLoop.RenderCallback(mf.Render);
                    RenderLoop.Run(mf, () =>
                        {
                            mf.Render();
                        }
                    );

                }
                else
                {
                    MessageBox.Show("User name or password you entered is wrong.Please try again.");
                }
            }


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            string userName = "arkenthera";
            string pass = "1234567";

            if (userName == String.Empty || pass == String.Empty)
            {
                MessageBox.Show("Please enter your user name or password.");
            }
            else
            {
                var q = context.Users.SingleOrDefault(linq => linq.Name == userName && linq.Pass == pass);
                if (q != null)
                {
                    MainForm mf = new MainForm();

                    mf.SetUser((Models.User)q);

                    mf.Show();

                    this.Hide();

                    RenderLoop.RenderCallback callback = new RenderLoop.RenderCallback(mf.Render);
                    RenderLoop.Run(mf, () =>
                        {
                            mf.Render();
                        }
                    );

                }
                else
                {
                    MessageBox.Show("User name or password you entered is wrong.Please try again.");
                }
            }

        }
    }
}
