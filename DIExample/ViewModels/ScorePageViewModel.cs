using DIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.ViewModels
{
	internal class ScorePageViewModel:ViewModelBase
	{
		private List<PlayerScore> PlayerScores;
		private string scoresDisplayText;

		public string ScoresDisplayText
		{
			get
			{
				return scoresDisplayText;
			}
			set
			{
				if (scoresDisplayText != value)
				{
					scoresDisplayText = value;
					OnPropertyChanged();

				}
			}
		}

		public ScorePageViewModel() {
			PlayerScores= new List<PlayerScore>
		{
			new PlayerScore { Name = "רון", Score = 150 },
			new PlayerScore { Name = "מיכל", Score = 120 },
			new PlayerScore { Name = "דני", Score = 90 }
		};
			ScoresDisplayText = string.Join("\n", PlayerScores.Select(s => $"{s.Name} - {s.Score}"));


		}
	}
}
