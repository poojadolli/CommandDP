using CommandDP.NewFolder;

namespace CommandDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light livingRoomLight = new Light();
            ICommand livingRoomLightOn = new LightOn(livingRoomLight);

            RemoteControl remote = new RemoteControl();
            remote.SetCommand(livingRoomLightOn);

            // Press the button to turn on the light
            remote.PressButton();
        }
    }
}