using System; //System--> namespace
using ReusableComponent;

namespace StandaloneComponent
{
	class FirstApp
	{
		static void CallMessenger()
		{
			Messenger messenger = new Messenger();
			string message = 
			messenger.DeliverMessage("joydip");
			Console.WriteLine(message);
		}
		static void Main()
		{
			Console.WriteLine("hello world");				CallMessenger();
			CallMessenger();
		}
	}
}