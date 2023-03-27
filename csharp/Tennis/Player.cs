using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
	public class Player
	{
		public int MScore { get; set; }
		public string PlayerName { get; set; }
		public Player(string playerName)
		{
			MScore = 0;
			PlayerName = playerName;
		}

	}
}
