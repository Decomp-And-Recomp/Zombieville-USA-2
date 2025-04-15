using System;

[Serializable]
public class PC
{
	public string characterName;

	public string characterModel;

	public string iconName;

	public WeaponEnum[] weapons;

	public PerkEnum[] perks;

	public int maxHealth;

	public float moveSpeed;

	public bool purchased;

	public string displayName;

	public string description;

	public PC()
	{
		weapons = new WeaponEnum[3];
		perks = new PerkEnum[3];
	}
}
