using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace PollAPP
{
	class XMLAddClass
	{
		
		public void XMLAddMethod()
		{
			AddPoll poll = new AddPoll();

			XmlSerializer serializer = new XmlSerializer(typeof(List<Poll>));

			using (FileStream fs = new FileStream("polls.xml", FileMode.OpenOrCreate))
			{
				serializer.Serialize(fs, poll.Polls);
			}

		}
	}
}
