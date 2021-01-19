using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PollAPP
{
	[Serializable]
	public class Poll
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
}
