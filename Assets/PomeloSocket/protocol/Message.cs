using System;
using SimpleJson;
using System.IO;

namespace Pomelo.DotNetClient
{
	public class Message
	{
		public MessageType type;
		public string route;
		public uint id;
		public JsonObject data;
        public Stream stream;

		public Message (MessageType type, uint id, string route, JsonObject data,Stream stream = null)
		{
			this.type = type;
			this.id = id;
			this.route = route;
			this.data = data;
            this.stream = stream;
		}
	}
}

