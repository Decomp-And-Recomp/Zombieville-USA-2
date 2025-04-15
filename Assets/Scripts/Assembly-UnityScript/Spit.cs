using System;
using UnityEngine;

[Serializable]
public class Spit
{
	public Transform tran;

	public Animation anim;

	public Renderer rend;

	public Transform opacity;

	public Vector3 vector;

	public float life;

	public Spit()
	{
		life = -10f;
	}
}
