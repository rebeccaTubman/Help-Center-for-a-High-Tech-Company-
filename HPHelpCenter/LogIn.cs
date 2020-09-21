using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPHelpCenter
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            String userName = this.tbUserName.Text;
            String password = this.tbPassword.Text;

            // TODO encode password (הצפנה)
            bool ok = ServiceFacade.getInstance().authenticate(userName, password);
            if (ok)
            {
                if (ServiceFacade.getInstance().isCrew())
                {
                    CrewHomePage nextPage = new CrewHomePage();
                    nextPage.Show();
                    this.Hide();
                }
                else
                {
                    if (ServiceFacade.getInstance().isProg())
                    {
                        ProgHomePage nextPage = new ProgHomePage();
                        nextPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        TechHomePage nextPage = new TechHomePage();
                        nextPage.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                this.lbError.Visible = true;
            }
        }
    }
}
