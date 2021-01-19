using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PollAPP
{
	class DeletePoll
	{
		public void DeletePollMethod(string pollNameInput)
		{
			AddPoll addPoll = new AddPoll();

			var deletePoll = from poll in addPoll.Polls
							 where poll.PollName == pollNameInput
							 select poll;

			addPoll.Polls.Remove(deletePoll.First());
			Console.WriteLine("Poll was succesfully deleted");
		}
	}
}
