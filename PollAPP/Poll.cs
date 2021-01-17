using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Poll
	{
		public string PollName { get; set; }

		public List<Question> Question { get; set; }
		public Poll(string pollName, List<Question> question)
		{
			PollName = pollName;

			Question = question;
		}
		public Poll() { }
	}
	class Question
	{
		public string PollId { get; set; }
		public string Questions { get; set; }
		public List<string> Answers { get; set; }
		public Question(string questions, List<string> answers)
		{
			Questions = questions;
			Answers = answers;
		}
		public Question() { }
	}
}
