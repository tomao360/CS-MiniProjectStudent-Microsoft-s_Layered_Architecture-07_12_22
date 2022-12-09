using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectStudents.Entities;
using ProjectStudents.Model;

namespace ProjectStudents.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainManager.Instance.Init();
        }

        private void dataInitBtn_Click(object sender, EventArgs e)
        {
            MainManager.Instance.students.LoadStudents();
        }

        private void enterToDbBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainManager.Instance.students.InsertNewStudentToDB(int.Parse(IDTextBox.Text), NameTextBox.Text, int.Parse(AgeTextBox.Text), AddressTextBox.Text);

                IDTextBox.Text = "";
                NameTextBox.Text = "";
                AgeTextBox.Text = "";
                AddressTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Missing data, please enter all necessary details", ex.Message);
            }
        }

        private void getSudentDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = MainManager.Instance.students.GetStudentFromHashTable(int.Parse(IDTextBox.Text));

                if (student != null)
                {
                    NameTextBox.Text = student.Name;
                    AgeTextBox.Text = student.Age.ToString();
                    AddressTextBox.Text = student.Address.ToString();
                }
                else
                {
                    MessageBox.Show("There is no student with this StudentID\n Please enter another StudentID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a StudentID to get infromation about a student", ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            IDTextBox.Text = "";
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            AddressTextBox.Text = "";
        }
    }
}
