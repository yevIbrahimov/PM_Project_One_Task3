using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PollAPP
{
	class Input
	{
		List<Poll> polls = new List<Poll>();
		public void UserInput()
		{
			while (true)
			{
				Console.Write("Enter poll name: ");
				var userInput = Console.ReadLine();

				if (userInput.ToUpper() == "EXIT")
				{
					Output(polls);
					break;
				}

				var pollName = userInput;

				List<string> pollQuestions = new List<string>();
				List<Question> questions = new List<Question>();
				while (true)
				{
					Console.Write("Enter question: "); //user enters question
					userInput = Console.ReadLine();

					if (userInput.ToUpper() == "DONE")
					{				
						break;
					}
					List<string> questionAnswers = new List<string>();
					var questionName = userInput;
					
					while (true)
					{
						Console.Write("Enter answer: "); //user enters question
						userInput = Console.ReadLine();

						if (userInput.ToUpper() == "DONE")
						{
							break;
						}

						questionAnswers.Add(userInput);
					}
					Question question = new Question(questionName, questionAnswers);
					questions.Add(question);

				}
				Poll poll = new Poll(pollName, questions); //new Poll copy
				polls.Add(poll); //new Poll copy added to Poll copy list
			}
		}

		private void Output(List<Poll> polls)
		{
			foreach (var poll in polls)
			{
				Console.WriteLine(poll.PollName);
				foreach (var question in poll.Question)
				{
					Console.WriteLine(" " + question.Questions);
					foreach (var answer in question.Answers)
					{
						Console.WriteLine("  " + answer);
					}
				}
			}
		}


		//private bool UserInputPollNameValid(string userInput)
		//{
		//	foreach (var names in pollNameList)
		//	{
		//		if(userInput == names)
		//		{
		//			return false;
		//		}
		//	}
		//	return true;
		//}


	}
}

//foreach (var questionItem in polls.Question)
//{
//	Console.WriteLine($"{counter}. " + questionItem.Questions);
//	foreach (var answerItem in question.Answers)
//	{
//		Console.WriteLine($"  {counter}) " + answerItem);
//	}
//	counter++;
//}



//Console.Write("Enter Poll Name: ");
//var userInput = Console.ReadLine();

//if (userInput.ToUpper() == "EXIT")
//{
//	break;
//}

//if (pollNameList != null)
//{
//	while (!UserInputPollNameValid(userInput))
//	{
//		Console.Write("There is such poll. Enter new poll name: ");
//		userInput = Console.ReadLine();
//	}
//}

//Poll poll = new Poll(userInput);
//pollNameList.Add(poll);

//questions.AddQuestions();


//////var question = new Question();
//////while (true)
//////{
//////	Console.Write("Poll Name: ");

//////	var pollName = Console.ReadLine();
//////	if (pollName.ToUpper() == "EXIT")
//////	{
//////		foreach (var polls in polls)
//////		{
//////			Console.WriteLine(polls.PollName);
//////			var counter = 1;
//////			foreach (var item in question.Questions)
//////			{
//////				if (question.PollId == polls.PollName)
//////				{
//////					Console.WriteLine($"{counter}. " + item);
//////					counter++;
//////				}
//////			}
//////			counter = 1;
//////		}
//////		break;
//////	}
//////	List<string> questions = new List<string>();
//////	while (true)
//////	{

//////		Console.Write("Add question: ");
//////		string userInputQuestion = Console.ReadLine();

//////		if (userInputQuestion.ToUpper() == "DONE")
//////		{
//////			break;
//////		}
//////		//while (true)
//////		//{
//////		//	Console.Write("Add anwsers: ");
//////		//	string userInputAnswer = Console.ReadLine();

//////		//	if (userInputAnswer.ToUpper() == "DONE")
//////		//	{
//////		//		break;
//////		//	}
//////		//	answers.Add(userInputAnswer);
//////		//}
//////		questions.Add(userInputQuestion);
//////		//questions.Add(question);
//////	}
//////	question = new Question(pollName, questions);
//////	var poll = new Poll(pollName);
//////	polls.Add(poll);

//////	//polls.Add(poll);
//////}
///
//Questions questions = new Questions();
//List<Poll> pollNameList = new List<Poll>() ;
//List<Poll> polls = new List<Poll>();
//List<Question> question = new List<Question>();
//List<string> answers = new List<string>();