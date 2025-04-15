using System;
using UnityEngine;

[Serializable]
public class SplashScreen : MonoBehaviour
{
	public float timer;

	public Renderer fader;

	public Camera theCam;

	public virtual void Awake()
	{
		if ((Screen.height == 768 && Screen.width == 1024) || (Screen.height == 1536 && Screen.width == 2048))
		{
			theCam.orthographicSize = 8f;
		}
		Application.targetFrameRate = 60;
	}

	public virtual void Update()
	{
		timer += Time.deltaTime;
		if (!(timer >= 4f) && !(timer < 1f) && Input.touchCount > 0)
		{
			timer = 4f;
		}
		if (!(timer >= 4f))
		{
			if (!(fader.material.color.a <= 0f))
			{
				float a = fader.material.color.a - Time.deltaTime * 1f;
				Color color = fader.material.color;
				float num = (color.a = a);
				Color color3 = (fader.material.color = color);
				if (!(fader.material.color.a > 0f))
				{
					fader.enabled = false;
				}
			}
		}
		else if (!(timer < 4f))
		{
			if (!fader.enabled)
			{
				fader.enabled = true;
			}
			float a2 = fader.material.color.a + Time.deltaTime * 0.5f;
			Color color4 = fader.material.color;
			float num2 = (color4.a = a2);
			Color color6 = (fader.material.color = color4);
			if (!(timer < 6.1f))
			{
				Application.LoadLevel("startup");
			}
		}
	}

	public virtual void Main()
	{
	}
}
