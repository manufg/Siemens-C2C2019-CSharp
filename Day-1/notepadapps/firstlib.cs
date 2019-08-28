using System;

namespace ReusableComponent
{
	public class Messenger
	{
		public string DeliverMessage(string name)
		{
			return "hello " + name;
		}
	}
}