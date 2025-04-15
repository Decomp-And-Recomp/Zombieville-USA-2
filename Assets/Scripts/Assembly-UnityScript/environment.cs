using System;
using UnityEngine;

[Serializable]
public class environment
{
	public Vector2 cameraVerticalBounds;

	public Vector2 characterVerticalBounds;

	public string basicFloorPiece;

	public float basicFloorSize;

	public string FGPiece;

	public float FGSize;

	public string SkylinePiece;

	public float SkylineSize;

	public string cloudPiece;

	public float cloudSize;

	public string backdrop;

	public backgroundPart[] parts;

	public backgroundPart[] alleys;

	public bool noClutter;

	public string[] clutter;

	public string[] destructibles;

	public Vector2 destructiblesSpawnRange;

	public string[] customParticles;
}
