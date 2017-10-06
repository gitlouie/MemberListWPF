using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MembershipListWPF
{
    public partial class AddMembershipForm : Form
    {
        public AddMembershipForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            MembershipList memList = new MembershipList();

            Member m = new Member(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text);

            memList.Save(m);
            this.Close();
        }


    }
}
