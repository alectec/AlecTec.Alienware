using LightFX;

namespace AlecTec.Alienware
{
    public interface ILightController
    {
        LFX_Result Initialize();
        void Start();
        void GoDark();

        void ChangeLights(LFX_ColorStruct color);

        uint GetNumberOfDevices();
        
    }
}
