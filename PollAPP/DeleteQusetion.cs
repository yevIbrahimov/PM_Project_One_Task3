using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PollAPP
{
	class DeleteQusetion
	{
		public void RemoveQuestionMethod(string pollName)
		{
			AddPoll addPoll = new AddPoll();
			var polls = from poll in addPoll.Polls
						where poll.PollName == pollName
					    select poll;
			var searchedQuestions = polls.First().Question;
			
			for (int i = 0; i < searchedQuestions.Count(); i++)
			{
				Console.WriteLine($"{i}" + searchedQuestions[i].Questions);
			}
			Console.Write("Select question number to delete: ");
			var numberToDelete = Console.ReadLine();

			int deleteNumber = ValidNumber(numberToDelete, searchedQuestions);

			polls.First().Question.RemoveAt(deleteNumber);
		}
		private int ValidNumber(string numberToDelete, List<Question> questions)
		{
			int result;
			while (!Int32.TryParse(numberToDelete, out result))
			{
				Console.Write("Enter correct number: ");
				numberToDelete = Console.ReadLine();
			}
			while (Int32.Parse(numberToDelete) < questions.Count() || Int32.Parse(numberToDelete) > questions.Count())
			{
				Console.Write("Enter correct number: ");
				numberToDelete = Console.ReadLine();
			}
			result = Int32.Parse(numberToDelete);
			return result;
		}
	}
}
