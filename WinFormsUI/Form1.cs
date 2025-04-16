using BusinessLayer;
using ServiceLayer;
using System.ComponentModel;

namespace WinFormsUI
{
    public partial class Form1 : Form
    {
        private AthleteService athleteService;
        private RunService runService;
        BindingList<Athlete> athleteList = new BindingList<Athlete>();
        public Form1()
        {
            InitializeComponent();
            runService = new RunService();
            athleteService = new AthleteService();
            InitializeAthletesComboBox();
            athletesGridView.DataSource = athleteList;
            CustomizeGridView();
        }
        private void CustomizeGridView()
        {
            athletesGridView.AutoGenerateColumns = true;
            athletesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            athletesGridView.MultiSelect = false;
            athletesGridView.ReadOnly = true;
            athletesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            athletesGridView.AllowUserToResizeColumns = false;
            athletesGridView.AllowUserToResizeRows = false;
            athletesGridView.AllowUserToAddRows = false;
            athletesGridView.AllowUserToDeleteRows = false;
            athletesGridView.ReadOnly = true;

            athletesGridView.Columns["Id"].Visible = false;
            athletesGridView.Columns["Notes"].Visible = false;
            athletesGridView.Columns["Gender"].Visible = false;
            athletesGridView.Columns["FullName"].Visible = false;
            athletesGridView.Columns["FirstName"].HeaderText = "First Name";
            athletesGridView.Columns["LastName"].HeaderText = "Last Name";
            athletesGridView.Columns["DateOfBirth"].HeaderText = "Birthdate";
            athletesGridView.Columns["Club"].HeaderText = "Club";
        }

        private void InitializeAthletesComboBox()
        {
            athleteList.Clear();

            foreach (var athlete in athleteService.GetAthletes())
            {
                athleteList.Add(athlete);
            }

            athletesComboBox.DataSource = athleteList;
            athletesComboBox.DisplayMember = "FullName";
            athletesComboBox.ValueMember = "Id";
            athletesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
                var newAthlete = athleteService.AddAthlete(firstName, lastName, dateOfBirth, gender, club, notes);
                athleteList.Add(newAthlete);
                errorMessageLabel.Text = "";

                MessageBox.Show("Successfully added an athlete!");
            }
            else
            {
                errorMessageLabel.Text = "Please fill out the required fields!";
            }
        }

        private void editAthleteButton_Click(object sender, EventArgs e)
        {
            if (athletesGridView.SelectedRows.Count > 0)
            {
                var selectedAthlete = (Athlete)athletesGridView.SelectedRows[0].DataBoundItem;

                EditAthleteForm editForm = new EditAthleteForm(selectedAthlete);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    athleteService.UpdateAthlete(selectedAthlete.Id, selectedAthlete.FirstName, selectedAthlete.LastName, selectedAthlete.DateOfBirth, selectedAthlete.Gender, selectedAthlete.Club, selectedAthlete.Notes); // ако имаш метод в ServiceLayer
                    athletesGridView.Refresh(); 
                }
            }
        }

        private void deleteAthleteButton_Click(object sender, EventArgs e)
        {
            if (athletesGridView.SelectedRows.Count > 0)
            {
                var selected = (Athlete)athletesGridView.SelectedRows[0].DataBoundItem;
                var confirm = MessageBox.Show($"Delete {selected.FullName}?", "Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    athleteList.Remove(selected);
                    athleteService.DeleteAthlete(selected.Id);
                    
                }
            }
        }
    }
}
