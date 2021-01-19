using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PollAPP
{
	class Manager
	{
	
		public void Manage()
		{
			while (true)
			{
				Console.Write("Action: ");
				var action = Int32.Parse(Console.ReadLine());

				if (action == 0)
				{
					break;
				}

				switch (action)
				{
					case 1:
						AddPoll addPoll = new AddPoll();
						addPoll.AddPollMethod();
						break;
					case 2:
						ShowPoll showPoll = new ShowPoll();
						showPoll.ShowPollMethod(PollName());
						break;
					case 3:
						DeletePoll deletePoll = new DeletePoll();
						deletePoll.DeletePollMethod(PollName());
						break;
				}
			}
		}

		private string PollName()
		{
			AddPoll addPoll = new AddPoll();
			Console.Write("Poll name: ");
			var pollName = Console.ReadLine();
			if (pollName.ToUpper() == "ALL")
			{
				return "ALL";
			}

			var pollNames = from names in addPoll.Polls
							where names.PollName == pollName
							select names;
			if (pollNames.Count() == 0)
			{
				return null;
			}
			return pollName;
		}

	}
}
