using System;
using UnityEngine;

[Serializable]
public class death
{
	public AudioSource deathSound;

	public AudioSource collapseSound;

	public float collapseDelay;

	public Renderer deathRenderer;

	public Renderer deathBackupRenderer;

	public Animation deathAnimation;

	public Transform deathOpacity;

	public Vector3 explosionOffset;

	public int goreType;

	public float goreVelocity;
}
