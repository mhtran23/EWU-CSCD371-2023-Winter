using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests
{
    [TestClass]
    public class SampleDataTests
    {

        SampleData data = new SampleData();

        [TestMethod]
        public void CsvRows_NotNull()
        {
            Assert.IsNotNull(data.CsvRows);
        }

        [TestMethod]
        public void Csv_SkipFirstRow()
        {
            IEnumerable<string> row = data.CsvRows;
            Assert.AreEqual(50, row.Count());
        }

        [TestMethod]
        public void GetUniqueSortedStates_IsEqual()
        {
            List<string> peoplesAddress = data.GetUniqueSortedListOfStatesGivenCsvRows().ToList();
            List<string> spokaneAddress = data.CsvRows.ToList();
            spokaneAddress.Add(",,,,990, 11114 E Sprague AV, Spokane, WA, 99206");
            spokaneAddress.Add(",,,,819 W Riverside Ave, Spokane, WA, 99201");
            List<string> addresses = data.GetUniqueSortedListOfStatesGivenCsvRows().ToList();
            Assert.IsTrue(peoplesAddress.SequenceEqual(addresses));
        }

        [TestMethod]
        public void GetAggregateSortedListOfStatesUsingCsvRows_ToStringSuccess()
        {
            string tempString = "AL,AZ,CA,DC,FL,GA,IN,KS,LA,MD,MN,MO,MT,NC,NE,NH,NV,NY,OR,PA,SC,TN,TX,UT,VA,WA,WV";
            string actualString = data.GetAggregateSortedListOfStatesUsingCsvRows();
            Assert.IsTrue(tempString.Equals(actualString));
        }

        [TestMethod]
        public void CreateAddress_NotNull()
        {
            Assert.IsNotNull(data.People.First().Address);
        }

        [TestMethod]
        public void CreatePeople_NotNull()
        {
            Assert.IsNotNull(data.People);
        }

        [TestMethod]
        public void EmailAddress_ReturnFirstLastName()
        {
            Predicate<string> sorting = email;
            static bool email(string email) => email.Contains("pjenyns0@state.gov");
            IEnumerable<(string, string)> result = data.FilterByEmailAddress(sorting);

            var name = ("Priscilla", "Jenyns");
            Assert.AreEqual(name, (result.First().Item1, result.First().Item2));
        }
    }
}
