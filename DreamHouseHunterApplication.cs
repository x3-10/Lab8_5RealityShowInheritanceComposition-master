using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    public class DreamHouseHunterApplication : ContestantApplication
    {

        #region Properties

        private string JobTitle { get; set; }
        private double CurrentAnnualIncome { get; set; }
        private int WhenBuyingHouseMonths { get; set; }
        private int NumberofBedrooms { get; set; }
        private int NumberofBathrooms { get; set; }

        #endregion

        #region Constructors

        public DreamHouseHunterApplication(string JobTitle, double CurrentAnnualIncome, int WhenBuyingHouseMonths, int NumberofBedrooms, int NumberofBathrooms,
            string FirstName, string LastName, DateTime DateofBirth, string Address, string City, string State, string Zip, string PhoneNumber, string Email) 
            : base (FirstName, LastName, DateofBirth, Address, City, State, Zip, PhoneNumber, Email)
        {
            
            this.JobTitle = JobTitle;
            this.CurrentAnnualIncome = CurrentAnnualIncome;
            this.WhenBuyingHouseMonths = WhenBuyingHouseMonths;
            this.NumberofBedrooms = NumberofBedrooms;
            this.NumberofBathrooms = NumberofBathrooms;

        }

        #endregion

        #region Methods

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine($"{FirstName} {LastName}, You've been accepted to 'Dream House Hunters'. (*Accept() From Child Class - DreamHouseHunterApplication)");
        }

        #endregion

    }
}
