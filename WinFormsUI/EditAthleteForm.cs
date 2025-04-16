using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class EditAthleteForm : Form
    {
        private Athlete athlete;

        public EditAthleteForm(Athlete athleteToEdit)
        {
            InitializeComponent();
            athlete = athleteToEdit;
            FillForm();
        }

        private void FillForm()
        {
            firstNameTextBox.Text = athlete.FirstName;
            lastNameTextBox.Text = athlete.LastName;
            clubNameTextBox.Text = athlete.Club;
            notesTextBox.Text = athlete.Notes;
            dateBirthDatePicker.Value = (DateTime)athlete.DateOfBirth;

            if (athlete.Gender == "male")
                maleRadioButton.Checked = true;
            else if (athlete.Gender == "female")
                femaleRadioButton.Checked = true;
        }

        private void addathleteButton_Click(object sender, EventArgs e)
        {
            athlete.FirstName = firstNameTextBox.Text;
            athlete.LastName = lastNameTextBox.Text;
            athlete.Club = clubNameTextBox.Text;
            athlete.Notes = notesTextBox.Text;
            athlete.DateOfBirth = dateBirthDatePicker.Value;
            athlete.Gender = maleRadioButton.Checked ? "male" : "female";

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
