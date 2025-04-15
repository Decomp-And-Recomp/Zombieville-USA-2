using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class MotherBrain_Menu : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024disconnect_00241746 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241166_00241747;

			internal Vector3 _0024_00241167_00241748;

			internal MotherBrain_Menu _0024self__00241749;

			public _0024(MotherBrain_Menu self_)
			{
				_0024self__00241749 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241749.DB.multiplayer)
					{
						int num = (_0024_00241166_00241747 = -1);
						Vector3 vector = (_0024_00241167_00241748 = _0024self__00241749.disconnectMarker.position);
						float num2 = (_0024_00241167_00241748.x = _0024_00241166_00241747);
						Vector3 vector3 = (_0024self__00241749.disconnectMarker.position = _0024_00241167_00241748);
					}
					_0024self__00241749.DB.multiplayer = false;
					_0024self__00241749.DB.GCmultiplayer = false;
					_0024self__00241749.DB.whichPlayerAmI = 0;
					_0024self__00241749.fade = true;
					result = (Yield(2, new WaitForSeconds(1.6f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241749.DB.levelToLoad = "title";
					Application.LoadLevel("middleman");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Menu _0024self__00241750;

		public _0024disconnect_00241746(MotherBrain_Menu self_)
		{
			_0024self__00241750 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241750);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024activateButton_00241751 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241168_00241752;

			internal Vector3 _0024_00241169_00241753;

			internal int _0024_00241170_00241754;

			internal Vector3 _0024_00241171_00241755;

			internal int _0024_00241172_00241756;

			internal Vector3 _0024_00241173_00241757;

			internal int _0024_00241174_00241758;

			internal Vector3 _0024_00241175_00241759;

			internal int _0024_00241176_00241760;

			internal Vector3 _0024_00241177_00241761;

			internal int _0024_00241178_00241762;

			internal Vector3 _0024_00241179_00241763;

			internal int _0024_00241180_00241764;

			internal Vector3 _0024_00241181_00241765;

			internal int _0024_00241182_00241766;

			internal Vector3 _0024_00241183_00241767;

			internal int _0024_00241184_00241768;

			internal Vector3 _0024_00241185_00241769;

			internal int _0024_00241186_00241770;

			internal Vector3 _0024_00241187_00241771;

			internal int _0024_00241188_00241772;

			internal Vector3 _0024_00241189_00241773;

			internal int _0024_00241190_00241774;

			internal Vector3 _0024_00241191_00241775;

			internal int _0024_00241192_00241776;

			internal Vector3 _0024_00241193_00241777;

			internal int _0024_00241194_00241778;

			internal Vector3 _0024_00241195_00241779;

			internal int _0024_00241196_00241780;

			internal Vector3 _0024_00241197_00241781;

			internal MotherBrain_Menu _0024self__00241782;

			public _0024(MotherBrain_Menu self_)
			{
				_0024self__00241782 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241782.killInput = true;
					_0024self__00241782.sounds[1].Play();
					result = (Yield(2, new WaitForSeconds(0.08f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241782.whichButton.name == "MainMenuButton")
					{
						_0024self__00241782.StartCoroutine_Auto(_0024self__00241782.disconnect());
					}
					else
					{
						if (_0024self__00241782.whichButton.name == "ReadyPane")
						{
							_0024self__00241782.sounds[3].Play();
							_0024self__00241782.updateDifficultyStars();
							result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
							break;
						}
						if (_0024self__00241782.whichButton.name == "Deploy")
						{
							_0024self__00241782.sounds[3].Play();
							if (!_0024self__00241782.player2Ready)
							{
								_0024self__00241782.zoneAnim.Play("idle");
								_0024self__00241782.mapTargetPosition = new Vector3(0f, 0f, 0f);
								_0024self__00241782.showLocation = false;
								_0024self__00241782.openMap = false;
								_0024self__00241782.showInfectionLevel = false;
								_0024self__00241782.hideDeployButton = true;
								_0024self__00241782.showNext = false;
								result = (Yield(6, new WaitForSeconds(0.15f)) ? 1 : 0);
								break;
							}
							_0024self__00241782.StartCoroutine_Auto(_0024self__00241782.startGame());
						}
						else if (_0024self__00241782.whichButton.name == "NextLevelButton")
						{
							if (_0024self__00241782.DB.difficulty < 10)
							{
								_0024self__00241782.DB.difficulty = _0024self__00241782.DB.difficulty + 1;
							}
							else
							{
								_0024self__00241782.DB.difficulty = 1;
							}
							_0024self__00241782.updateDifficultyStars();
						}
						else if (_0024self__00241782.whichButton.name == "PreviousLevelButton")
						{
							if (_0024self__00241782.DB.difficulty > 1)
							{
								_0024self__00241782.DB.difficulty = _0024self__00241782.DB.difficulty - 1;
							}
							else
							{
								_0024self__00241782.DB.difficulty = 10;
							}
							_0024self__00241782.updateDifficultyStars();
						}
						else
						{
							if (_0024self__00241782.whichButton.name == "MapCancelButton")
							{
								if (_0024self__00241782.pleaseWait.position.y == 0f)
								{
									int num3 = (_0024_00241174_00241758 = 0);
									Vector3 vector4 = (_0024_00241175_00241759 = _0024self__00241782.readyMarker2.position);
									float num4 = (_0024_00241175_00241759.x = _0024_00241174_00241758);
									Vector3 vector6 = (_0024self__00241782.readyMarker2.position = _0024_00241175_00241759);
									int num5 = (_0024_00241176_00241760 = -20);
									Vector3 vector7 = (_0024_00241177_00241761 = _0024self__00241782.pleaseWait.position);
									float num6 = (_0024_00241177_00241761.y = _0024_00241176_00241760);
									Vector3 vector9 = (_0024self__00241782.pleaseWait.position = _0024_00241177_00241761);
								}
								int num7 = (_0024_00241178_00241762 = -20);
								Vector3 vector10 = (_0024_00241179_00241763 = _0024self__00241782.pleaseWaitForPlayer2.position);
								float num8 = (_0024_00241179_00241763.y = _0024_00241178_00241762);
								Vector3 vector12 = (_0024self__00241782.pleaseWaitForPlayer2.position = _0024_00241179_00241763);
								_0024self__00241782.zoneAnim.Play("idle");
								_0024self__00241782.mapTargetPosition = new Vector3(0f, 0f, 0f);
								_0024self__00241782.showLocation = false;
								_0024self__00241782.openMap = false;
								_0024self__00241782.showInfectionLevel = false;
								_0024self__00241782.hideDeployButton = true;
								_0024self__00241782.showNext = false;
								_0024self__00241782.showMapCancel = false;
								result = (Yield(8, new WaitForSeconds(0.15f)) ? 1 : 0);
								break;
							}
							if (_0024self__00241782.whichButton.name == "WeaponPane1" || _0024self__00241782.whichButton.name == "WeaponPane2" || _0024self__00241782.whichButton.name == "WeaponPane3")
							{
								_0024self__00241782.hideReadyButton = true;
								_0024self__00241782.hideExitButton = true;
								_0024self__00241782.updateScrollingWeaponList();
								_0024self__00241782.maximumPages = 4;
								_0024self__00241782.editWeaponSlot = _0024self__00241782.whichButton;
								_0024self__00241782.topLeftText.text = "Weapon Select";
								int num9 = (_0024_00241180_00241764 = -3);
								Vector3 vector13 = (_0024_00241181_00241765 = _0024self__00241782.editWeaponSlot.position);
								float num10 = (_0024_00241181_00241765.z = _0024_00241180_00241764);
								Vector3 vector15 = (_0024self__00241782.editWeaponSlot.position = _0024_00241181_00241765);
								_0024self__00241782.moveConsoleDown = true;
								result = (Yield(11, new WaitForSeconds(0.1f)) ? 1 : 0);
								break;
							}
							if (_0024self__00241782.whichButton.name == "PerkPane1" || _0024self__00241782.whichButton.name == "PerkPane2" || _0024self__00241782.whichButton.name == "PerkPane3")
							{
								_0024self__00241782.hideReadyButton = true;
								_0024self__00241782.hideExitButton = true;
								_0024self__00241782.updateScrollingPerkList();
								_0024self__00241782.maximumPages = 5;
								_0024self__00241782.editWeaponSlot = _0024self__00241782.whichButton;
								_0024self__00241782.topLeftText.text = "Skill Select";
								int num11 = (_0024_00241184_00241768 = -3);
								Vector3 vector16 = (_0024_00241185_00241769 = _0024self__00241782.editWeaponSlot.position);
								float num12 = (_0024_00241185_00241769.z = _0024_00241184_00241768);
								Vector3 vector18 = (_0024self__00241782.editWeaponSlot.position = _0024_00241185_00241769);
								_0024self__00241782.moveConsoleDown = true;
								result = (Yield(14, new WaitForSeconds(0.1f)) ? 1 : 0);
								break;
							}
							if (_0024self__00241782.whichButton.name == "PlayerWindow")
							{
								_0024self__00241782.hideReadyButton = true;
								_0024self__00241782.hideExitButton = true;
								_0024self__00241782.updateScrollingPlayerList();
								_0024self__00241782.maximumPages = 4;
								_0024self__00241782.editWeaponSlot = _0024self__00241782.whichButton;
								_0024self__00241782.topLeftText.text = "Player Select";
								int num13 = (_0024_00241188_00241772 = -2);
								Vector3 vector19 = (_0024_00241189_00241773 = _0024self__00241782.editWeaponSlot.position);
								float num14 = (_0024_00241189_00241773.z = _0024_00241188_00241772);
								Vector3 vector21 = (_0024self__00241782.editWeaponSlot.position = _0024_00241189_00241773);
								_0024self__00241782.playerSpawnScript.changeLayer(12);
								_0024self__00241782.playerCullerGO.layer = 12;
								_0024self__00241782.moveConsoleDown = true;
								result = (Yield(17, new WaitForSeconds(0.1f)) ? 1 : 0);
								break;
							}
							if (_0024self__00241782.whichButton.name == "CancelButton")
							{
								if (_0024self__00241782.panelMode == "weaponUpgrade")
								{
									_0024self__00241782.upgradeDescriptionPrinter.Printout(string.Empty);
									_0024self__00241782.panelMode = "weapon";
									_0024self__00241782.showPurchaseConsole = false;
									result = (Yield(20, new WaitForSeconds(0.15f)) ? 1 : 0);
									break;
								}
								if (_0024self__00241782.panelMode == "perkUpgrade")
								{
									_0024self__00241782.upgradeDescriptionPrinter.Printout(string.Empty);
									_0024self__00241782.panelMode = "perk";
									_0024self__00241782.showPurchaseConsole = false;
									result = (Yield(21, new WaitForSeconds(0.15f)) ? 1 : 0);
									break;
								}
								if (_0024self__00241782.showWeaponPerkName)
								{
									_0024self__00241782.showPurchaseConsole = false;
									_0024self__00241782.showUpgradeConsole = false;
									_0024self__00241782.descriptionPrinter.Printout(string.Empty);
									_0024self__00241782.showWeaponPerkName = false;
									_0024self__00241782.moveIsoIcon = false;
									_0024self__00241782.moveIsoIconBack = true;
									result = (Yield(22, new WaitForSeconds(0.3f)) ? 1 : 0);
									break;
								}
							}
							else if (_0024self__00241782.whichButton.name == "BuyButton")
							{
								_0024self__00241782.DB.save();
								_0024self__00241782.identifyPanel();
								if (_0024self__00241782.panelMode == "weaponUpgrade")
								{
									if (_0024self__00241782.DB.money >= _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank + 1])
									{
										_0024self__00241782.DB.money = _0024self__00241782.DB.money - _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank + 1];
										_0024self__00241782.DB.moneyStamp = _0024self__00241782.DB.moneyStamp + 1;
										_0024self__00241782.sounds[0].Play();
										_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank = _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank + 1;
										_0024self__00241782.DB.applySingleWeaponRank((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon, _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank);
										_0024self__00241782.upgradeDescriptionPrinter.Printout(string.Empty);
										_0024self__00241782.updateLoadout();
										if (_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank == 5)
										{
											_0024self__00241782.showPurchaseConsole = false;
											if (_0024self__00241782.DB.achievements[10].counter != (float)_0024self__00241782.DB.achievements[10].threshold)
											{
												_0024self__00241782.DB.achievements[10].counter = _0024self__00241782.DB.achievements[10].threshold;
												_0024self__00241782.DB.announceAchievement(10);
											}
										}
										result = (Yield(23, new WaitForSeconds(0.15f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024self__00241782.panelMode == "perkUpgrade")
								{
									if (_0024self__00241782.DB.money >= _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[(int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1)])
									{
										_0024self__00241782.DB.money = _0024self__00241782.DB.money - _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[(int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1)];
										_0024self__00241782.DB.moneyStamp = _0024self__00241782.DB.moneyStamp + 1;
										_0024self__00241782.sounds[0].Play();
										_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank = _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1;
										_0024self__00241782.upgradeDescriptionPrinter.Printout(string.Empty);
										if (_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank == PerkStars.Rank5)
										{
											_0024self__00241782.showPurchaseConsole = false;
											if (_0024self__00241782.DB.achievements[11].counter != (float)_0024self__00241782.DB.achievements[11].threshold)
											{
												_0024self__00241782.DB.achievements[11].counter = _0024self__00241782.DB.achievements[11].threshold;
												_0024self__00241782.DB.announceAchievement(11);
											}
										}
										result = (Yield(24, new WaitForSeconds(0.15f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024self__00241782.panelMode == "weapon")
								{
									if (_0024self__00241782.DB.money >= _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[0])
									{
										_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].purchased = true;
										_0024self__00241782.DB.money = _0024self__00241782.DB.money - _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[0];
										_0024self__00241782.DB.moneyStamp = _0024self__00241782.DB.moneyStamp + 1;
										_0024self__00241782.sounds[0].Play();
										_0024self__00241782.showPurchaseConsole = false;
										result = (Yield(25, new WaitForSeconds(0.15f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024self__00241782.panelMode == "perk")
								{
									if (_0024self__00241782.DB.money >= _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[0])
									{
										_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].purchased = true;
										_0024self__00241782.DB.money = _0024self__00241782.DB.money - _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[0];
										_0024self__00241782.DB.moneyStamp = _0024self__00241782.DB.moneyStamp + 1;
										_0024self__00241782.sounds[0].Play();
										_0024self__00241782.showPurchaseConsole = false;
										result = (Yield(26, new WaitForSeconds(0.15f)) ? 1 : 0);
										break;
									}
								}
								else if (_0024self__00241782.panelMode == "player" && _0024self__00241782.DB.money >= _0024self__00241782.DB.playerPriceTable[_0024self__00241782.DB.playersPurchased])
								{
									_0024self__00241782.DB.PCs[_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].PC].purchased = true;
									_0024self__00241782.DB.money = _0024self__00241782.DB.money - _0024self__00241782.DB.playerPriceTable[_0024self__00241782.DB.playersPurchased];
									_0024self__00241782.DB.moneyStamp = _0024self__00241782.DB.moneyStamp + 1;
									_0024self__00241782.sounds[0].Play();
									_0024self__00241782.DB.playersPurchased = _0024self__00241782.DB.playersPurchased + 1;
									_0024self__00241782.showPurchaseConsole = false;
									result = (Yield(27, new WaitForSeconds(0.15f)) ? 1 : 0);
									break;
								}
							}
							else if (_0024self__00241782.whichButton.name == "UpgradeButton")
							{
								_0024self__00241782.DB.save();
								if (_0024self__00241782.showUpgradeConsole)
								{
									_0024self__00241782.identifyPanel();
									if (_0024self__00241782.panelMode == "weapon")
									{
										_0024self__00241782.panelMode = "weaponUpgrade";
										_0024self__00241782.showUpgradeConsole = false;
										_0024self__00241782.descriptionPrinter.Printout(string.Empty);
										result = (Yield(28, new WaitForSeconds(0.15f)) ? 1 : 0);
										break;
									}
									if (_0024self__00241782.panelMode == "perk")
									{
										_0024self__00241782.panelMode = "perkUpgrade";
										_0024self__00241782.showUpgradeConsole = false;
										_0024self__00241782.descriptionPrinter.Printout(string.Empty);
										result = (Yield(29, new WaitForSeconds(0.15f)) ? 1 : 0);
										break;
									}
								}
							}
							else if (_0024self__00241782.whichButton.name == "OkayButton")
							{
								_0024self__00241782.DB.save();
								if (_0024self__00241782.showUpgradeConsole)
								{
									_0024self__00241782.identifyPanel();
									if (_0024self__00241782.panelMode == "weapon")
									{
										_0024self__00241782.StartCoroutine_Auto(_0024self__00241782.equip((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon));
									}
									else if (_0024self__00241782.panelMode == "perk")
									{
										_0024self__00241782.StartCoroutine_Auto(_0024self__00241782.equipPerk((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk));
									}
									else if (_0024self__00241782.panelMode == "player")
									{
										_0024self__00241782.DB.myPC = _0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].PC;
										_0024self__00241782.updateVisiblePlayer();
										_0024self__00241782.playerSpawnScript.changeLayer(12);
										_0024self__00241782.updateLoadout();
										_0024self__00241782.showPurchaseConsole = false;
										_0024self__00241782.showUpgradeConsole = false;
										_0024self__00241782.descriptionPrinter.Printout(string.Empty);
										_0024self__00241782.showWeaponPerkName = false;
										_0024self__00241782.moveIsoIcon = false;
										_0024self__00241782.moveIsoIconBack = true;
										result = (Yield(30, new WaitForSeconds(0.3f)) ? 1 : 0);
										break;
									}
								}
							}
							else if (_0024self__00241782.openWeaponPane && !_0024self__00241782.moveIsoIcon)
							{
								_0024self__00241782.scrollingSpeed = 0f;
								_0024self__00241782.editPanel = _0024self__00241782.whichButton;
								int num15 = (_0024_00241196_00241780 = -3);
								Vector3 vector22 = (_0024_00241197_00241781 = _0024self__00241782.editPanel.position);
								float num16 = (_0024_00241197_00241781.z = _0024_00241196_00241780);
								Vector3 vector24 = (_0024self__00241782.editPanel.position = _0024_00241197_00241781);
								_0024self__00241782.iconIsoStartPos = _0024self__00241782.editPanel.position;
								_0024self__00241782.iconIsoRenderer.enabled = true;
								result = (Yield(31, new WaitForSeconds(0.1f)) ? 1 : 0);
								break;
							}
						}
					}
					goto IL_3151;
				case 3:
					_0024self__00241782.hideReadyButton = true;
					_0024self__00241782.hideExitButton = true;
					_0024self__00241782.hideConsole = true;
					_0024self__00241782.hideCash = true;
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 4:
					if (_0024self__00241782.DB.whichPlayerAmI == 1)
					{
						_0024self__00241782.showMap = true;
						result = (Yield(5, new WaitForSeconds(0.2f)) ? 1 : 0);
						break;
					}
					if (_0024self__00241782.DB.whichPlayerAmI == 2)
					{
						_0024self__00241782.showMapCancel = true;
						int num27 = (_0024_00241168_00241752 = 0);
						Vector3 vector40 = (_0024_00241169_00241753 = _0024self__00241782.pleaseWait.position);
						float num28 = (_0024_00241169_00241753.y = _0024_00241168_00241752);
						Vector3 vector42 = (_0024self__00241782.pleaseWait.position = _0024_00241169_00241753);
						int num29 = (_0024_00241170_00241754 = 1);
						Vector3 vector43 = (_0024_00241171_00241755 = _0024self__00241782.readyMarker2.position);
						float num30 = (_0024_00241171_00241755.x = _0024_00241170_00241754);
						Vector3 vector45 = (_0024self__00241782.readyMarker2.position = _0024_00241171_00241755);
					}
					goto IL_3151;
				case 5:
					_0024self__00241782.showInfectionLevel = true;
					_0024self__00241782.openMap = true;
					_0024self__00241782.sounds[2].Play();
					_0024self__00241782.scrollMap = true;
					if (_0024self__00241782.DB.totalKills >= _0024self__00241782.zones[_0024self__00241782.DB.difficulty - 1].requiredKills)
					{
						_0024self__00241782.zoneAnim.Stop();
						_0024self__00241782.zoneAnim.Play("open");
						_0024self__00241782.hideDeployButton = false;
					}
					_0024self__00241782.showNext = true;
					_0024self__00241782.showMapCancel = true;
					_0024self__00241782.showLocation = true;
					goto IL_3151;
				case 6:
					_0024self__00241782.showMap = false;
					_0024self__00241782.mapTransform.localPosition = _0024self__00241782.mapTargetPosition;
					result = (Yield(7, new WaitForSeconds(0.09f)) ? 1 : 0);
					break;
				case 7:
				{
					int num17 = (_0024_00241172_00241756 = 0);
					Vector3 vector25 = (_0024_00241173_00241757 = _0024self__00241782.pleaseWaitForPlayer2.position);
					float num18 = (_0024_00241173_00241757.y = _0024_00241172_00241756);
					Vector3 vector27 = (_0024self__00241782.pleaseWaitForPlayer2.position = _0024_00241173_00241757);
					goto IL_3151;
				}
				case 8:
					_0024self__00241782.showMap = false;
					_0024self__00241782.mapTransform.localPosition = _0024self__00241782.mapTargetPosition;
					result = (Yield(9, new WaitForSeconds(0.09f)) ? 1 : 0);
					break;
				case 9:
					_0024self__00241782.hideReadyButton = false;
					_0024self__00241782.hideConsole = false;
					_0024self__00241782.sounds[2].Play();
					_0024self__00241782.hideCash = false;
					_0024self__00241782.hideExitButton = false;
					result = (Yield(10, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 10:
					_0024self__00241782.scrollMap = false;
					goto IL_3151;
				case 11:
					_0024self__00241782.liftWeaponPane = true;
					result = (Yield(12, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 12:
				{
					_0024self__00241782.openWeaponPane = true;
					_0024self__00241782.sounds[2].Play();
					_0024self__00241782.mainConsoleShade = true;
					int num = (_0024_00241182_00241766 = -10);
					Vector3 vector = (_0024_00241183_00241767 = _0024self__00241782.scrollingWeaponMenu.position);
					float num2 = (_0024_00241183_00241767.x = _0024_00241182_00241766);
					Vector3 vector3 = (_0024self__00241782.scrollingWeaponMenu.position = _0024_00241183_00241767);
					_0024self__00241782.scrollingSpeed = 20f;
					_0024self__00241782.editWeaponSlot.gameObject.layer = 15;
					if ((bool)_0024self__00241782.editWeaponSlot.Find("Icon"))
					{
						_0024self__00241782.editWeaponSlot.Find("Icon").gameObject.layer = 15;
					}
					result = (Yield(13, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 13:
					_0024self__00241782.showTopLeft = true;
					_0024self__00241782.panelMode = "weapon";
					goto IL_3151;
				case 14:
					_0024self__00241782.liftWeaponPane = true;
					result = (Yield(15, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 15:
				{
					_0024self__00241782.openWeaponPane = true;
					_0024self__00241782.sounds[2].Play();
					_0024self__00241782.mainConsoleShade = true;
					int num25 = (_0024_00241186_00241770 = -10);
					Vector3 vector37 = (_0024_00241187_00241771 = _0024self__00241782.scrollingWeaponMenu.position);
					float num26 = (_0024_00241187_00241771.x = _0024_00241186_00241770);
					Vector3 vector39 = (_0024self__00241782.scrollingWeaponMenu.position = _0024_00241187_00241771);
					_0024self__00241782.scrollingSpeed = 20f;
					_0024self__00241782.editWeaponSlot.gameObject.layer = 15;
					if ((bool)_0024self__00241782.editWeaponSlot.Find("Icon"))
					{
						_0024self__00241782.editWeaponSlot.Find("Icon").gameObject.layer = 15;
					}
					result = (Yield(16, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 16:
					_0024self__00241782.showTopLeftShort = true;
					_0024self__00241782.panelMode = "perk";
					goto IL_3151;
				case 17:
					_0024self__00241782.liftWeaponPane = true;
					result = (Yield(18, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 18:
				{
					_0024self__00241782.openWeaponPane = true;
					_0024self__00241782.sounds[2].Play();
					_0024self__00241782.mainConsoleShade = true;
					int num23 = (_0024_00241190_00241774 = -10);
					Vector3 vector34 = (_0024_00241191_00241775 = _0024self__00241782.scrollingWeaponMenu.position);
					float num24 = (_0024_00241191_00241775.x = _0024_00241190_00241774);
					Vector3 vector36 = (_0024self__00241782.scrollingWeaponMenu.position = _0024_00241191_00241775);
					_0024self__00241782.scrollingSpeed = 20f;
					_0024self__00241782.editWeaponSlot.gameObject.layer = 15;
					result = (Yield(19, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 19:
					_0024self__00241782.showTopLeftMed = true;
					_0024self__00241782.panelMode = "player";
					goto IL_3151;
				case 20:
					_0024self__00241782.showUpgradeConsole = true;
					_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].description);
					goto IL_3151;
				case 21:
					_0024self__00241782.showUpgradeConsole = true;
					_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].perkDescription);
					goto IL_3151;
				case 22:
				{
					_0024self__00241782.editPanel.position = _0024self__00241782.iconIsoStartPos;
					int num19 = (_0024_00241192_00241776 = 0);
					Vector3 vector28 = (_0024_00241193_00241777 = _0024self__00241782.editPanel.position);
					float num20 = (_0024_00241193_00241777.z = _0024_00241192_00241776);
					Vector3 vector30 = (_0024self__00241782.editPanel.position = _0024_00241193_00241777);
					_0024self__00241782.editPanel = null;
					_0024self__00241782.iconIsoRenderer.enabled = false;
					_0024self__00241782.moveIsoIconBack = false;
					_0024self__00241782.killInput = false;
					goto IL_3151;
				}
				case 23:
					_0024self__00241782.updateScrollingWeaponList();
					_0024self__00241782.updateStars(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank);
					if (_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank < 5)
					{
						_0024self__00241782.upgradeDescriptionPrinter.Printout(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rankInfo[_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank].upgradeDescription);
						_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank + 1];
					}
					else
					{
						_0024self__00241782.showUpgradeConsole = true;
						_0024self__00241782.upgradeDescriptionPrinter.Printout(string.Empty);
						_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].description);
						_0024self__00241782.panelMode = "weapon";
						_0024self__00241782.upgradeButtonVisibility((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon, "weapon");
					}
					if ((bool)_0024self__00241782.blinkyRenderer && _0024self__00241782.blinkyRenderer.enabled)
					{
						_0024self__00241782.blinkyRenderer.enabled = false;
					}
					_0024self__00241782.blinkyRenderer = (Renderer)_0024self__00241782.editPanel.Find("Light").GetComponent(typeof(Renderer));
					_0024self__00241782.blinkTimer = 0.5f;
					_0024self__00241782.blinkyActive = true;
					_0024self__00241782.weaponPerkName.text = _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].displayName;
					goto IL_3151;
				case 24:
					_0024self__00241782.updateStars((int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1));
					if (_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank < PerkStars.Rank5)
					{
						_0024self__00241782.upgradeDescriptionPrinter.Printout(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rankDescriptions[(int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1)]);
						_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[(int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1)];
					}
					else
					{
						_0024self__00241782.showUpgradeConsole = true;
						_0024self__00241782.upgradeDescriptionPrinter.Printout(string.Empty);
						_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].perkDescription);
						_0024self__00241782.panelMode = "perk";
						_0024self__00241782.upgradeButtonVisibility((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk, "perk");
					}
					if ((bool)_0024self__00241782.blinkyRenderer && _0024self__00241782.blinkyRenderer.enabled)
					{
						_0024self__00241782.blinkyRenderer.enabled = false;
					}
					_0024self__00241782.blinkyRenderer = (Renderer)_0024self__00241782.editPanel.Find("Light").GetComponent(typeof(Renderer));
					_0024self__00241782.blinkTimer = 0.5f;
					_0024self__00241782.blinkyActive = true;
					goto IL_3151;
				case 25:
					_0024self__00241782.showUpgradeConsole = true;
					_0024self__00241782.hideStars = false;
					_0024self__00241782.upgradeButtonVisibility((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon, "weapon");
					_0024self__00241782.updateScrollingWeaponList();
					if ((bool)_0024self__00241782.blinkyRenderer && _0024self__00241782.blinkyRenderer.enabled)
					{
						_0024self__00241782.blinkyRenderer.enabled = false;
					}
					_0024self__00241782.blinkyRenderer = (Renderer)_0024self__00241782.editPanel.Find("Light").GetComponent(typeof(Renderer));
					_0024self__00241782.blinkTimer = 0.5f;
					_0024self__00241782.blinkyActive = true;
					goto IL_3151;
				case 26:
					_0024self__00241782.showUpgradeConsole = true;
					_0024self__00241782.hideStars = false;
					_0024self__00241782.upgradeButtonVisibility((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk, "perk");
					_0024self__00241782.updateScrollingPerkList();
					if ((bool)_0024self__00241782.blinkyRenderer && _0024self__00241782.blinkyRenderer.enabled)
					{
						_0024self__00241782.blinkyRenderer.enabled = false;
					}
					_0024self__00241782.blinkyRenderer = (Renderer)_0024self__00241782.editPanel.Find("Light").GetComponent(typeof(Renderer));
					_0024self__00241782.updateStars((int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1));
					_0024self__00241782.blinkTimer = 0.5f;
					_0024self__00241782.blinkyActive = true;
					goto IL_3151;
				case 27:
					_0024self__00241782.showUpgradeConsole = true;
					_0024self__00241782.hideStars = true;
					_0024self__00241782.upgradeButtonVisibility(0, "player");
					_0024self__00241782.updateScrollingPlayerList();
					if ((bool)_0024self__00241782.blinkyRenderer && _0024self__00241782.blinkyRenderer.enabled)
					{
						_0024self__00241782.blinkyRenderer.enabled = false;
					}
					_0024self__00241782.blinkyRenderer = (Renderer)_0024self__00241782.editPanel.Find("Light").GetComponent(typeof(Renderer));
					_0024self__00241782.blinkTimer = 0.5f;
					_0024self__00241782.blinkyActive = true;
					goto IL_3151;
				case 28:
					_0024self__00241782.showPurchaseConsole = true;
					_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank + 1];
					_0024self__00241782.upgradeDescriptionPrinter.Printout(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rankInfo[_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank].upgradeDescription);
					goto IL_3151;
				case 29:
					_0024self__00241782.showPurchaseConsole = true;
					_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[(int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1)];
					_0024self__00241782.upgradeDescriptionPrinter.Printout(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rankDescriptions[(int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1)]);
					goto IL_3151;
				case 30:
				{
					_0024self__00241782.editPanel.position = _0024self__00241782.iconIsoStartPos;
					int num21 = (_0024_00241194_00241778 = 0);
					Vector3 vector31 = (_0024_00241195_00241779 = _0024self__00241782.editPanel.position);
					float num22 = (_0024_00241195_00241779.z = _0024_00241194_00241778);
					Vector3 vector33 = (_0024self__00241782.editPanel.position = _0024_00241195_00241779);
					_0024self__00241782.editPanel = null;
					_0024self__00241782.iconIsoRenderer.enabled = false;
					_0024self__00241782.moveIsoIconBack = false;
					goto IL_3151;
				}
				case 31:
					_0024self__00241782.moveIsoIcon = true;
					result = (Yield(32, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 32:
					_0024self__00241782.showWeaponPerkName = true;
					_0024self__00241782.identifyPanel();
					if (_0024self__00241782.panelMode == "weapon")
					{
						_0024self__00241782.weaponPerkName.text = _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].displayName;
						_0024self__00241782.weaponPerkNameTransform.localScale = new Vector3(0.078f, 0.078f, 0.078f);
						_0024self__00241782.updateStars(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].rank);
						_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].description);
						if (_0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].purchased)
						{
							_0024self__00241782.showUpgradeConsole = true;
							_0024self__00241782.hideStars = false;
							_0024self__00241782.upgradeButtonVisibility((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon, "weapon");
						}
						else
						{
							_0024self__00241782.showPurchaseConsole = true;
							_0024self__00241782.hideStars = true;
							_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.weapons[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].weapon].price[0];
						}
					}
					else if (_0024self__00241782.panelMode == "perk")
					{
						_0024self__00241782.weaponPerkName.text = _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].perkName;
						if (_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].topDisplaySize != 0f)
						{
							_0024self__00241782.weaponPerkNameTransform.localScale = new Vector3(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].topDisplaySize, _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].topDisplaySize, _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].topDisplaySize);
						}
						else
						{
							_0024self__00241782.weaponPerkNameTransform.localScale = new Vector3(0.078f, 0.078f, 0.078f);
						}
						_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].perkDescription);
						if (_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].purchased)
						{
							_0024self__00241782.showUpgradeConsole = true;
							_0024self__00241782.hideStars = false;
							_0024self__00241782.upgradeButtonVisibility((int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk, "perk");
							_0024self__00241782.updateStars((int)(_0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].rank + 1));
						}
						else
						{
							_0024self__00241782.showPurchaseConsole = true;
							_0024self__00241782.hideStars = true;
							_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.perks[(int)_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].perk].price[0];
							_0024self__00241782.updateStars(0);
						}
					}
					else if (_0024self__00241782.panelMode == "player")
					{
						_0024self__00241782.weaponPerkName.text = _0024self__00241782.DB.PCs[_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].PC].displayName;
						_0024self__00241782.weaponPerkNameTransform.localScale = new Vector3(0.078f, 0.078f, 0.078f);
						_0024self__00241782.hideStars = true;
						_0024self__00241782.descriptionPrinter.Printout(_0024self__00241782.DB.PCs[_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].PC].description);
						if (_0024self__00241782.DB.PCs[_0024self__00241782.scrollingListSlots[_0024self__00241782.panelID].PC].purchased)
						{
							_0024self__00241782.showUpgradeConsole = true;
							_0024self__00241782.upgradeButtonVisibility(0, "player");
						}
						else
						{
							_0024self__00241782.showPurchaseConsole = true;
							_0024self__00241782.purchaseText.text = "Price: $" + _0024self__00241782.DB.playerPriceTable[_0024self__00241782.DB.playersPurchased];
						}
					}
					goto IL_3151;
				case 1:
					{
						result = 0;
						break;
					}
					IL_3151:
					_0024self__00241782.killInput = false;
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Menu _0024self__00241783;

		public _0024activateButton_00241751(MotherBrain_Menu self_)
		{
			_0024self__00241783 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241783);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024closeSubMenu_00241784 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241198_00241785;

			internal Vector3 _0024_00241199_00241786;

			internal int _0024_00241200_00241787;

			internal Vector3 _0024_00241201_00241788;

			internal MotherBrain_Menu _0024self__00241789;

			public _0024(MotherBrain_Menu self_)
			{
				_0024self__00241789 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241789.sounds[2].Play();
					_0024self__00241789.killInput = true;
					if (_0024self__00241789.showWeaponPerkName)
					{
						_0024self__00241789.showPurchaseConsole = false;
						_0024self__00241789.showUpgradeConsole = false;
						_0024self__00241789.descriptionPrinter.Printout(string.Empty);
						_0024self__00241789.upgradeDescriptionPrinter.Printout(string.Empty);
						_0024self__00241789.showWeaponPerkName = false;
						_0024self__00241789.moveIsoIcon = false;
						_0024self__00241789.moveIsoIconBack = true;
						result = (Yield(2, new WaitForSeconds(0.12f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 2:
				{
					_0024self__00241789.editPanel.position = _0024self__00241789.iconIsoStartPos;
					int num3 = (_0024_00241198_00241785 = 0);
					Vector3 vector4 = (_0024_00241199_00241786 = _0024self__00241789.editPanel.position);
					float num4 = (_0024_00241199_00241786.z = _0024_00241198_00241785);
					Vector3 vector6 = (_0024self__00241789.editPanel.position = _0024_00241199_00241786);
					_0024self__00241789.iconIsoRenderer.enabled = false;
					_0024self__00241789.moveIsoIconBack = false;
					_0024self__00241789.editPanel = null;
					result = (Yield(3, new WaitForSeconds(0.08f)) ? 1 : 0);
					break;
				}
				case 3:
					_0024self__00241789.showTopLeft = false;
					_0024self__00241789.showTopLeftShort = false;
					_0024self__00241789.showTopLeftMed = false;
					_0024self__00241789.mainConsoleShade = false;
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241789.openWeaponPane = false;
					result = (Yield(5, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241789.liftWeaponPane = false;
					result = (Yield(6, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00241789.moveConsoleDown = false;
					if ((bool)_0024self__00241789.editWeaponSlot)
					{
						_0024self__00241789.editWeaponSlot.gameObject.layer = 10;
						int num = (_0024_00241200_00241787 = 0);
						Vector3 vector = (_0024_00241201_00241788 = _0024self__00241789.editWeaponSlot.position);
						float num2 = (_0024_00241201_00241788.z = _0024_00241200_00241787);
						Vector3 vector3 = (_0024self__00241789.editWeaponSlot.position = _0024_00241201_00241788);
						if ((bool)_0024self__00241789.editWeaponSlot.Find("Icon"))
						{
							_0024self__00241789.editWeaponSlot.Find("Icon").gameObject.layer = 0;
						}
					}
					_0024self__00241789.playerSpawnScript.changeLayer(14);
					_0024self__00241789.playerCullerGO.layer = 14;
					result = (Yield(7, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 7:
					if (_0024self__00241789.DB.whichPlayerAmI != 0)
					{
						_0024self__00241789.hideReadyButton = false;
					}
					_0024self__00241789.hideExitButton = false;
					_0024self__00241789.blinkyRenderer = null;
					_0024self__00241789.whichButton = null;
					_0024self__00241789.killInput = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Menu _0024self__00241790;

		public _0024closeSubMenu_00241784(MotherBrain_Menu self_)
		{
			_0024self__00241790 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241790);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024equip_00241791 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024slotToFill_00241792;

			internal int _0024alreadyInSlot_00241793;

			internal int _0024i_00241794;

			internal WeaponEnum _0024oldWeapon_00241795;

			internal int _0024_00241218_00241796;

			internal Vector3 _0024_00241219_00241797;

			internal int _0024whichWeapon_00241798;

			internal MotherBrain_Menu _0024self__00241799;

			public _0024(int whichWeapon, MotherBrain_Menu self_)
			{
				_0024whichWeapon_00241798 = whichWeapon;
				_0024self__00241799 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024slotToFill_00241792 = 0;
					if (_0024self__00241799.editWeaponSlot.name == "WeaponPane2")
					{
						_0024slotToFill_00241792 = 1;
					}
					else if (_0024self__00241799.editWeaponSlot.name == "WeaponPane3")
					{
						_0024slotToFill_00241792 = 2;
					}
					_0024alreadyInSlot_00241793 = -1;
					for (_0024i_00241794 = 0; _0024i_00241794 < 3; _0024i_00241794++)
					{
						if (_0024self__00241799.DB.PCs[_0024self__00241799.DB.myPC].weapons[_0024i_00241794] == (WeaponEnum)_0024whichWeapon_00241798)
						{
							_0024alreadyInSlot_00241793 = _0024i_00241794;
						}
					}
					if (_0024alreadyInSlot_00241793 == -1)
					{
						_0024self__00241799.DB.PCs[_0024self__00241799.DB.myPC].weapons[_0024slotToFill_00241792] = (WeaponEnum)_0024whichWeapon_00241798;
					}
					else
					{
						_0024oldWeapon_00241795 = _0024self__00241799.DB.PCs[_0024self__00241799.DB.myPC].weapons[_0024slotToFill_00241792];
						_0024self__00241799.DB.PCs[_0024self__00241799.DB.myPC].weapons[_0024slotToFill_00241792] = (WeaponEnum)_0024whichWeapon_00241798;
						_0024self__00241799.DB.PCs[_0024self__00241799.DB.myPC].weapons[_0024alreadyInSlot_00241793] = _0024oldWeapon_00241795;
					}
					_0024self__00241799.updateLoadout();
					if (_0024slotToFill_00241792 == 0 || _0024alreadyInSlot_00241793 == 0)
					{
						_0024self__00241799.updateVisiblePlayer();
					}
					_0024self__00241799.showPurchaseConsole = false;
					_0024self__00241799.showUpgradeConsole = false;
					_0024self__00241799.descriptionPrinter.Printout(string.Empty);
					_0024self__00241799.showWeaponPerkName = false;
					_0024self__00241799.moveIsoIcon = false;
					_0024self__00241799.moveIsoIconBack = true;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241799.editPanel.position = _0024self__00241799.iconIsoStartPos;
					int num = (_0024_00241218_00241796 = 0);
					Vector3 vector = (_0024_00241219_00241797 = _0024self__00241799.editPanel.position);
					float num2 = (_0024_00241219_00241797.z = _0024_00241218_00241796);
					Vector3 vector3 = (_0024self__00241799.editPanel.position = _0024_00241219_00241797);
					_0024self__00241799.editPanel = null;
					_0024self__00241799.iconIsoRenderer.enabled = false;
					_0024self__00241799.moveIsoIconBack = false;
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024whichWeapon_00241800;

		internal MotherBrain_Menu _0024self__00241801;

		public _0024equip_00241791(int whichWeapon, MotherBrain_Menu self_)
		{
			_0024whichWeapon_00241800 = whichWeapon;
			_0024self__00241801 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichWeapon_00241800, _0024self__00241801);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024equipPerk_00241802 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024slotToFill_00241803;

			internal int _0024alreadyInSlot_00241804;

			internal int _0024i_00241805;

			internal PerkEnum _0024oldWeapon_00241806;

			internal int _0024_00241220_00241807;

			internal Vector3 _0024_00241221_00241808;

			internal int _0024whichWeapon_00241809;

			internal MotherBrain_Menu _0024self__00241810;

			public _0024(int whichWeapon, MotherBrain_Menu self_)
			{
				_0024whichWeapon_00241809 = whichWeapon;
				_0024self__00241810 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024slotToFill_00241803 = 0;
					if (_0024self__00241810.editWeaponSlot.name == "PerkPane2")
					{
						_0024slotToFill_00241803 = 1;
					}
					else if (_0024self__00241810.editWeaponSlot.name == "PerkPane3")
					{
						_0024slotToFill_00241803 = 2;
					}
					_0024alreadyInSlot_00241804 = -1;
					for (_0024i_00241805 = 0; _0024i_00241805 < 3; _0024i_00241805++)
					{
						if (_0024self__00241810.DB.PCs[_0024self__00241810.DB.myPC].perks[_0024i_00241805] == (PerkEnum)_0024whichWeapon_00241809)
						{
							_0024alreadyInSlot_00241804 = _0024i_00241805;
						}
					}
					if (_0024alreadyInSlot_00241804 == -1)
					{
						_0024self__00241810.DB.PCs[_0024self__00241810.DB.myPC].perks[_0024slotToFill_00241803] = (PerkEnum)_0024whichWeapon_00241809;
					}
					else
					{
						_0024oldWeapon_00241806 = _0024self__00241810.DB.PCs[_0024self__00241810.DB.myPC].perks[_0024slotToFill_00241803];
						_0024self__00241810.DB.PCs[_0024self__00241810.DB.myPC].perks[_0024slotToFill_00241803] = (PerkEnum)_0024whichWeapon_00241809;
						_0024self__00241810.DB.PCs[_0024self__00241810.DB.myPC].perks[_0024alreadyInSlot_00241804] = _0024oldWeapon_00241806;
					}
					_0024self__00241810.updateLoadout();
					_0024self__00241810.showPurchaseConsole = false;
					_0024self__00241810.showUpgradeConsole = false;
					_0024self__00241810.descriptionPrinter.Printout(string.Empty);
					_0024self__00241810.showWeaponPerkName = false;
					_0024self__00241810.moveIsoIcon = false;
					_0024self__00241810.moveIsoIconBack = true;
					result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 2:
				{
					_0024self__00241810.editPanel.position = _0024self__00241810.iconIsoStartPos;
					int num = (_0024_00241220_00241807 = 0);
					Vector3 vector = (_0024_00241221_00241808 = _0024self__00241810.editPanel.position);
					float num2 = (_0024_00241221_00241808.z = _0024_00241220_00241807);
					Vector3 vector3 = (_0024self__00241810.editPanel.position = _0024_00241221_00241808);
					_0024self__00241810.editPanel = null;
					_0024self__00241810.iconIsoRenderer.enabled = false;
					_0024self__00241810.moveIsoIconBack = false;
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024whichWeapon_00241811;

		internal MotherBrain_Menu _0024self__00241812;

		public _0024equipPerk_00241802(int whichWeapon, MotherBrain_Menu self_)
		{
			_0024whichWeapon_00241811 = whichWeapon;
			_0024self__00241812 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichWeapon_00241811, _0024self__00241812);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024forceGameStart_00241813 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241232_00241814;

			internal Vector3 _0024_00241233_00241815;

			internal int _0024_00241234_00241816;

			internal Vector3 _0024_00241235_00241817;

			internal int _0024whichDifficulty_00241818;

			internal MotherBrain_Menu _0024self__00241819;

			public _0024(int whichDifficulty, MotherBrain_Menu self_)
			{
				_0024whichDifficulty_00241818 = whichDifficulty;
				_0024self__00241819 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00241819.killInput = true;
					int num3 = (_0024_00241232_00241814 = -20);
					Vector3 vector4 = (_0024_00241233_00241815 = _0024self__00241819.pleaseWait.position);
					float num4 = (_0024_00241233_00241815.y = _0024_00241232_00241814);
					Vector3 vector6 = (_0024self__00241819.pleaseWait.position = _0024_00241233_00241815);
					_0024self__00241819.DB.difficulty = _0024whichDifficulty_00241818;
					_0024self__00241819.interpretDifficulty();
					_0024self__00241819.fade = true;
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_00241234_00241816 = 1);
					Vector3 vector = (_0024_00241235_00241817 = _0024self__00241819.queuePauser.position);
					float num2 = (_0024_00241235_00241817.x = _0024_00241234_00241816);
					Vector3 vector3 = (_0024self__00241819.queuePauser.position = _0024_00241235_00241817);
					result = (Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
					break;
				}
				case 3:
					_0024self__00241819.DB.levelToLoad = "sandbox";
					Application.LoadLevel("middleman");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024whichDifficulty_00241820;

		internal MotherBrain_Menu _0024self__00241821;

		public _0024forceGameStart_00241813(int whichDifficulty, MotherBrain_Menu self_)
		{
			_0024whichDifficulty_00241820 = whichDifficulty;
			_0024self__00241821 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichDifficulty_00241820, _0024self__00241821);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024startGame_00241822 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241236_00241823;

			internal Vector3 _0024_00241237_00241824;

			internal int _0024_00241238_00241825;

			internal Vector3 _0024_00241239_00241826;

			internal MotherBrain_Menu _0024self__00241827;

			public _0024(MotherBrain_Menu self_)
			{
				_0024self__00241827 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241827.killInput = true;
					_0024self__00241827.hideCursor = true;
					_0024self__00241827.fade = true;
					_0024self__00241827.interpretDifficulty();
					if (_0024self__00241827.DB.multiplayer)
					{
						int num3 = (_0024_00241236_00241823 = _0024self__00241827.DB.difficulty);
						Vector3 vector4 = (_0024_00241237_00241824 = _0024self__00241827.readyMarker1.position);
						float num4 = (_0024_00241237_00241824.x = _0024_00241236_00241823);
						Vector3 vector6 = (_0024self__00241827.readyMarker1.position = _0024_00241237_00241824);
					}
					result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
					break;
				case 2:
				{
					int num = (_0024_00241238_00241825 = 1);
					Vector3 vector = (_0024_00241239_00241826 = _0024self__00241827.queuePauser.position);
					float num2 = (_0024_00241239_00241826.x = _0024_00241238_00241825);
					Vector3 vector3 = (_0024self__00241827.queuePauser.position = _0024_00241239_00241826);
					result = (Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
					break;
				}
				case 3:
					_0024self__00241827.DB.levelToLoad = "sandbox";
					Application.LoadLevel("middleman");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Menu _0024self__00241828;

		public _0024startGame_00241822(MotherBrain_Menu self_)
		{
			_0024self__00241828 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241828);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024onPeerDisconnect_00241829 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241240_00241830;

			internal Vector3 _0024_00241241_00241831;

			internal float _0024_00241242_00241832;

			internal Vector3 _0024_00241243_00241833;

			internal int _0024_00241244_00241834;

			internal Vector3 _0024_00241245_00241835;

			internal MotherBrain_Menu _0024self__00241836;

			public _0024(MotherBrain_Menu self_)
			{
				_0024self__00241836 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00241836.DB.multiplayer = false;
					_0024self__00241836.DB.whichPlayerAmI = 1;
					int num3 = (_0024_00241240_00241830 = 0);
					Vector3 vector4 = (_0024_00241241_00241831 = _0024self__00241836.disconnectMarker.position);
					float num4 = (_0024_00241241_00241831.x = _0024_00241240_00241830);
					Vector3 vector6 = (_0024self__00241836.disconnectMarker.position = _0024_00241241_00241831);
					_0024self__00241836.player2Ready = true;
					if ((bool)_0024self__00241836.disconnectMessage)
					{
						float num5 = (_0024_00241242_00241832 = -2.178658f);
						Vector3 vector7 = (_0024_00241243_00241833 = _0024self__00241836.disconnectMessage.localPosition);
						float num6 = (_0024_00241243_00241833.y = _0024_00241242_00241832);
						Vector3 vector9 = (_0024self__00241836.disconnectMessage.localPosition = _0024_00241243_00241833);
					}
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				}
				case 2:
					if ((bool)_0024self__00241836.disconnectMessage)
					{
						int num = (_0024_00241244_00241834 = -8);
						Vector3 vector = (_0024_00241245_00241835 = _0024self__00241836.disconnectMessage.localPosition);
						float num2 = (_0024_00241245_00241835.y = _0024_00241244_00241834);
						Vector3 vector3 = (_0024self__00241836.disconnectMessage.localPosition = _0024_00241245_00241835);
					}
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Menu _0024self__00241837;

		public _0024onPeerDisconnect_00241829(MotherBrain_Menu self_)
		{
			_0024self__00241837 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241837);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024tutorialSequence_00241838 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MotherBrain_Menu _0024self__00241839;

			public _0024(MotherBrain_Menu self_)
			{
				_0024self__00241839 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241839.hideReadyButton = true;
					_0024self__00241839.hideExitButton = true;
					_0024self__00241839.killInput = true;
					result = (Yield(2, new WaitForSeconds(1.6f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241839.showTutorialText = true;
					result = (Yield(3, new WaitForSeconds(5.2f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241839.showTutorialText = false;
					result = (Yield(4, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241839.showTutorialText = true;
					_0024self__00241839.tutorialText.text = "Tap the buttons above to browse the store,\nor tap READY to get back into the action!";
					result = (Yield(5, new WaitForSeconds(5.2f)) ? 1 : 0);
					break;
				case 5:
					_0024self__00241839.showTutorialText = false;
					_0024self__00241839.hideExitButton = false;
					result = (Yield(6, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00241839.hideReadyButton = false;
					_0024self__00241839.DB.tutorial = false;
					_0024self__00241839.killInput = false;
					_0024self__00241839.DB.save();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Menu _0024self__00241840;

		public _0024tutorialSequence_00241838(MotherBrain_Menu self_)
		{
			_0024self__00241840 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241840);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024showAchievementBubble_00241841 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241246_00241842;

			internal Vector3 _0024_00241247_00241843;

			internal int _0024_00241248_00241844;

			internal Vector3 _0024_00241249_00241845;

			internal int _0024whichAchievement_00241846;

			internal MotherBrain_Menu _0024self__00241847;

			public _0024(int whichAchievement, MotherBrain_Menu self_)
			{
				_0024whichAchievement_00241846 = whichAchievement;
				_0024self__00241847 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00241847.sounds[3].Play();
					_0024self__00241847.achievementBubbleText.text = _0024self__00241847.DB.achievements[_0024whichAchievement_00241846].achievementName;
					float num3 = (_0024_00241246_00241842 = -1.8f);
					Vector3 vector4 = (_0024_00241247_00241843 = _0024self__00241847.achievementBubbleTransform.localPosition);
					float num4 = (_0024_00241247_00241843.y = _0024_00241246_00241842);
					Vector3 vector6 = (_0024self__00241847.achievementBubbleTransform.localPosition = _0024_00241247_00241843);
					_0024self__00241847.achievementBubbleAnimation.Stop();
					_0024self__00241847.achievementBubbleAnimation.Play();
					result = (Yield(2, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_00241248_00241844 = 100);
					Vector3 vector = (_0024_00241249_00241845 = _0024self__00241847.achievementBubbleTransform.localPosition);
					float num2 = (_0024_00241249_00241845.y = _0024_00241248_00241844);
					Vector3 vector3 = (_0024self__00241847.achievementBubbleTransform.localPosition = _0024_00241249_00241845);
					YieldDefault(1);
					goto case 1;
				}
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024whichAchievement_00241848;

		internal MotherBrain_Menu _0024self__00241849;

		public _0024showAchievementBubble_00241841(int whichAchievement, MotherBrain_Menu self_)
		{
			_0024whichAchievement_00241848 = whichAchievement;
			_0024self__00241849 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichAchievement_00241848, _0024self__00241849);
		}
	}

	public Transform queuePauser;

	public Transform disconnectMarker;

	public Transform readyMarker1;

	public Transform readyMarker2;

	public Database DB;

	public GameObject playerCullerGO;

	public GameObject upgradeButtonGO;

	public Transform upgradeButtonTransform;

	public TextPrint upgradeDescriptionPrinter;

	public TextPrint descriptionPrinter;

	public Transform weaponPerkNameTransform;

	public TextMesh weaponPerkName;

	public Transform underlineTransform;

	public Renderer iconIsoRenderer;

	private Vector3 iconIsoStartPos;

	public Renderer fader;

	public bool fade;

	public LayerMask HUDmask;

	public Camera cameraLens;

	private float draggingThreshold;

	public bool killInput;

	public Renderer[] difficultyStars;

	public Renderer[] difficultyStarsLit;

	private bool holdThePhone;

	public AudioSource menuMusic;

	public Transform tutorialTextTran;

	public TextMesh tutorialText;

	public Transform disconnectMessage;

	public float messagePulse;

	private float initialInputLock;

	private bool initialFade;

	public bool hideCursor;

	private Transform whichButton;

	private Transform tempTransform;

	private Ray tempRay;

	private RaycastHit tempHit;

	private bool fingerDown;

	private bool draggingMode;

	private Vector2 contactPosition;

	private Vector2 travelDistance;

	public Transform scrollingWeaponMenu;

	private Vector3 windowStartPos;

	public float scrollingSpeed;

	private int scrollingSpeedBreakPoint;

	public Transform cursor;

	public Renderer cursorRenderer;

	public float cursorTimer;

	public bool hideStars;

	public Transform starCluster;

	public bool showUpgradeConsole;

	public bool showPurchaseConsole;

	public bool showWeaponPerkName;

	public bool moveIsoIcon;

	public bool moveIsoIconBack;

	public bool mainConsoleShade;

	public bool moveConsoleDown;

	public bool moveConsoleUp;

	public bool hideConsole;

	public bool liftWeaponPane;

	public bool openWeaponPane;

	public bool showTopLeft;

	public bool showTopLeftShort;

	public bool showTopLeftMed;

	public GameObject mainConsoleShadeGO;

	public Renderer mainConsoleShadeRenderer;

	public Transform upgradeConsole;

	public Transform purchaseConsole;

	public Transform topLeftPane;

	public Transform mainConsole;

	public Transform weaponPane;

	public Transform leftBorder;

	public Transform rightBorder;

	public Transform readyButton;

	public bool hideReadyButton;

	public Renderer centralCullerBottom;

	public bool hideCash;

	public Transform cashLines;

	public bool showMap;

	public Transform mapGroup;

	public Transform leftBorder2;

	public Transform rightBorder2;

	public bool openMap;

	public bool hideDeployButton;

	public Transform deployButton;

	public bool showNext;

	public Transform nextButton;

	public Transform previousButton;

	public Transform mapCancelButton;

	public bool showMapCancel;

	public bool showInfectionLevel;

	public Transform infectionLevel;

	public bool showLocation;

	public Transform location;

	public Vector3 mapTargetPosition;

	public Transform mapTransform;

	public Transform exitButton;

	public bool hideExitButton;

	public bool showTutorialText;

	public Renderer blinkyRenderer;

	public bool blinkyActive;

	private float blinkTimer;

	private float blinkSubTimer;

	private Transform editWeaponSlot;

	private Transform editPanel;

	public TextMesh topLeftText;

	public TextMesh purchaseText;

	public bool scrollMap;

	public Transform pleaseWait;

	public Transform pleaseWaitForPlayer2;

	private string panelMode;

	private GameObject tempGO;

	private GameObject playerSpawnGO;

	public Transform playerSpawnSocket;

	private PlayerScript playerSpawnScript;

	public Transform[] centerConsoleWeaponSockets;

	public TextMesh[] centerConsolePerkText;

	public GameObject[] loadoutIcons;

	public storePanel[] scrollingListSlots;

	public Transform perkTextPrefab;

	public Material darkTextMaterial;

	public Material lightTextMaterial;

	private int maximumPages;

	private int panelID;

	public Renderer[] darkStars;

	public Renderer[] lightStars;

	public TextMesh locationNameText;

	public Transform mapShade;

	public TextMesh levelLockText;

	public Transform zoneHighlight;

	public Animation zoneAnim;

	public TextMesh cashText;

	public int displayedCash;

	public GameObject[] dotGO;

	public GameObject[] dotParentGO;

	public Zone[] zones;

	public bool player2Ready;

	public AudioSource[] sounds;

	public TextMesh achievementBubbleText;

	public Transform achievementBubbleTransform;

	public Animation achievementBubbleAnimation;

	public MotherBrain_Menu()
	{
		killInput = true;
		messagePulse = 1f;
		initialInputLock = 1f;
		scrollingSpeedBreakPoint = 15;
		hideDeployButton = true;
		blinkTimer = 0.5f;
		blinkSubTimer = 0.04f;
		panelMode = string.Empty;
		loadoutIcons = new GameObject[3];
		maximumPages = 4;
		player2Ready = true;
	}

	public virtual void Awake()
	{
		draggingThreshold = UnityBuiltins.parseFloat(Screen.width) / 24f;
		if ((bool)GameObject.Find("**DATABASE"))
		{
			DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
		}
		else
		{
			DB = (Database)GameObject.Find("**DATABASE_Sandbox").GetComponent(typeof(Database));
		}
		if (DB.musicEnabled)
		{
			menuMusic.Play();
		}
		muteSounds();
		updateVisiblePlayer();
		updateLoadout();
		updateScrollingPlayerList();
		updateScrollingWeaponList();
		displayCash(true);
		if (DB.multiplayer)
		{
			player2Ready = false;
		}
		else if (DB.tutorial)
		{
			StartCoroutine_Auto(tutorialSequence());
		}
		else
		{
			hideReadyButton = false;
		}
		if (DB.multiplayer && DB.whichPlayerAmI != 0)
		{
			hideReadyButton = false;
		}
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			StartCoroutine_Auto(disconnect());
		}
		if (DB.moneyInfo < DB.money)
		{
			DB = null;
			DB.money = 0;
		}
		if (!(initialInputLock <= 0f))
		{
			initialInputLock -= Time.deltaTime;
			if (!(initialInputLock > 0f))
			{
				if (!DB.tutorial)
				{
					killInput = false;
				}
				fade = false;
			}
		}
		if (!killInput)
		{
			menuInput();
		}
		if (hideCursor && !(cursorRenderer.material.color.a <= 0f))
		{
			float a = cursorRenderer.material.color.a - 2f * Time.deltaTime;
			Color color = cursorRenderer.material.color;
			float num = (color.a = a);
			Color color3 = (cursorRenderer.material.color = color);
			if (!(cursorRenderer.material.color.a > 0f))
			{
				int num2 = 0;
				Color color4 = cursorRenderer.material.color;
				float num3 = (color4.a = num2);
				Color color6 = (cursorRenderer.material.color = color4);
				cursorRenderer.enabled = false;
			}
		}
		menuAnimation();
		fadeAnimation();
		blinkyAnimation();
		displayCash(false);
		if (DB.whichPlayerAmI == 0)
		{
			determineWhichPlayer();
		}
		if (pleaseWaitForPlayer2.position.y == 0f && player2Ready)
		{
			StartCoroutine_Auto(startGame());
		}
		if (DB.multiplayer)
		{
			if (readyMarker2.position.x == 1f)
			{
				player2Ready = true;
			}
			else
			{
				player2Ready = false;
			}
			if (!(readyMarker1.position.x <= 0f) && !fade)
			{
				StartCoroutine_Auto(forceGameStart((int)readyMarker1.position.x));
			}
			if (disconnectMarker.position.x == 1f)
			{
				StartCoroutine_Auto(onPeerDisconnect());
			}
		}
	}

	public virtual void menuInput()
	{
		Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
		cursor.position += vector * Time.deltaTime * 4.5f;
		if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
		{
			cursorTimer = 2f;
		}
		else if (!Input.GetButton("Fire1") && !Input.GetButton("Fire2") && !Input.GetButton("Fire3"))
		{
			cursorTimer -= Time.deltaTime;
		}
		if (!hideCursor)
		{
			if (!(cursorTimer <= 0f))
			{
				cursorRenderer.enabled = true;
				if (!(cursorRenderer.material.color.a >= 1f))
				{
					float a = cursorRenderer.material.color.a + 3f * Time.deltaTime;
					Color color = cursorRenderer.material.color;
					float num = (color.a = a);
					Color color3 = (cursorRenderer.material.color = color);
				}
			}
			if (!(cursorTimer > 0f) && !(cursorRenderer.material.color.a <= 0f))
			{
				float a2 = cursorRenderer.material.color.a - 2f * Time.deltaTime;
				Color color4 = cursorRenderer.material.color;
				float num2 = (color4.a = a2);
				Color color6 = (cursorRenderer.material.color = color4);
				if (!(cursorRenderer.material.color.a > 0f))
				{
					int num3 = 0;
					Color color7 = cursorRenderer.material.color;
					float num4 = (color7.a = num3);
					Color color9 = (cursorRenderer.material.color = color7);
					cursorRenderer.enabled = false;
				}
			}
			if (!(cursorRenderer.material.color.r <= 0.25f))
			{
				float r = cursorRenderer.material.color.r - Time.deltaTime * 3f;
				Color color10 = cursorRenderer.material.color;
				float num5 = (color10.r = r);
				Color color12 = (cursorRenderer.material.color = color10);
				if (!(cursorRenderer.material.color.r >= 0.25f))
				{
					float r2 = 0.25f;
					Color color13 = cursorRenderer.material.color;
					float num6 = (color13.r = r2);
					Color color15 = (cursorRenderer.material.color = color13);
				}
				float r3 = cursorRenderer.material.color.r;
				Color color16 = cursorRenderer.material.color;
				float num7 = (color16.g = r3);
				Color color18 = (cursorRenderer.material.color = color16);
				float r4 = cursorRenderer.material.color.r;
				Color color19 = cursorRenderer.material.color;
				float num8 = (color19.b = r4);
				Color color21 = (cursorRenderer.material.color = color19);
			}
			if (cursor.localScale.x != 0.63f)
			{
				float x = Mathf.Lerp(cursor.localScale.x, 0.63f, 5f * Time.deltaTime);
				Vector3 localScale = cursor.localScale;
				float num9 = (localScale.x = x);
				Vector3 vector3 = (cursor.localScale = localScale);
				float x2 = cursor.localScale.x;
				Vector3 localScale2 = cursor.localScale;
				float num10 = (localScale2.y = x2);
				Vector3 vector5 = (cursor.localScale = localScale2);
				float x3 = cursor.localScale.x;
				Vector3 localScale3 = cursor.localScale;
				float num11 = (localScale3.z = x3);
				Vector3 vector7 = (cursor.localScale = localScale3);
			}
		}
		if (Input.GetMouseButtonDown(0) || (Application.platform != 0 && Input.touchCount > 0 && !fingerDown) || Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3"))
		{
			if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3"))
			{
				cursor.localScale = new Vector3(0.83f, 0.83f, 0.83f);
				float r5 = 0.5f;
				Color color22 = cursorRenderer.material.color;
				float num12 = (color22.r = r5);
				Color color24 = (cursorRenderer.material.color = color22);
				float g = 0.5f;
				Color color25 = cursorRenderer.material.color;
				float num13 = (color25.g = g);
				Color color27 = (cursorRenderer.material.color = color25);
				float b = 0.5f;
				Color color28 = cursorRenderer.material.color;
				float num14 = (color28.b = b);
				Color color30 = (cursorRenderer.material.color = color28);
				cursorTimer = 2f;
			}
			fingerDown = true;
			scrollingSpeed = 0f;
			if ((bool)blinkyRenderer)
			{
				blinkyRenderer.enabled = false;
				blinkyRenderer = null;
			}
			blinkyActive = false;
			if (Application.platform == RuntimePlatform.OSXEditor && Input.GetMouseButtonDown(0))
			{
				contactPosition = Input.mousePosition;
			}
			else if (Input.touchCount > 0)
			{
				contactPosition = Input.GetTouch(0).position;
			}
			else if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3"))
			{
				contactPosition = cameraLens.WorldToScreenPoint(cursor.position);
			}
			tempRay = cameraLens.ScreenPointToRay(contactPosition);
			if (Physics.Raycast(tempRay, out tempHit, 100f, HUDmask))
			{
				whichButton = tempHit.transform;
				if ((bool)whichButton.Find("Light") && editPanel != whichButton)
				{
					blinkyRenderer = (Renderer)whichButton.Find("Light").GetComponent(typeof(Renderer));
					blinkyRenderer.enabled = true;
				}
			}
			else
			{
				blinkyRenderer = null;
			}
		}
		bool flag = false;
		if (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3"))
		{
			flag = true;
		}
		if (Input.GetMouseButtonUp(0) || (Application.platform != 0 && Input.touchCount == 0 && fingerDown && !flag) || (Input.GetButtonUp("Fire1") && !flag) || (Input.GetButtonUp("Fire2") && !flag) || (Input.GetButtonUp("Fire3") && !flag))
		{
			if (!draggingMode && (bool)whichButton && whichButton.name == "MainConsoleShade1")
			{
				StartCoroutine_Auto(closeSubMenu());
			}
			fingerDown = false;
			draggingMode = false;
			travelDistance = new Vector2(0f, 0f);
			if ((bool)blinkyRenderer)
			{
				blinkTimer = 0.5f;
				blinkyActive = true;
				StartCoroutine_Auto(activateButton());
			}
		}
		if (fingerDown)
		{
			if (Application.platform == RuntimePlatform.OSXEditor && Input.GetMouseButton(0))
			{
				travelDistance = Input.mousePosition - (Vector3)contactPosition;
			}
			else if (Input.touchCount > 0)
			{
				travelDistance = Input.GetTouch(0).position - contactPosition;
			}
			else if (Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3"))
			{
				travelDistance = cameraLens.WorldToScreenPoint(cursor.position) - (Vector3)contactPosition;
			}
			if ((!(Mathf.Abs(travelDistance.x) <= draggingThreshold) && !draggingMode) || (!(Mathf.Abs(travelDistance.y) <= draggingThreshold) && !draggingMode))
			{
				draggingMode = true;
				windowStartPos = scrollingWeaponMenu.position;
				if ((bool)blinkyRenderer)
				{
					blinkyRenderer.enabled = false;
					blinkyRenderer = null;
				}
			}
		}
		if (fingerDown && draggingMode && (bool)whichButton && whichButton.name != "MainConsoleShade1" && liftWeaponPane && !moveIsoIcon)
		{
			float x4 = scrollingWeaponMenu.position.x;
			Vector3 vector8 = cameraLens.ScreenToWorldPoint(new Vector3(windowStartPos.x + travelDistance.x, 0f, 0f)) - cameraLens.ScreenToWorldPoint(new Vector3(windowStartPos.x, 0f, 0f));
			if (!((windowStartPos + vector8).x <= 0f))
			{
				vector8.x -= (windowStartPos + vector8).x * 0.75f;
			}
			else if (!((windowStartPos + vector8).x >= (float)(maximumPages - 1) * -1.87f))
			{
				vector8.x -= ((windowStartPos + vector8).x - (float)(maximumPages - 1) * -1.87f) * 0.75f;
			}
			scrollingWeaponMenu.position = Vector3.Lerp(scrollingWeaponMenu.position, windowStartPos + vector8, 15f * Time.deltaTime);
			scrollingSpeed = scrollingWeaponMenu.position.x - x4;
			scrollingSpeed /= Time.deltaTime;
		}
	}

	public virtual void menuAnimation()
	{
		if (showTutorialText && tutorialTextTran.position.x != 0f)
		{
			float x = Mathf.Lerp(tutorialTextTran.position.x, 0f, 14f * Time.deltaTime);
			Vector3 position = tutorialTextTran.position;
			float num = (position.x = x);
			Vector3 vector2 = (tutorialTextTran.position = position);
			if (!(tutorialTextTran.position.x > 0.001f))
			{
				int num2 = 0;
				Vector3 position2 = tutorialTextTran.position;
				float num3 = (position2.x = num2);
				Vector3 vector4 = (tutorialTextTran.position = position2);
			}
		}
		else if (!showTutorialText && !(tutorialTextTran.position.x > 0.1f))
		{
			float x2 = Mathf.Lerp(tutorialTextTran.position.x, -10f, 14f * Time.deltaTime);
			Vector3 position3 = tutorialTextTran.position;
			float num4 = (position3.x = x2);
			Vector3 vector6 = (tutorialTextTran.position = position3);
			if (!(tutorialTextTran.position.x > -9.5f))
			{
				int num5 = 10;
				Vector3 position4 = tutorialTextTran.position;
				float num6 = (position4.x = num5);
				Vector3 vector8 = (tutorialTextTran.position = position4);
			}
		}
		if (hideExitButton && exitButton.localPosition.x != 5f)
		{
			float x3 = Mathf.Lerp(exitButton.localPosition.x, 5f, 14f * Time.deltaTime);
			Vector3 localPosition = exitButton.localPosition;
			float num7 = (localPosition.x = x3);
			Vector3 vector10 = (exitButton.localPosition = localPosition);
			if (!(exitButton.localPosition.x < 4.999f))
			{
				int num8 = 5;
				Vector3 localPosition2 = exitButton.localPosition;
				float num9 = (localPosition2.x = num8);
				Vector3 vector12 = (exitButton.localPosition = localPosition2);
			}
		}
		else if (!hideExitButton && !RuntimeServices.EqualityOperator(exitButton.localPosition, 3.029f))
		{
			float x4 = Mathf.Lerp(exitButton.localPosition.x, 3.029f, 14f * Time.deltaTime);
			Vector3 localPosition3 = exitButton.localPosition;
			float num10 = (localPosition3.x = x4);
			Vector3 vector14 = (exitButton.localPosition = localPosition3);
			if (!(exitButton.localPosition.x > 3.03f))
			{
				float x5 = 3.029f;
				Vector3 localPosition4 = exitButton.localPosition;
				float num11 = (localPosition4.x = x5);
				Vector3 vector16 = (exitButton.localPosition = localPosition4);
			}
		}
		if (scrollMap)
		{
			mapTransform.localPosition = Vector3.Lerp(mapTransform.localPosition, mapTargetPosition, 15f * Time.deltaTime);
		}
		if (showLocation && location.position.y != 0f)
		{
			float y = Mathf.Lerp(location.position.y, 0f, 15f * Time.deltaTime);
			Vector3 position5 = location.position;
			float num12 = (position5.y = y);
			Vector3 vector18 = (location.position = position5);
			if (!(location.position.y > 0.001f))
			{
				int num13 = 0;
				Vector3 position6 = location.position;
				float num14 = (position6.y = num13);
				Vector3 vector20 = (location.position = position6);
			}
		}
		else if (!showLocation && location.position.y != 1f)
		{
			float y2 = Mathf.Lerp(location.position.y, 1f, 15f * Time.deltaTime);
			Vector3 position7 = location.position;
			float num15 = (position7.y = y2);
			Vector3 vector22 = (location.position = position7);
			if (!(location.position.y < 0.999f))
			{
				int num16 = 1;
				Vector3 position8 = location.position;
				float num17 = (position8.y = num16);
				Vector3 vector24 = (location.position = position8);
			}
		}
		if (showInfectionLevel && infectionLevel.localScale.y != 1f)
		{
			if (infectionLevel.position.y != -1.5f)
			{
				float y3 = -1.5f;
				Vector3 position9 = infectionLevel.position;
				float num18 = (position9.y = y3);
				Vector3 vector26 = (infectionLevel.position = position9);
			}
			float y4 = Mathf.Lerp(infectionLevel.localScale.y, 1f, 25f * Time.deltaTime);
			Vector3 localScale = infectionLevel.localScale;
			float num19 = (localScale.y = y4);
			Vector3 vector28 = (infectionLevel.localScale = localScale);
			if (!(infectionLevel.localScale.y < 0.999f))
			{
				float y5 = 1f;
				Vector3 localScale2 = infectionLevel.localScale;
				float num20 = (localScale2.y = y5);
				Vector3 vector30 = (infectionLevel.localScale = localScale2);
			}
		}
		else if (!showInfectionLevel && infectionLevel.localScale.y != 0f)
		{
			float y6 = Mathf.Lerp(infectionLevel.localScale.y, 0f, 25f * Time.deltaTime);
			Vector3 localScale3 = infectionLevel.localScale;
			float num21 = (localScale3.y = y6);
			Vector3 vector32 = (infectionLevel.localScale = localScale3);
			if (!(infectionLevel.localScale.y > 0.001f))
			{
				int num22 = 0;
				Vector3 localScale4 = infectionLevel.localScale;
				float num23 = (localScale4.y = num22);
				Vector3 vector34 = (infectionLevel.localScale = localScale4);
				int num24 = -6;
				Vector3 position10 = infectionLevel.position;
				float num25 = (position10.y = num24);
				Vector3 vector36 = (infectionLevel.position = position10);
			}
		}
		if (showMapCancel && mapCancelButton.position.x != -3f)
		{
			float x6 = Mathf.Lerp(mapCancelButton.position.x, -3f, 15f * Time.deltaTime);
			Vector3 position11 = mapCancelButton.position;
			float num26 = (position11.x = x6);
			Vector3 vector38 = (mapCancelButton.position = position11);
			if (!(mapCancelButton.position.x < -3.001f))
			{
				int num27 = -3;
				Vector3 position12 = mapCancelButton.position;
				float num28 = (position12.x = num27);
				Vector3 vector40 = (mapCancelButton.position = position12);
			}
		}
		else if (!showMapCancel && mapCancelButton.position.x != -5.1f)
		{
			float x7 = Mathf.Lerp(mapCancelButton.position.x, -5.1f, 15f * Time.deltaTime);
			Vector3 position13 = mapCancelButton.position;
			float num29 = (position13.x = x7);
			Vector3 vector42 = (mapCancelButton.position = position13);
			if (!(mapCancelButton.position.x > -5.099f))
			{
				float x8 = -5.1f;
				Vector3 position14 = mapCancelButton.position;
				float num30 = (position14.x = x8);
				Vector3 vector44 = (mapCancelButton.position = position14);
			}
		}
		if (showNext && nextButton.position.x != 2.4f)
		{
			float x9 = Mathf.Lerp(nextButton.position.x, 2.4f, 15f * Time.deltaTime);
			Vector3 position15 = nextButton.position;
			float num31 = (position15.x = x9);
			Vector3 vector46 = (nextButton.position = position15);
			float x10 = 0f - nextButton.position.x;
			Vector3 position16 = previousButton.position;
			float num32 = (position16.x = x10);
			Vector3 vector48 = (previousButton.position = position16);
			if (!(nextButton.position.x > 2.401f))
			{
				float x11 = 2.4f;
				Vector3 position17 = nextButton.position;
				float num33 = (position17.x = x11);
				Vector3 vector50 = (nextButton.position = position17);
				float x12 = -2.4f;
				Vector3 position18 = previousButton.position;
				float num34 = (position18.x = x12);
				Vector3 vector52 = (previousButton.position = position18);
			}
		}
		else if (!showNext && nextButton.position.x != 5.1f)
		{
			float x13 = Mathf.Lerp(nextButton.position.x, 5.1f, 15f * Time.deltaTime);
			Vector3 position19 = nextButton.position;
			float num35 = (position19.x = x13);
			Vector3 vector54 = (nextButton.position = position19);
			float x14 = 0f - nextButton.position.x;
			Vector3 position20 = previousButton.position;
			float num36 = (position20.x = x14);
			Vector3 vector56 = (previousButton.position = position20);
			if (!(nextButton.position.x < 5.009f))
			{
				float x15 = 5.1f;
				Vector3 position21 = nextButton.position;
				float num37 = (position21.x = x15);
				Vector3 vector58 = (nextButton.position = position21);
				float x16 = -5.1f;
				Vector3 position22 = previousButton.position;
				float num38 = (position22.x = x16);
				Vector3 vector60 = (previousButton.position = position22);
			}
		}
		if (hideDeployButton && !(deployButton.localScale.y <= 0f))
		{
			if (deployButton.position.y != -2.35f)
			{
				float y7 = -2.35f;
				Vector3 position23 = deployButton.position;
				float num39 = (position23.y = y7);
				Vector3 vector62 = (deployButton.position = position23);
				int num40 = 0;
				Vector3 localScale5 = deployButton.localScale;
				float num41 = (localScale5.y = num40);
				Vector3 vector64 = (deployButton.localScale = localScale5);
			}
			else
			{
				float y8 = deployButton.localScale.y - Time.deltaTime * 15f;
				Vector3 localScale6 = deployButton.localScale;
				float num42 = (localScale6.y = y8);
				Vector3 vector66 = (deployButton.localScale = localScale6);
				if (!(deployButton.localScale.y >= 0f))
				{
					int num43 = 0;
					Vector3 localScale7 = deployButton.localScale;
					float num44 = (localScale7.y = num43);
					Vector3 vector68 = (deployButton.localScale = localScale7);
				}
			}
		}
		else if (!hideDeployButton && deployButton.localScale.y != 1f)
		{
			float y9 = deployButton.localScale.y + Time.deltaTime * 15f;
			Vector3 localScale8 = deployButton.localScale;
			float num45 = (localScale8.y = y9);
			Vector3 vector70 = (deployButton.localScale = localScale8);
			if (!(deployButton.localScale.y <= 1f))
			{
				int num46 = 1;
				Vector3 localScale9 = deployButton.localScale;
				float num47 = (localScale9.y = num46);
				Vector3 vector72 = (deployButton.localScale = localScale9);
			}
		}
		if (openMap && leftBorder2.position.x != 0f)
		{
			float x17 = Mathf.Lerp(leftBorder2.position.x, 0f, 16f * Time.deltaTime);
			Vector3 position24 = leftBorder2.position;
			float num48 = (position24.x = x17);
			Vector3 vector74 = (leftBorder2.position = position24);
			float x18 = 0f - leftBorder2.position.x;
			Vector3 position25 = rightBorder2.position;
			float num49 = (position25.x = x18);
			Vector3 vector76 = (rightBorder2.position = position25);
			if (!(Mathf.Abs(leftBorder2.position.x) >= 0.001f))
			{
				int num50 = 0;
				Vector3 position26 = leftBorder2.position;
				float num51 = (position26.x = num50);
				Vector3 vector78 = (leftBorder2.position = position26);
				int num52 = 0;
				Vector3 position27 = rightBorder2.position;
				float num53 = (position27.x = num52);
				Vector3 vector80 = (rightBorder2.position = position27);
			}
		}
		else if (!openMap && leftBorder2.position.x != 4f)
		{
			float x19 = Mathf.Lerp(leftBorder2.position.x, 4f, 24f * Time.deltaTime);
			Vector3 position28 = leftBorder2.position;
			float num54 = (position28.x = x19);
			Vector3 vector82 = (leftBorder2.position = position28);
			float x20 = 0f - leftBorder2.position.x;
			Vector3 position29 = rightBorder2.position;
			float num55 = (position29.x = x20);
			Vector3 vector84 = (rightBorder2.position = position29);
			if (!(leftBorder2.position.x <= 3.999f))
			{
				int num56 = 4;
				Vector3 position30 = leftBorder2.position;
				float num57 = (position30.x = num56);
				Vector3 vector86 = (leftBorder2.position = position30);
				int num58 = -4;
				Vector3 position31 = rightBorder2.position;
				float num59 = (position31.x = num58);
				Vector3 vector88 = (rightBorder2.position = position31);
			}
		}
		if (showMap && !(mapGroup.position.y >= 0.46f))
		{
			float y10 = Mathf.Lerp(mapGroup.position.y, 0.46f, 15f * Time.deltaTime);
			Vector3 position32 = mapGroup.position;
			float num60 = (position32.y = y10);
			Vector3 vector90 = (mapGroup.position = position32);
			if (!(mapGroup.position.y < 0.459f))
			{
				float y11 = 0.46f;
				Vector3 position33 = mapGroup.position;
				float num61 = (position33.y = y11);
				Vector3 vector92 = (mapGroup.position = position33);
			}
		}
		else if (!showMap && mapGroup.position.y != -7.5f)
		{
			float y12 = Mathf.Lerp(mapGroup.position.y, -7.5f, 15f * Time.deltaTime);
			Vector3 position34 = mapGroup.position;
			float num62 = (position34.y = y12);
			Vector3 vector94 = (mapGroup.position = position34);
			if (!(mapGroup.position.y > -7.448f))
			{
				float y13 = -7.5f;
				Vector3 position35 = mapGroup.position;
				float num63 = (position35.y = y13);
				Vector3 vector96 = (mapGroup.position = position35);
			}
		}
		if (hideStars && starCluster.localEulerAngles.y != 180f)
		{
			int num64 = 180;
			Vector3 localEulerAngles = starCluster.localEulerAngles;
			float num65 = (localEulerAngles.y = num64);
			Vector3 vector98 = (starCluster.localEulerAngles = localEulerAngles);
		}
		else if (!hideStars && starCluster.localEulerAngles.y != 0f)
		{
			int num66 = 0;
			Vector3 localEulerAngles2 = starCluster.localEulerAngles;
			float num67 = (localEulerAngles2.y = num66);
			Vector3 vector100 = (starCluster.localEulerAngles = localEulerAngles2);
		}
		if (hideCash && cashLines.position.y != 1f)
		{
			float y14 = Mathf.Lerp(cashLines.position.y, 1f, 15f * Time.deltaTime);
			Vector3 position36 = cashLines.position;
			float num68 = (position36.y = y14);
			Vector3 vector102 = (cashLines.position = position36);
			if (!(cashLines.position.y < 0.999f))
			{
				float y15 = 1f;
				Vector3 position37 = cashLines.position;
				float num69 = (position37.y = y15);
				Vector3 vector104 = (cashLines.position = position37);
			}
		}
		else if (!hideCash && cashLines.position.y != 0f)
		{
			float y16 = Mathf.Lerp(cashLines.position.y, 0f, 15f * Time.deltaTime);
			Vector3 position38 = cashLines.position;
			float num70 = (position38.y = y16);
			Vector3 vector106 = (cashLines.position = position38);
			if (!(cashLines.position.y > 0.001f))
			{
				int num71 = 0;
				Vector3 position39 = cashLines.position;
				float num72 = (position39.y = num71);
				Vector3 vector108 = (cashLines.position = position39);
			}
		}
		for (int i = 0; i < 3; i++)
		{
			if (dotGO[i].layer != dotParentGO[i].layer)
			{
				dotGO[i].layer = dotParentGO[i].layer;
			}
		}
		if (hideReadyButton && !(readyButton.localScale.y <= 0f))
		{
			float y17 = readyButton.localScale.y - Time.deltaTime * 15f;
			Vector3 localScale10 = readyButton.localScale;
			float num73 = (localScale10.y = y17);
			Vector3 vector110 = (readyButton.localScale = localScale10);
			if (!(readyButton.localScale.y >= 0f))
			{
				int num74 = 0;
				Vector3 localScale11 = readyButton.localScale;
				float num75 = (localScale11.y = num74);
				Vector3 vector112 = (readyButton.localScale = localScale11);
			}
		}
		else if (!hideReadyButton && readyButton.localScale.y != 1f)
		{
			float y18 = readyButton.localScale.y + Time.deltaTime * 15f;
			Vector3 localScale12 = readyButton.localScale;
			float num76 = (localScale12.y = y18);
			Vector3 vector114 = (readyButton.localScale = localScale12);
			if (!(readyButton.localScale.y <= 1f))
			{
				int num77 = 1;
				Vector3 localScale13 = readyButton.localScale;
				float num78 = (localScale13.y = num77);
				Vector3 vector116 = (readyButton.localScale = localScale13);
			}
		}
		if (showUpgradeConsole && upgradeConsole.position.y != -0.21f)
		{
			float y19 = Mathf.Lerp(upgradeConsole.position.y, -0.21f, 14f * Time.deltaTime);
			Vector3 position40 = upgradeConsole.position;
			float num79 = (position40.y = y19);
			Vector3 vector118 = (upgradeConsole.position = position40);
			if (!(upgradeConsole.position.y < -0.211f))
			{
				float y20 = -0.21f;
				Vector3 position41 = upgradeConsole.position;
				float num80 = (position41.y = y20);
				Vector3 vector120 = (upgradeConsole.position = position41);
			}
		}
		else if (!showUpgradeConsole && upgradeConsole.position.y != -3.8f)
		{
			float y21 = Mathf.Lerp(upgradeConsole.position.y, -2.5f, 14f * Time.deltaTime);
			Vector3 position42 = upgradeConsole.position;
			float num81 = (position42.y = y21);
			Vector3 vector122 = (upgradeConsole.position = position42);
			if (!(upgradeConsole.position.y > -2.499f))
			{
				float y22 = -3.8f;
				Vector3 position43 = upgradeConsole.position;
				float num82 = (position43.y = y22);
				Vector3 vector124 = (upgradeConsole.position = position43);
			}
		}
		if (showPurchaseConsole && purchaseConsole.position.y != -0.21f)
		{
			float y23 = Mathf.Lerp(purchaseConsole.position.y, -0.21f, 14f * Time.deltaTime);
			Vector3 position44 = purchaseConsole.position;
			float num83 = (position44.y = y23);
			Vector3 vector126 = (purchaseConsole.position = position44);
			if (!(purchaseConsole.position.y < -0.211f))
			{
				float y24 = -0.21f;
				Vector3 position45 = purchaseConsole.position;
				float num84 = (position45.y = y24);
				Vector3 vector128 = (purchaseConsole.position = position45);
			}
		}
		else if (!showPurchaseConsole && purchaseConsole.position.y != -3.8f)
		{
			float y25 = Mathf.Lerp(purchaseConsole.position.y, -2.5f, 14f * Time.deltaTime);
			Vector3 position46 = purchaseConsole.position;
			float num85 = (position46.y = y25);
			Vector3 vector130 = (purchaseConsole.position = position46);
			if (!(purchaseConsole.position.y > -2.499f))
			{
				float y26 = -3.8f;
				Vector3 position47 = purchaseConsole.position;
				float num86 = (position47.y = y26);
				Vector3 vector132 = (purchaseConsole.position = position47);
			}
		}
		if (underlineTransform.position.x != weaponPerkNameTransform.position.x)
		{
			float x21 = weaponPerkNameTransform.position.x;
			Vector3 position48 = underlineTransform.position;
			float num87 = (position48.x = x21);
			Vector3 vector134 = (underlineTransform.position = position48);
		}
		if (mainConsoleShade && !(mainConsoleShadeRenderer.material.color.a >= 0.7f))
		{
			float a = mainConsoleShadeRenderer.material.color.a + Time.deltaTime * 2f;
			Color color = mainConsoleShadeRenderer.material.color;
			float num88 = (color.a = a);
			Color color3 = (mainConsoleShadeRenderer.material.color = color);
			if (!mainConsoleShadeRenderer.enabled)
			{
				mainConsoleShadeRenderer.enabled = true;
				mainConsoleShadeGO.active = true;
			}
			if (!(mainConsoleShadeRenderer.material.color.a <= 0.7f))
			{
				float a2 = 0.7f;
				Color color4 = mainConsoleShadeRenderer.material.color;
				float num89 = (color4.a = a2);
				Color color6 = (mainConsoleShadeRenderer.material.color = color4);
			}
		}
		else if (!mainConsoleShade && !(mainConsoleShadeRenderer.material.color.a <= 0f))
		{
			float a3 = mainConsoleShadeRenderer.material.color.a - Time.deltaTime * 4f;
			Color color7 = mainConsoleShadeRenderer.material.color;
			float num90 = (color7.a = a3);
			Color color9 = (mainConsoleShadeRenderer.material.color = color7);
			if (!(mainConsoleShadeRenderer.material.color.a > 0f))
			{
				mainConsoleShadeRenderer.enabled = false;
				mainConsoleShadeGO.active = false;
			}
		}
		if (moveConsoleDown && mainConsole.position.y != -1.97f)
		{
			float y27 = Mathf.Lerp(mainConsole.position.y, -1.97f, 13f * Time.deltaTime);
			Vector3 position49 = mainConsole.position;
			float num91 = (position49.y = y27);
			Vector3 vector136 = (mainConsole.position = position49);
			if (!(mainConsole.position.y > -1.969f))
			{
				float y28 = -1.97f;
				Vector3 position50 = mainConsole.position;
				float num92 = (position50.y = y28);
				Vector3 vector138 = (mainConsole.position = position50);
			}
		}
		else if (moveConsoleUp && mainConsole.position.y != 1.2f)
		{
			float y29 = Mathf.Lerp(mainConsole.position.y, 1.2f, 13f * Time.deltaTime);
			Vector3 position51 = mainConsole.position;
			float num93 = (position51.y = y29);
			Vector3 vector140 = (mainConsole.position = position51);
			if (!(mainConsole.position.y < 1.199f))
			{
				float y30 = 1.2f;
				Vector3 position52 = mainConsole.position;
				float num94 = (position52.y = y30);
				Vector3 vector142 = (mainConsole.position = position52);
			}
		}
		else if (hideConsole && mainConsole.position.y != -4.4f)
		{
			float y31 = Mathf.Lerp(mainConsole.position.y, -4.4f, 16f * Time.deltaTime);
			Vector3 position53 = mainConsole.position;
			float num95 = (position53.y = y31);
			Vector3 vector144 = (mainConsole.position = position53);
			if (!(mainConsole.position.y > -4.399f))
			{
				float y32 = -4.4f;
				Vector3 position54 = mainConsole.position;
				float num96 = (position54.y = y32);
				Vector3 vector146 = (mainConsole.position = position54);
			}
			if (weaponPane.position.y != -5.5f)
			{
				float y33 = -5.5f;
				Vector3 position55 = weaponPane.position;
				float num97 = (position55.y = y33);
				Vector3 vector148 = (weaponPane.position = position55);
			}
		}
		else if (!hideConsole && !moveConsoleDown && !moveConsoleUp && mainConsole.position.y != 0.15f)
		{
			float y34 = Mathf.Lerp(mainConsole.position.y, 0.15f, 13f * Time.deltaTime);
			Vector3 position56 = mainConsole.position;
			float num98 = (position56.y = y34);
			Vector3 vector150 = (mainConsole.position = position56);
			if (!(mainConsole.position.y <= 0.149f))
			{
				float y35 = 0.15f;
				Vector3 position57 = mainConsole.position;
				float num99 = (position57.y = y35);
				Vector3 vector152 = (mainConsole.position = position57);
			}
		}
		if (liftWeaponPane && weaponPane.position.y != 0f)
		{
			float y36 = Mathf.Lerp(weaponPane.position.y, 0f, 19f * Time.deltaTime);
			Vector3 position58 = weaponPane.position;
			float num100 = (position58.y = y36);
			Vector3 vector154 = (weaponPane.position = position58);
			if (!(weaponPane.position.y < -0.001f))
			{
				int num101 = 0;
				Vector3 position59 = weaponPane.position;
				float num102 = (position59.y = num101);
				Vector3 vector156 = (weaponPane.position = position59);
			}
		}
		else if (!hideConsole && !liftWeaponPane && weaponPane.position.y != -6f)
		{
			float y37 = Mathf.Lerp(weaponPane.position.y, -6f, 19f * Time.deltaTime);
			Vector3 position60 = weaponPane.position;
			float num103 = (position60.y = y37);
			Vector3 vector158 = (weaponPane.position = position60);
			if (!(weaponPane.position.y > -5.999f))
			{
				int num104 = -6;
				Vector3 position61 = weaponPane.position;
				float num105 = (position61.y = num104);
				Vector3 vector160 = (weaponPane.position = position61);
			}
		}
		if (openWeaponPane && leftBorder.position.x != 0f)
		{
			float x22 = Mathf.Lerp(leftBorder.position.x, 0f, 16f * Time.deltaTime);
			Vector3 position62 = leftBorder.position;
			float num106 = (position62.x = x22);
			Vector3 vector162 = (leftBorder.position = position62);
			float x23 = 0f - leftBorder.position.x;
			Vector3 position63 = rightBorder.position;
			float num107 = (position63.x = x23);
			Vector3 vector164 = (rightBorder.position = position63);
			if (!(Mathf.Abs(leftBorder.position.x) >= 0.001f))
			{
				int num108 = 0;
				Vector3 position64 = leftBorder.position;
				float num109 = (position64.x = num108);
				Vector3 vector166 = (leftBorder.position = position64);
				int num110 = 0;
				Vector3 position65 = rightBorder.position;
				float num111 = (position65.x = num110);
				Vector3 vector168 = (rightBorder.position = position65);
			}
		}
		else if (!openWeaponPane && leftBorder.position.x != 4f)
		{
			float x24 = Mathf.Lerp(leftBorder.position.x, 4f, 24f * Time.deltaTime);
			Vector3 position66 = leftBorder.position;
			float num112 = (position66.x = x24);
			Vector3 vector170 = (leftBorder.position = position66);
			float x25 = 0f - leftBorder.position.x;
			Vector3 position67 = rightBorder.position;
			float num113 = (position67.x = x25);
			Vector3 vector172 = (rightBorder.position = position67);
			if (!(leftBorder.position.x <= 3.999f))
			{
				int num114 = 4;
				Vector3 position68 = leftBorder.position;
				float num115 = (position68.x = num114);
				Vector3 vector174 = (leftBorder.position = position68);
				int num116 = -4;
				Vector3 position69 = rightBorder.position;
				float num117 = (position69.x = num116);
				Vector3 vector176 = (rightBorder.position = position69);
			}
		}
		if (showTopLeft && topLeftPane.position.x != 0f)
		{
			float x26 = Mathf.Lerp(topLeftPane.position.x, 0f, 16f * Time.deltaTime);
			Vector3 position70 = topLeftPane.position;
			float num118 = (position70.x = x26);
			Vector3 vector178 = (topLeftPane.position = position70);
			if (!(topLeftPane.position.x < -0.001f))
			{
				int num119 = 0;
				Vector3 position71 = topLeftPane.position;
				float num120 = (position71.x = num119);
				Vector3 vector180 = (topLeftPane.position = position71);
			}
		}
		else if (showTopLeftShort && topLeftPane.position.x != -0.72f)
		{
			float x27 = Mathf.Lerp(topLeftPane.position.x, -0.72f, 13f * Time.deltaTime);
			Vector3 position72 = topLeftPane.position;
			float num121 = (position72.x = x27);
			Vector3 vector182 = (topLeftPane.position = position72);
			if (!(topLeftPane.position.x < -0.721f))
			{
				float x28 = -0.72f;
				Vector3 position73 = topLeftPane.position;
				float num122 = (position73.x = x28);
				Vector3 vector184 = (topLeftPane.position = position73);
			}
		}
		else if (showTopLeftMed && topLeftPane.position.x != -0.416f)
		{
			float x29 = Mathf.Lerp(topLeftPane.position.x, -0.416f, 13f * Time.deltaTime);
			Vector3 position74 = topLeftPane.position;
			float num123 = (position74.x = x29);
			Vector3 vector186 = (topLeftPane.position = position74);
			if (!(topLeftPane.position.x < -0.417f))
			{
				float x30 = -0.416f;
				Vector3 position75 = topLeftPane.position;
				float num124 = (position75.x = x30);
				Vector3 vector188 = (topLeftPane.position = position75);
			}
		}
		else if (!showTopLeftMed && !showTopLeft && !showTopLeftShort && topLeftPane.position.x != -4f)
		{
			float x31 = Mathf.Lerp(topLeftPane.position.x, -4f, 13f * Time.deltaTime);
			Vector3 position76 = topLeftPane.position;
			float num125 = (position76.x = x31);
			Vector3 vector190 = (topLeftPane.position = position76);
			if (!(topLeftPane.position.x > -3.999f))
			{
				int num126 = -4;
				Vector3 position77 = topLeftPane.position;
				float num127 = (position77.x = num126);
				Vector3 vector192 = (topLeftPane.position = position77);
			}
		}
		if (!fingerDown && scrollingSpeed != 0f)
		{
			float x32 = scrollingWeaponMenu.position.x + scrollingSpeed * Time.deltaTime;
			Vector3 position78 = scrollingWeaponMenu.position;
			float num128 = (position78.x = x32);
			Vector3 vector194 = (scrollingWeaponMenu.position = position78);
			if (!(scrollingSpeed <= 0f) && !(Mathf.Abs(scrollingSpeed) >= (float)scrollingSpeedBreakPoint))
			{
				scrollingSpeed -= Time.deltaTime * 15f;
				if (!(scrollingSpeed >= 0f))
				{
					scrollingSpeed = 0f;
				}
			}
			else if (!(scrollingSpeed >= 0f) && !(Mathf.Abs(scrollingSpeed) >= (float)scrollingSpeedBreakPoint))
			{
				scrollingSpeed += Time.deltaTime * 15f;
				if (!(scrollingSpeed <= 0f))
				{
					scrollingSpeed = 0f;
				}
			}
		}
		if (!fingerDown && !(Mathf.Abs(scrollingSpeed) > 3f) && !moveIsoIcon && !iconIsoRenderer.enabled)
		{
			float num129 = 0f;
			for (int i = 0; i < maximumPages; i++)
			{
				if (!(Mathf.Abs(scrollingWeaponMenu.position.x - (float)i * -1.87f) >= Mathf.Abs(scrollingWeaponMenu.position.x - num129)))
				{
					num129 = (float)i * -1.87f;
				}
			}
			float x33 = Mathf.Lerp(scrollingWeaponMenu.position.x, num129, 6f * Time.deltaTime);
			Vector3 position79 = scrollingWeaponMenu.position;
			float num130 = (position79.x = x33);
			Vector3 vector196 = (scrollingWeaponMenu.position = position79);
		}
		if (!(scrollingWeaponMenu.position.x <= 0.6f) && !(scrollingSpeed <= 0f))
		{
			scrollingSpeed = 0f;
		}
		else if (!(scrollingWeaponMenu.position.x >= (float)(maximumPages - 1) * -1.87f - 0.6f) && !(scrollingSpeed >= 0f))
		{
			scrollingSpeed = 0f;
		}
		if (!(scrollingSpeed <= 25f))
		{
			scrollingSpeed = 25f;
		}
		else if (!(scrollingSpeed >= -25f))
		{
			scrollingSpeed = -25f;
		}
		if (moveIsoIcon && (bool)editPanel)
		{
			editPanel.position = Vector3.Lerp(editPanel.position, new Vector3(-2.8f, 1.8f, -3f), 15f * Time.deltaTime);
		}
		else if (moveIsoIconBack && (bool)editPanel && editPanel.position != iconIsoStartPos)
		{
			editPanel.position = Vector3.Lerp(editPanel.position, iconIsoStartPos, 18f * Time.deltaTime);
		}
		if (showWeaponPerkName)
		{
			float x34 = Mathf.Lerp(weaponPerkNameTransform.position.x, -1.77f, 15f * Time.deltaTime);
			Vector3 position80 = weaponPerkNameTransform.position;
			float num131 = (position80.x = x34);
			Vector3 vector198 = (weaponPerkNameTransform.position = position80);
		}
		else if (!showWeaponPerkName)
		{
			float x35 = Mathf.Lerp(weaponPerkNameTransform.position.x, 6f, 15f * Time.deltaTime);
			Vector3 position81 = weaponPerkNameTransform.position;
			float num132 = (position81.x = x35);
			Vector3 vector200 = (weaponPerkNameTransform.position = position81);
		}
	}

	public virtual void fadeAnimation()
	{
		if (fade)
		{
			if (!fader.enabled)
			{
				fader.enabled = true;
			}
			if (fader.material.color.a != 1f)
			{
				menuMusic.volume -= Time.deltaTime;
				float a = fader.material.color.a + 0.8f * Time.deltaTime;
				Color color = fader.material.color;
				float num = (color.a = a);
				Color color3 = (fader.material.color = color);
				if (!(fader.material.color.a < 1f))
				{
					int num2 = 1;
					Color color4 = fader.material.color;
					float num3 = (color4.a = num2);
					Color color6 = (fader.material.color = color4);
				}
			}
		}
		else
		{
			if (fade)
			{
				return;
			}
			if (!fader.enabled && fader.material.color.a != 0f)
			{
				fader.enabled = true;
			}
			if (fader.material.color.a != 0f)
			{
				float a2 = fader.material.color.a - 1.4f * Time.deltaTime;
				Color color7 = fader.material.color;
				float num4 = (color7.a = a2);
				Color color9 = (fader.material.color = color7);
				if (!(fader.material.color.a > 0f))
				{
					int num5 = 0;
					Color color10 = fader.material.color;
					float num6 = (color10.a = num5);
					Color color12 = (fader.material.color = color10);
					fader.enabled = false;
				}
			}
		}
	}

	public virtual void blinkyAnimation()
	{
		if (!blinkyActive || !blinkyRenderer)
		{
			return;
		}
		blinkTimer -= Time.deltaTime;
		blinkSubTimer -= Time.deltaTime;
		if (!(blinkSubTimer > 0f))
		{
			blinkSubTimer = 0.04f;
			if (blinkyRenderer.enabled)
			{
				blinkyRenderer.enabled = false;
			}
			else
			{
				blinkyRenderer.enabled = true;
			}
		}
		if (!(blinkTimer > 0f))
		{
			blinkyActive = false;
			blinkyRenderer.enabled = false;
		}
	}

	public virtual IEnumerator disconnect()
	{
		return new _0024disconnect_00241746(this).GetEnumerator();
	}

	public virtual IEnumerator activateButton()
	{
		return new _0024activateButton_00241751(this).GetEnumerator();
	}

	public virtual IEnumerator closeSubMenu()
	{
		return new _0024closeSubMenu_00241784(this).GetEnumerator();
	}

	public virtual void updateVisiblePlayer()
	{
		if ((bool)playerSpawnGO)
		{
			UnityEngine.Object.Destroy(playerSpawnGO);
		}
		playerSpawnGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.PCs[DB.myPC].characterModel));
		playerSpawnScript = (PlayerScript)playerSpawnGO.GetComponent(typeof(PlayerScript));
		playerSpawnScript.MenuInitialize();
		playerSpawnScript.myTransform.parent = playerSpawnSocket;
		playerSpawnScript.myTransform.localPosition = new Vector3(0f, 0f, 0f);
		playerSpawnScript.myTransform.localEulerAngles = new Vector3(0f, 0f, 0f);
		playerSpawnScript.myTransform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
	}

	public virtual void updateLoadout()
	{
		for (int i = 0; i < 3; i++)
		{
			if (DB.PCs[DB.myPC].weapons[i] != WeaponEnum.Empty)
			{
				if (loadoutIcons[i] != null)
				{
					UnityEngine.Object.Destroy(loadoutIcons[i]);
				}
				loadoutIcons[i] = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Menu_WeaponIcons/" + DB.weapons[(int)DB.PCs[DB.myPC].weapons[i]].weaponName));
				tempTransform = loadoutIcons[i].transform;
				tempTransform.name = "Icon";
				tempTransform.parent = centerConsoleWeaponSockets[i];
				tempTransform.localPosition = new Vector3(0f, 0f, 0f);
				tempTransform.localEulerAngles = new Vector3(0f, 0f, 0f);
				if ((bool)editWeaponSlot && ((i == 0 && editWeaponSlot.name == "WeaponPane1" && editWeaponSlot.position.z <= -2f) || (i == 1 && editWeaponSlot.name == "WeaponPane2" && editWeaponSlot.position.z <= -2f) || (i == 2 && editWeaponSlot.name == "WeaponPane3" && !(editWeaponSlot.position.z > -2f))))
				{
					loadoutIcons[i].layer = 15;
				}
			}
			else if (loadoutIcons[i] != null)
			{
				UnityEngine.Object.Destroy(loadoutIcons[i]);
			}
		}
		for (int i = 0; i < 3; i++)
		{
			if (DB.PCs[DB.myPC].perks[i] != PerkEnum.Empty)
			{
				centerConsolePerkText[i].text = DB.perks[(int)DB.PCs[DB.myPC].perks[i]].perkDisplayName;
				centerConsolePerkText[i].transform.localScale = new Vector3(DB.perks[(int)DB.PCs[DB.myPC].perks[i]].perkFontSize, DB.perks[(int)DB.PCs[DB.myPC].perks[i]].perkFontSize, DB.perks[(int)DB.PCs[DB.myPC].perks[i]].perkFontSize);
			}
			else
			{
				centerConsolePerkText[i].text = "-";
				centerConsolePerkText[i].transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
			}
		}
	}

	public virtual void updateScrollingWeaponList()
	{
		for (int i = 0; i < Extensions.get_length((Array)scrollingListSlots); i++)
		{
			if ((bool)scrollingListSlots[i].perkTextGO)
			{
				scrollingListSlots[i].perkTextGO.active = false;
			}
			if ((bool)scrollingListSlots[i].playerIconInstance)
			{
				scrollingListSlots[i].playerIconInstance.active = false;
			}
			if (scrollingListSlots[i].weapon != WeaponEnum.Empty)
			{
				int num = 0;
				Vector3 localEulerAngles = scrollingListSlots[i].slot.localEulerAngles;
				float num2 = (localEulerAngles.y = num);
				Vector3 vector2 = (scrollingListSlots[i].slot.localEulerAngles = localEulerAngles);
				scrollingListSlots[i].slot.gameObject.layer = 15;
				if (scrollingListSlots[i].iconInstance != null && scrollingListSlots[i].iconInstance.transform.name != DB.weapons[(int)scrollingListSlots[i].weapon].weaponName)
				{
					UnityEngine.Object.Destroy(scrollingListSlots[i].iconInstance);
					scrollingListSlots[i].iconInstance = null;
				}
				if (scrollingListSlots[i].iconInstance == null)
				{
					scrollingListSlots[i].iconInstance = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Menu_WeaponIcons/" + DB.weapons[(int)scrollingListSlots[i].weapon].weaponName));
					scrollingListSlots[i].iconInstance.layer = 15;
					tempTransform = scrollingListSlots[i].iconInstance.transform;
					tempTransform.name = DB.weapons[(int)scrollingListSlots[i].weapon].weaponName;
					tempTransform.parent = scrollingListSlots[i].slot;
					tempTransform.localPosition = new Vector3(0f, 0f, 0f);
					tempTransform.localEulerAngles = new Vector3(0f, 0f, 0f);
				}
				else
				{
					scrollingListSlots[i].iconInstance.active = true;
				}
				if (DB.weapons[(int)scrollingListSlots[i].weapon].purchased)
				{
					scrollingListSlots[i].iconInstance.GetComponent<Renderer>().material.color = new Color(0.25f, 0.25f, 0.25f);
					scrollingListSlots[i].@lock.enabled = false;
					scrollingListSlots[i].darkBG.enabled = false;
					scrollingListSlots[i].lightBG.enabled = true;
					continue;
				}
				scrollingListSlots[i].iconInstance.GetComponent<Renderer>().material.color = new Color(0.05f, 0.05f, 0.05f);
				if (DB.weapons[(int)scrollingListSlots[i].weapon].price[0] > DB.money)
				{
					scrollingListSlots[i].@lock.enabled = true;
				}
				else
				{
					scrollingListSlots[i].@lock.enabled = false;
				}
				scrollingListSlots[i].darkBG.enabled = true;
				scrollingListSlots[i].lightBG.enabled = false;
			}
			else
			{
				int num3 = 180;
				Vector3 localEulerAngles2 = scrollingListSlots[i].slot.localEulerAngles;
				float num4 = (localEulerAngles2.y = num3);
				Vector3 vector4 = (scrollingListSlots[i].slot.localEulerAngles = localEulerAngles2);
				scrollingListSlots[i].slot.gameObject.layer = 0;
				scrollingListSlots[i].@lock.enabled = false;
				scrollingListSlots[i].darkBG.enabled = true;
				scrollingListSlots[i].lightBG.enabled = false;
			}
		}
	}

	public virtual void updateScrollingPerkList()
	{
		for (int i = 0; i < Extensions.get_length((Array)scrollingListSlots); i++)
		{
			if ((bool)scrollingListSlots[i].iconInstance)
			{
				scrollingListSlots[i].iconInstance.active = false;
			}
			if ((bool)scrollingListSlots[i].playerIconInstance)
			{
				scrollingListSlots[i].playerIconInstance.active = false;
			}
			if (scrollingListSlots[i].perk != PerkEnum.Empty)
			{
				int num = 0;
				Vector3 localEulerAngles = scrollingListSlots[i].slot.localEulerAngles;
				float num2 = (localEulerAngles.y = num);
				Vector3 vector2 = (scrollingListSlots[i].slot.localEulerAngles = localEulerAngles);
				scrollingListSlots[i].slot.gameObject.layer = 15;
				if (!scrollingListSlots[i].perkTextGO)
				{
					tempTransform = UnityEngine.Object.Instantiate(perkTextPrefab);
					scrollingListSlots[i].perkTextGO = tempTransform.gameObject;
					scrollingListSlots[i].perkText = (TextMesh)scrollingListSlots[i].perkTextGO.GetComponent(typeof(TextMesh));
					scrollingListSlots[i].perkText.text = DB.perks[(int)scrollingListSlots[i].perk].perkDisplayName;
					scrollingListSlots[i].perkTextRenderer = (Renderer)scrollingListSlots[i].perkTextGO.GetComponent(typeof(Renderer));
					tempTransform.parent = scrollingListSlots[i].slot;
					tempTransform.localPosition = new Vector3(0f, 0.05f, 0.6f);
					tempTransform.localScale = new Vector3(DB.perks[(int)scrollingListSlots[i].perk].perkFontSize, DB.perks[(int)scrollingListSlots[i].perk].perkFontSize, DB.perks[(int)scrollingListSlots[i].perk].perkFontSize);
				}
				else
				{
					scrollingListSlots[i].perkTextGO.active = true;
				}
				if (DB.perks[(int)scrollingListSlots[i].perk].purchased)
				{
					scrollingListSlots[i].perkTextRenderer.material = lightTextMaterial;
					scrollingListSlots[i].@lock.enabled = false;
					scrollingListSlots[i].darkBG.enabled = false;
					scrollingListSlots[i].lightBG.enabled = true;
					continue;
				}
				scrollingListSlots[i].perkTextRenderer.material = darkTextMaterial;
				if (DB.perks[(int)scrollingListSlots[i].perk].price[0] > DB.money)
				{
					scrollingListSlots[i].@lock.enabled = true;
				}
				else
				{
					scrollingListSlots[i].@lock.enabled = false;
				}
				scrollingListSlots[i].darkBG.enabled = true;
				scrollingListSlots[i].lightBG.enabled = false;
			}
			else
			{
				int num3 = 180;
				Vector3 localEulerAngles2 = scrollingListSlots[i].slot.localEulerAngles;
				float num4 = (localEulerAngles2.y = num3);
				Vector3 vector4 = (scrollingListSlots[i].slot.localEulerAngles = localEulerAngles2);
				scrollingListSlots[i].slot.gameObject.layer = 0;
				scrollingListSlots[i].@lock.enabled = false;
				scrollingListSlots[i].darkBG.enabled = true;
				scrollingListSlots[i].lightBG.enabled = false;
			}
		}
	}

	public virtual void updateScrollingPlayerList()
	{
		for (int i = 0; i < Extensions.get_length((Array)scrollingListSlots); i++)
		{
			if ((bool)scrollingListSlots[i].perkTextGO)
			{
				scrollingListSlots[i].perkTextGO.active = false;
			}
			if ((bool)scrollingListSlots[i].iconInstance)
			{
				scrollingListSlots[i].iconInstance.active = false;
			}
			if (scrollingListSlots[i].PC != -1)
			{
				int num = 0;
				Vector3 localEulerAngles = scrollingListSlots[i].slot.localEulerAngles;
				float num2 = (localEulerAngles.y = num);
				Vector3 vector2 = (scrollingListSlots[i].slot.localEulerAngles = localEulerAngles);
				scrollingListSlots[i].slot.gameObject.layer = 15;
				if (scrollingListSlots[i].playerIconInstance == null)
				{
					scrollingListSlots[i].playerIconInstance = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Menu_Portraits/" + DB.PCs[scrollingListSlots[i].PC].iconName));
					scrollingListSlots[i].playerIconInstance.layer = 15;
					tempTransform = scrollingListSlots[i].playerIconInstance.transform;
					tempTransform.name = DB.PCs[scrollingListSlots[i].PC].iconName;
					tempTransform.parent = scrollingListSlots[i].slot;
					tempTransform.localPosition = new Vector3(0f, 0f, 0.5f);
					tempTransform.localEulerAngles = new Vector3(0f, 0f, 0f);
				}
				else
				{
					scrollingListSlots[i].playerIconInstance.active = true;
				}
				if (DB.PCs[scrollingListSlots[i].PC].purchased)
				{
					scrollingListSlots[i].playerIconInstance.GetComponent<Renderer>().material.color = new Color(0.25f, 0.25f, 0.25f);
					scrollingListSlots[i].@lock.enabled = false;
					scrollingListSlots[i].darkBG.enabled = false;
					scrollingListSlots[i].lightBG.enabled = true;
					continue;
				}
				scrollingListSlots[i].playerIconInstance.GetComponent<Renderer>().material.color = new Color(0.05f, 0.05f, 0.05f);
				if (DB.playerPriceTable[DB.playersPurchased] > DB.money)
				{
					scrollingListSlots[i].@lock.enabled = true;
				}
				else
				{
					scrollingListSlots[i].@lock.enabled = false;
				}
				scrollingListSlots[i].darkBG.enabled = true;
				scrollingListSlots[i].lightBG.enabled = false;
			}
			else
			{
				int num3 = 180;
				Vector3 localEulerAngles2 = scrollingListSlots[i].slot.localEulerAngles;
				float num4 = (localEulerAngles2.y = num3);
				Vector3 vector4 = (scrollingListSlots[i].slot.localEulerAngles = localEulerAngles2);
				scrollingListSlots[i].slot.gameObject.layer = 0;
				scrollingListSlots[i].@lock.enabled = false;
				scrollingListSlots[i].darkBG.enabled = true;
				scrollingListSlots[i].lightBG.enabled = false;
			}
		}
	}

	public virtual void identifyPanel()
	{
		for (int i = 0; i < Extensions.get_length((Array)scrollingListSlots); i++)
		{
			if (editPanel == scrollingListSlots[i].slot)
			{
				panelID = i;
				i = Extensions.get_length((Array)scrollingListSlots);
			}
		}
	}

	public virtual void updateStars(int howMany)
	{
		for (int i = 0; i < 5; i++)
		{
			if (i < howMany)
			{
				darkStars[i].enabled = false;
				lightStars[i].enabled = true;
			}
			else
			{
				darkStars[i].enabled = true;
				lightStars[i].enabled = false;
			}
		}
	}

	public virtual void updateDifficultyStars()
	{
		for (int i = 0; i < Extensions.get_length((Array)difficultyStars); i++)
		{
			difficultyStars[i].enabled = true;
			difficultyStarsLit[i].enabled = false;
		}
		for (int i = 0; i < DB.difficulty; i++)
		{
			difficultyStars[i].enabled = false;
			difficultyStarsLit[i].enabled = true;
		}
		locationNameText.text = zones[DB.difficulty - 1].zoneName;
		mapTargetPosition = zones[DB.difficulty - 1].mapLocation;
		if (DB.totalKills >= zones[DB.difficulty - 1].requiredKills)
		{
			int num = -20;
			Vector3 localPosition = mapShade.localPosition;
			float num2 = (localPosition.y = num);
			Vector3 vector2 = (mapShade.localPosition = localPosition);
			if (openMap)
			{
				hideDeployButton = false;
			}
			zoneHighlight.localPosition = -zones[DB.difficulty - 1].mapLocation + new Vector3(0f, 0f, 1f);
			zoneAnim.Stop();
			zoneAnim.Play("open");
		}
		else
		{
			int num3 = 0;
			Vector3 localPosition2 = mapShade.localPosition;
			float num4 = (localPosition2.y = num3);
			Vector3 vector4 = (mapShade.localPosition = localPosition2);
			hideDeployButton = true;
			int num5 = zones[DB.difficulty - 1].requiredKills - DB.totalKills;
			levelLockText.text = "- Area Locked -\nDestroy " + num5 + " more zombies to unlock";
			zoneAnim.Play("idle");
		}
	}

	public virtual void displayCash(bool forceUpdate)
	{
		if (forceUpdate)
		{
			displayedCash = DB.money;
			cashText.text = "$" + displayedCash;
		}
		else if (displayedCash < DB.money)
		{
			displayedCash += Mathf.RoundToInt(Time.deltaTime * 500f);
			if (displayedCash > DB.money)
			{
				displayedCash = DB.money;
			}
			cashText.text = "$" + displayedCash;
		}
		else if (displayedCash > DB.money)
		{
			displayedCash -= Mathf.RoundToInt(Time.deltaTime * 500f);
			if (displayedCash < DB.money)
			{
				displayedCash = DB.money;
			}
			cashText.text = "$" + displayedCash;
		}
	}

	public virtual IEnumerator equip(int whichWeapon)
	{
		return new _0024equip_00241791(whichWeapon, this).GetEnumerator();
	}

	public virtual IEnumerator equipPerk(int whichWeapon)
	{
		return new _0024equipPerk_00241802(whichWeapon, this).GetEnumerator();
	}

	public virtual void upgradeButtonVisibility(int whichWeapon, string perkOrWeapon)
	{
		switch (perkOrWeapon)
		{
		case "weapon":
			if (DB.weapons[whichWeapon].rank == 5)
			{
				upgradeButtonGO.layer = 0;
				int num7 = 180;
				Vector3 localEulerAngles4 = upgradeButtonTransform.localEulerAngles;
				float num8 = (localEulerAngles4.y = num7);
				Vector3 vector8 = (upgradeButtonTransform.localEulerAngles = localEulerAngles4);
			}
			else
			{
				upgradeButtonGO.layer = 13;
				int num9 = 0;
				Vector3 localEulerAngles5 = upgradeButtonTransform.localEulerAngles;
				float num10 = (localEulerAngles5.y = num9);
				Vector3 vector10 = (upgradeButtonTransform.localEulerAngles = localEulerAngles5);
			}
			break;
		case "perk":
			if (DB.perks[whichWeapon].rank == PerkStars.Rank5)
			{
				upgradeButtonGO.layer = 0;
				int num3 = 180;
				Vector3 localEulerAngles2 = upgradeButtonTransform.localEulerAngles;
				float num4 = (localEulerAngles2.y = num3);
				Vector3 vector4 = (upgradeButtonTransform.localEulerAngles = localEulerAngles2);
			}
			else
			{
				upgradeButtonGO.layer = 13;
				int num5 = 0;
				Vector3 localEulerAngles3 = upgradeButtonTransform.localEulerAngles;
				float num6 = (localEulerAngles3.y = num5);
				Vector3 vector6 = (upgradeButtonTransform.localEulerAngles = localEulerAngles3);
			}
			break;
		case "player":
		{
			int num = 180;
			Vector3 localEulerAngles = upgradeButtonTransform.localEulerAngles;
			float num2 = (localEulerAngles.y = num);
			Vector3 vector2 = (upgradeButtonTransform.localEulerAngles = localEulerAngles);
			upgradeButtonGO.layer = 0;
			break;
		}
		}
	}

	public virtual void determineWhichPlayer()
	{
	}

	public virtual void broadcast(string whichObject, string whichFunction, string message, bool reliable)
	{
	}

	public virtual void P2Waiting(string argument)
	{
		if (argument == "true")
		{
			player2Ready = true;
		}
		else
		{
			player2Ready = false;
		}
	}

	public virtual IEnumerator forceGameStart(int whichDifficulty)
	{
		return new _0024forceGameStart_00241813(whichDifficulty, this).GetEnumerator();
	}

	public virtual void interpretDifficulty()
	{
		DB.location = zones[DB.difficulty - 1].location;
		DB.musicTrack = zones[DB.difficulty - 1].music;
		for (int i = 0; i < Extensions.get_length((Array)DB.enemyChance); i++)
		{
			DB.enemyChance[i] = zones[DB.difficulty - 1].enemyChance[i];
		}
		DB.maxEnemyCount = zones[DB.difficulty - 1].maxEnemyCount;
		DB.spawnDelayRange.x = zones[DB.difficulty - 1].spawnDelayRange.x;
		DB.spawnDelayRange.y = zones[DB.difficulty - 1].spawnDelayRange.y;
		DB.rearSpawnDelayRange.x = zones[DB.difficulty - 1].rearSpawnDelayRange.x;
		DB.rearSpawnDelayRange.y = zones[DB.difficulty - 1].rearSpawnDelayRange.y;
		DB.levelClock = zones[DB.difficulty - 1].levelClock;
		for (int i = 0; i < Extensions.get_length((Array)DB.enemyChance); i++)
		{
			DB.waveSize[i] = zones[DB.difficulty - 1].waveSize[i];
		}
	}

	public virtual IEnumerator startGame()
	{
		return new _0024startGame_00241822(this).GetEnumerator();
	}

	public virtual void muteSounds()
	{
		if (!DB.soundEnabled)
		{
			for (int i = 0; i < Extensions.get_length((Array)sounds); i++)
			{
				sounds[i].volume = 0f;
			}
		}
	}

	public virtual IEnumerator onPeerDisconnect()
	{
		return new _0024onPeerDisconnect_00241829(this).GetEnumerator();
	}

	public virtual IEnumerator tutorialSequence()
	{
		return new _0024tutorialSequence_00241838(this).GetEnumerator();
	}

	public virtual IEnumerator showAchievementBubble(int whichAchievement)
	{
		return new _0024showAchievementBubble_00241841(whichAchievement, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
