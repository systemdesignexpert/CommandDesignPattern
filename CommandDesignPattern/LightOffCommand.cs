using System;
namespace CommandDesignPattern
{
    public class LightOffCommand : ICommand
    {

        private Light light;

        public LightOffCommand(Light _light)
        {
            this.light = _light;
        }

        public void Execute()
        {
            this.light.LightsOff();
        }

        public void Undo()
        {
            this.light.LightsOn();
        }
    }
}

