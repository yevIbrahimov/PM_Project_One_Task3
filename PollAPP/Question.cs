using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Question
	{
		public string Questions { get; set; }
		public List<Answer> Answers { get; set; }
		public Question(string questions, List<Answer> answers)
		{
			Questions = questions;
			Answers = answers;
		}
		public Question() { }
	}
}
