﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamReguester callingForm;


        public CreateTeamForm(ITeamReguester caller)
        {
            InitializeComponent();
            callingForm = caller;
           // CreateSampleData();

            WireUpLists();
        }



        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Bartek", LastName = "Pozniewski" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Arek", LastName = "Marow" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Wariusz", LastName = "Tadek" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Michal", LastName = "Zdychal" });

        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

            
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName =      firstNameValue.Text;
                p.LastName =       lastNameValue.Text;
                p.EmailAddress =   emailValue.Text;
                p.CellphoneNumber= cellPhoneValue.Text;

                p=GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text ="";
                lastNameValue.Text  ="";
                emailValue.Text     ="";
                cellPhoneValue.Text ="";


            }
            else
            {
                MessageBox.Show("Fill all the fields. ");
            }
        }

        private bool ValidateForm()
        {
            //TODO - Add validation to the form
            if (firstNameValue.Text.Length == 0) return false;
            if (lastNameValue.Text.Length == 0) return false;
            if (emailValue.Text.Length == 0) return false;
            if (cellPhoneValue.Text.Length == 0) return false;

            return true; ;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

            }

            private void removeSelectedMemberButton_Click(object sender, EventArgs e)
            {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p!=null)
            {

                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();  
            }

            }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
