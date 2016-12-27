using System;
using System.Diagnostics;
using LightFX;

namespace AlecTec.Alienware
{
    public class AlienLightController : ILightController
    {
        private readonly LightFXController _lightFxController;

        public AlienLightController()
        {
            _lightFxController = new LightFXController();
        }

        public LFX_Result Initialize()
        {
            return _lightFxController.LFX_Initialize();
        }

        public void Start()
        {
            var result = Initialize();
            if (result != LFX_Result.LFX_Success)
                throw new UnableToInitializeLightsException($"ErrorCode: {result.ToString()}");

            // Start fresh
            _lightFxController.LFX_Reset();

        }

        public void GoDark()
        {
            // Turn off all active lights
            var numberOfLights = GetNumberOfLights();
            WriteDataPointToDebugOutput(nameof(numberOfLights), numberOfLights);

        }

        public void ChangeLights(LFX_ColorStruct color)
        {
            throw new NotImplementedException();
        }


        public uint GetNumberOfLights()
        {
            uint numberOfDevices;
            _lightFxController.LFX_GetNumDevices(out numberOfDevices);

            return numberOfDevices;
        }

        private void WriteDataPointToDebugOutput(string key, object value)
        {
            Debug.WriteLine("{0}: {1}", key, value);
        }
    }
}
