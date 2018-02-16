using System;
using System.Windows.Forms;

namespace TodoistNetTest.Forms
{
    public partial class ApiTokenInputBox : Form
    {
        public string ApiToken { get; set; }

        public ApiTokenInputBox()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ApiToken = textBoxApiToken.Text;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ApiToken = null;
            Close();
        }
    }
}