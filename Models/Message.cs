﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_UAQ_Client.Models
{
	public class Message
	{
		public MessageType Type { get; set; }
		public object? Data { get; set; }
	}
}