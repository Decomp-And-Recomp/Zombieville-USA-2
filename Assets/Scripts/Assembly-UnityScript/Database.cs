using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Boo.Lang;
using Prime31;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class Database : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024forceUploadAchievementData_00241630 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241631;

			internal Database _0024self__00241632;

			public _0024(Database self_)
			{
				_0024self__00241632 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024i_00241631 = 0;
					goto IL_00a2;
				case 2:
					_0024i_00241631++;
					goto IL_00a2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00a2:
					if (_0024i_00241631 < Extensions.get_length((Array)_0024self__00241632.achievements))
					{
						if (!(_0024self__00241632.achievements[_0024i_00241631].counter < (float)_0024self__00241632.achievements[_0024i_00241631].threshold))
						{
							_0024self__00241632.GPGachievement.text = _0024self__00241632.achievements[_0024i_00241631].GoogleID;
							result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
							break;
						}
						goto case 2;
					}
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Database _0024self__00241633;

		public _0024forceUploadAchievementData_00241630(Database self_)
		{
			_0024self__00241633 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241633);
		}
	}

	public TextMesh GPGachievement;

	public int myPC;

	public int money;

	public int difficulty;

	public int totalKills;

	public int[] playerPriceTable;

	public int playersPurchased;

	public int moneyInfo;

	public bool iCloud;

	public bool voiceChat;

	public bool GCactive;

	public bool multiplayer;

	public bool GCmultiplayer;

	public bool musicEnabled;

	public bool soundEnabled;

	public int whichPlayerAmI;

	public PC[] PCs;

	public achievement[] achievements;

	public weapon[] weapons;

	public perk[] perks;

	public environment[] environments;

	public Location location;

	public Mission mission;

	public float[] enemyChance;

	public Vector2 spawnDelayRange;

	public Vector2 rearSpawnDelayRange;

	public float[] waveSize;

	public int maxEnemyCount;

	public string musicTrack;

	public float levelClock;

	public string levelToLoad;

	public MotherBrain_Menu motherBrain_Menu;

	public MotherBrain motherBrain;

	private string secretKey;

	public int highscore;

	public string megaString;

	public bool security;

	public MotherBrain_Title motherBrain_Title;

	public bool tutorial;

	public int moneyStamp;

	public Database()
	{
		money = 10;
		difficulty = 1;
		iCloud = true;
		GCactive = true;
		musicEnabled = true;
		soundEnabled = true;
		whichPlayerAmI = 1;
		maxEnemyCount = 5;
		levelToLoad = string.Empty;
		secretKey = "Baconalia";
		highscore = 50;
		megaString = string.Empty;
	}

	public virtual void Awake()
	{
		Application.targetFrameRate = 60;
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		forceLocalLoad();
		if (iCloud)
		{
			bool flag = P31Prefs.synchronize();
			Debug.Log("did synchronize: " + flag);
		}
		else
		{
			Debug.Log("iCloud is not available");
		}
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown("f"))
		{
			save();
		}
	}

	public virtual void onPeerDisconnect()
	{
	}

	public virtual void onPlayerDisconnect()
	{
	}

	public virtual void save()
	{
		megaString = moneyStamp.ToString();
		P31Prefs.setInt("Stamp", moneyStamp);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		if (voiceChat)
		{
			num = 1;
		}
		if (musicEnabled)
		{
			num2 = 1;
		}
		if (soundEnabled)
		{
			num3 = 1;
		}
		if (tutorial)
		{
			num4 = 1;
		}
		if (GCactive)
		{
			num5 = 1;
		}
		if (iCloud)
		{
			num6 = 1;
		}
		string text = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", myPC, money, totalKills, highscore, playersPurchased, num, num2, num3, difficulty, num4, num5, num6);
		string val = mdFiveSum(text + "Baconalia");
		P31Prefs.setString("Data1", text);
		megaString = megaString + "|" + text;
		P31Prefs.setString("Data1H", val);
		text = string.Empty;
		for (int i = 0; i < Extensions.get_length((Array)PCs); i++)
		{
			int num7 = 0;
			int num8 = (int)PCs[i].weapons[0];
			int num9 = (int)PCs[i].weapons[1];
			int num10 = (int)PCs[i].weapons[2];
			int num11 = (int)PCs[i].perks[0];
			int num12 = (int)PCs[i].perks[1];
			int num13 = (int)PCs[i].perks[2];
			if (PCs[i].purchased)
			{
				num7 = 1;
			}
			text = ((!(text == string.Empty)) ? (text + "," + num8 + "," + num9 + "," + num10 + "," + num11 + "," + num12 + "," + num13 + "," + num7) : (num8 + "," + num9 + "," + num10 + "," + num11 + "," + num12 + "," + num13 + "," + num7));
		}
		val = mdFiveSum(text + "Baconalia");
		P31Prefs.setString("Data2", text);
		megaString = megaString + "|" + text;
		P31Prefs.setString("Data2H", val);
		text = string.Empty;
		for (int i = 0; i < Extensions.get_length((Array)achievements); i++)
		{
			int num7 = 0;
			if (achievements[i].reported)
			{
				num7 = 1;
			}
			text = ((!(text == string.Empty)) ? (text + "," + achievements[i].counter + "," + num7) : (achievements[i].counter + "," + num7));
		}
		val = mdFiveSum(text + "Baconalia");
		P31Prefs.setString("Data3", text);
		megaString = megaString + "|" + text;
		P31Prefs.setString("Data3H", val);
		text = string.Empty;
		for (int i = 0; i < Extensions.get_length((Array)weapons); i++)
		{
			int num7 = 0;
			if (weapons[i].purchased)
			{
				num7 = 1;
			}
			text = ((!(text == string.Empty)) ? (text + "," + weapons[i].rank + "," + num7) : (weapons[i].rank + "," + num7));
		}
		val = mdFiveSum(text + "Baconalia");
		P31Prefs.setString("Data4", text);
		megaString = megaString + "|" + text;
		P31Prefs.setString("Data4H", val);
		text = string.Empty;
		for (int i = 0; i < Extensions.get_length((Array)perks); i++)
		{
			int num7 = 0;
			if (perks[i].purchased)
			{
				num7 = 1;
			}
			int rank = (int)perks[i].rank;
			text = ((!(text == string.Empty)) ? (text + "," + rank + "," + num7) : (rank + "," + num7));
		}
		val = mdFiveSum(text + "Baconalia");
		P31Prefs.setString("Data5", text);
		megaString = megaString + "|" + text;
		P31Prefs.setString("Data5H", val);
	}

	public virtual void load()
	{
		if (P31Prefs.hasKey("Data1"))
		{
			string @string = P31Prefs.getString("Data1");
			string string2 = P31Prefs.getString("Data1H");
			string text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				myPC = UnityBuiltins.parseInt(array[0]);
				if (P31Prefs.hasKey("Stamp") && P31Prefs.getInt("Stamp") > moneyStamp)
				{
					money = UnityBuiltins.parseInt(array[1]);
				}
				else if (money < UnityBuiltins.parseInt(array[1]))
				{
					money = UnityBuiltins.parseInt(array[1]);
				}
				if (totalKills < UnityBuiltins.parseInt(array[2]))
				{
					totalKills = UnityBuiltins.parseInt(array[2]);
				}
				if (highscore < UnityBuiltins.parseInt(array[3]))
				{
					highscore = UnityBuiltins.parseInt(array[3]);
				}
				if (playersPurchased < UnityBuiltins.parseInt(array[4]))
				{
					playersPurchased = UnityBuiltins.parseInt(array[4]);
				}
				if (array[5] == "0")
				{
					voiceChat = false;
				}
				else
				{
					voiceChat = true;
				}
				if (array[6] == "0")
				{
					musicEnabled = false;
				}
				else
				{
					musicEnabled = true;
				}
				if (array[7] == "0")
				{
					soundEnabled = false;
				}
				else
				{
					soundEnabled = true;
				}
				difficulty = UnityBuiltins.parseInt(array[8]);
				if (Extensions.get_length((Array)array) >= 10)
				{
					if (array[9] == "0")
					{
						tutorial = false;
					}
					else
					{
						tutorial = true;
					}
				}
				if (Extensions.get_length((Array)array) >= 11)
				{
					if (array[10] == "0")
					{
						GCactive = false;
					}
					else
					{
						GCactive = true;
					}
				}
				if (Extensions.get_length((Array)array) >= 12)
				{
					if (array[11] == "0")
					{
						iCloud = false;
					}
					else
					{
						iCloud = true;
					}
				}
			}
			@string = P31Prefs.getString("Data2");
			string2 = P31Prefs.getString("Data2H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 7; i++)
				{
					PCs[i].weapons[0] = (WeaponEnum)UnityBuiltins.parseInt(array[i * 7]);
					PCs[i].weapons[1] = (WeaponEnum)UnityBuiltins.parseInt(array[1 + i * 7]);
					PCs[i].weapons[2] = (WeaponEnum)UnityBuiltins.parseInt(array[2 + i * 7]);
					PCs[i].perks[0] = (PerkEnum)UnityBuiltins.parseInt(array[3 + i * 7]);
					PCs[i].perks[1] = (PerkEnum)UnityBuiltins.parseInt(array[4 + i * 7]);
					PCs[i].perks[2] = (PerkEnum)UnityBuiltins.parseInt(array[5 + i * 7]);
					if (UnityBuiltins.parseInt(array[6 + i * 7]) == 1)
					{
						PCs[i].purchased = true;
					}
				}
			}
			@string = P31Prefs.getString("Data3");
			string2 = P31Prefs.getString("Data3H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 2; i++)
				{
					achievements[i].counter = UnityBuiltins.parseFloat(array[i * 2]);
					if (UnityBuiltins.parseInt(array[1 + i * 2]) == 1)
					{
						achievements[i].reported = true;
					}
					else
					{
						achievements[i].reported = false;
					}
				}
			}
			@string = P31Prefs.getString("Data4");
			string2 = P31Prefs.getString("Data4H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 2; i++)
				{
					int rank = weapons[i].rank;
					if (UnityBuiltins.parseInt(array[i * 2]) > rank)
					{
						weapons[i].rank = UnityBuiltins.parseInt(array[i * 2]);
					}
					if (weapons[i].rank > rank)
					{
						for (int j = rank + 1; j <= weapons[i].rank; j++)
						{
							applySingleWeaponRank(i, j);
						}
					}
					if (UnityBuiltins.parseInt(array[1 + i * 2]) == 1)
					{
						weapons[i].purchased = true;
					}
				}
			}
			@string = P31Prefs.getString("Data5");
			string2 = P31Prefs.getString("Data5H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 2; i++)
				{
					int rank2 = (int)perks[1].rank;
					if (rank2 <= UnityBuiltins.parseInt(array[i * 2]))
					{
						perks[i].rank = (PerkStars)UnityBuiltins.parseInt(array[i * 2]);
					}
					if (UnityBuiltins.parseInt(array[1 + i * 2]) == 1)
					{
						perks[i].purchased = true;
					}
				}
			}
		}
		moneyInfo = money;
		if (Application.loadedLevelName == "mainMenu")
		{
			Application.LoadLevel("mainMenu");
		}
	}

	public virtual string mdFiveSum(string strToEncrypt)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(strToEncrypt);
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = string.Empty;
		for (int i = 0; i < array.Length; i++)
		{
			text += Convert.ToString(array[i], 16).PadLeft(2, "0"[0]);
		}
		return text.PadLeft(32, "0"[0]);
	}

	public virtual void applyAllWeaponRanks()
	{
		for (int i = 0; i < Extensions.get_length((Array)weapons); i++)
		{
			for (int j = 0; j < weapons[i].rank; j++)
			{
				for (int k = 0; k < Extensions.get_length((Array)weapons[i].rankInfo[j].upgrades); k++)
				{
					if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.Damage)
					{
						weapons[i].damage = weapons[i].damage + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.MaxAmmo)
					{
						weapons[i].maxAmmo = weapons[i].maxAmmo + UnityBuiltins.parseInt(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.DamageFalloff)
					{
						weapons[i].damageFalloff = weapons[i].damageFalloff + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.HitChance)
					{
						weapons[i].hitChance = weapons[i].hitChance + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.HitChanceFalloff)
					{
						weapons[i].hitChanceFalloff = weapons[i].hitChanceFalloff + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.CritChance)
					{
						weapons[i].critChance = weapons[i].critChance + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.ExplosiveRadius)
					{
						weapons[i].explosiveRadius = weapons[i].explosiveRadius + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.ImpactForce)
					{
						weapons[i].impactForce = weapons[i].impactForce + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.RateOfFire)
					{
						weapons[i].rateOfFire = weapons[i].rateOfFire + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.DualWield)
					{
						if (weapons[i].rankInfo[j].upgrades[k].upgradeValue == "true")
						{
							weapons[i].dualWield = true;
						}
						else if (weapons[i].rankInfo[j].upgrades[k].upgradeValue == "false")
						{
							weapons[i].dualWield = false;
						}
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.Automatic)
					{
						if (weapons[i].rankInfo[j].upgrades[k].upgradeValue == "true")
						{
							weapons[i].automatic = true;
						}
						else if (weapons[i].rankInfo[j].upgrades[k].upgradeValue == "false")
						{
							weapons[i].automatic = false;
						}
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.UVAnimation)
					{
						if (weapons[i].rankInfo[j].upgrades[k].upgradeValue == "true")
						{
							weapons[i].UVanimation = true;
						}
						else if (weapons[i].rankInfo[j].upgrades[k].upgradeValue == "false")
						{
							weapons[i].UVanimation = false;
						}
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.WeaponModel)
					{
						weapons[i].weaponModel = weapons[i].rankInfo[j].upgrades[k].upgradeValue;
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.WeaponName)
					{
						weapons[i].weaponName = weapons[i].rankInfo[j].upgrades[k].upgradeValue;
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.ExplosiveModel)
					{
						weapons[i].explosiveModel = weapons[i].rankInfo[j].upgrades[k].upgradeValue;
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.ExplosiveFuse)
					{
						weapons[i].explosiveFuse = weapons[i].explosiveFuse + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.AimDelay)
					{
						weapons[i].aimDelay = weapons[i].aimDelay + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.AnimSet)
					{
						weapons[i].animSet = UnityBuiltins.parseInt(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.DamageType)
					{
						weapons[i].damageType = UnityBuiltins.parseInt(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.MovementLockout)
					{
						weapons[i].movementLockout = weapons[i].movementLockout + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.ShellType)
					{
						weapons[i].shellType = UnityBuiltins.parseInt(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.Spray)
					{
						weapons[i].spray = weapons[i].spray + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.MovementPenalty)
					{
						weapons[i].movementPenalty = weapons[i].movementPenalty + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.HitStyle)
					{
						weapons[i].hitStyle = weapons[i].rankInfo[j].upgrades[k].upgradeValue;
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.PiercingRange)
					{
						weapons[i].piercingRange = weapons[i].piercingRange + UnityBuiltins.parseFloat(weapons[i].rankInfo[j].upgrades[k].upgradeValue);
					}
					else if (weapons[i].rankInfo[j].upgrades[k].upgradeType == UpgradeTypeEnum.DisplayName)
					{
						weapons[i].displayName = weapons[i].rankInfo[j].upgrades[k].upgradeValue;
					}
				}
			}
		}
	}

	public virtual void applySingleWeaponRank(int i, int i2)
	{
		i2--;
		for (int j = 0; j < Extensions.get_length((Array)weapons[i].rankInfo[i2].upgrades); j++)
		{
			if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.Damage)
			{
				weapons[i].damage = weapons[i].damage + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.MaxAmmo)
			{
				weapons[i].maxAmmo = weapons[i].maxAmmo + UnityBuiltins.parseInt(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.DamageFalloff)
			{
				weapons[i].damageFalloff = weapons[i].damageFalloff + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.HitChance)
			{
				weapons[i].hitChance = weapons[i].hitChance + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.HitChanceFalloff)
			{
				weapons[i].hitChanceFalloff = weapons[i].hitChanceFalloff + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.CritChance)
			{
				weapons[i].critChance = weapons[i].critChance + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.ExplosiveRadius)
			{
				weapons[i].explosiveRadius = weapons[i].explosiveRadius + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.ImpactForce)
			{
				weapons[i].impactForce = weapons[i].impactForce + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.RateOfFire)
			{
				weapons[i].rateOfFire = weapons[i].rateOfFire + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.DualWield)
			{
				if (weapons[i].rankInfo[i2].upgrades[j].upgradeValue == "true")
				{
					weapons[i].dualWield = true;
				}
				else if (weapons[i].rankInfo[i2].upgrades[j].upgradeValue == "false")
				{
					weapons[i].dualWield = false;
				}
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.Automatic)
			{
				if (weapons[i].rankInfo[i2].upgrades[j].upgradeValue == "true")
				{
					weapons[i].automatic = true;
				}
				else if (weapons[i].rankInfo[i2].upgrades[j].upgradeValue == "false")
				{
					weapons[i].automatic = false;
				}
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.UVAnimation)
			{
				if (weapons[i].rankInfo[i2].upgrades[j].upgradeValue == "true")
				{
					weapons[i].UVanimation = true;
				}
				else if (weapons[i].rankInfo[i2].upgrades[j].upgradeValue == "false")
				{
					weapons[i].UVanimation = false;
				}
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.WeaponModel)
			{
				weapons[i].weaponModel = weapons[i].rankInfo[i2].upgrades[j].upgradeValue;
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.WeaponName)
			{
				weapons[i].weaponName = weapons[i].rankInfo[i2].upgrades[j].upgradeValue;
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.ExplosiveModel)
			{
				weapons[i].explosiveModel = weapons[i].rankInfo[i2].upgrades[j].upgradeValue;
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.ExplosiveFuse)
			{
				weapons[i].explosiveFuse = weapons[i].explosiveFuse + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.AimDelay)
			{
				weapons[i].aimDelay = weapons[i].aimDelay + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.AnimSet)
			{
				weapons[i].animSet = UnityBuiltins.parseInt(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.DamageType)
			{
				weapons[i].damageType = UnityBuiltins.parseInt(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.MovementLockout)
			{
				weapons[i].movementLockout = weapons[i].movementLockout + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.ShellType)
			{
				weapons[i].shellType = UnityBuiltins.parseInt(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.Spray)
			{
				weapons[i].spray = weapons[i].spray + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.MovementPenalty)
			{
				weapons[i].movementPenalty = weapons[i].movementPenalty + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.HitStyle)
			{
				weapons[i].hitStyle = weapons[i].rankInfo[i2].upgrades[j].upgradeValue;
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.PiercingRange)
			{
				weapons[i].piercingRange = weapons[i].piercingRange + UnityBuiltins.parseFloat(weapons[i].rankInfo[i2].upgrades[j].upgradeValue);
			}
			else if (weapons[i].rankInfo[i2].upgrades[j].upgradeType == UpgradeTypeEnum.DisplayName)
			{
				weapons[i].displayName = weapons[i].rankInfo[i2].upgrades[j].upgradeValue;
			}
		}
	}

	public virtual void gainKill()
	{
		if (!tutorial)
		{
			totalKills++;
			if (totalKills == 100)
			{
				achievements[0].counter = achievements[0].threshold;
				announceAchievement(0);
			}
			else if (totalKills == 1000)
			{
				achievements[1].counter = achievements[1].threshold;
				announceAchievement(1);
			}
			else if (totalKills == 10000)
			{
				achievements[2].counter = achievements[2].threshold;
				announceAchievement(2);
			}
			else if (totalKills == 100000)
			{
				achievements[3].counter = achievements[3].threshold;
				announceAchievement(3);
			}
		}
	}

	public virtual void announceAchievement(int whichAchievement)
	{
		GPGachievement.text = achievements[whichAchievement].GoogleID;
	}

	public virtual void uploadAchievementData()
	{
	}

	public virtual IEnumerator forceUploadAchievementData()
	{
		return new _0024forceUploadAchievementData_00241630(this).GetEnumerator();
	}

	public virtual void reportAchievementFinished(string ID)
	{
		Debug.Log("Achievement " + ID + " successfully reported to GC servers");
		for (int i = 0; i < Extensions.get_length((Array)achievements); i++)
		{
			if (achievements[i].ID == ID)
			{
				achievements[i].reported = true;
			}
		}
	}

	public virtual void OnApplicationQuit()
	{
		save();
	}

	public virtual void OnApplicationPause(bool tempBool)
	{
		if (tempBool)
		{
			save();
		}
	}

	public virtual void GCmatchmade()
	{
	}

	public virtual void cloudDownloadComplete(System.Collections.Generic.List<object> keyList)
	{
		if (iCloud)
		{
			load();
		}
	}

	public virtual void forceLoadOptions()
	{
		if (!PlayerPrefs.HasKey("Data1"))
		{
			return;
		}
		string @string = PlayerPrefs.GetString("Data1");
		string string2 = PlayerPrefs.GetString("Data1H");
		string text = mdFiveSum(@string + "Baconalia");
		if (!(text == string2) && security)
		{
			return;
		}
		string[] array = @string.Split(","[0]);
		if (array[5] == "0")
		{
			voiceChat = false;
		}
		else
		{
			voiceChat = true;
		}
		if (array[6] == "0")
		{
			musicEnabled = false;
		}
		else
		{
			musicEnabled = true;
		}
		if (array[7] == "0")
		{
			soundEnabled = false;
		}
		else
		{
			soundEnabled = true;
		}
		if (Extensions.get_length((Array)array) >= 10)
		{
			if (array[9] == "0")
			{
				tutorial = false;
			}
			else
			{
				tutorial = true;
			}
		}
		if (Extensions.get_length((Array)array) >= 11)
		{
			if (array[10] == "0")
			{
				GCactive = false;
			}
			else
			{
				GCactive = true;
			}
		}
	}

	public virtual void forceLocalLoad()
	{
		if (!PlayerPrefs.HasKey("Stamp"))
		{
			moneyStamp = 1;
			PlayerPrefs.SetInt("Stamp", moneyStamp);
		}
		else
		{
			moneyStamp = PlayerPrefs.GetInt("Stamp");
		}
		if (PlayerPrefs.HasKey("Data1"))
		{
			string @string = PlayerPrefs.GetString("Data1");
			string string2 = PlayerPrefs.GetString("Data1H");
			string text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				myPC = UnityBuiltins.parseInt(array[0]);
				money = UnityBuiltins.parseInt(array[1]);
				totalKills = UnityBuiltins.parseInt(array[2]);
				highscore = UnityBuiltins.parseInt(array[3]);
				playersPurchased = UnityBuiltins.parseInt(array[4]);
				if (array[5] == "0")
				{
					voiceChat = false;
				}
				else
				{
					voiceChat = true;
				}
				if (array[6] == "0")
				{
					musicEnabled = false;
				}
				else
				{
					musicEnabled = true;
				}
				if (array[7] == "0")
				{
					soundEnabled = false;
				}
				else
				{
					soundEnabled = true;
				}
				difficulty = UnityBuiltins.parseInt(array[8]);
				if (Extensions.get_length((Array)array) >= 10)
				{
					if (array[9] == "0")
					{
						tutorial = false;
					}
					else
					{
						tutorial = true;
					}
				}
				if (Extensions.get_length((Array)array) >= 11)
				{
					if (array[10] == "0")
					{
						GCactive = false;
					}
					else
					{
						GCactive = true;
					}
				}
				if (Extensions.get_length((Array)array) >= 12)
				{
					if (array[11] == "0")
					{
						iCloud = false;
					}
					else
					{
						iCloud = true;
					}
				}
			}
			@string = PlayerPrefs.GetString("Data2");
			string2 = PlayerPrefs.GetString("Data2H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 7; i++)
				{
					PCs[i].weapons[0] = (WeaponEnum)UnityBuiltins.parseInt(array[i * 7]);
					PCs[i].weapons[1] = (WeaponEnum)UnityBuiltins.parseInt(array[1 + i * 7]);
					PCs[i].weapons[2] = (WeaponEnum)UnityBuiltins.parseInt(array[2 + i * 7]);
					PCs[i].perks[0] = (PerkEnum)UnityBuiltins.parseInt(array[3 + i * 7]);
					PCs[i].perks[1] = (PerkEnum)UnityBuiltins.parseInt(array[4 + i * 7]);
					PCs[i].perks[2] = (PerkEnum)UnityBuiltins.parseInt(array[5 + i * 7]);
					if (UnityBuiltins.parseInt(array[6 + i * 7]) == 1)
					{
						PCs[i].purchased = true;
					}
				}
			}
			@string = PlayerPrefs.GetString("Data3");
			string2 = PlayerPrefs.GetString("Data3H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 2; i++)
				{
					achievements[i].counter = UnityBuiltins.parseFloat(array[i * 2]);
					if (UnityBuiltins.parseInt(array[1 + i * 2]) == 1)
					{
						achievements[i].reported = true;
					}
					else
					{
						achievements[i].reported = false;
					}
				}
			}
			@string = PlayerPrefs.GetString("Data4");
			string2 = PlayerPrefs.GetString("Data4H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 2; i++)
				{
					int rank = weapons[i].rank;
					weapons[i].rank = UnityBuiltins.parseInt(array[i * 2]);
					if (weapons[i].rank > rank)
					{
						for (int j = rank + 1; j <= weapons[i].rank; j++)
						{
							applySingleWeaponRank(i, j);
						}
					}
					if (UnityBuiltins.parseInt(array[1 + i * 2]) == 1)
					{
						weapons[i].purchased = true;
					}
				}
			}
			@string = PlayerPrefs.GetString("Data5");
			string2 = PlayerPrefs.GetString("Data5H");
			text = mdFiveSum(@string + "Baconalia");
			if (text == string2 || !security)
			{
				string[] array = @string.Split(","[0]);
				for (int i = 0; i < Extensions.get_length((Array)array) / 2; i++)
				{
					if ((int)perks[i].rank < UnityBuiltins.parseInt(array[i * 2]))
					{
						perks[i].rank = (PerkStars)UnityBuiltins.parseInt(array[i * 2]);
					}
					if (UnityBuiltins.parseInt(array[1 + i * 2]) == 1)
					{
						perks[i].purchased = true;
					}
				}
			}
		}
		moneyInfo = money;
	}

	public virtual void forceGoogleCloudLoad(string forcedString)
	{
		string[] array = forcedString.Split("|"[0]);
		moneyStamp = UnityBuiltins.parseInt(array[0]);
		string text = array[1];
		string[] array2 = text.Split(","[0]);
		myPC = UnityBuiltins.parseInt(array2[0]);
		money = UnityBuiltins.parseInt(array2[1]);
		totalKills = UnityBuiltins.parseInt(array2[2]);
		highscore = UnityBuiltins.parseInt(array2[3]);
		playersPurchased = UnityBuiltins.parseInt(array2[4]);
		if (array2[5] == "0")
		{
			voiceChat = false;
		}
		else
		{
			voiceChat = true;
		}
		if (array2[6] == "0")
		{
			musicEnabled = false;
		}
		else
		{
			musicEnabled = true;
		}
		if (array2[7] == "0")
		{
			soundEnabled = false;
		}
		else
		{
			soundEnabled = true;
		}
		difficulty = UnityBuiltins.parseInt(array2[8]);
		if (Extensions.get_length((Array)array2) >= 10)
		{
			if (array2[9] == "0")
			{
				tutorial = false;
			}
			else
			{
				tutorial = true;
			}
		}
		if (Extensions.get_length((Array)array2) >= 11)
		{
			if (array2[10] == "0")
			{
				GCactive = false;
			}
			else
			{
				GCactive = true;
			}
		}
		if (Extensions.get_length((Array)array2) >= 12)
		{
			if (array2[11] == "0")
			{
				iCloud = false;
			}
			else
			{
				iCloud = true;
			}
		}
		text = array[2];
		array2 = text.Split(","[0]);
		for (int i = 0; i < Extensions.get_length((Array)array2) / 7; i++)
		{
			PCs[i].weapons[0] = (WeaponEnum)UnityBuiltins.parseInt(array2[i * 7]);
			PCs[i].weapons[1] = (WeaponEnum)UnityBuiltins.parseInt(array2[1 + i * 7]);
			PCs[i].weapons[2] = (WeaponEnum)UnityBuiltins.parseInt(array2[2 + i * 7]);
			PCs[i].perks[0] = (PerkEnum)UnityBuiltins.parseInt(array2[3 + i * 7]);
			PCs[i].perks[1] = (PerkEnum)UnityBuiltins.parseInt(array2[4 + i * 7]);
			PCs[i].perks[2] = (PerkEnum)UnityBuiltins.parseInt(array2[5 + i * 7]);
			if (UnityBuiltins.parseInt(array2[6 + i * 7]) == 1)
			{
				PCs[i].purchased = true;
			}
		}
		text = array[3];
		array2 = text.Split(","[0]);
		for (int i = 0; i < Extensions.get_length((Array)array2) / 2; i++)
		{
			achievements[i].counter = UnityBuiltins.parseFloat(array2[i * 2]);
			if (UnityBuiltins.parseInt(array2[1 + i * 2]) == 1)
			{
				achievements[i].reported = true;
			}
			else
			{
				achievements[i].reported = false;
			}
		}
		text = array[4];
		array2 = text.Split(","[0]);
		for (int i = 0; i < Extensions.get_length((Array)array2) / 2; i++)
		{
			int rank = weapons[i].rank;
			weapons[i].rank = UnityBuiltins.parseInt(array2[i * 2]);
			if (weapons[i].rank > rank)
			{
				for (int j = rank + 1; j <= weapons[i].rank; j++)
				{
					applySingleWeaponRank(i, j);
				}
			}
			if (UnityBuiltins.parseInt(array2[1 + i * 2]) == 1)
			{
				weapons[i].purchased = true;
			}
		}
		text = array[5];
		array2 = text.Split(","[0]);
		for (int i = 0; i < Extensions.get_length((Array)array2) / 2; i++)
		{
			if ((int)perks[i].rank < UnityBuiltins.parseInt(array2[i * 2]))
			{
				perks[i].rank = (PerkStars)UnityBuiltins.parseInt(array2[i * 2]);
			}
			if (UnityBuiltins.parseInt(array2[1 + i * 2]) == 1)
			{
				perks[i].purchased = true;
			}
		}
		moneyInfo = money;
		save();
	}

	public virtual void Main()
	{
	}
}
