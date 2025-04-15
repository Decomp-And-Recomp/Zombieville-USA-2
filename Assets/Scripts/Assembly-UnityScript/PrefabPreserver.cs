using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class PrefabPreserver : MonoBehaviour
{
	public ColliderTarget[] targetArray;

	public ParentLinker[] parentArray;

	public virtual void Awake()
	{
		for (int i = 0; i < Extensions.get_length((Array)targetArray); i++)
		{
			if ((bool)targetArray[i].GO)
			{
				BoxCollider boxCollider = null;
				boxCollider = targetArray[i].GO.AddComponent<BoxCollider>();
				boxCollider.size = targetArray[i].dimensions;
				boxCollider.center = targetArray[i].centerpoint;
			}
		}
		for (int i = 0; i < Extensions.get_length((Array)parentArray); i++)
		{
			parentArray[i].child.parent = parentArray[i].newParent;
		}
	}

	public virtual void Main()
	{
	}
}
