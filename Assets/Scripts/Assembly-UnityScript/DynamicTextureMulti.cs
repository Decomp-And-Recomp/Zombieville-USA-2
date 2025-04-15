using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class DynamicTextureMulti : MonoBehaviour
{
	public string textureName;

	public Renderer[] renderers;

	public DynamicTextureMulti()
	{
		textureName = "textureName";
	}

	public virtual void Awake()
	{
		for (int i = 0; i < Extensions.get_length((Array)renderers); i++)
		{
			if ((bool)renderers[i])
			{
				if (Screen.width > 500)
				{
					renderers[i].material.mainTexture = (Texture)Resources.Load("DynamicTextures/" + textureName);
				}
				else
				{
					renderers[i].material.mainTexture = (Texture)Resources.Load("DynamicTextures/" + textureName + "Lo");
				}
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	public virtual void Main()
	{
	}
}
