using System;
using Shouldly;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlecTec.Alienware.UnitTests
{
    [TestClass]
    public class LightControllerTests
    {
        private ILightController _lightController;

        [TestInitialize]
        public void Init()
        {
            _lightController = new AlienLightController();
        }

        [TestMethod]
        public void InitializeLights()
        {
            
        }

        [TestMethod]
        public void Change_Light_Color()
        {
            
        }

        [TestMethod]
        public void Turn_Lights_Dark()
        {
            _lightController.GoDark();
            
        }

        private void FakeLights()
        {
            
        }



        // Integration Tests
        // TODO:
    }
}
