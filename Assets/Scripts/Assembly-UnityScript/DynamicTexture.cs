using System;
using UnityEngine;

[Serializable]
public class DynamicTexture : MonoBehaviour
{
	public string textureName;

	public bool shared;

	public DynamicTexture()
	{
		textureName = "textureName";
	}

	public virtual void Awake()
	{
		Renderer renderer = null;
		renderer = (Renderer)gameObject.GetComponent("Renderer");
		if (Screen.width > 500)
		{
			if (shared)
			{
				if (renderer.sharedMaterial.mainTexture == null)
				{
					renderer.sharedMaterial.mainTexture = (Texture)Resources.Load("DynamicTextures/" + textureName);
				}
			}
			else
			{
				renderer.material.mainTexture = (Texture)Resources.Load("DynamicTextures/" + textureName);
			}
		}
		else if (shared)
		{
			if (renderer.sharedMaterial.mainTexture == null)
			{
				renderer.sharedMaterial.mainTexture = (Texture)Resources.Load("DynamicTextures/" + textureName + "Lo");
			}
		}
		else
		{
			renderer.material.mainTexture = (Texture)Resources.Load("DynamicTextures/" + textureName + "Lo");
		}
		if (!shared)
		{
			UnityEngine.Object.Destroy(this);
		}
	}

	public virtual void OnApplicationQuit()
	{
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			GetComponent<Renderer>().sharedMaterial.mainTexture = null;
		}
	}

	public virtual void Main()
	{
	}
}
