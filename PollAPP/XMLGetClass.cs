using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;


namespace PollAPP
{
	class XMLGetClass
	{
		AddPoll polls = new AddPoll();
		public void XMLGetMethod()
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Poll>));
			var inputList = new List<Poll>();
			using (FileStream fs = new FileStream("polls.xml", FileMode.OpenOrCreate))
			{
				inputList = (List<Poll>)serializer.Deserialize(fs);
			}
			
			for (int i = 0; i < inputList.Count; i++)
			{
				polls.Polls.Add(inputList[i]);
			}
		}
	}
}
