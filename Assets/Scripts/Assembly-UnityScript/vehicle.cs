using System;
using UnityEngine;

[Serializable]
public class vehicle
{
	public string vehicleName;

	public bool inUse;

	public bool occupied;

	public float remainingGas;

	public Animation myAnimation;

	public Transform myTransform;

	public ParticleSystem myExhaust;

	public Transform myParent;
}
