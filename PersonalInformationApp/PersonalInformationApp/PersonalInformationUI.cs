using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationUI : Form
    {
        public PersonalInformationUI()
        {
            InitializeComponent();
        }


        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string phoneNumber = "";
        private string dateOfBirth = "";
        private string nationalIdNumber = "";
        private string gender = "";
        private string fatherName = "";
        private string motherName = "";
        private string meritialStatus = "";
        private string religion = "";
        private string nationality = "";
        private string address = "";

        private string schoolName = "";
        private string collegeName = "";
        private string universityName = "";
        private string sscGpa = "";
        private string hscGpa = "";
        private string univercityGpa = "";




        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            email = emailTextBox.Text;
            phoneNumber = phoneNumberTextBox.Text;
            dateOfBirth = dateOfBirthTextBox.Text;
            nationalIdNumber = nationalIdNumberTextBox.Text;
            gender = genderTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            meritialStatus = maritialStatusTextBox.Text;
            religion = religionTextBox.Text;
            nationality = nationalityTextBox.Text;
            address = addressTextBox.Text;

            schoolName = schoolNameTextBox.Text;
            collegeName = collegeNameTextBox.Text;
            universityName = universityNameTextBox.Text;
            sscGpa = sscGpaTextBox.Text;
            hscGpa = hscGpaTextBox.Text;
            univercityGpa = universityGpaTextBox.Text;

            MessageBox.Show(@"All information save successfully!");

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            dateOfBirthTextBox.Text = "";
            nationalIdNumberTextBox.Text = "";
            genderTextBox.Text = "";
            fatherNameTextBox.Text = "";
            motherNameTextBox.Text = "";
            maritialStatusTextBox.Text = "";
            religionTextBox.Text = "";
            nationalityTextBox.Text = "";
            addressTextBox.Text = "";

            schoolNameTextBox.Text = "";
            collegeNameTextBox.Text = "";
            universityNameTextBox.Text = "";
            sscGpaTextBox.Text = "";
            hscGpaTextBox.Text = "";
            universityGpaTextBox.Text = "";


        }

        private void fullNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your First name: " + firstName + "\nLast name: " + lastName);
        }

        private void parentNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your parent's name: " + fatherName + " and " + motherName);
        }

        private void allResultButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your School name is: " + schoolName + @" and your cgpa is: " + sscGpa + "\n" +
                @"Your College name is: " + collegeName + @" and your cgpa is: " + hscGpa + "\n" +
                @"Your University name is: " + universityName + @" and your cgpa is: " + univercityGpa);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(address);
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Your name is: " + firstName + " " + lastName + "\n" +
                @"Your email address is: " + email + "\n" + @"Your phone number is:"+ phoneNumber + "\n"
                    + @"Your date of birth is: " + dateOfBirth + "\nyou are: " + gender + "\n" +
                    @"Your national id number is: " + nationalIdNumber + "\n" + @"Your parent's name: " + fatherName + @" and " + motherName + "\n" + @"You are: " + meritialStatus + "\nYou are: " + religion + "\nYour nationality: " + nationality + "\n" + @"Your address: " + address + "\n"+ @"Your School name is: " + schoolName + @" and your cgpa is: " + sscGpa + "\n" +
                @"Your College name is: " + collegeName + @" and your cgpa is: " + hscGpa + "\n" +
                @"Your University name is: " + universityName + @" and your cgpa is: " + univercityGpa
                               
                
                );
        }
    }
}
