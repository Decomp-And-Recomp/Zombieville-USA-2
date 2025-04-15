using System;
using UnityEngine;

[Serializable]
public class storePanel
{
	public WeaponEnum weapon;

	public PerkEnum perk;

	public int PC;

	public Transform slot;

	public Renderer @lock;

	public Renderer darkBG;

	public Renderer lightBG;

	public GameObject iconInstance;

	public GameObject playerIconInstance;

	public TextMesh perkText;

	public GameObject perkTextGO;

	public Renderer perkTextRenderer;
}
