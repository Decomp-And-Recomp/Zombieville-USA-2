using System;
using UnityEngine;

[Serializable]
public class weapon
{
	public string weaponName;

	public string displayName;

	public string description;

	public string weaponModel;

	public string explosiveModel;

	public float explosiveFuse;

	public float explosiveRange;

	public float explosiveRadius;

	public float explosiveMotion;

	public int maxAmmo;

	public float damage;

	public float damageFalloff;

	public int damagePerk;

	public float spray;

	public float hitChance;

	public float hitChanceFalloff;

	public float critChance;

	public float impactForce;

	public float impactFalloff;

	public float piercingRange;

	public int damageType;

	public float rateOfFire;

	public float aimDelay;

	public float movementPenalty;

	public float movementLockout;

	public bool automatic;

	public bool dualWield;

	public bool UVanimation;

	public bool flipExplosion;

	public int animSet;

	public string hitStyle;

	public int shellType;

	public Vector3 shellOffset;

	public bool backpack;

	public int rank;

	public UpgradeRank[] rankInfo;

	public int[] price;

	public bool purchased;

	public weapon()
	{
		rankInfo = new UpgradeRank[5];
		price = new int[6];
	}
}
