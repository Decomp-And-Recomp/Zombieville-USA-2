using System;
using UnityEngine;

[Serializable]
public class MenuBrain_Temp : MonoBehaviour
{
	public LayerMask greenButton;

	public LayerMask otherButton;

	public LayerMask GCButton;

	public LayerMask friends;

	public int touchState;

	public Renderer lightUp;

	public Database DB;

	private float counter;

	public MenuBrain_Temp()
	{
		counter = 1f;
	}

	public virtual void Update()
	{
		if (!(counter <= 0f))
		{
			counter -= Time.deltaTime;
		}
		else if (counter <= -100f)
		{
		}
		if (Input.touchCount > 0 && touchState == 0)
		{
			touchState = 1;
			Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit hitInfo = default(RaycastHit);
			if (!Physics.Raycast(ray, out hitInfo, 100f, greenButton))
			{
				if (Physics.Raycast(ray, out hitInfo, 100f, otherButton))
				{
					DB.whichPlayerAmI = 1;
					DB.multiplayer = false;
					DB.GCmultiplayer = false;
					Application.LoadLevel(1);
				}
				else if (!Physics.Raycast(ray, out hitInfo, 100f, GCButton) && !Physics.Raycast(ray, out hitInfo, 100f, friends))
				{
				}
			}
		}
		else if (Input.touchCount == 0)
		{
			touchState = 0;
		}
	}

	public virtual void Awake()
	{
		if ((bool)GameObject.Find("**DATABASE"))
		{
			DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
		}
		else
		{
			DB = (Database)GameObject.Find("**DATABASE_Sandbox").GetComponent(typeof(Database));
		}
	}

	public virtual void onPeerConnected(string peerId)
	{
	}

	public virtual void GCmatchmade()
	{
		DB.multiplayer = true;
		DB.GCmultiplayer = true;
		DB.whichPlayerAmI = 0;
		Application.LoadLevel(1);
	}

	public virtual void orientScreen()
	{
		if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
		{
			Screen.orientation = ScreenOrientation.LandscapeRight;
		}
		else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
		}
	}

	public virtual void Main()
	{
	}
}
