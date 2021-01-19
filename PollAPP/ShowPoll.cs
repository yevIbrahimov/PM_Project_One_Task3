using System;
using System.Collections.Generic;
using System.Linq;

namespace PollAPP
{
	class ShowPoll
	{
		public Poll ShowPollProp { get; set; }
		AddPoll poll = new AddPoll();

		public void ShowPollMethod(string pollName)
		{
			if(pollName.ToUpper() == "ALL")
			{
				OutputAll(poll.Polls);
			}
			else if(pollName == null)
			{
				Console.WriteLine("There is no such poll");
			}
			else
			{
				OutputByName(poll.Polls, pollName);
			}
		}
		private void OutputAll(List<Poll> polls)
		{
			foreach (var poll in polls)
			{
				Console.WriteLine(poll.PollName);
				var questionCounter = 1;
				foreach (var question in poll.Question)
				{
					Console.WriteLine($" {questionCounter}. " + question.Questions);
					var answerCounter = 1;
					foreach (var answer in question.Answers)
					{

						Console.WriteLine($"  {answerCounter}) " + answer);
						answerCounter++;
					}
					questionCounter++;
				}
			}
		}
		private void OutputByName(List<Poll> polls, string pollName)
		{
			List<Question> thisPollQuestions = new List<Question>();
			foreach (var poll in polls)
			{
				if (poll.PollName == pollName)
				{
					thisPollQuestions = poll.Question;
				}
			}
			Console.WriteLine(pollName);
			int questionCounter = 1;
			foreach (var question in thisPollQuestions)
			{
				Console.WriteLine($" {questionCounter}. " + question.Questions);
				int answerCounter = 1;
				foreach (var answer in question.Answers)
				{
					Console.WriteLine($"  {answerCounter}) " + answer);
					answerCounter++;
				}
				questionCounter++;
			}
			
		}
	}
}
