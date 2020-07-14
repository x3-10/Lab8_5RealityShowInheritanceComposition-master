using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{

    public class ContestantApplication
    {

        #region Properties

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime DateofBirth { get; set; }
        protected string Address { get; set; }
        protected string City { get; set; }
        protected string State { get; set; }
        protected string Zip { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Email { get; set; }
        protected bool ApplicationSubmitted { get; set; }
        protected bool ApplicationAccepted { get; set; }

        #endregion

        #region Constructors
        public ContestantApplication(string FirstName, string LastName, DateTime DateofBirth, 
            string Address, string City, string State, string Zip, string PhoneNumber, string Email) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateofBirth = DateofBirth;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        } 
        #endregion

        #region Methods

        public void Submit()
        {
            Console.WriteLine($"The application for {FirstName} {LastName} has been submitted.");
            ApplicationSubmitted = true;
        }

        // Virtual Methods like Accept can be overridden by any class that inherits this class as a base class.
        public virtual void Accept()
        {
            Console.WriteLine($"The application for {FirstName} {LastName} has been accepted. (*Accept() From Base Class - ContestantApplication)");
            ApplicationAccepted = true;
        }

        #endregion

    }

}
