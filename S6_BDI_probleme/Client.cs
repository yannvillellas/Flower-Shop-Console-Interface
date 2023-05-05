﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6_BDI_probleme
{
    internal class Client
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string password;
        private string loyalty = "none";
        private bool admin = false;
        private int billingAddressID = 0;
        public Client(string firstName, string lastName, string phoneNumber, string email, string password, int billingAddressID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.password = password;
            this.billingAddressID = billingAddressID;
        }
        public Client(string email)
        {
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
            this.email = email;
            this.password = "";
        }
        public Client()
        {
            this.firstName = "";
            this.lastName = "";
            this.phoneNumber = "";
            this.email = "";
            this.password = "";
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Loyalty
        {
            get => loyalty;
            set => loyalty = value;
        }
        
        public bool Admin
        {
            get => admin;
            set => admin = value;
        }

        public int BillingAddressID
        {
            get => billingAddressID;
            set => billingAddressID = value;
        }

        public override string ToString()
        {
            return "Client{" +
                   "firstName='" + firstName + '\'' +
                   ", lastName='" + lastName + '\'' +
                   ", phoneNumber='" + phoneNumber + '\'' +
                   ", email='" + email + '\'' +
                   ", password='" + password + '\'' +
                   ", billingAddressID='" + billingAddressID + '\'' +
                   ", loyalty='" + loyalty + '\'' +
                   '}';
        }
    }
}
