using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Vote
	{
		AddPoll addPoll = new AddPoll();
		public void VoteMethod(List<Poll> polls, string pollName)
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
			foreach (var question in thisPollQuestions)//show questions in one poll 
			{
				Console.WriteLine($" {questionCounter}. " + question.Questions); 
				int answerCounter = 1;
				foreach (var answer in question.Answers) //show all answers to one question
				{
					Console.WriteLine($"  {answerCounter}) " + answer);
					answerCounter++;
				}
				questionCounter++;
				Console.Write("What choose variant using numbers: ");
				int variant = Convert.ToInt32(Console.ReadLine());
				while (variant < 1 || variant > answerCounter)
				{
					Console.Write("wrong variant! enter again: ");
					variant = Convert.ToInt32(Console.ReadLine());
				}
				question.Answers[variant].Counter++;
				Console.WriteLine("You voted");
			}
		}
	}
}
