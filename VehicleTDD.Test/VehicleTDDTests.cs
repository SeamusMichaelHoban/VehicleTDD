using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTDD.Test
{
    [TestFixture]
    public class VehicleTDDTest
    {
        [Test]
        public void VehicleTDD_Ctor()
        {
            var vehicle = new Vehicle(" "); //Arrange

            var result = vehicle.GetName; //Act

            Assert.That(result, Is.EqualTo(" ")); //Assert
        }
        //[Test]
        //public void VehicleTDD_DefaultCtor()
        //{
        //    var vehicle = new Vehicle("DefaultCtor"); //Arrange

        //    var result = vehicle.GetName; //Act

        //    Assert.That(result, Is.EqualTo("DefaultCtor")); //Assert
        //}





    }
















}

