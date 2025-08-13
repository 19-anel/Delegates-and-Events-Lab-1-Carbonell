using System;

using System.Windows.Forms;


namespace AccountRegistration1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            studentInfoClass.Program = cbProg1.Text.ToString();
            studentInfoClass.FirstName = txtFirstN.Text.ToString();
            studentInfoClass.LastName = txtLastN.Text.ToString();  
            studentInfoClass.MiddleName = txtMDL.Text.ToString();
            studentInfoClass.Address =txtAddress.Text.ToString(); 

            if (long.TryParse(txtAge.Text, out long age))
            studentInfoClass.Age = age;

            if (long.TryParse(txtContNum.Text, out long contactNo))
                studentInfoClass.ContactNo = contactNo;    

           if (long.TryParse(txtStudNo1.Text, out long studentNo))
                studentInfoClass.StudentNo = studentNo;

            FrmConfirm confirmForm = new FrmConfirm();
           if (confirmForm.ShowDialog() == DialogResult.OK)
            {
                txtFirstN.Clear();
                txtLastN.Clear();
                txtMDL.Clear();
                txtAddress.Clear();
                txtAge.Clear();
                txtContNum.Clear(); 
                txtStudNo1.Clear();
                cbProg1.SelectedIndex = -1;

            }


        }
    }
}
