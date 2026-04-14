using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Services
{
	internal class MockScoreService 
	{
		public List<PlayerScore> GetHighScores()
		{
			return new List<PlayerScore>
		{
			new PlayerScore { Name = "רון", Score = 150 },
			new PlayerScore { Name = "מיכל", Score = 120 },
			new PlayerScore { Name = "דני", Score = 90 }
		};
		}
	}
}
