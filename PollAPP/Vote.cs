﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PollAPP
{
	class Vote
	{
		
		public void VoteMethod(List<Poll> polls)
		{
			Console.WriteLine("POLLS:");
			for (int i = 0; i < polls.Count; i++)
			{
				Console.WriteLine($" {i+1}. " + polls[i].PollName);
			}

			string pollName = PollName();
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
					Console.WriteLine($"  {answerCounter}) " + answer.AnswerName);
					answerCounter++;
				}
				questionCounter++;
				Console.Write("Choose variant using numbers: ");
				int variant = Convert.ToInt32(Console.ReadLine());

				while (variant < 1 || variant > answerCounter)
				{
					Console.Write("Wrong variant! enter again: ");
					variant = Convert.ToInt32(Console.ReadLine());
				}
				question.Answers[variant-1].Counter++;
				Console.WriteLine("You voted");
			}
		}
		private string PollName()
		{
			AddPoll addPoll = new AddPoll();
			Console.Write("Poll name: ");
			var pollName = Console.ReadLine();

			var pollNames = from names in addPoll.Polls
							where names.PollName == pollName
							select names;
			while (pollNames.Count() == 0)
			{
				Console.Write("No such poll! Poll name: ");
				pollName = Console.ReadLine();
			} 
			return pollName;
		}
	}
}
