using System;

[Serializable]
public class perk
{
	public string perkName;

	public float topDisplaySize;

	public string perkDisplayName;

	public float perkFontSize;

	public string perkDescription;

	public bool purchased;

	public bool implemented;

	public PerkStars rank;

	public float[] rankBonuses;

	public string[] rankDescriptions;

	public int[] price;

	public perk()
	{
		rankBonuses = new float[5];
		rankDescriptions = new string[5];
		price = new int[5];
	}
}
