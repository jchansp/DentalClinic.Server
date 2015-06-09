using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entities.Tests
{
    [TestClass]
    public class PatientTests
    {
        [TestMethod]
        public void Entities_Patient_Register()
        {
            new Patient
            {
                Id = Guid.NewGuid(),
                FirstName = "John"
            }.Register();
        }
    }
}