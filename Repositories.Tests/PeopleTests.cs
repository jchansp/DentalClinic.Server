using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repositories.Tests
{
    [TestClass]
    public class PeopleTests
    {
        [TestMethod]
        public void Repositories_People_Retrieve()
        {
            var people = People.Retrieve();
        }

        [TestMethod]
        public void Repositories_People_Persist()
        {
            var person = new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "John"
            };
            People.Persist(person);
        }
    }
}