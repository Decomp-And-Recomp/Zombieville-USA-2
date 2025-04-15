using Photon;
using UnityEngine;

public class ReadyUp : Photon.MonoBehaviour
{
	private bool ready;

	public Transform readyMarker;

	public Transform queuePauser;

	private void Start()
	{
	}

	private void Update()
	{
		if (readyMarker.position.x > 0.1f && !ready)
		{
			ready = true;
			string text = readyMarker.position.x.ToString();
			base.photonView.RPC("Ready", PhotonTargets.All, text);
		}
		else if (readyMarker.position.x == 0f && ready)
		{
			ready = false;
			base.photonView.RPC("Ready", PhotonTargets.All, "0");
		}
		if (PhotonNetwork.isMessageQueueRunning && queuePauser.position.x != 0f)
		{
			PhotonNetwork.isMessageQueueRunning = false;
		}
	}

	[PunRPC]
	private void Ready(string argument)
	{
		if (argument != "0")
		{
			float x = float.Parse(argument);
			readyMarker.position = new Vector3(x, 0f, 0f);
			ready = true;
		}
		else
		{
			readyMarker.position = new Vector3(0f, 0f, 0f);
			ready = false;
		}
	}
}
