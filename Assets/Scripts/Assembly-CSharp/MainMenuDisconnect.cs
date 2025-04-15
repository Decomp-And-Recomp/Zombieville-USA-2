using Photon;
using UnityEngine;

public class MainMenuDisconnect : Photon.MonoBehaviour
{
	public Transform myTransform;

	private void Update()
	{
		if (PhotonNetwork.connected && PhotonNetwork.playerList.Length == 1)
		{
			PhotonNetwork.Disconnect();
			myTransform.position = new Vector3(1f, 0f, 0f);
		}
		if (PhotonNetwork.connected && myTransform.position.x == -1f)
		{
			PhotonNetwork.Disconnect();
		}
	}
}
