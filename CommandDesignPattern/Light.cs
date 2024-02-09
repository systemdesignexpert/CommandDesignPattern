using System;
namespace CommandDesignPattern
{
	public class Light
	{

		private string name;

		public Light(string _name)
		{
			this.name = _name;
		}

		public void LightsOn()
		{

            Console.WriteLine("Light:" + name + " is on");

        }


		public void LightsOff()
		{
            Console.WriteLine("Light:" + name + " is off");
        }
	}
}

