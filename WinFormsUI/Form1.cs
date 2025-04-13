using BusinessLayer;
using ServiceLayer;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        private AthleteService athleteService;
        private RunService runService;
        public Form1()
        {
            InitializeComponent();
            runService = new RunService();
            athleteService = new AthleteService();

        }

        private void addathleteButton_Click(object sender, EventArgs e)
        {
            bool filled = true;
            Athlete athlete = new Athlete();
            string firstName = firstNameTextBox.Text;
            if (String.IsNullOrEmpty(firstName))
            {
                filled = false;
            }
            string lastName = lastNameTextBox.Text;
            if (String.IsNullOrEmpty(lastName))
            {
                filled = false;
            }
            DateTime dateOfBirth = dateBirthDatePicker.Value;
            string gender = null;

            if (maleRadioButton.Checked)
            {
                gender = "male";
            }
            else if (femaleRadioButton.Checked)
            {
                gender = "female";
            }
            else
            {
                filled = false;
            }


            string club = clubNameTextBox.Text;
            string notes = notesTextBox.Text;
            if (filled)
            {
                athleteService.AddAthlete(firstName, lastName, dateOfBirth, gender, club, notes);
                errorMessageLabel.Text = "";

                MessageBox.Show("Successfully added an athlete!");
            }
            else
            {
                errorMessageLabel.Text = "Please fill out the required fields!";
            }
        }
    }
}
