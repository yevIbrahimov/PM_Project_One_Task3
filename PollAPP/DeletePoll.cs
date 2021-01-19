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
			AddPoll polls = new AddPoll();
			foreach (var poll in polls.Polls)
			{
				if (poll.PollName == pollNameInput)
				{
					polls.Polls.Remove(poll);
				}
			}
		}
	}
}
