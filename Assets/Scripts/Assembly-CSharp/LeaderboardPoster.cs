using UnityEngine;

public class LeaderboardPoster : MonoBehaviour
{
	public TextMesh[] leaderBoardPosters;

	private void Update()
	{
		if (leaderBoardPosters[0].text != string.Empty)
		{
			int num = int.Parse(leaderBoardPosters[0].text);
			Social.ReportScore(num, "CgkI-6fsotMGEAIQHg", delegate
			{
			});
			leaderBoardPosters[0].text = string.Empty;
		}
		if (leaderBoardPosters[1].text != string.Empty)
		{
			int num2 = int.Parse(leaderBoardPosters[1].text);
			Social.ReportScore(num2, "CgkI-6fsotMGEAIQHw", delegate
			{
			});
			leaderBoardPosters[1].text = string.Empty;
		}
		if (leaderBoardPosters[2].text != string.Empty)
		{
			int num3 = int.Parse(leaderBoardPosters[2].text);
			Social.ReportScore(num3, "CgkI-6fsotMGEAIQIA", delegate
			{
			});
			leaderBoardPosters[2].text = string.Empty;
		}
		if (leaderBoardPosters[3].text != string.Empty)
		{
			int num4 = int.Parse(leaderBoardPosters[3].text);
			Social.ReportScore(num4, "CgkI-6fsotMGEAIQIQ", delegate
			{
			});
			leaderBoardPosters[3].text = string.Empty;
		}
		if (leaderBoardPosters[4].text != string.Empty)
		{
			int num5 = int.Parse(leaderBoardPosters[4].text);
			Social.ReportScore(num5, "CgkI-6fsotMGEAIQIg", delegate
			{
			});
			leaderBoardPosters[4].text = string.Empty;
		}
	}
}
