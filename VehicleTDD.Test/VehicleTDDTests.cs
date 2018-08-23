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
    {//Seamus Hoban
        [Test]
        public void Create_Veh_CTR_1_Input()
        {
            var vehicle = new Vehicle(); //Arrange

            var result = vehicle.GetName = " "; //Act

            Assert.That(result, Is.EqualTo(" ")); //Assert
        }
        //[Test]
        //public void Create_Veh_CTR_2_Input()
        //{
        //    var vehicle = new Vehicle("Make", "Model"); //Arrange

        //    var result = vehicle.GetName; //Act

        //    Assert.That(result, Is.EqualTo("GetName")); //Assert
        //}
        [Test]
        public void Create_Veh_CTR_3_Make_Model_Year()
        {
            var vehicle = new Vehicle();//Arrange

            var result = vehicle.GetName = "GetName";//Act

            Assert.That(result, Is.EqualTo("GetName"));//Assert
        }
        [Test]
        public void Set_Engine_Size()
        {
            var vehicle = new Vehicle(); //Arrange

            var result = vehicle.EngineSize = 5.0; //Act

            Assert.That(result, Is.EqualTo(5.0));//Assert
        }
        [Test]
        public void Set_Rim_Size()
        {
            var vehicle = new Vehicle(); //Arrange

            var result = vehicle.RimSize = 16; //Act

            Assert.That(result, Is.EqualTo(16));//Assert

        }
        [Test]
        public void Set_Veh_Color()
        {
            var vehicle = new Vehicle(); //Arrange

            var result = vehicle.VehColor = "blue"; //Act

            Assert.That(result, Is.EqualTo("blue"));//Assert

        }
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, .5)]
        public void GetMPH_Return_0_For_0(double distance, double time, double expected)
        {
            var vehicle = new Vehicle(); //Arrange

            var result = vehicle.GetMPH(distance, time); //Act

            Assert.That(result, Is.EqualTo(expected));//Assert
        }
     
        [Test]
        public void Create_Get_MPH_From_Timespan()
        {
            var vehicle = new Vehicle(); //Arrange
            var distance = 1;
            TimeSpan time = TimeSpan.FromMinutes(2);

            var result = vehicle.GetMPH(distance, time); //Act

            Assert.That(result, Is.EqualTo(30));//Assert
        }
        [Test]
        public void Create_Get_MPH_Timespan()
        {
            var vehicle = new Vehicle(); //Arrange
            var distance = 1;
            TimeSpan time = TimeSpan.FromHours(2);

            var result = vehicle.GetMPH(distance, time); //Act

            Assert.That(result, Is.EqualTo(.5));//Assert
        }
        [Test]
        public void Create_Get_MPG()
        {

        }




    }
















}

