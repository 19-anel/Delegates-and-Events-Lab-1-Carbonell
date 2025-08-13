using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration1
{
    public partial class FrmConfirm : Form
    {   
        private studentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private studentInfoClass.DelegateNumber DelAge, DelContactNo, DelStudentNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new studentInfoClass.DelegateText(studentInfoClass.GetProgram);
            DelLastName = new studentInfoClass.DelegateText(studentInfoClass.GetLastName);
            DelFirstName = new studentInfoClass.DelegateText(studentInfoClass.GetFirstName);
            DelMiddleName = new studentInfoClass.DelegateText(studentInfoClass.GetMiddleName);
            DelAddress = new studentInfoClass.DelegateText(studentInfoClass.GetAddress);
            DelAge = new studentInfoClass.DelegateNumber(studentInfoClass.GetAge);
            DelContactNo = new studentInfoClass.DelegateNumber(studentInfoClass.GetContactNo);
            DelStudentNo = new studentInfoClass.DelegateNumber(studentInfoClass.GetStudentNo);

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblProgram.Text = DelProgram(studentInfoClass.Program);
            lblLastName.Text = DelLastName(studentInfoClass.LastName);
            lblFirstName.Text = DelFirstName(studentInfoClass.FirstName);
            lblMiddleName.Text = DelMiddleName(studentInfoClass.MiddleName);
            lblAddress2.Text = DelAddress(studentInfoClass.Address);
            lblAGE.Text = DelAge(studentInfoClass.Age).ToString();
            lblContactNo.Text = DelContactNo(studentInfoClass.ContactNo).ToString();
            lblStudentNo.Text = DelStudentNo(studentInfoClass.StudentNo).ToString();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
