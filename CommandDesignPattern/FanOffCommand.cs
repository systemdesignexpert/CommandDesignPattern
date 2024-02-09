using System;
namespace CommandDesignPattern
{
    public class FanOffCommand : ICommand
    {
        private Fan fan;
        public FanOffCommand(Fan _fan)
        {
            this.fan = _fan;
        }

        public void Execute()
        {
            this.fan.FanOff();
        }

        public void Undo()
        {
            this.fan.FanOn();
        }
    }
}

