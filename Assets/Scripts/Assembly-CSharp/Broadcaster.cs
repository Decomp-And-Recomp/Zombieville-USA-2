using System;
using Photon;
using UnityEngine;

public class Broadcaster : Photon.MonoBehaviour
{
	[Serializable]
	public class MessageSlot
	{
		public TextMesh whichObject;

		public TextMesh whichFunction;

		public TextMesh message;
	}

	public MessageSlot[] messageSlots;

	public TextMesh[] listeners;

	private void Update()
	{
		for (int i = 0; i < messageSlots.Length; i++)
		{
			if (messageSlots[i].whichObject.text != string.Empty)
			{
				base.photonView.RPC("broadcasting", PhotonTargets.Others, messageSlots[i].whichFunction.text, messageSlots[i].message.text);
				messageSlots[i].whichObject.text = string.Empty;
				messageSlots[i].whichFunction.text = string.Empty;
				messageSlots[i].message.text = string.Empty;
			}
		}
	}

	[PunRPC]
	private void broadcasting(string whichFunction, string message)
	{
		switch (whichFunction)
		{
		case "ZombieSync":
			if (listeners[8].text == string.Empty)
			{
				listeners[8].text = message;
			}
			else if (listeners[9].text == string.Empty)
			{
				listeners[9].text = message;
			}
			else if (listeners[10].text == string.Empty)
			{
				listeners[10].text = message;
			}
			break;
		case "spawnSync":
			if (listeners[20].text == string.Empty)
			{
				listeners[20].text = message;
			}
			else if (listeners[21].text == string.Empty)
			{
				listeners[21].text = message;
			}
			else if (listeners[22].text == string.Empty)
			{
				listeners[22].text = message;
			}
			break;
		case "syncBuildings":
			listeners[23].text = message;
			break;
		case "syncAlleys":
			listeners[24].text = message;
			break;
		case "syncClutter":
			listeners[25].text = message;
			break;
		case "syncDestructibles":
			listeners[26].text = message;
			break;
		case "syncPickup":
			listeners[27].text = message;
			break;
		case "despawnPickup":
			if (listeners[31].text == string.Empty)
			{
				listeners[31].text = message;
			}
			else if (listeners[32].text == string.Empty)
			{
				listeners[32].text = message;
			}
			else if (listeners[33].text == string.Empty)
			{
				listeners[33].text = message;
			}
			break;
		case "spawnHelicopter":
			listeners[46].text = message;
			break;
		case "learnAllyScore":
			listeners[48].text = message;
			break;
		case "placeVehicles":
			listeners[55].text = message;
			break;
		case "syncShot":
			if (listeners[0].text == string.Empty)
			{
				listeners[0].text = message;
			}
			else if (listeners[1].text == string.Empty)
			{
				listeners[1].text = message;
			}
			else if (listeners[2].text == string.Empty)
			{
				listeners[2].text = message;
			}
			break;
		case "sync":
			if (listeners[3].text == string.Empty)
			{
				listeners[3].text = message;
			}
			else if (listeners[4].text == string.Empty)
			{
				listeners[4].text = message;
			}
			break;
		case "syncSimpleShot":
			if (listeners[5].text == string.Empty)
			{
				listeners[5].text = message;
			}
			else if (listeners[6].text == string.Empty)
			{
				listeners[6].text = message;
			}
			else if (listeners[7].text == string.Empty)
			{
				listeners[7].text = message;
			}
			break;
		case "syncExplosion":
			if (listeners[11].text == string.Empty)
			{
				listeners[11].text = message;
			}
			else if (listeners[12].text == string.Empty)
			{
				listeners[12].text = message;
			}
			break;
		case "killWeaponLoop":
			if (listeners[34].text == string.Empty)
			{
				listeners[34].text = message;
			}
			else if (listeners[35].text == string.Empty)
			{
				listeners[35].text = message;
			}
			break;
		case "die":
			listeners[45].text = message;
			break;
		case "grabHelicopter":
			listeners[47].text = message;
			break;
		case "enterVehicle":
			listeners[49].text = message;
			break;
		case "explodeVehicle":
			listeners[54].text = message;
			break;
		case "syncVehicularManslaughter":
			if (listeners[50].text == string.Empty)
			{
				listeners[50].text = message;
			}
			else if (listeners[51].text == string.Empty)
			{
				listeners[51].text = message;
			}
			else if (listeners[52].text == string.Empty)
			{
				listeners[52].text = message;
			}
			else if (listeners[53].text == string.Empty)
			{
				listeners[53].text = message;
			}
			break;
		case "syncAttack":
			if (listeners[13].text == string.Empty)
			{
				listeners[13].text = message;
			}
			else if (listeners[14].text == string.Empty)
			{
				listeners[14].text = message;
			}
			else if (listeners[15].text == string.Empty)
			{
				listeners[15].text = message;
			}
			else if (listeners[16].text == string.Empty)
			{
				listeners[16].text = message;
			}
			else if (listeners[17].text == string.Empty)
			{
				listeners[17].text = message;
			}
			else if (listeners[18].text == string.Empty)
			{
				listeners[18].text = message;
			}
			else if (listeners[19].text == string.Empty)
			{
				listeners[19].text = message;
			}
			break;
		case "syncSpit":
			if (listeners[36].text == string.Empty)
			{
				listeners[36].text = message;
			}
			else if (listeners[37].text == string.Empty)
			{
				listeners[37].text = message;
			}
			else if (listeners[38].text == string.Empty)
			{
				listeners[38].text = message;
			}
			break;
		case "syncDetonate":
			if (listeners[39].text == string.Empty)
			{
				listeners[39].text = message;
			}
			else if (listeners[40].text == string.Empty)
			{
				listeners[40].text = message;
			}
			break;
		case "changeOwnership":
			if (listeners[41].text == string.Empty)
			{
				listeners[41].text = message;
			}
			else if (listeners[42].text == string.Empty)
			{
				listeners[42].text = message;
			}
			else if (listeners[43].text == string.Empty)
			{
				listeners[43].text = message;
			}
			else if (listeners[44].text == string.Empty)
			{
				listeners[44].text = message;
			}
			break;
		case "spawnOtherPlayer":
			listeners[56].text = message;
			break;
		case "iGotTheWorld":
			listeners[57].text = message;
			break;
		case "syncEquip":
			if (listeners[58].text == string.Empty)
			{
				listeners[58].text = message;
			}
			else if (listeners[59].text == string.Empty)
			{
				listeners[59].text = message;
			}
			break;
		case "syncHeal":
			if (listeners[60].text == string.Empty)
			{
				listeners[60].text = message;
			}
			else if (listeners[61].text == string.Empty)
			{
				listeners[61].text = message;
			}
			break;
		case "syncAimRelease":
			if (listeners[62].text == string.Empty)
			{
				listeners[62].text = message;
			}
			else if (listeners[63].text == string.Empty)
			{
				listeners[63].text = message;
			}
			break;
		case "despawn":
			if (listeners[64].text == string.Empty)
			{
				listeners[64].text = message;
			}
			else if (listeners[65].text == string.Empty)
			{
				listeners[65].text = message;
			}
			else if (listeners[66].text == string.Empty)
			{
				listeners[66].text = message;
			}
			break;
		}
	}
}
