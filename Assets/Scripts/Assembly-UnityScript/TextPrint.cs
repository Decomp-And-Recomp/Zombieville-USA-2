using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class TextPrint : MonoBehaviour
{
	public bool instant;

	public string targetString;

	private Renderer myRenderer;

	private TextMesh myTextMesh;

	private float internalTimer;

	private float characterDelay;

	public TextPrint()
	{
		characterDelay = 0.014f;
	}

	public virtual void Awake()
	{
		myTextMesh = (TextMesh)transform.GetComponent(typeof(TextMesh));
		myRenderer = GetComponent<Renderer>();
	}

	public virtual void Update()
	{
		if (targetString != myTextMesh.text)
		{
			internalTimer += Time.deltaTime;
			if (!(internalTimer < characterDelay))
			{
				internalTimer -= characterDelay;
				myTextMesh.text += targetString[Extensions.get_length(myTextMesh.text)];
				if (!(internalTimer < characterDelay) && targetString != myTextMesh.text)
				{
					internalTimer -= characterDelay;
					myTextMesh.text += targetString[Extensions.get_length(myTextMesh.text)];
				}
			}
		}
		else
		{
			enabled = false;
		}
	}

	public virtual void Printout(string whatToPrint)
	{
		targetString = whatToPrint;
		myRenderer.enabled = true;
		myTextMesh.text = string.Empty;
		enabled = true;
		if (targetString == string.Empty)
		{
			myRenderer.enabled = false;
		}
		if (instant)
		{
			myTextMesh.text = targetString;
			enabled = false;
		}
	}

	public virtual void Main()
	{
	}
}
