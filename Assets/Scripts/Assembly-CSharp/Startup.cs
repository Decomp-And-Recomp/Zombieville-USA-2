using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

public class Startup : MonoBehaviour
{
	private void Start()
	{
		PlayGamesClientConfiguration configuration = new PlayGamesClientConfiguration.Builder().EnableSavedGames().Build();
		PlayGamesPlatform.InitializeInstance(configuration);
		PlayGamesPlatform.DebugLogEnabled = true;
		PlayGamesPlatform.Activate();
		Social.localUser.Authenticate(delegate(bool success)
		{
			if (success)
			{
				Debug.Log("Authentication successful");
			}
			else
			{
				Debug.Log("Authentication failed");
			}
		});
		Application.LoadLevel("title");
	}
}
