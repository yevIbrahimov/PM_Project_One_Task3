using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PollAPP
{
	class AddPoll
	{
		public List<Poll> Polls { get; set; }
		static List<Poll> polls = new List<Poll>();
		public void AddPollMethod()
		{
			while (true)
			{
				Console.Write("Enter poll name or exit: "); // create poll
				var userInput = Console.ReadLine();

				CheckEmpty(userInput);

				var checkPollName = from checkName in polls // check new poll name
									where checkName.PollName == userInput
									select checkName;

				while (checkPollName.Count() != 0) // if there is such name
				{
					Console.Write("There is such poll name! Enter new: ");
					userInput = Console.ReadLine();

					checkPollName = from checkName in polls
									where checkName.PollName == userInput
									select checkName;
				}

				if (userInput.ToUpper() == "EXIT") //exit condition
				{
					break;
				}
				
				var pollName = userInput; //set poll name

				List<Question> questions = new List<Question>(); //List of variable type Question (one question - many answers)
				while (true)
				{
					Console.Write("Enter question: "); //user enters question
					userInput = Console.ReadLine();

					if (userInput.ToUpper() == "EXIT")
					{
						return;
					}

					var questionName = CheckEmpty(userInput);
					if (userInput.ToUpper() == "EXIT")
					{
						return;
					}

					if (userInput.ToUpper() == "DONE" ) //enough questions
					{
						if (questions.Count() > 0) //question count condition (minimum 1 question)
						{
							Console.WriteLine("Questions were successfully added");
							break;
						}
						else
						{
							Console.Write("Minimum 1 question! Add more: ");
							userInput = Console.ReadLine();
							if (userInput.ToUpper() == "EXIT")
							{
								return;
							}
						}
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

						CheckEmpty(userInput);
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
					Question question = new Question(questionName, questionAnswers);  //new copy of Question
					questions.Add(question); //List of class Question copies
				}
				Poll poll = new Poll(pollName, questions); //new Poll copy
				polls.Add(poll); //new Poll copy added to Poll copy list
			}
		}

		public AddPoll()
		{
			Polls = polls;
		}

		
		public string CheckEmpty(string userInput)
		{
			while (userInput.Trim() == "") //check string, is it empty
			{
				Console.Write("Enter something: ");
				userInput = Console.ReadLine();
			}
			return userInput;
		}

	}
}

