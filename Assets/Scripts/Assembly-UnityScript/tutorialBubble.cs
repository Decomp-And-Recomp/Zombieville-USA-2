using System;
using UnityEngine;

[Serializable]
public class tutorialBubble
{
	public string bubbleName;

	public string bubbleText;

	public float width;

	public float height;

	public float arrowPosition;

	public BubbleType bubbleType;

	public Vector2 bubbleCenter;

	public Vector2 bubbleCenterPad;

	public Vector2 colliderCenter;

	public Vector2 colliderSize;

	public bool leftJustify;

	public bool rightJustify;
}
