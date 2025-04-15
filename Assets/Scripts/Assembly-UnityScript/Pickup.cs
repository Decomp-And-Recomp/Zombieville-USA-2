using System;
using UnityEngine;

[Serializable]
public class Pickup
{
	public float life;

	public bool inUse;

	public Transform tran;

	public Animation anim;

	public PickupValue pickupValue;
}
