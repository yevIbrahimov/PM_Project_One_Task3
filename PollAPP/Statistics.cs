using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Statistics
	{
		AddPoll polls = new AddPoll();
		List<Question> questions = new List<Question>();
		public void StatisticsMethod(string pollName)
		{
			foreach (var poll in polls.Polls)
			{
				if (poll.PollName == pollName)
				{
					questions = poll.Question;
				}
			}
			var questionCounter = 1;
			foreach (var question in questions)
			{
				Console.WriteLine($" {questionCounter}." + question.Questions);
				var answerCounter = 1;
				foreach (var answer in question.Answers)
				{
					Console.WriteLine($"  {answerCounter}){answer.AnswerName} - {answer.Counter} voted for this variant");
				}
			}
		}
	}
}
