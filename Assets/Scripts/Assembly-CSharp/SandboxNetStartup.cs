using Photon;
using UnityEngine;

public class SandboxNetStartup : Photon.MonoBehaviour
{
	public bool ready1;

	public bool ready2;

	public Transform readyMarker1;

	public Transform readyMarker2;

	private void Start()
	{
		PhotonNetwork.isMessageQueueRunning = true;
	}

	private void Update()
	{
		if (readyMarker1.position.x != 0f && !ready1)
		{
			ready1 = true;
			base.photonView.RPC("sandboxReady", PhotonTargets.Others, "1");
		}
		if (readyMarker2.position.x != 0f && !ready2)
		{
			ready2 = true;
			base.photonView.RPC("sandboxReady", PhotonTargets.Others, "2");
		}
	}

	[PunRPC]
	private void sandboxReady(string info)
	{
		if (info == "1")
		{
			readyMarker1.position = new Vector3(1f, 0f, 0f);
			ready1 = true;
		}
		else if (info == "2")
		{
			readyMarker2.position = new Vector3(1f, 0f, 0f);
			ready2 = true;
		}
	}
}
