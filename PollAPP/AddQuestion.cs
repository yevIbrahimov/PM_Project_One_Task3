using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PollAPP
{
	class AddQuestion
	{
		public void AddQuestionMethod(string pollName)
		{
			AddPoll addPoll = new AddPoll();

			Console.Write("Enter question: "); //user enters question
			var userInput = Console.ReadLine();

			if (userInput.ToUpper() == "EXIT")
			{
				return;
			}
			var questionName = addPoll.CheckEmpty(userInput);
			if (userInput.ToUpper() == "EXIT")
			{
				return;
			}

			List<Answer> questionAnswers = new List<Answer>(); //answer List
			
			while (true)
			{
				Console.Write("Enter answer: "); //user enters question
				userInput = Console.ReadLine();

				if (userInput.ToUpper() == "EXIT")
				{
					return;
				}

				addPoll.CheckEmpty(userInput);
				if (userInput.ToUpper() == "EXIT")
				{
					return;
				}
				if (userInput.ToUpper() == "DONE") //enough answers
				{
					if (questionAnswers.Count() > 1)
					{
						Console.WriteLine("Answers were successfully added");
						break;
					}
					else
					{
						Console.Write("Minimum 2 answers! Add more: ");
						userInput = Console.ReadLine();
						if (userInput.ToUpper() == "EXIT")
						{
							return;
						}
					}
				}
				Answer answer = new Answer(userInput, 0);
				questionAnswers.Add(answer); //answer List
			}
			Question question = new Question(questionName, questionAnswers);
			var index = 0;
			for (int i = 0; i < addPoll.Polls.Count(); i++)
			{
				if (addPoll.Polls[i].PollName == pollName)
				{
					index = i;
					break;
				}
			}
			addPoll.Polls[index].Question.Add(question);
			
		}
	}
}
