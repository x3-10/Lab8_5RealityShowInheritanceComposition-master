using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityShowInheritanceComposition
{
    class HackersApp: ContestantApplication
    {
        #region Properties
        //private string FirstName { get; set; }
        //private string LastName { get; set; }

        private int CodingYearsExperience { get; set; }
        private string Handle { get; set; }
        private int CodeathonWins { get; set; }

        #endregion

        #region Constructors

        public HackersApp( int CodingYearsExperience,
            string Handle, int CodethonWins, string FirstName, string LastName, DateTime DateofBirth, 
            string Address, string City, string State, string Zip, string PhoneNumber, string Email)
            : base(FirstName, LastName, DateofBirth, Address, City, State, Zip, PhoneNumber, Email)
        {

            this.CodingYearsExperience = CodingYearsExperience;
            this.Handle = Handle;
            this.CodeathonWins = CodeathonWins;

        }

        #endregion

        #region Methods

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine($"{FirstName} {LastName} a.k.a. {Handle}, You've been accepted to 'Hackers'. (*Accept() From Child Class - ParadiseIslandApplication)");

        }
        
        public void comment()
        {
            Console.WriteLine($"Contestant {FirstName} {LastName} a.k.a {Handle} logged into the website, there seemed to be a system outage for the network.");
        }
        #endregion
    }
}
