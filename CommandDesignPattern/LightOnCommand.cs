using System;
namespace CommandDesignPattern
{
	public class LightOnCommand: ICommand
	{

		private Light light;

		public LightOnCommand(Light _light)
		{
			this.light = _light;
		}

        public void Execute()
        {
			this.light.LightsOn();
        }

        public void Undo()
        {
            this.light.LightsOff();
        }
    }
}

