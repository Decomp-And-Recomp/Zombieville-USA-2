using System;
using UnityEngine;

[Serializable]
public class Middleman : MonoBehaviour
{
	public Database DB;

	public virtual void Awake()
	{
		if ((bool)GameObject.Find("**DATABASE"))
		{
			DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
		}
		Application.LoadLevel(DB.levelToLoad);
	}

	public virtual void Main()
	{
	}
}
