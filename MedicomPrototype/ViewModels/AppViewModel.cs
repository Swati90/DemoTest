using System;
using System.Collections.ObjectModel;
using MedicomPrototype.Models;

namespace MedicomPrototype.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
		public ObservableCollection<Patient> Patients { get; set; }
        public ObservableCollection<PatientDisease> Diseases { get; set; }
        public ObservableCollection<PatientContact> Contacts { get; set; }
        public ObservableCollection<HealthCareProfessional> HCPs { get; set; }
        public ObservableCollection<PatientConditionViewModel> Conditions { get; set; }

		public AppViewModel()
        {
            Patients = new ObservableCollection<Patient>();
            Diseases = new ObservableCollection<PatientDisease>();
            Contacts = new ObservableCollection<PatientContact>();
            HCPs = new ObservableCollection<HealthCareProfessional>();
            Conditions = new ObservableCollection<PatientConditionViewModel>();
        }

        public void Initialize()
        {
            //Initializing with dummy data
            //TODO: Actual initialization logic to be implemented

			Patients.Add(new Patient()
			{
				Id = "1",
				FirstName = "Nick",
				LastName = "Wright",
				EmailId = "nickwright@gmail.com"
			});

			Diseases.Add(new PatientDisease()
			{
				Id = "1",
				PatientId = "1",
				DiseaseId = "1",
				DiseaseName = "Anaphylaxis"
			});

			Diseases.Add(new PatientDisease()
			{
				Id = "2",
				PatientId = "1",
				DiseaseId = "2",
				DiseaseName = "Atopic Dermatitis"
			});

            Diseases.Add(new PatientDisease()
			{
				Id = "3",
				PatientId = "1",
				DiseaseId = "3",
				DiseaseName = "Latex Allergy"
			});
			
            Contacts.Add(new PatientContact()
            {
                Id = "1",
				PatientId = "1",
		        ContactId = "1",
		        FirstName = "Steve",
		        LastName = "Wright",
		        PhoneNumber = "1234567890",
		        EmailId = "stevewright@gmail.com",
		        Relationship = "Father"
            });

            HCPs.Add(new HealthCareProfessional()
            {
                Id = "1",
                PatientId = "1",
                FirstName = "Marlon",
                LastName = "Samuels",
                EmailId = "marlonsamuels@gmail.com",
                CanShareInformation = true
            });

            Conditions.Add(new PatientConditionViewModel()
            {
                Id = "1",
                DiseaseId = "1",
                DiseaseName = "Anaphylaxis",
                IsPresent = true
            });

			Conditions.Add(new PatientConditionViewModel()
			{
                Id = "2",
                DiseaseId = "2",
                DiseaseName = "Atopic Dermatitis",
                IsPresent = false
			});

			Conditions.Add(new PatientConditionViewModel()
            {
                Id = "3",
                DiseaseId = "3",
                DiseaseName = "Latex Allergy",
                IsPresent = false
			});
		}
    }
}
