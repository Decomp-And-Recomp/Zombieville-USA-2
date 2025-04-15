using System;
using UnityEngine;

[Serializable]
public class DynamicCorners : MonoBehaviour
{
	public int distanceFromCamera;

	public Camera cameraLens;

	public Transform bottomLeftCorner;

	public Transform bottomRightCorner;

	public Transform topLeftCorner;

	public Transform topRightCorner;

	public DynamicCorners()
	{
		distanceFromCamera = 20;
	}

	public virtual void Awake()
	{
		if ((bool)bottomLeftCorner)
		{
			bottomLeftCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(0f, 0f, distanceFromCamera));
		}
		if ((bool)bottomRightCorner)
		{
			bottomRightCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(1f, 0f, distanceFromCamera));
		}
		if ((bool)topLeftCorner)
		{
			topLeftCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(0f, 1f, distanceFromCamera));
		}
		if ((bool)topRightCorner)
		{
			topRightCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(1f, 1f, distanceFromCamera));
		}
	}

	public virtual void Main()
	{
	}
}
