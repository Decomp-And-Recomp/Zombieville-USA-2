using UnityEngine;

public class ShowLeaderboardEtc : MonoBehaviour
{
	public Transform showLeaderboards;

	public Transform showAchieves;

	private void Update()
	{
		if (showLeaderboards.position.x == 1f)
		{
			Social.ShowLeaderboardUI();
			showLeaderboards.position = new Vector3(0f, 0f, 0f);
		}
		if (showAchieves.position.x == 1f)
		{
			Social.ShowAchievementsUI();
			showAchieves.position = new Vector3(0f, 0f, 0f);
		}
	}
}
