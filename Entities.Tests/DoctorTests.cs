using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entities.Tests
{
    [TestClass]
    public class DoctorTests
    {
        [TestMethod]
        public void Entities_Doctor_Register()
        {
            var doctor = new Doctor
            {
                Id = Guid.NewGuid(),
                FirstName = "John"
            };
            doctor.Register();
        }
    }
}