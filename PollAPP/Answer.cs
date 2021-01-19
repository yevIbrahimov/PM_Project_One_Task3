using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	[Serializable]
	public class Answer
	{
		public string AnswerName { get; set; }
		public int Counter { get; set; }
		public Answer(string answerName, int counter)
		{
			AnswerName = answerName;
			Counter = counter;
		}
		public Answer() { }
	}
}
