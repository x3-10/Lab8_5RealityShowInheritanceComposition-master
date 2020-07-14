using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    class AboveDeckApplication : ContestantApplication
    {

        #region Properties

        private int YearsBoatingExperience  { get; set; }
        private string Nationality { get; set; }

        #endregion

        #region Constructors

        public AboveDeckApplication(int YearsBoatingExperience, string Nationality, 
            string FirstName, string LastName, DateTime DateofBirth, string Address, string City, string State, 
            string Zip, string PhoneNumber, string Email) : base(FirstName, LastName, DateofBirth, Address, City, State, Zip, PhoneNumber, Email)
        {

            this.YearsBoatingExperience = YearsBoatingExperience;
            this.Nationality = Nationality;

        }

        #endregion

        #region Methods

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine($"{FirstName} {LastName}, You've been accepted to 'Above Deck'. (*Accept() From Child Class - AboveDeckApplication)");
        }

        #endregion

    }
}
