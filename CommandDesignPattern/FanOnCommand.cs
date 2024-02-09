using System;
namespace CommandDesignPattern
{
	public class FanOnCommand: ICommand
	{
		private Fan fan;
		public FanOnCommand(Fan _fan)
		{
			this.fan = _fan;
		}

        public void Execute()
        {
			this.fan.FanOn();
        }

        public void Undo()
        {
            this.fan.FanOff();
        }
    }
}

