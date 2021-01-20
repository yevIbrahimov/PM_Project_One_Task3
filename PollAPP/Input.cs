using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Input
	{
		AddPoll poll = new AddPoll();
		public void InputMethod()
		{
			while (true)
			{
				Console.Write("You can manage poll or vote: ");
				var userChoose = Console.ReadLine();
				while (poll.Polls.Count == 0 && userChoose.ToUpper() == "VOTE")
				{
					Console.WriteLine("No poll to vote");
					Console.Write("You can manage poll or vote: ");
					userChoose = Console.ReadLine();
				}
				if (userChoose.ToUpper() == "EXIT")
				{
					break;
				}
				while (userChoose.ToUpper() != "MANAGE" && userChoose.ToUpper() != "VOTE")
				{
					Console.Write("Only manage or vote: ");
					userChoose = Console.ReadLine();
				}

				if (userChoose.ToUpper() == "MANAGE")
				{
					Manager manager = new Manager();
					manager.Manage();
				}
				else
				{
					Vote vote = new Vote();
					vote.VoteMethod(poll.Polls);
				}
			}
		}
	}
}
