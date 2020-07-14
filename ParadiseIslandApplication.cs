using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    class ParadiseIslandApplication : ContestantApplication
    {

        #region Properties

        private string Gender { get; set; }
        private string NameofBoyfriendGirlfriend { get; set; }
        private int YearsDating { get; set; }

        #endregion

        #region Constructors

        public ParadiseIslandApplication(string Gender, string NameofBoyfriendGirlfriend, int YearsDating,
            string FirstName, string LastName, DateTime DateofBirth, string Address, string City, string State, 
            string Zip, string PhoneNumber, string Email) : base(FirstName, LastName, DateofBirth, Address, City, State, Zip, PhoneNumber, Email)
        {

            this.Gender = Gender;
            this.NameofBoyfriendGirlfriend = NameofBoyfriendGirlfriend;
            this.YearsDating = YearsDating;

        }

        #endregion

        #region Methods

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine($"{FirstName} {LastName}, You've been accepted to 'Paradise Island'. (*Accept() From Child Class - ParadiseIslandApplication)");

        }

        #endregion

    }
}
