using System;
namespace CommandDesignPattern
{
	public class Fan
	{
		private string name;
		public Fan(string _name)
		{
			this.name = _name;
		}

		public void FanOn()
		{
			Console.WriteLine("Fan:" + name +  " is on");

		}

        public void FanOff()
        {
            Console.WriteLine("Fan:" + name + " is off");

        }
    }
}

