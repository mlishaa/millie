using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session6
{
    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
        }

        private void FormTest2_Load(object sender, EventArgs e)
        {
            cmbboxCountries.DropDownHeight = 120;
            cmbboxCountries.DropDownWidth = 60;

            cmbboxCountries.Items.Add("Canada");
            cmbboxCountries.Items.Add("USA");

           // Bitmap bitmap = new Bitmap(@"C:\projects\testImg.jpg");
          //  pictureBox1.Image = (Image)bitmap;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CheckState state = checkboxTest.CheckState;

            //if(state == CheckState.Checked)
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Check the checkbox");
            //}

            if (checkboxTest.Checked)
            {
                MessageBox.Show("you checked it ");
            }
        }

        private void checkboxTest_CheckedChanged(object sender, EventArgs e)
        {           
            MessageBox.Show(checkboxTest.Checked.ToString());
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            cmbboxCountries.DropDownHeight = 120;
            cmbboxCountries.DropDownWidth = 60;

            if(cmbboxCountries.Items.Count == 0)
            {
                cmbboxCountries.Items.Add("QC");
                cmbboxCountries.Items.Add("ON");
                cmbboxCountries.Items.Add("BC");

            }

            
        }

        private void cmbboxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbboxStates.Items.Clear();
            
            //CANADA
            if (cmbboxCountries.SelectedItem.ToString().ToUpper() == "CANADA")
            {
                cmbboxStates.Items.Add("QC");
                cmbboxStates.Items.Add("ON");
                cmbboxStates.Items.Add("BC");
                cmbboxStates.Items.Add("MB");              
            }

            //USA
            if (cmbboxCountries.SelectedIndex == 1)
            {
                cmbboxStates.Items.Add("DC");
                cmbboxStates.Items.Add("Florida");
                cmbboxStates.Items.Add("Coloroda");
                cmbboxStates.Items.Add("California");
            }
            

            
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            string value = datePicker.Text;
            MessageBox.Show(value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown1.Value.ToString());
        }

        private void btnCheckRbtn_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            string lang = string.Empty;

            //since they are in groupbox 1 either one of them is checked
            if (rbtnF.Checked)
            {
                gender = "female";
            }
            if (rbtnM.Checked)
            {
                gender = "male";
            }
            if (rbtnN.Checked)
            {
                gender = "neutral";
            }

            //since they are in groupbox 1 either one of them is checked
            if (rbtnEng.Checked)
            {
                lang = "Eng";
            }
            if (rbtnFrench.Checked)
            {
                lang = "French";
            }

            MessageBox.Show(gender + " talks in " + lang);
        }

        private void btnProgressBar_Click(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            progressBar1.MarqueeAnimationSpeed = 100000; 

            for (int i=0; i<2000000; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void btnFillTree_Click(object sender, EventArgs e)
        {
            TreeNode nodeRoot = treeView1.Nodes[0];
            TreeNodeCollection Childnodes =  nodeRoot.Nodes;
            int index = 0;
            foreach(TreeNode node in Childnodes)
            {
                node.Nodes.Add("child "+ index.ToString());
                index++;
            }
            //MessageBox.Show(nodeRoot.Nodes.Count.ToString());
        }
        
          private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.Filter = "Text|*.txt|All|*.*";
            DialogResult result = dialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                MessageBox.Show(fileName);
            }
        }
    }
}
