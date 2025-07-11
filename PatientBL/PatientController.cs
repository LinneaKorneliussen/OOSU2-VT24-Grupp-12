﻿using Microsoft.EntityFrameworkCore;
using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientBL
{
    public class PatientController
    {
        /// <summary>
        /// Returns a patient based on personalnumber
        /// Creates a new patient by invoking the CreateNewPatient method of the patientRepository
        /// Updates the information of a patient with the provided parameters
        /// </summary>

        private PatientRepository patientRepository;
        public PatientController()
        {
            patientRepository = new PatientRepository();
        }

        #region Patient personalnumber unique Method
        public bool IsPersonalNumberUnique(string personalNumber)
        {
           return patientRepository.IsPersonalNumberUnique(personalNumber);
        }
        #endregion

        #region Get patient Method
        public Patient GetPatient(string patientPersonalNumber)
        {
            return patientRepository.GetPatient(patientPersonalNumber);
        }
        #endregion

        #region Register new patient Method
        public void CreateNewPatient(string name, string personalNumber, string address, string phoneNumber, string emailAddress)
        {
            patientRepository.CreateNewPatient(name, personalNumber, address, phoneNumber, emailAddress);   
        }
        #endregion

        #region Update patient information Method
        public void UpdatePatientInfo(Patient patientToUpdate, int choice, string newValue)
        {
            patientRepository.UpdatePatientInfo(patientToUpdate, choice, newValue); 
        }

        #endregion
    }
}
