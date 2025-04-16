using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class MotherBrain : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024triggerZombieLoad_00241657 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024i_00241658;

			internal GameObject _0024tempGO_00241659;

			internal MotherBrain _0024self__00241660;

			public _0024(MotherBrain self_)
			{
				_0024self__00241660 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024i_00241658 = 0;
					goto IL_0304;
				case 3:
					_0024i_00241658++;
					goto IL_0304;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0304:
					if (_0024i_00241658 < 26)
					{
						if (_0024i_00241658 < 6)
						{
							_0024tempGO_00241659 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Enemies/BasicZombie"));
						}
						else if (_0024i_00241658 < 12)
						{
							if (_0024self__00241660.DB.difficulty >= 2)
							{
								_0024tempGO_00241659 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Enemies/FeralZombie"));
							}
							else
							{
								_0024i_00241658 = 100;
							}
						}
						else if (_0024i_00241658 < 16)
						{
							if (_0024self__00241660.DB.difficulty >= 3)
							{
								_0024tempGO_00241659 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Enemies/FatZombie"));
							}
							else
							{
								_0024i_00241658 = 100;
							}
						}
						else if (_0024i_00241658 < 22)
						{
							if (_0024self__00241660.DB.difficulty >= 4)
							{
								_0024tempGO_00241659 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Enemies/SpitterZombie"));
							}
							else
							{
								_0024i_00241658 = 100;
							}
						}
						else if (_0024self__00241660.DB.difficulty >= 5)
						{
							_0024tempGO_00241659 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Enemies/ExploderZombie"));
						}
						else
						{
							_0024i_00241658 = 100;
						}
						if (_0024i_00241658 != 100)
						{
							_0024self__00241660.zombies[_0024i_00241658] = (ZombieScript)_0024tempGO_00241659.GetComponent(typeof(ZombieScript));
							_0024self__00241660.zombies[_0024i_00241658].Initialize(_0024self__00241660.DB, _0024self__00241660);
							if (_0024self__00241660.zombies[_0024i_00241658].zombieType == EnemyType.Spitter)
							{
								_0024self__00241660.zombies[_0024i_00241658].mySpit = _0024self__00241660.spitReferences[_0024self__00241660.spitToTransfer];
								_0024self__00241660.spitToTransfer++;
							}
							if (_0024self__00241660.zombies[_0024i_00241658].zombieType == EnemyType.Exploder)
							{
								_0024self__00241660.zombies[_0024i_00241658].myExplosion = _0024self__00241660.selfDestructExplosions[_0024self__00241660.explosionToTransfer];
								_0024self__00241660.explosionToTransfer++;
							}
							_0024self__00241660.zombies[_0024i_00241658].myTransform.name = _0024i_00241658.ToString();
						}
						result = (Yield(3, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					_0024self__00241660.zombiesLoaded = true;
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain _0024self__00241661;

		public _0024triggerZombieLoad_00241657(MotherBrain self_)
		{
			_0024self__00241661 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241661);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024onPeerDisconnect_00241662 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024418_00241663;

			internal Vector3 _0024_0024419_00241664;

			internal int _0024_0024420_00241665;

			internal Vector3 _0024_0024421_00241666;

			internal MotherBrain _0024self__00241667;

			public _0024(MotherBrain self_)
			{
				_0024self__00241667 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241667.DB.multiplayer = false;
					_0024self__00241667.DB.whichPlayerAmI = 1;
					if ((bool)_0024self__00241667.allyScript)
					{
						_0024self__00241667.allyScript.mySounds[_0024self__00241667.allyScript.equippedSlot].idleLoop(false);
						UnityEngine.Object.Destroy(_0024self__00241667.allyScript.gameObject);
					}
					if ((bool)_0024self__00241667.partnerDisconnect)
					{
						float num3 = (_0024_0024418_00241663 = -2.14f);
						Vector3 vector4 = (_0024_0024419_00241664 = _0024self__00241667.partnerDisconnect.localPosition);
						float num4 = (_0024_0024419_00241664.y = _0024_0024418_00241663);
						Vector3 vector6 = (_0024self__00241667.partnerDisconnect.localPosition = _0024_0024419_00241664);
					}
					result = (Yield(2, new WaitForSeconds(3f)) ? 1 : 0);
					break;
				case 2:
					if ((bool)_0024self__00241667.partnerDisconnect)
					{
						int num = (_0024_0024420_00241665 = -8);
						Vector3 vector = (_0024_0024421_00241666 = _0024self__00241667.partnerDisconnect.localPosition);
						float num2 = (_0024_0024421_00241666.y = _0024_0024420_00241665);
						Vector3 vector3 = (_0024self__00241667.partnerDisconnect.localPosition = _0024_0024421_00241666);
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

		internal MotherBrain _0024self__00241668;

		public _0024onPeerDisconnect_00241662(MotherBrain self_)
		{
			_0024self__00241668 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241668);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024Spawn_00241669 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string _0024spawnSide_00241670;

			internal int _0024spawnTable_00241671;

			internal int _0024waveSize_00241672;

			internal int _0024i_00241673;

			internal int _0024cummulativeInt_00241674;

			internal int _0024enemyType_00241675;

			internal int _0024i2_00241676;

			internal int _0024availableZombie_00241677;

			internal float _0024tempPosition_00241678;

			internal Transform _0024rightmostPlayer_00241679;

			internal Transform _0024leftmostPlayer_00241680;

			internal int _0024spawnStyle_00241681;

			internal int _0024tempSpecialSpawnChance_00241682;

			internal MotherBrain _0024self__00241683;

			public _0024(MotherBrain self_)
			{
				_0024self__00241683 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (!(_0024self__00241683.spawnDelay <= 0f) && _0024self__00241683.activeEnemies < _0024self__00241683.DB.maxEnemyCount)
					{
						if (((bool)_0024self__00241683.playerScript && _0024self__00241683.playerScript.inVehicle) || ((bool)_0024self__00241683.allyScript && _0024self__00241683.allyScript.inVehicle))
						{
							_0024self__00241683.spawnDelay -= 9f * Time.deltaTime;
						}
						else
						{
							_0024self__00241683.spawnDelay -= Time.deltaTime;
						}
					}
					if (!(_0024self__00241683.rearSpawnDelay <= 0f) && _0024self__00241683.activeEnemies < _0024self__00241683.DB.maxEnemyCount)
					{
						_0024self__00241683.rearSpawnDelay -= Time.deltaTime;
					}
					if ((!(_0024self__00241683.spawnDelay > 0f) && _0024self__00241683.activeEnemies < _0024self__00241683.DB.maxEnemyCount) || (!(_0024self__00241683.rearSpawnDelay > 0f) && _0024self__00241683.activeEnemies < _0024self__00241683.DB.maxEnemyCount))
					{
						if (!(_0024self__00241683.spawnDelay > 0f))
						{
							_0024self__00241683.spawnDelay = UnityEngine.Random.Range(_0024self__00241683.DB.spawnDelayRange.x, _0024self__00241683.DB.spawnDelayRange.y);
							_0024spawnSide_00241670 = "front";
						}
						else if (!(_0024self__00241683.rearSpawnDelay > 0f))
						{
							_0024self__00241683.rearSpawnDelay = UnityEngine.Random.Range(_0024self__00241683.DB.rearSpawnDelayRange.x, _0024self__00241683.DB.rearSpawnDelayRange.y);
							_0024spawnSide_00241670 = "rear";
						}
						_0024spawnTable_00241671 = 0;
						_0024waveSize_00241672 = 0;
						for (_0024i_00241673 = 0; _0024i_00241673 < Extensions.get_length(_0024self__00241683.DB.waveSize); _0024i_00241673++)
						{
							_0024spawnTable_00241671 = (int)((float)_0024spawnTable_00241671 + _0024self__00241683.DB.waveSize[_0024i_00241673]);
						}
						_0024self__00241683.randomRoll = UnityEngine.Random.Range(0, _0024spawnTable_00241671);
						_0024cummulativeInt_00241674 = 0;
						for (_0024i_00241673 = 0; _0024i_00241673 < Extensions.get_length(_0024self__00241683.DB.waveSize); _0024i_00241673++)
						{
							if (!((float)_0024self__00241683.randomRoll >= _0024self__00241683.DB.waveSize[_0024i_00241673] + (float)_0024cummulativeInt_00241674) && !(_0024self__00241683.DB.waveSize[_0024i_00241673] <= 0f))
							{
								_0024waveSize_00241672 = _0024i_00241673;
								_0024i_00241673 = Extensions.get_length(_0024self__00241683.DB.waveSize);
							}
							else
							{
								_0024cummulativeInt_00241674 = (int)((float)_0024cummulativeInt_00241674 + _0024self__00241683.DB.waveSize[_0024i_00241673]);
							}
						}
						_0024i_00241673 = 0;
						goto IL_0c96;
					}
					goto IL_0ca7;
				case 2:
					_0024i_00241673++;
					goto IL_0c96;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0ca7:
					YieldDefault(1);
					goto case 1;
					IL_0c96:
					if (_0024i_00241673 < _0024waveSize_00241672)
					{
						if (_0024self__00241683.activeEnemies < _0024self__00241683.DB.maxEnemyCount)
						{
							_0024spawnTable_00241671 = 0;
							_0024enemyType_00241675 = 0;
							for (_0024i2_00241676 = 0; _0024i2_00241676 < Extensions.get_length(_0024self__00241683.DB.enemyChance); _0024i2_00241676++)
							{
								_0024spawnTable_00241671 = (int)((float)_0024spawnTable_00241671 + _0024self__00241683.DB.enemyChance[_0024i2_00241676]);
							}
							_0024self__00241683.randomRoll = UnityEngine.Random.Range(0, _0024spawnTable_00241671);
							_0024cummulativeInt_00241674 = 0;
							for (_0024i2_00241676 = 0; _0024i2_00241676 < Extensions.get_length(_0024self__00241683.DB.enemyChance); _0024i2_00241676++)
							{
								if (!((float)_0024self__00241683.randomRoll >= _0024self__00241683.DB.enemyChance[_0024i2_00241676] + (float)_0024cummulativeInt_00241674))
								{
									_0024enemyType_00241675 = _0024i2_00241676;
									_0024i2_00241676 = Extensions.get_length(_0024self__00241683.DB.enemyChance);
								}
								else
								{
									_0024cummulativeInt_00241674 = (int)((float)_0024cummulativeInt_00241674 + _0024self__00241683.DB.enemyChance[_0024i2_00241676]);
								}
							}
							_0024availableZombie_00241677 = -1;
							for (_0024i2_00241676 = 0; _0024i2_00241676 < Extensions.get_length(_0024self__00241683.zombies); _0024i2_00241676++)
							{
								if ((bool)_0024self__00241683.zombies[_0024i2_00241676] && _0024self__00241683.zombies[_0024i2_00241676].availableForSpawning && _0024self__00241683.zombies[_0024i2_00241676].zombieType == (EnemyType)_0024enemyType_00241675)
								{
									_0024availableZombie_00241677 = _0024i2_00241676;
									_0024i2_00241676 = Extensions.get_length(_0024self__00241683.zombies);
								}
							}
							if (_0024availableZombie_00241677 != -1)
							{
								_0024self__00241683.activeEnemies++;
								_0024tempPosition_00241678 = 0f;
								_0024rightmostPlayer_00241679 = _0024self__00241683.playerScript.myTransform;
								_0024leftmostPlayer_00241680 = _0024self__00241683.playerScript.myTransform;
								if ((bool)_0024self__00241683.allyScript)
								{
									if (!(_0024self__00241683.allyScript.myTransform.position.x <= _0024rightmostPlayer_00241679.position.x))
									{
										_0024rightmostPlayer_00241679 = _0024self__00241683.allyScript.myTransform;
									}
									else if (!(_0024self__00241683.allyScript.myTransform.position.x >= _0024leftmostPlayer_00241680.position.x))
									{
										_0024leftmostPlayer_00241680 = _0024self__00241683.allyScript.myTransform;
									}
								}
								_0024spawnStyle_00241681 = 0;
								_0024tempSpecialSpawnChance_00241682 = _0024self__00241683.zombies[_0024availableZombie_00241677].specialSpawnChance;
								if (((bool)_0024self__00241683.playerScript && _0024self__00241683.playerScript.inVehicle) || ((bool)_0024self__00241683.allyScript && _0024self__00241683.allyScript.inVehicle))
								{
									_0024tempSpecialSpawnChance_00241682 -= 20;
								}
								if (UnityEngine.Random.Range(0, 101) < _0024tempSpecialSpawnChance_00241682)
								{
									_0024spawnStyle_00241681 = 1;
								}
								if (_0024spawnStyle_00241681 == 0)
								{
									if (_0024spawnSide_00241670 == "front")
									{
										_0024tempPosition_00241678 = _0024rightmostPlayer_00241679.position.x + _0024self__00241683.screenEdge + UnityEngine.Random.Range(1.7f, 2.6f);
										if (!(_0024tempPosition_00241678 >= _0024self__00241683.gameCamera.position.x + _0024self__00241683.screenEdge))
										{
											_0024tempPosition_00241678 = _0024self__00241683.gameCamera.position.x + _0024self__00241683.screenEdge + UnityEngine.Random.Range(0.7f, 1.5f);
										}
									}
									else if (_0024spawnSide_00241670 == "rear")
									{
										_0024tempPosition_00241678 = _0024leftmostPlayer_00241680.position.x - _0024self__00241683.screenEdge - UnityEngine.Random.Range(1.7f, 2.6f);
										if (!(_0024tempPosition_00241678 <= _0024self__00241683.gameCamera.position.x - _0024self__00241683.screenEdge))
										{
											_0024tempPosition_00241678 = _0024self__00241683.gameCamera.position.x - _0024self__00241683.screenEdge - UnityEngine.Random.Range(0.7f, 1.5f);
										}
									}
								}
								else if (_0024spawnStyle_00241681 == 1)
								{
									if (_0024spawnSide_00241670 == "front")
									{
										_0024tempPosition_00241678 = UnityEngine.Random.Range(_0024leftmostPlayer_00241680.position.x + _0024self__00241683.minimumBreathingRoom, _0024rightmostPlayer_00241679.position.x + _0024self__00241683.screenEdge);
									}
									else if (_0024spawnSide_00241670 == "rear")
									{
										_0024tempPosition_00241678 = UnityEngine.Random.Range(_0024rightmostPlayer_00241679.position.x - _0024self__00241683.minimumBreathingRoom, _0024leftmostPlayer_00241680.position.x - _0024self__00241683.screenEdge);
									}
								}
								_0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.position = new Vector3(_0024tempPosition_00241678, 0f, UnityEngine.Random.Range(_0024self__00241683.characterVerticalBounds.x, _0024self__00241683.characterVerticalBounds.y));
								_0024self__00241683.zombies[_0024availableZombie_00241677].reset();
								_0024self__00241683.zombies[_0024availableZombie_00241677].targetNearest();
								if (_0024spawnStyle_00241681 == 1)
								{
									_0024self__00241683.groundEruption(_0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.position, _0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.localScale.x);
									_0024self__00241683.StartCoroutine(_0024self__00241683.zombies[_0024availableZombie_00241677].emerge());
								}
								if (_0024self__00241683.DB.multiplayer)
								{
									if (_0024self__00241683.zombies[_0024availableZombie_00241677].myTargetScript == _0024self__00241683.playerScript)
									{
										_0024self__00241683.textMessage = _0024availableZombie_00241677 + " " + _0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.position.x + " " + _0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.position.z + " 1 " + _0024spawnStyle_00241681;
									}
									else
									{
										_0024self__00241683.textMessage = _0024availableZombie_00241677 + " " + _0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.position.x + " " + _0024self__00241683.zombies[_0024availableZombie_00241677].myTransform.position.z + " 2 " + _0024spawnStyle_00241681;
									}
									_0024self__00241683.broadcast("**MOTHERBRAIN", "spawnSync", _0024self__00241683.textMessage, true);
								}
							}
							result = (Yield(2, new WaitForSeconds(0.3f)) ? 1 : 0);
							break;
						}
						goto case 2;
					}
					goto IL_0ca7;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain _0024self__00241684;

		public _0024Spawn_00241669(MotherBrain self_)
		{
			_0024self__00241684 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241684);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024spawnPickup_00241685 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024availablePickup_00241686;

			internal int _0024i_00241687;

			internal int _0024whichValue_00241688;

			internal Vector3 _0024spawnPosition_00241689;

			internal MotherBrain _0024self__00241690;

			public _0024(int whichValue, Vector3 spawnPosition, MotherBrain self_)
			{
				_0024whichValue_00241688 = whichValue;
				_0024spawnPosition_00241689 = spawnPosition;
				_0024self__00241690 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024availablePickup_00241686 = -1;
					for (_0024i_00241687 = 0; _0024i_00241687 < Extensions.get_length(_0024self__00241690.pickups); _0024i_00241687++)
					{
						if (_0024self__00241690.pickups[_0024i_00241687].pickupValue == (PickupValue)_0024whichValue_00241688 && !_0024self__00241690.pickups[_0024i_00241687].inUse)
						{
							_0024availablePickup_00241686 = _0024i_00241687;
						}
					}
					if (_0024availablePickup_00241686 != -1)
					{
						_0024self__00241690.pickups[_0024availablePickup_00241686].inUse = true;
						_0024self__00241690.pickups[_0024availablePickup_00241686].life = 0f;
						_0024self__00241690.pickups[_0024availablePickup_00241686].tran.position = _0024spawnPosition_00241689;
						_0024self__00241690.pickups[_0024availablePickup_00241686].anim.Play("start");
						if (_0024self__00241690.DB.multiplayer)
						{
							_0024self__00241690.textMessage = _0024availablePickup_00241686 + " " + _0024spawnPosition_00241689.x + " " + _0024spawnPosition_00241689.z;
							_0024self__00241690.broadcast("**MOTHERBRAIN", "syncPickup", _0024self__00241690.textMessage, true);
						}
						result = (Yield(2, new WaitForSeconds(0.466f)) ? 1 : 0);
						break;
					}
					goto IL_01e0;
				case 2:
					_0024self__00241690.pickups[_0024availablePickup_00241686].anim.Play("loop");
					goto IL_01e0;
				case 1:
					{
						result = 0;
						break;
					}
					IL_01e0:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal int _0024whichValue_00241691;

		internal Vector3 _0024spawnPosition_00241692;

		internal MotherBrain _0024self__00241693;

		public _0024spawnPickup_00241685(int whichValue, Vector3 spawnPosition, MotherBrain self_)
		{
			_0024whichValue_00241691 = whichValue;
			_0024spawnPosition_00241692 = spawnPosition;
			_0024self__00241693 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichValue_00241691, _0024spawnPosition_00241692, _0024self__00241693);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024tutorialCompleteSequence_00241694 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MotherBrain _0024self__00241695;

			public _0024(MotherBrain self_)
			{
				_0024self__00241695 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(1.1f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241695.killCameraAnimation = true;
					_0024self__00241695.helicopterDepart = true;
					result = (Yield(3, new WaitForSeconds(1.4f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241695.fade = true;
					result = (Yield(4, new WaitForSeconds(1.2f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241695.DB.levelToLoad = "mainMenu";
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

		internal MotherBrain _0024self__00241696;

		public _0024tutorialCompleteSequence_00241694(MotherBrain self_)
		{
			_0024self__00241696 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241696);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024levelCompleteSequence_00241697 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024skillBonus_00241698;

			internal int _0024sendScore_00241699;

			internal int _0024cashEarned_00241700;

			internal float _0024_0024850_00241701;

			internal Vector3 _0024_0024851_00241702;

			internal float _0024_0024852_00241703;

			internal Vector3 _0024_0024853_00241704;

			internal float _0024_0024854_00241705;

			internal Vector3 _0024_0024855_00241706;

			internal float _0024_0024856_00241707;

			internal Vector3 _0024_0024857_00241708;

			internal float _0024_0024858_00241709;

			internal Vector3 _0024_0024859_00241710;

			internal float _0024_0024860_00241711;

			internal Vector3 _0024_0024861_00241712;

			internal float _0024_0024862_00241713;

			internal Vector3 _0024_0024863_00241714;

			internal float _0024_0024864_00241715;

			internal Vector3 _0024_0024865_00241716;

			internal float _0024_0024866_00241717;

			internal Vector3 _0024_0024867_00241718;

			internal float _0024_0024868_00241719;

			internal Vector3 _0024_0024869_00241720;

			internal float _0024_0024870_00241721;

			internal Vector3 _0024_0024871_00241722;

			internal float _0024_0024872_00241723;

			internal Vector3 _0024_0024873_00241724;

			internal float _0024_0024874_00241725;

			internal Vector3 _0024_0024875_00241726;

			internal MotherBrain _0024self__00241727;

			public _0024(MotherBrain self_)
			{
				_0024self__00241727 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241727.levelComplete = true;
					_0024self__00241727.fadeMusic = true;
					_0024skillBonus_00241698 = 0;
					if (_0024self__00241727.shotsFired != 0)
					{
						_0024skillBonus_00241698 = (int)((float)_0024skillBonus_00241698 + UnityBuiltins.parseFloat(_0024self__00241727.hits) / UnityBuiltins.parseFloat(_0024self__00241727.shotsFired) * 0.15f * (float)_0024self__00241727.score);
					}
					if (!(_0024self__00241727.playerScript.health <= 0f))
					{
						_0024skillBonus_00241698 = (int)((float)_0024skillBonus_00241698 + (UnityBuiltins.parseFloat(_0024self__00241727.playerScript.health) / UnityBuiltins.parseFloat(_0024self__00241727.playerScript.maxHealth) * 0.1f + 0.05f) * (float)_0024self__00241727.score);
					}
					_0024skillBonus_00241698 = (int)((float)_0024skillBonus_00241698 + Mathf.Round(_0024self__00241727.horizontalProgress * 0.3f * 10f) / 10f * (float)_0024self__00241727.DB.difficulty);
					if (!(_0024self__00241727.playerScript.health > 0f))
					{
						_0024skillBonus_00241698 = 0;
					}
					_0024self__00241727.stats[5].targetNumber = _0024skillBonus_00241698;
					if (_0024self__00241727.DB.multiplayer)
					{
						_0024sendScore_00241699 = _0024self__00241727.score + _0024skillBonus_00241698;
						_0024self__00241727.broadcast("**MOTHERBRAIN", "learnAllyScore", _0024sendScore_00241699.ToString(), true);
					}
					result = (Yield(2, new WaitForSeconds(1.1f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241727.DB.achievements[28].counter == 0f && !(_0024self__00241727.playerScript.health <= 0f))
					{
						if (_0024self__00241727.playerScript.singleMinded[0] && !_0024self__00241727.playerScript.singleMinded[1] && !_0024self__00241727.playerScript.singleMinded[2])
						{
							_0024self__00241727.DB.achievements[28].counter = 1f;
							_0024self__00241727.DB.announceAchievement(28);
						}
						else if (!_0024self__00241727.playerScript.singleMinded[0] && _0024self__00241727.playerScript.singleMinded[1] && !_0024self__00241727.playerScript.singleMinded[2])
						{
							_0024self__00241727.DB.achievements[28].counter = 1f;
							_0024self__00241727.DB.announceAchievement(28);
						}
						else if (!_0024self__00241727.playerScript.singleMinded[0] && !_0024self__00241727.playerScript.singleMinded[1] && _0024self__00241727.playerScript.singleMinded[2])
						{
							_0024self__00241727.DB.achievements[28].counter = 1f;
							_0024self__00241727.DB.announceAchievement(28);
						}
					}
					_0024self__00241727.killCameraAnimation = true;
					_0024self__00241727.helicopterDepart = true;
					result = (Yield(3, new WaitForSeconds(1.4f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241727.freezeZombies();
					_0024self__00241727.freezeGame = true;
					if (_0024self__00241727.DB.multiplayer && !(_0024self__00241727.playerScript.health <= 0f))
					{
						_0024self__00241727.levelCompleteRenderers[2].enabled = true;
						_0024self__00241727.levelCompleteRenderers[3].enabled = true;
						_0024self__00241727.levelCompleteTopText.text = "Mission Complete!";
					}
					else if (_0024self__00241727.DB.multiplayer && !(_0024self__00241727.playerScript.health > 0f))
					{
						_0024self__00241727.levelCompleteRenderers[6].enabled = true;
						_0024self__00241727.levelCompleteRenderers[7].enabled = true;
						_0024self__00241727.levelCompleteTopText.text = "Zombie Chow!";
					}
					else if (!_0024self__00241727.DB.multiplayer && !(_0024self__00241727.playerScript.health <= 0f))
					{
						_0024self__00241727.levelCompleteRenderers[0].enabled = true;
						_0024self__00241727.levelCompleteRenderers[1].enabled = true;
						_0024self__00241727.levelCompleteTopText.text = "Mission Complete!";
					}
					else if (!_0024self__00241727.DB.multiplayer && !(_0024self__00241727.playerScript.health > 0f))
					{
						_0024self__00241727.levelCompleteRenderers[4].enabled = true;
						_0024self__00241727.levelCompleteRenderers[5].enabled = true;
						_0024self__00241727.levelCompleteTopText.text = "Zombie Chow!";
					}
					_0024self__00241727.showLevelComplete = true;
					if (_0024self__00241727.DB.musicEnabled)
					{
						_0024self__00241727.fadeMusic = false;
						if (!(_0024self__00241727.playerScript.health <= 0f))
						{
							_0024self__00241727.BGmusic.clip = (AudioClip)Resources.Load("Music/levelClear");
						}
						else
						{
							_0024self__00241727.BGmusic.clip = (AudioClip)Resources.Load("Music/dead");
						}
						_0024self__00241727.BGmusic.volume = 1f;
						_0024self__00241727.BGmusic.Play();
						_0024self__00241727.BGmusic.loop = false;
					}
					result = (Yield(4, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 4:
					_0024self__00241727.stats[0].slide = true;
					result = (Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 5:
				{
					_0024self__00241727.stats[0].textMesh.text = _0024self__00241727.kills.ToString();
					float num23 = (_0024_0024850_00241701 = 0.1f);
					Vector3 vector34 = (_0024_0024851_00241702 = _0024self__00241727.stats[0].rightSide.localScale);
					float num24 = (_0024_0024851_00241702.y = _0024_0024850_00241701);
					Vector3 vector36 = (_0024self__00241727.stats[0].rightSide.localScale = _0024_0024851_00241702);
					_0024self__00241727.stats[0].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(6, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 6:
					_0024self__00241727.stats[1].slide = true;
					result = (Yield(7, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 7:
				{
					_0024self__00241727.stats[1].textMesh.text = _0024self__00241727.score.ToString();
					float num19 = (_0024_0024852_00241703 = 0.1f);
					Vector3 vector28 = (_0024_0024853_00241704 = _0024self__00241727.stats[1].rightSide.localScale);
					float num20 = (_0024_0024853_00241704.y = _0024_0024852_00241703);
					Vector3 vector30 = (_0024self__00241727.stats[1].rightSide.localScale = _0024_0024853_00241704);
					_0024self__00241727.stats[1].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(8, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 8:
					_0024self__00241727.stats[2].slide = true;
					result = (Yield(9, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 9:
				{
					if (_0024self__00241727.shotsFired != 0)
					{
						_0024self__00241727.stats[2].textMesh.text = Mathf.RoundToInt(UnityBuiltins.parseFloat(_0024self__00241727.hits) / UnityBuiltins.parseFloat(_0024self__00241727.shotsFired) * 100f).ToString() + "%";
					}
					else
					{
						_0024self__00241727.stats[2].textMesh.text = "0%";
					}
					float num13 = (_0024_0024854_00241705 = 0.1f);
					Vector3 vector19 = (_0024_0024855_00241706 = _0024self__00241727.stats[2].rightSide.localScale);
					float num14 = (_0024_0024855_00241706.y = _0024_0024854_00241705);
					Vector3 vector21 = (_0024self__00241727.stats[2].rightSide.localScale = _0024_0024855_00241706);
					_0024self__00241727.stats[2].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(10, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 10:
					_0024self__00241727.stats[3].slide = true;
					result = (Yield(11, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 11:
				{
					_0024self__00241727.stats[3].textMesh.text = Mathf.RoundToInt(UnityBuiltins.parseFloat(_0024self__00241727.playerScript.health) / UnityBuiltins.parseFloat(_0024self__00241727.playerScript.maxHealth) * 100f).ToString() + "%";
					float num21 = (_0024_0024856_00241707 = 0.1f);
					Vector3 vector31 = (_0024_0024857_00241708 = _0024self__00241727.stats[3].rightSide.localScale);
					float num22 = (_0024_0024857_00241708.y = _0024_0024856_00241707);
					Vector3 vector33 = (_0024self__00241727.stats[3].rightSide.localScale = _0024_0024857_00241708);
					_0024self__00241727.stats[3].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(12, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 12:
					_0024self__00241727.stats[4].slide = true;
					result = (Yield(13, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 13:
				{
					_0024self__00241727.stats[4].textMesh.text = (Mathf.Round(_0024self__00241727.horizontalProgress * 3f * 10f) / 10f).ToString() + " ft.";
					float num25 = (_0024_0024858_00241709 = 0.1f);
					Vector3 vector37 = (_0024_0024859_00241710 = _0024self__00241727.stats[4].rightSide.localScale);
					float num26 = (_0024_0024859_00241710.y = _0024_0024858_00241709);
					Vector3 vector39 = (_0024self__00241727.stats[4].rightSide.localScale = _0024_0024859_00241710);
					_0024self__00241727.stats[4].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(14, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 14:
					_0024self__00241727.stats[5].slide = true;
					result = (Yield(15, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 15:
					if (!_0024self__00241727.DB.multiplayer)
					{
						_0024self__00241727.stats[6].slide = true;
					}
					else
					{
						_0024self__00241727.stats[7].slide = true;
					}
					result = (Yield(16, new WaitForSeconds(0.25f)) ? 1 : 0);
					break;
				case 16:
				{
					_0024self__00241727.stats[5].count = true;
					if (_0024skillBonus_00241698 != 0)
					{
						_0024self__00241727.sounds[8].Play();
					}
					float num17 = (_0024_0024860_00241711 = 0.1f);
					Vector3 vector25 = (_0024_0024861_00241712 = _0024self__00241727.stats[5].rightSide.localScale);
					float num18 = (_0024_0024861_00241712.y = _0024_0024860_00241711);
					Vector3 vector27 = (_0024self__00241727.stats[5].rightSide.localScale = _0024_0024861_00241712);
					_0024self__00241727.stats[5].scale = true;
					result = (((_0024skillBonus_00241698 == 0) ? Yield(18, new WaitForSeconds(0.4f)) : Yield(17, new WaitForSeconds(2f))) ? 1 : 0);
					break;
				}
				case 17:
				case 18:
				{
					_0024self__00241727.stats[6].scale = true;
					_0024self__00241727.sounds[7].Play();
					float num15 = (_0024_0024862_00241713 = 0.1f);
					Vector3 vector22 = (_0024_0024863_00241714 = _0024self__00241727.stats[6].rightSide.localScale);
					float num16 = (_0024_0024863_00241714.y = _0024_0024862_00241713);
					Vector3 vector24 = (_0024self__00241727.stats[6].rightSide.localScale = _0024_0024863_00241714);
					_0024self__00241727.score += _0024skillBonus_00241698;
					_0024self__00241727.stats[6].textMesh.text = _0024self__00241727.score.ToString();
					result = (Yield(19, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 19:
					_0024cashEarned_00241700 = Mathf.RoundToInt(_0024self__00241727.cashThisRound * 7f * (UnityBuiltins.parseFloat(_0024self__00241727.DB.difficulty) + 2f) * 0.33f * UnityEngine.Random.Range(0.95f, 1.05f));
					if (_0024self__00241727.playerScript.perks[0] == 17 || _0024self__00241727.playerScript.perks[1] == 17 || _0024self__00241727.playerScript.perks[2] == 17)
					{
						_0024cashEarned_00241700 += Mathf.RoundToInt((float)_0024cashEarned_00241700 * (_0024self__00241727.DB.perks[17].rankBonuses[(int)_0024self__00241727.DB.perks[17].rank] * 0.01f));
					}
					if (_0024self__00241727.DB.multiplayer)
					{
						_0024cashEarned_00241700 *= 2;
					}
					_0024self__00241727.DB.money = _0024self__00241727.DB.money + _0024cashEarned_00241700;
					_0024self__00241727.DB.moneyInfo = _0024self__00241727.DB.money;
					if (!_0024self__00241727.DB.multiplayer)
					{
						_0024self__00241727.stats[8].slide = true;
						result = (Yield(20, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					else
					{
						_0024self__00241727.stats[9].slide = true;
						result = (Yield(21, new WaitForSeconds(0.3f)) ? 1 : 0);
					}
					break;
				case 20:
				{
					_0024self__00241727.stats[8].textMesh.text = "$" + _0024cashEarned_00241700.ToString();
					float num7 = (_0024_0024864_00241715 = 0.1f);
					Vector3 vector10 = (_0024_0024865_00241716 = _0024self__00241727.stats[8].rightSide.localScale);
					float num8 = (_0024_0024865_00241716.y = _0024_0024864_00241715);
					Vector3 vector12 = (_0024self__00241727.stats[8].rightSide.localScale = _0024_0024865_00241716);
					_0024self__00241727.stats[8].scale = true;
					_0024self__00241727.sounds[6].Play();
					goto IL_1410;
				}
				case 21:
				{
					_0024self__00241727.stats[9].textMesh.text = _0024self__00241727.allyScore.ToString();
					float num5 = (_0024_0024866_00241717 = 0.1f);
					Vector3 vector7 = (_0024_0024867_00241718 = _0024self__00241727.stats[9].rightSide.localScale);
					float num6 = (_0024_0024867_00241718.y = _0024_0024866_00241717);
					Vector3 vector9 = (_0024self__00241727.stats[9].rightSide.localScale = _0024_0024867_00241718);
					_0024self__00241727.stats[9].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(22, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 22:
					_0024self__00241727.stats[10].slide = true;
					result = (Yield(23, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 23:
				{
					_0024self__00241727.stats[10].textMesh.text = (_0024self__00241727.score + _0024self__00241727.allyScore).ToString();
					float num3 = (_0024_0024868_00241719 = 0.1f);
					Vector3 vector4 = (_0024_0024869_00241720 = _0024self__00241727.stats[10].rightSide.localScale);
					float num4 = (_0024_0024869_00241720.y = _0024_0024868_00241719);
					Vector3 vector6 = (_0024self__00241727.stats[10].rightSide.localScale = _0024_0024869_00241720);
					_0024self__00241727.stats[10].scale = true;
					_0024self__00241727.sounds[7].Play();
					result = (Yield(24, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				}
				case 24:
					_0024self__00241727.stats[11].slide = true;
					result = (Yield(25, new WaitForSeconds(0.3f)) ? 1 : 0);
					break;
				case 25:
				{
					_0024self__00241727.stats[11].textMesh.text = "$" + _0024cashEarned_00241700.ToString();
					float num = (_0024_0024870_00241721 = 0.1f);
					Vector3 vector = (_0024_0024871_00241722 = _0024self__00241727.stats[11].rightSide.localScale);
					float num2 = (_0024_0024871_00241722.y = _0024_0024870_00241721);
					Vector3 vector3 = (_0024self__00241727.stats[11].rightSide.localScale = _0024_0024871_00241722);
					_0024self__00241727.stats[11].scale = true;
					_0024self__00241727.sounds[6].Play();
					goto IL_1410;
				}
				case 1:
					{
						result = 0;
						break;
					}
					IL_1410:
					if (!(_0024self__00241727.playerScript.health < _0024self__00241727.playerScript.maxHealth) && _0024self__00241727.DB.difficulty >= 5 && _0024self__00241727.DB.achievements[23].counter != 1f)
					{
						_0024self__00241727.DB.achievements[23].counter = 1f;
						_0024self__00241727.DB.announceAchievement(23);
					}
					if (_0024self__00241727.timeRemaining == 999f)
					{
						if (!_0024self__00241727.DB.multiplayer)
						{
							_0024self__00241727.leaderBoardPosters[3].text = _0024self__00241727.score.ToString();
						}
						else if (_0024self__00241727.DB.multiplayer)
						{
							_0024self__00241727.leaderBoardPosters[4].text = (_0024self__00241727.score + _0024self__00241727.allyScore).ToString();
						}
					}
					else if (!_0024self__00241727.DB.multiplayer)
					{
						_0024self__00241727.leaderBoardPosters[1].text = _0024self__00241727.score.ToString();
					}
					else if (_0024self__00241727.DB.multiplayer)
					{
						_0024self__00241727.leaderBoardPosters[2].text = (_0024self__00241727.score + _0024self__00241727.allyScore).ToString();
					}
					_0024self__00241727.leaderBoardPosters[0].text = _0024self__00241727.DB.totalKills.ToString();
					if (_0024self__00241727.DB.multiplayer)
					{
						float num9 = (_0024_0024874_00241725 = -2.676611f);
						Vector3 vector13 = (_0024_0024875_00241726 = _0024self__00241727.tapToContinue.localPosition);
						float num10 = (_0024_0024875_00241726.y = _0024_0024874_00241725);
						Vector3 vector15 = (_0024self__00241727.tapToContinue.localPosition = _0024_0024875_00241726);
					}
					else
					{
						float num11 = (_0024_0024872_00241723 = -1.978041f);
						Vector3 vector16 = (_0024_0024873_00241724 = _0024self__00241727.tapToContinue.localPosition);
						float num12 = (_0024_0024873_00241724.y = _0024_0024872_00241723);
						Vector3 vector18 = (_0024self__00241727.tapToContinue.localPosition = _0024_0024873_00241724);
					}
					_0024self__00241727.DB.save();
					PlayerPrefs.Save();
					_0024self__00241727.waitingToExit = true;
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain _0024self__00241728;

		public _0024levelCompleteSequence_00241697(MotherBrain self_)
		{
			_0024self__00241728 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241728);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024goBackToMainMenu_00241729 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MotherBrain _0024self__00241730;

			public _0024(MotherBrain self_)
			{
				_0024self__00241730 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241730.DB.levelToLoad = "mainMenu";
					result = (Yield(2, new WaitForSeconds(1.1f)) ? 1 : 0);
					break;
				case 2:
					Time.timeScale = 1f;
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

		internal MotherBrain _0024self__00241731;

		public _0024goBackToMainMenu_00241729(MotherBrain self_)
		{
			_0024self__00241731 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241731);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024tutorialSequence_00241732 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024916_00241733;

			internal Vector3 _0024_0024917_00241734;

			internal MotherBrain _0024self__00241735;

			public _0024(MotherBrain self_)
			{
				_0024self__00241735 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241735.tutorialTimer != -100f)
					{
						_0024self__00241735.tutorialTimer += Time.deltaTime;
					}
					if (_0024self__00241735.currentBubble == 0 && !(_0024self__00241735.tutorialTimer < 1.3f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
						break;
					}
					goto IL_00f1;
				case 2:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					goto IL_00f1;
				case 3:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					goto IL_0185;
				case 4:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					if ((bool)_0024self__00241735.zombies[30] && !_0024self__00241735.zombies[30].enabled)
					{
						_0024self__00241735.zombies[30].reset();
						_0024self__00241735.zombies[30].myTransform.position = new Vector3(1.5f, 0f, 0.4f);
					}
					_0024self__00241735.tutorialTimer = 0f;
					goto IL_0292;
				case 5:
					_0024self__00241735.showBubble(-1);
					result = (Yield(6, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 6:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					goto IL_0350;
				case 7:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					goto IL_03e1;
				case 8:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					_0024self__00241735.activeEnemies++;
					_0024self__00241735.zombies[0].myTransform.position = new Vector3(1.7f, 0f, 0.5f);
					_0024self__00241735.zombies[0].reset();
					_0024self__00241735.zombies[0].targetNearest();
					_0024self__00241735.groundEruption(_0024self__00241735.zombies[0].myTransform.position, _0024self__00241735.zombies[0].myTransform.localScale.x);
					_0024self__00241735.StartCoroutine(_0024self__00241735.zombies[0].emerge());
					goto IL_0535;
				case 9:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					goto IL_060f;
				case 10:
				{
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					_0024self__00241735.timeRemaining = 11f;
					float num = (_0024_0024916_00241733 = _0024self__00241735.clockPosition.localPosition.y - 3f);
					Vector3 vector = (_0024_0024917_00241734 = _0024self__00241735.clockPosition.localPosition);
					float num2 = (_0024_0024917_00241734.y = _0024_0024916_00241733);
					Vector3 vector3 = (_0024self__00241735.clockPosition.localPosition = _0024_0024917_00241734);
					goto IL_0723;
				}
				case 11:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					goto IL_07b5;
				case 12:
					_0024self__00241735.currentBubble++;
					_0024self__00241735.showBubble(_0024self__00241735.currentBubble);
					_0024self__00241735.tutorialTimer = 0f;
					goto IL_0848;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0848:
					YieldDefault(1);
					goto case 1;
					IL_03e1:
					if (_0024self__00241735.currentBubble == 5 && !(_0024self__00241735.tutorialTimer < 5.5f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(8, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0535;
					IL_0185:
					if (_0024self__00241735.currentBubble == 2 && _0024self__00241735.fireButtonsTouched && !(_0024self__00241735.tutorialTimer <= 2.5f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(4, new WaitForSeconds(0.6f)) ? 1 : 0);
						break;
					}
					goto IL_0292;
					IL_0292:
					if (_0024self__00241735.currentBubble == 3 && _0024self__00241735.zombies[30].health <= 0 && _0024self__00241735.tutorialTimer != -100f)
					{
						_0024self__00241735.tutorialTimer = -100f;
						result = (Yield(5, new WaitForSeconds(0.3f)) ? 1 : 0);
						break;
					}
					goto IL_0350;
					IL_07b5:
					if (_0024self__00241735.currentBubble == 9 && !(_0024self__00241735.tutorialTimer < 6f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(12, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0848;
					IL_0723:
					if (_0024self__00241735.currentBubble == 8 && !(_0024self__00241735.tutorialTimer < 4.5f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(11, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_07b5;
					IL_0535:
					if (_0024self__00241735.currentBubble == 6 && !(_0024self__00241735.tutorialTimer < 3.5f))
					{
						_0024self__00241735.showBubble(-1);
					}
					if (_0024self__00241735.currentBubble == 6 && _0024self__00241735.zombies[0].health <= 0 && _0024self__00241735.tutorialTimer != -100f)
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(9, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_060f;
					IL_00f1:
					if (_0024self__00241735.currentBubble == 1 && _0024self__00241735.joyStickTouched && !(_0024self__00241735.tutorialTimer <= 2f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
						break;
					}
					goto IL_0185;
					IL_060f:
					if (_0024self__00241735.currentBubble == 7 && !(_0024self__00241735.tutorialTimer < 4f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(10, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_0723;
					IL_0350:
					if (_0024self__00241735.currentBubble == 4 && !(_0024self__00241735.tutorialTimer < 4f))
					{
						_0024self__00241735.tutorialTimer = -100f;
						_0024self__00241735.showBubble(-1);
						result = (Yield(7, new WaitForSeconds(0.5f)) ? 1 : 0);
						break;
					}
					goto IL_03e1;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain _0024self__00241736;

		public _0024tutorialSequence_00241732(MotherBrain self_)
		{
			_0024self__00241736 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241736);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024showAchievementBubble_00241737 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_0024918_00241738;

			internal Vector3 _0024_0024919_00241739;

			internal int _0024_0024920_00241740;

			internal Vector3 _0024_0024921_00241741;

			internal int _0024whichAchievement_00241742;

			internal MotherBrain _0024self__00241743;

			public _0024(int whichAchievement, MotherBrain self_)
			{
				_0024whichAchievement_00241742 = whichAchievement;
				_0024self__00241743 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00241743.pickupSound.Play();
					_0024self__00241743.achievementBubbleText.text = _0024self__00241743.DB.achievements[_0024whichAchievement_00241742].achievementName;
					float num3 = (_0024_0024918_00241738 = 1.7f);
					Vector3 vector4 = (_0024_0024919_00241739 = _0024self__00241743.achievementBubbleTransform.localPosition);
					float num4 = (_0024_0024919_00241739.y = _0024_0024918_00241738);
					Vector3 vector6 = (_0024self__00241743.achievementBubbleTransform.localPosition = _0024_0024919_00241739);
					_0024self__00241743.achievementBubbleAnimation.Stop();
					_0024self__00241743.achievementBubbleAnimation.Play();
					result = (Yield(2, new WaitForSeconds(3.5f)) ? 1 : 0);
					break;
				}
				case 2:
				{
					int num = (_0024_0024920_00241740 = 100);
					Vector3 vector = (_0024_0024921_00241741 = _0024self__00241743.achievementBubbleTransform.localPosition);
					float num2 = (_0024_0024921_00241741.y = _0024_0024920_00241740);
					Vector3 vector3 = (_0024self__00241743.achievementBubbleTransform.localPosition = _0024_0024921_00241741);
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

		internal int _0024whichAchievement_00241744;

		internal MotherBrain _0024self__00241745;

		public _0024showAchievementBubble_00241737(int whichAchievement, MotherBrain self_)
		{
			_0024whichAchievement_00241744 = whichAchievement;
			_0024self__00241745 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichAchievement_00241744, _0024self__00241745);
		}
	}

	public TextMesh[] leaderBoardPosters;

	public bool zombiesOff;

	public Transform disconnector;

	public MessageSlot[] messageSlots;

	public Transform readyMarker1;

	public Transform readyMarker2;

	public Database DB;

	public vehicle[] vehicles;

	public AudioSource BGmusic;

	public string[] musicCollection;

	public bool introSequence;

	public float timeRemaining;

	public Transform joystickHelper;

	public Transform joystickLerp;

	public Transform joystickRotator;

	public Renderer[] buttonLights;

	public bool newMultiplayer;

	public float cashThisRound;

	public int score;

	public int multiplier;

	public int shotsFired;

	public int hits;

	public int kills;

	public TextMesh[] messages;

	public AudioSource[] sounds;

	public ZombieScript[] zombies;

	public float stateSyncDelay;

	public PlayerScript playerScript;

	public PlayerScript allyScript;

	public Transform gameCamera;

	public Camera cameraLens;

	public Animation cameraShaker;

	public Renderer fader;

	public bool fade;

	public LayerMask zombieMask;

	private GameObject tempGO;

	private bool holdThePhone;

	private float tempTimer;

	public Vector2 cameraVerticalBounds;

	public Vector2 cameraHorizontalBounds;

	public Vector2 characterVerticalBounds;

	public Vector2 characterHorizontalBounds;

	private bool environmentExists;

	public AudioSource[] emergeSounds;

	public int emergeSound;

	public AudioSource pickupSound;

	public float horizontalProgress;

	public Transform runForIt;

	public Animation runForItAnim;

	public Spit[] spitReferences;

	public EffectMachine[] selfDestructExplosions;

	public EffectMachine[] vehicleExplosions;

	public int whichVehicleExplosion;

	private float singlePlayerStartupDelay;

	private bool zombiesLoaded;

	private bool destructiblesLoaded;

	private bool initializedZombies;

	private int spitToTransfer;

	private int explosionToTransfer;

	private float despawnCheckTimer;

	private bool player2RecievedEnvironment;

	public TextMesh debugText;

	public int currentBubble;

	private float zombieSyncDelay;

	public Transform allyTransform;

	public Transform arrowTransform;

	public Animation arrowAnimation;

	public Transform arrowSubTransform;

	public float watchOtherPlayer;

	public float distanceTraveled;

	public bool killCameraAnimation;

	private float slightWait;

	public Transform HUDroot;

	public Transform joystickCenter;

	public GameObject joystickGO;

	public GameObject fire1GO;

	public GameObject fire2GO;

	public GameObject fire3GO;

	public Transform bottomLeftCorner;

	public Transform bottomRightCorner;

	public Transform topLeftCorner;

	public Transform topRightCorner;

	public Transform clockPosition;

	public GameObject clockGO;

	private Vector3 HUDtargetScale;

	public Transform partnerDisconnect;

	public BasicEffect[] dirt;

	private int nextDirt;

	private int nextBasicShell;

	public particle[] basicShells;

	private int nextShottyShell;

	public particle[] shottyShells;

	private int nextSniperShell;

	public particle[] sniperShells;

	private int nextBlood;

	public particle[] blood;

	private int nextMeat;

	public particle[] meat;

	private int nextBone;

	public particle[] bone;

	private int nextTooth;

	public particle[] teeth;

	private int nextEyeball;

	public particle[] eyes;

	private int nextAsh;

	public particle[] ashes;

	private int nextPin;

	public particle[] pins;

	private int nextIceBig;

	public particle[] iceBig;

	private int nextIceSmall;

	public particle[] iceSmall;

	private int nextPebble;

	public particle[] pebbles;

	private int nextGlass;

	public particle[] glass;

	public particleGroup[] envParticles;

	private float gravityConstant;

	public Transform rotationHelper;

	public float spawnDelay;

	public float rearSpawnDelay;

	public int activeEnemies;

	public int maxEnemies;

	public int nextZombie;

	private string textMessage;

	private int randomRoll;

	private float minimumBreathingRoom;

	public Transform explodedHead;

	public Transform explodedHeadAlly;

	private Transform[] groundPieces;

	private float basicFloorSize;

	private Transform[] FGPieces;

	private float FGSize;

	private Transform[] SkylinePieces;

	private float SkylineSize;

	private Transform[] cloudPieces;

	private float cloudSize;

	private Transform backdrop;

	private Transform tempTransform;

	private float buildingSpawnPosition;

	private float clutterSpawnPosition;

	private float destructibleSpawnPosition;

	public Transform edgeFinder;

	private float screenEdge;

	public int previousRoll;

	public int alleyRoll;

	public string buildingMessage;

	public string alleyMessage;

	public string clutterMessage;

	public string destructibleMessage;

	public GameObject getReady;

	public Animation getReadyAnim;

	public Transform redButton;

	public Transform greenButton;

	public Transform yellowButton;

	public Transform[] multDigits1;

	public Transform[] multDigits2;

	private int displayedMultiplier;

	public Transform multiplierRoot;

	public float multiplierTimer;

	public float multiplierTimerDefault;

	private float multiplierFlashThreshold;

	private float multiplierFlash;

	public Transform multiplierWindow;

	public Transform[] tumblers;

	public int[] tumblerDigits;

	public Transform redWeaponBG;

	public Digit[] ammoDigits1;

	public Digit[] ammoDigits2;

	public Digit[] ammoDigits3;

	public Digit[] greenDigits1;

	public Digit[] greenDigits2;

	public Digit[] greenDigits3;

	public int activeAmmoDisplay;

	public Transform[] ammoDisplays;

	public Transform weaponIconSlot;

	public Transform healthMask;

	public Transform healthLight;

	public Transform[] clockDigits1;

	public Transform[] clockDigits2;

	public Transform[] clockDigits3;

	public Transform clockColon;

	public Transform clockLight;

	private float colonBlink;

	private int displayedTime;

	public float lifeBarFlash;

	private float lifeBarFlashTimer;

	private float clockFlash;

	private float introTimer;

	public Renderer GOrenderer;

	public Animation GOanimation;

	public Renderer introDarkener;

	public Pickup[] pickups;

	public float pickupCollectionPulse;

	public bool helicopterActive;

	public bool helicopterDepart;

	public Renderer windRenderer1;

	public Renderer windRenderer2;

	public Transform windOpacity1;

	public Transform windOpacity2;

	public Animation windAnimation1;

	public Animation windAnimation2;

	public Transform helicopterTransform;

	public Transform helicopterGroup;

	public Renderer heliShadow;

	public float worldEnd;

	public Transform heliAttachPoint;

	private float hideRunForIt;

	public bool levelComplete;

	public Renderer[] levelCompleteRenderers;

	public bool showLevelComplete;

	public Transform levelCompletePage;

	public Transform levelCompleteBG;

	public bool freezeGame;

	public statLine[] stats;

	public int allyScore;

	public TextMesh levelCompleteTopText;

	public bool fadeMusic;

	private bool waitingToExit;

	public Transform tapToContinue;

	public float musicTime;

	public bool pausedMidCoop;

	public Transform pauseScreenTran;

	public LayerMask pauseScreenMask;

	public tutorialBubble[] bubbles;

	public Transform bubbleBoneTR;

	public Transform bubbleBoneT;

	public Transform bubbleBoneBR;

	public Transform bubbleBoneB;

	public Transform bubbleBoneBL;

	public TextMesh tutorialTextMesh;

	public Animation bubbleAnimation;

	public Transform bubbleTransform;

	public Renderer[] bubbleRenderers;

	public BoxCollider bubbleCollider;

	public float tutorialTimer;

	public bool joyStickTouched;

	public bool fireButtonsTouched;

	public int endlessModeKills;

	public TextMesh achievementBubbleText;

	public Transform achievementBubbleTransform;

	public Animation achievementBubbleAnimation;

	public MotherBrain()
	{
		introSequence = true;
		timeRemaining = 180f;
		multiplier = 1;
		stateSyncDelay = 0.1f;
		tempTimer = 0.1f;
		despawnCheckTimer = 0.5f;
		currentBubble = -1;
		zombieSyncDelay = 1f;
		watchOtherPlayer = 1.5f;
		slightWait = 1f;
		HUDtargetScale = new Vector3(1.2f, 1.2f, 1.2f);
		gravityConstant = 40f;
		spawnDelay = 10f;
		rearSpawnDelay = 13f;
		maxEnemies = 5;
		minimumBreathingRoom = 1.5f;
		buildingSpawnPosition = -10f;
		clutterSpawnPosition = -10f;
		destructibleSpawnPosition = 3f;
		previousRoll = -1;
		alleyRoll = -1;
		buildingMessage = string.Empty;
		alleyMessage = string.Empty;
		clutterMessage = string.Empty;
		destructibleMessage = string.Empty;
		displayedMultiplier = 1;
		multiplierTimerDefault = 2f;
		multiplierFlashThreshold = 1.5f;
		multiplierFlash = 0.05f;
		activeAmmoDisplay = -1;
		colonBlink = 0.23f;
		lifeBarFlashTimer = 0.1f;
		clockFlash = 0.1f;
		introTimer = 3.65f;
		pickupCollectionPulse = 0.15f;
		worldEnd = 100000f;
	}

	public virtual void Awake()
	{
		int num = 100;
		Vector3 localPosition = bubbleTransform.localPosition;
		float num2 = (localPosition.y = num);
		Vector3 vector2 = (bubbleTransform.localPosition = localPosition);
		if (screenEdge == 0f)
		{
			while (cameraLens.WorldToViewportPoint(edgeFinder.position).x > 0f)
			{
				float x = edgeFinder.position.x - Time.deltaTime;
				Vector3 position = edgeFinder.position;
				float num3 = (position.x = x);
				Vector3 vector4 = (edgeFinder.position = position);
			}
			screenEdge = 0f - edgeFinder.position.x;
		}
		float num4 = Screen.height;
		float num5 = Screen.width;
		if (num4 / num5 == 0.75f)
		{
			arrowAnimation.Play("ipadArrow");
		}
		if ((Screen.height == 768 && Screen.width == 1024) || (Screen.height == 1536 && Screen.width == 2048))
		{
			arrowAnimation.Play("ipadArrow");
		}
		if (num4 / num5 == 0.5625f)
		{
			arrowAnimation.Play("wideArrow");
		}
		if ((Screen.height == 640 && Screen.width == 1136) || (Screen.height == 750 && Screen.width == 1334) || (Screen.height == 1080 && Screen.width == 1920))
		{
			arrowAnimation.Play("wideArrow");
		}
		if ((bool)GameObject.Find("**DATABASE"))
		{
			DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
		}
		else
		{
			DB = (Database)GameObject.Find("**DATABASE_Sandbox").GetComponent(typeof(Database));
		}
		DB.achievements[13].counter = 0f;
		if (DB.multiplayer)
		{
			holdThePhone = true;
			if (DB.whichPlayerAmI == 1)
			{
				int num6 = 1;
				Vector3 position2 = readyMarker1.position;
				float num7 = (position2.x = num6);
				Vector3 vector6 = (readyMarker1.position = position2);
			}
			else
			{
				int num8 = 1;
				Vector3 position3 = readyMarker2.position;
				float num9 = (position3.x = num8);
				Vector3 vector8 = (readyMarker2.position = position3);
			}
		}
		else
		{
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.PCs[DB.myPC].characterModel));
			playerScript = (PlayerScript)tempGO.GetComponent(typeof(PlayerScript));
			playerScript.Initialize();
			createEnvironment();
			singlePlayerStartupDelay = 0.5f;
		}
		if (DB.musicEnabled)
		{
			BGmusic.clip = (AudioClip)Resources.Load(DB.musicTrack);
			BGmusic.Play();
		}
		timeRemaining = DB.levelClock;
		HUDAnimation();
		configureHUD();
		if (!DB.multiplayer)
		{
			player2RecievedEnvironment = true;
		}
		if (!DB.soundEnabled)
		{
			muteSound();
		}
		if (!(DB.achievements[29].counter >= (float)DB.achievements[29].threshold))
		{
			DB.achievements[29].counter = 0f;
		}
		if (DB.tutorial)
		{
			cameraHorizontalBounds.x = 0f;
			cameraHorizontalBounds.y = 1.5f;
			characterHorizontalBounds.x = cameraHorizontalBounds.x - screenEdge + 0.4f;
			worldEnd = cameraHorizontalBounds.y + screenEdge - 0.4f;
		}
		StartCoroutine(triggerZombieLoad());
	}

	public virtual IEnumerator triggerZombieLoad()
	{
		return new _0024triggerZombieLoad_00241657(this).GetEnumerator();
	}

	public virtual void despawnCheck()
	{
		float num = 0f;
		despawnCheckTimer = 0.5f;
		if ((bool)playerScript && (bool)allyScript && playerScript.alive && allyScript.alive)
		{
			num = ((allyScript.myTransform.position.x >= playerScript.myTransform.position.x) ? (playerScript.myTransform.position.x - screenEdge * 2f) : (allyScript.myTransform.position.x - screenEdge * 2f));
		}
		else if ((bool)playerScript && (bool)allyScript && !playerScript.alive)
		{
			num = allyScript.myTransform.position.x - screenEdge * 2f;
		}
		else if ((bool)playerScript && (bool)allyScript && !allyScript.alive)
		{
			num = playerScript.myTransform.position.x - screenEdge * 2f;
		}
		else if ((bool)playerScript)
		{
			num = playerScript.myTransform.position.x - screenEdge * 2f;
		}
		for (int i = 0; i < Extensions.get_length(zombies); i++)
		{
			if ((bool)zombies[i] && zombies[i].enabled && zombies[i].health > 0 && !zombies[i].availableForSpawning && !(zombies[i].myTransform.position.x >= num))
			{
				zombies[i].despawn(string.Empty);
				if (DB.multiplayer)
				{
					broadcast(i.ToString(), "despawn", i.ToString(), true);
				}
			}
		}
	}

	public virtual void handleJoysticks()
	{
		if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f || Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3"))
		{
			if (bottomLeftCorner.localScale.x != 0f)
			{
				bottomLeftCorner.localScale = new Vector3(0f, 0f, 0f);
				bottomRightCorner.localScale = new Vector3(0f, 0f, 0f);
			}
		}
		else if (Input.touchCount > 0 && bottomLeftCorner.localScale.x != 1f)
		{
			bottomLeftCorner.localScale = new Vector3(1f, 1f, 1f);
			bottomRightCorner.localScale = new Vector3(1f, 1f, 1f);
		}
	}

	public virtual void Update()
	{
		if (DB.multiplayer)
		{
			if (holdThePhone && readyMarker1.position.x == 1f && readyMarker2.position.x == 1f)
			{
				holdThePhone = false;
			}
			if (disconnector.position.x == 1f)
			{
				int num = 0;
				Vector3 position = disconnector.position;
				float num2 = (position.x = num);
				Vector3 vector2 = (disconnector.position = position);
				StartCoroutine(onPeerDisconnect());
			}
		}
		handleJoysticks();
		if (Input.GetKeyDown("r"))
		{
			showBubble(currentBubble);
			currentBubble++;
		}
		if (!(singlePlayerStartupDelay > 0f))
		{
			if (zombiesLoaded && destructiblesLoaded && !initializedZombies)
			{
				for (int i = 0; i < Extensions.get_length(zombies); i++)
				{
					if ((bool)zombies[i])
					{
						zombies[i].Initialize(DB, this);
					}
				}
				initializedZombies = true;
			}
			listen();
			//debugTools();
			if (DB.whichPlayerAmI == 1 && !(despawnCheckTimer > 0f))
			{
				despawnCheck();
			}
			else
			{
				despawnCheckTimer -= Time.deltaTime;
			}
			if (!playerScript && !holdThePhone)
			{
				tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.PCs[DB.myPC].characterModel));
				playerScript = (PlayerScript)tempGO.GetComponent(typeof(PlayerScript));
				determineWhichPlayer();
				playerScript.Initialize();
				createEnvironment();
			}
			if (!DB.multiplayer || ((bool)playerScript && (bool)allyScript))
			{
				if (introSequence && player2RecievedEnvironment)
				{
					FadeAnimation();
					HUDAnimation();
					RemoteUpdates();
					IntroSequence();
					deriveBounds();
				}
				else if (!introSequence)
				{
					if (DB.tutorial)
					{
						StartCoroutine(tutorialSequence());
					}
					if (!freezeGame)
					{
						RemoteUpdates();
					}
					if (!killCameraAnimation)
					{
						deriveBounds();
						CameraAnimation();
					}
					if (levelComplete)
					{
						levelCompleteAnimation();
					}
					FadeAnimation();
					ParticleAnimation();
					HUDAnimation();
					PickupCollection();
					Helicopter();
					handleVehicles();
					CheckForLevelComplete();
					if (DB.whichPlayerAmI == 1 && !freezeGame && !DB.tutorial)
					{
						if (!zombiesOff)
						{
							StartCoroutine(Spawn());
						}
						SpawnNextChunk();
					}
				}
			}
			if (!allyScript && DB.multiplayer)
			{
				if (!(tempTimer <= 0f))
				{
					tempTimer -= Time.deltaTime;
				}
				else
				{
					tempTimer = 0.1f;
				}
			}
			if (environmentExists)
			{
				loopingBG();
			}
			if (freezeGame)
			{
				if (Input.touchCount > 0 || Input.GetButton("Fire1") || Input.GetButton("Fire2") || Input.GetButton("Fire3") || Input.GetMouseButton(0)) // i added last one
				{
					Time.timeScale = 4f;
				}
				else
				{
					Time.timeScale = 1f;
				}
			}
			if (((waitingToExit && Input.touchCount > 0) || (waitingToExit && Input.GetMouseButtonDown(0)) || (waitingToExit && Input.GetButtonDown("Fire1")) || (waitingToExit && Input.GetButtonDown("Fire2")) || (waitingToExit && Input.GetButtonDown("Fire3"))) && !fade)
			{
				fade = true;
				StartCoroutine(goBackToMainMenu());
			}
		}
		else
		{
			singlePlayerStartupDelay -= Time.deltaTime;
		}
	}

	public virtual void iGotTheWorld(string emptyString)
	{
		player2RecievedEnvironment = true;
	}

	public virtual void RemoteUpdates()
	{
		if ((bool)playerScript)
		{
			playerScript.RemoteUpdate();
		}
		if ((bool)allyScript)
		{
			allyScript.RemoteUpdate();
		}
		zombieSyncDelay -= Time.deltaTime;
		if (DB.multiplayer && !(zombieSyncDelay > 0f))
		{
			textMessage = string.Empty;
		}
		for (int i = 0; i < Extensions.get_length(zombies); i++)
		{
			if (!zombies[i] || !zombies[i].enabled)
			{
				continue;
			}
			zombies[i].RemoteUpdate();
			if (zombies[i].zombieType != EnemyType.Container && DB.multiplayer && !(zombieSyncDelay > 0f) && zombies[i].myTargetScript == playerScript && zombies[i].enabled && !(zombies[i].recentAttack > 0f))
			{
				if (textMessage == string.Empty)
				{
					textMessage = zombies[i].createSyncMessage();
				}
				else
				{
					textMessage = textMessage + " " + zombies[i].createSyncMessage();
				}
			}
		}
		if (!(zombieSyncDelay > 0f) && DB.multiplayer)
		{
			zombieSyncDelay = stateSyncDelay * 3f;
			if (textMessage != string.Empty)
			{
				broadcast("**MOTHERBRAIN", "ZombieSync", textMessage, false);
			}
		}
	}

	public virtual void ZombieSync(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		int num = default(int);
		for (int i = 0; i < Extensions.get_length(array); i += 5)
		{
			num = UnityBuiltins.parseInt(array[i]);
			if (!(zombies[num].ignoreSync > 0f) && zombies[num].enabled)
			{
				zombies[num].timeSinceLastSync = 0f;
				zombies[num].movementVector = new Vector3(UnityBuiltins.parseFloat(array[i + 1]), 0f, UnityBuiltins.parseFloat(array[i + 2]));
				zombies[num].positionMagnet = new Vector3(UnityBuiltins.parseFloat(array[i + 3]), 0f, UnityBuiltins.parseFloat(array[i + 4]));
			}
		}
	}

	public virtual void deriveBounds()
	{
		if (!(slightWait > 0f))
		{
			if (DB.tutorial)
			{
				return;
			}
			if (!DB.multiplayer && !(cameraHorizontalBounds.x >= gameCamera.position.x - 3f))
			{
				cameraHorizontalBounds.x = gameCamera.position.x - 3f;
				characterHorizontalBounds.x = cameraHorizontalBounds.x - (screenEdge - 0.5f);
			}
			else if (DB.multiplayer && (bool)allyScript && (bool)playerScript && playerScript.alive && allyScript.alive)
			{
				if (!(playerScript.myTransform.position.x >= allyScript.myTransform.position.x) && !(cameraHorizontalBounds.x >= playerScript.myTransform.position.x - 1.5f))
				{
					cameraHorizontalBounds.x = playerScript.myTransform.position.x - 1.5f;
					characterHorizontalBounds.x = cameraHorizontalBounds.x - (screenEdge - 0.5f);
				}
				else if (!(allyScript.myTransform.position.x >= playerScript.myTransform.position.x) && !(cameraHorizontalBounds.x >= allyScript.myTransform.position.x - 1.5f))
				{
					cameraHorizontalBounds.x = allyScript.myTransform.position.x - 1.5f;
					characterHorizontalBounds.x = cameraHorizontalBounds.x - (screenEdge - 0.5f);
				}
			}
			else if (DB.multiplayer && (bool)allyScript && (bool)playerScript && !(cameraHorizontalBounds.x >= gameCamera.position.x - 3f))
			{
				cameraHorizontalBounds.x = gameCamera.position.x - 3f;
				characterHorizontalBounds.x = cameraHorizontalBounds.x - (screenEdge - 0.5f);
			}
		}
		else
		{
			slightWait -= Time.deltaTime;
		}
	}

	public virtual void CameraAnimation()
	{
		if ((bool)playerScript && !playerScript.alive && !(watchOtherPlayer <= 0f))
		{
			watchOtherPlayer -= Time.deltaTime;
		}
		if (!(watchOtherPlayer <= 0f))
		{
			float x = gameCamera.position.x;
			float z = gameCamera.position.z;
			if ((bool)playerScript)
			{
				if (playerScript.inVehicle && !(playerScript.movementLockout > 0f))
				{
					gameCamera.position = Vector3.Lerp(gameCamera.position, playerScript.myTransform.position + new Vector3(playerScript.myTransform.localScale.x * 2.4f, 0f, 0f), Time.deltaTime * 15f);
				}
				else
				{
					gameCamera.position = Vector3.Lerp(gameCamera.position, playerScript.myTransform.position + new Vector3(playerScript.myTransform.localScale.x * 1f, 0f, 0f), Time.deltaTime * 4f);
				}
				if (!(gameCamera.position.z <= cameraVerticalBounds.x))
				{
					float x2 = cameraVerticalBounds.x;
					Vector3 position = gameCamera.position;
					float num = (position.z = x2);
					Vector3 vector2 = (gameCamera.position = position);
				}
				else if (!(gameCamera.position.z >= cameraVerticalBounds.y))
				{
					float y = cameraVerticalBounds.y;
					Vector3 position2 = gameCamera.position;
					float num2 = (position2.z = y);
					Vector3 vector4 = (gameCamera.position = position2);
				}
				if (!(gameCamera.position.x >= cameraHorizontalBounds.x))
				{
					float x3 = cameraHorizontalBounds.x;
					Vector3 position3 = gameCamera.position;
					float num3 = (position3.x = x3);
					Vector3 vector6 = (gameCamera.position = position3);
				}
				else if (!(gameCamera.position.x <= cameraHorizontalBounds.y))
				{
					float y2 = cameraHorizontalBounds.y;
					Vector3 position4 = gameCamera.position;
					float num4 = (position4.x = y2);
					Vector3 vector8 = (gameCamera.position = position4);
				}
				if (!(DB.achievements[27].counter >= (float)DB.achievements[27].threshold) && !(gameCamera.position.x <= horizontalProgress))
				{
					DB.achievements[27].counter = DB.achievements[27].counter + (gameCamera.position.x - horizontalProgress) * 0.03f;
					horizontalProgress = gameCamera.position.x;
					if (!(DB.achievements[27].counter < (float)DB.achievements[27].threshold))
					{
						DB.achievements[27].counter = DB.achievements[27].threshold;
						DB.announceAchievement(27);
					}
				}
				else if (!(gameCamera.position.x <= horizontalProgress))
				{
					horizontalProgress = gameCamera.position.x;
				}
			}
			if (environmentExists)
			{
				for (int i = 0; i < 3; i++)
				{
					if ((bool)FGPieces[i])
					{
						float x4 = FGPieces[i].position.x - (gameCamera.position.x - x) * 0.2f;
						Vector3 position5 = FGPieces[i].position;
						float num5 = (position5.x = x4);
						Vector3 vector10 = (FGPieces[i].position = position5);
						float z2 = FGPieces[i].position.z - (gameCamera.position.z - z) * 0.2f;
						Vector3 position6 = FGPieces[i].position;
						float num6 = (position6.z = z2);
						Vector3 vector12 = (FGPieces[i].position = position6);
					}
					if ((bool)SkylinePieces[i])
					{
						float x5 = SkylinePieces[i].position.x + (gameCamera.position.x - x) * 0.6f;
						Vector3 position7 = SkylinePieces[i].position;
						float num7 = (position7.x = x5);
						Vector3 vector14 = (SkylinePieces[i].position = position7);
					}
					if ((bool)cloudPieces[i])
					{
						float x6 = cloudPieces[i].position.x + (gameCamera.position.x - x) * 0.8f;
						Vector3 position8 = cloudPieces[i].position;
						float num8 = (position8.x = x6);
						Vector3 vector16 = (cloudPieces[i].position = position8);
						float x7 = cloudPieces[i].position.x - Time.deltaTime * 0.2f;
						Vector3 position9 = cloudPieces[i].position;
						float num9 = (position9.x = x7);
						Vector3 vector18 = (cloudPieces[i].position = position9);
					}
				}
				if ((bool)backdrop)
				{
					float x8 = gameCamera.position.x;
					Vector3 position10 = backdrop.position;
					float num10 = (position10.x = x8);
					Vector3 vector20 = (backdrop.position = position10);
				}
			}
		}
		else if (!(watchOtherPlayer > 0f) && (bool)allyScript)
		{
			float x = gameCamera.position.x;
			float z = gameCamera.position.z;
			if ((bool)allyScript)
			{
				gameCamera.position = Vector3.Lerp(gameCamera.position, allyScript.myTransform.position + new Vector3(allyScript.myTransform.localScale.x * 1f, 0f, 0f), Time.deltaTime * 4f);
				if (!(gameCamera.position.z <= cameraVerticalBounds.x))
				{
					float x9 = cameraVerticalBounds.x;
					Vector3 position11 = gameCamera.position;
					float num11 = (position11.z = x9);
					Vector3 vector22 = (gameCamera.position = position11);
				}
				else if (!(gameCamera.position.z >= cameraVerticalBounds.y))
				{
					float y3 = cameraVerticalBounds.y;
					Vector3 position12 = gameCamera.position;
					float num12 = (position12.z = y3);
					Vector3 vector24 = (gameCamera.position = position12);
				}
				if (!(gameCamera.position.x >= cameraHorizontalBounds.x))
				{
					float x10 = cameraHorizontalBounds.x;
					Vector3 position13 = gameCamera.position;
					float num13 = (position13.x = x10);
					Vector3 vector26 = (gameCamera.position = position13);
				}
				else if (!(gameCamera.position.x <= cameraHorizontalBounds.y))
				{
					float y4 = cameraHorizontalBounds.y;
					Vector3 position14 = gameCamera.position;
					float num14 = (position14.x = y4);
					Vector3 vector28 = (gameCamera.position = position14);
				}
			}
			if (environmentExists)
			{
				for (int i = 0; i < 3; i++)
				{
					if ((bool)FGPieces[i])
					{
						float x11 = FGPieces[i].position.x - (gameCamera.position.x - x) * 0.2f;
						Vector3 position15 = FGPieces[i].position;
						float num15 = (position15.x = x11);
						Vector3 vector30 = (FGPieces[i].position = position15);
						float z3 = FGPieces[i].position.z - (gameCamera.position.z - z) * 0.2f;
						Vector3 position16 = FGPieces[i].position;
						float num16 = (position16.z = z3);
						Vector3 vector32 = (FGPieces[i].position = position16);
					}
					if ((bool)SkylinePieces[i])
					{
						float x12 = SkylinePieces[i].position.x + (gameCamera.position.x - x) * 0.6f;
						Vector3 position17 = SkylinePieces[i].position;
						float num17 = (position17.x = x12);
						Vector3 vector34 = (SkylinePieces[i].position = position17);
					}
					if ((bool)cloudPieces[i])
					{
						float x13 = cloudPieces[i].position.x + (gameCamera.position.x - x) * 0.8f;
						Vector3 position18 = cloudPieces[i].position;
						float num18 = (position18.x = x13);
						Vector3 vector36 = (cloudPieces[i].position = position18);
						float x14 = cloudPieces[i].position.x - Time.deltaTime * 0.2f;
						Vector3 position19 = cloudPieces[i].position;
						float num19 = (position19.x = x14);
						Vector3 vector38 = (cloudPieces[i].position = position19);
					}
				}
				if ((bool)backdrop)
				{
					float x15 = gameCamera.position.x;
					Vector3 position20 = backdrop.position;
					float num20 = (position20.x = x15);
					Vector3 vector40 = (backdrop.position = position20);
				}
			}
		}
		if ((bool)allyScript)
		{
			if (!allyScript.alive)
			{
				int num21 = 100;
				Vector3 position21 = arrowTransform.position;
				float num22 = (position21.z = num21);
				Vector3 vector42 = (arrowTransform.position = position21);
			}
			else if (!(allyScript.myTransform.position.x >= gameCamera.position.x - screenEdge))
			{
				float z4 = allyScript.myTransform.position.z;
				Vector3 position22 = arrowTransform.position;
				float num23 = (position22.z = z4);
				Vector3 vector44 = (arrowTransform.position = position22);
				float x16 = gameCamera.position.x;
				Vector3 position23 = arrowTransform.position;
				float num24 = (position23.x = x16);
				Vector3 vector46 = (arrowTransform.position = position23);
				if (arrowTransform.localScale.x != 1f)
				{
					int num25 = 1;
					Vector3 localScale = arrowTransform.localScale;
					float num26 = (localScale.x = num25);
					Vector3 vector48 = (arrowTransform.localScale = localScale);
				}
			}
			else if (!(allyScript.myTransform.position.x <= gameCamera.position.x + screenEdge))
			{
				float z5 = allyScript.myTransform.position.z;
				Vector3 position24 = arrowTransform.position;
				float num27 = (position24.z = z5);
				Vector3 vector50 = (arrowTransform.position = position24);
				float x17 = gameCamera.position.x;
				Vector3 position25 = arrowTransform.position;
				float num28 = (position25.x = x17);
				Vector3 vector52 = (arrowTransform.position = position25);
				if (arrowTransform.localScale.x != -1f)
				{
					int num29 = -1;
					Vector3 localScale2 = arrowTransform.localScale;
					float num30 = (localScale2.x = num29);
					Vector3 vector54 = (arrowTransform.localScale = localScale2);
				}
			}
			else
			{
				int num31 = 100;
				Vector3 position26 = arrowTransform.position;
				float num32 = (position26.z = num31);
				Vector3 vector56 = (arrowTransform.position = position26);
			}
		}
		else if (arrowTransform.position.z != 100f)
		{
			int num33 = 100;
			Vector3 position27 = arrowTransform.position;
			float num34 = (position27.z = num33);
			Vector3 vector58 = (arrowTransform.position = position27);
		}
	}

	public virtual void FadeAnimation()
	{
		if (!fade && fader.enabled && !(fader.material.color.a <= 0f))
		{
			float a = fader.material.color.a - Time.deltaTime;
			Color color = fader.material.color;
			float num = (color.a = a);
			Color color3 = (fader.material.color = color);
		}
		else if (!fade && fader.enabled)
		{
			fader.enabled = false;
		}
		else if (fade && !fader.enabled)
		{
			fader.enabled = true;
			int num2 = 0;
			Color color4 = fader.material.color;
			float num3 = (color4.a = num2);
			Color color6 = (fader.material.color = color4);
		}
		else if (fade && fader.enabled && !(fader.material.color.a >= 1f))
		{
			float a2 = fader.material.color.a + Time.deltaTime;
			Color color7 = fader.material.color;
			float num4 = (color7.a = a2);
			Color color9 = (fader.material.color = color7);
			BGmusic.volume -= Time.deltaTime;
		}
	}

	public virtual void spawnOtherPlayer(string spawnInfo)
	{
		string[] array = spawnInfo.Split(" "[0]);
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.PCs[UnityBuiltins.parseInt(array[0])].characterModel));
		allyScript = (PlayerScript)tempGO.GetComponent(typeof(PlayerScript));
		allyScript.weapons[0] = UnityBuiltins.parseInt(array[1]);
		allyScript.weapons[1] = UnityBuiltins.parseInt(array[2]);
		allyScript.weapons[2] = UnityBuiltins.parseInt(array[3]);
		allyScript.maxHealth = UnityBuiltins.parseInt(array[4]);
		allyScript.moveSpeed = UnityBuiltins.parseFloat(array[5]);
		allyScript.perks[0] = UnityBuiltins.parseInt(array[6]);
		allyScript.perks[1] = UnityBuiltins.parseInt(array[7]);
		allyScript.perks[2] = UnityBuiltins.parseInt(array[8]);
		allyScript.perkRanks[0] = UnityBuiltins.parseInt(array[9]);
		allyScript.perkRanks[1] = UnityBuiltins.parseInt(array[10]);
		allyScript.perkRanks[2] = UnityBuiltins.parseInt(array[11]);
		allyScript.health = allyScript.maxHealth;
		allyScript.weaponNames[0] = array[14];
		allyScript.weaponNames[1] = array[15];
		allyScript.weaponNames[2] = array[16];
		allyScript.weaponModels[0] = array[17];
		allyScript.weaponModels[1] = array[18];
		allyScript.weaponModels[2] = array[19];
		allyScript.animSets[0] = UnityBuiltins.parseInt(array[20]);
		allyScript.animSets[1] = UnityBuiltins.parseInt(array[21]);
		allyScript.animSets[2] = UnityBuiltins.parseInt(array[22]);
		allyScript.explosiveModels[0] = array[23];
		allyScript.explosiveModels[1] = array[24];
		allyScript.explosiveModels[2] = array[25];
		if (array[26] == "1")
		{
			allyScript.DWstatus[0] = true;
		}
		if (array[27] == "1")
		{
			allyScript.DWstatus[1] = true;
		}
		if (array[28] == "1")
		{
			allyScript.DWstatus[2] = true;
		}
		allyScript.movementPenalties[0] = UnityBuiltins.parseFloat(array[29]);
		allyScript.movementPenalties[1] = UnityBuiltins.parseFloat(array[30]);
		allyScript.movementPenalties[2] = UnityBuiltins.parseFloat(array[31]);
		allyScript.impactForces[0] = UnityBuiltins.parseFloat(array[32]);
		allyScript.impactForces[1] = UnityBuiltins.parseFloat(array[33]);
		allyScript.impactForces[2] = UnityBuiltins.parseFloat(array[34]);
		allyScript.impactFalloffs[0] = UnityBuiltins.parseFloat(array[35]);
		allyScript.impactFalloffs[1] = UnityBuiltins.parseFloat(array[36]);
		allyScript.impactFalloffs[2] = UnityBuiltins.parseFloat(array[37]);
		allyScript.shellTypes[0] = UnityBuiltins.parseInt(array[38]);
		allyScript.shellTypes[1] = UnityBuiltins.parseInt(array[39]);
		allyScript.shellTypes[2] = UnityBuiltins.parseInt(array[40]);
		allyScript.ally = true;
		allyScript.AllyInitialize();
		float x = UnityBuiltins.parseFloat(array[12]);
		Vector3 position = allyScript.myTransform.position;
		float num = (position.x = x);
		Vector3 vector2 = (allyScript.myTransform.position = position);
		float z = UnityBuiltins.parseFloat(array[13]);
		Vector3 position2 = allyScript.myTransform.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (allyScript.myTransform.position = position2);
		allyScript.movementTarget.x = UnityBuiltins.parseFloat(array[12]) + 4f;
	}

	public virtual void configureHUD()
	{
		float num = Screen.height;
		float num2 = Screen.width;
		if (!(Mathf.Abs(num / num2 - 0.75f) > 0.005f))
		{
			HUDroot.localScale = new Vector3(0.8f, 0.8f, 0.8f);
			HUDtargetScale = new Vector3(0.8f, 0.8f, 0.8f);
		}
		bottomLeftCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(0f, 0f, 20f));
		bottomRightCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(1f, 0f, 20f));
		topLeftCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(0f, 1f, 20f));
		topRightCorner.position = cameraLens.ViewportToWorldPoint(new Vector3(1f, 1f, 20f));
		clockPosition.position = cameraLens.ViewportToWorldPoint(new Vector3(0.5f, 1f, 20f));
		if (DB.tutorial)
		{
			float y = clockPosition.localPosition.y + 3f;
			Vector3 localPosition = clockPosition.localPosition;
			float num3 = (localPosition.y = y);
			Vector3 vector2 = (clockPosition.localPosition = localPosition);
		}
		BoxCollider boxCollider = null;
		boxCollider = joystickGO.AddComponent<BoxCollider>();
		boxCollider.size = new Vector3(4.7f, 4.7f, 0.1f);
		boxCollider = fire1GO.AddComponent<BoxCollider>();
		boxCollider.size = new Vector3(1.25f, 1.25f, 0.1f);
		boxCollider = fire2GO.AddComponent<BoxCollider>();
		boxCollider.size = new Vector3(1.25f, 1.25f, 0.1f);
		boxCollider = fire3GO.AddComponent<BoxCollider>();
		boxCollider.size = new Vector3(1.25f, 1.25f, 0.1f);
		boxCollider = clockGO.AddComponent<BoxCollider>();
		boxCollider.size = new Vector3(1.4f, 1.4f, 0.1f);
		boxCollider.center = new Vector3(0f, 0f, 0f);
		HUDroot.localScale += new Vector3(1.8f, 1.8f, 1.8f);
		string[] joystickNames = Input.GetJoystickNames();
		if (joystickNames.Length > 0)
		{
			bottomLeftCorner.localScale = new Vector3(0f, 0f, 0f);
			bottomRightCorner.localScale = new Vector3(0f, 0f, 0f);
		}
	}

	public virtual IEnumerator onPeerDisconnect()
	{
		return new _0024onPeerDisconnect_00241662(this).GetEnumerator();
	}

	public virtual void OnApplicationQuit()
	{
	}

	public virtual void broadcast(string whichObject, string whichFunction, string message, bool reliable)
	{
		if (!DB.multiplayer)
		{
			return;
		}
		for (int i = 0; i < Extensions.get_length(messageSlots); i++)
		{
			if (messageSlots[i].whichObject.text == string.Empty)
			{
				messageSlots[i].whichObject.text = whichObject;
				messageSlots[i].whichFunction.text = whichFunction;
				messageSlots[i].message.text = message;
				i = Extensions.get_length(messageSlots);
			}
		}
	}

	public virtual void peerIsReady(string noString)
	{
		holdThePhone = false;
	}

	public virtual void spawnBasicShell(Vector3 startPos, Vector3 offset, int facing)
	{
		basicShells[nextBasicShell].life = 1.6f;
		basicShells[nextBasicShell].myTransform.position = startPos;
		float x = basicShells[nextBasicShell].myTransform.position.x + offset.x * (float)facing;
		Vector3 position = basicShells[nextBasicShell].myTransform.position;
		float num = (position.x = x);
		Vector3 vector2 = (basicShells[nextBasicShell].myTransform.position = position);
		float z = basicShells[nextBasicShell].myTransform.position.z + offset.z;
		Vector3 position2 = basicShells[nextBasicShell].myTransform.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (basicShells[nextBasicShell].myTransform.position = position2);
		float y = basicShells[nextBasicShell].myTransform.localPosition.y + offset.y;
		Vector3 localPosition = basicShells[nextBasicShell].myTransform.localPosition;
		float num3 = (localPosition.y = y);
		Vector3 vector6 = (basicShells[nextBasicShell].myTransform.localPosition = localPosition);
		basicShells[nextBasicShell].movement = new Vector3(UnityEngine.Random.Range(2.9f, 4.7f) * (float)(-facing), UnityEngine.Random.Range(5.9f, 8.2f), UnityEngine.Random.Range(-0.2f, 0.2f));
		basicShells[nextBasicShell].spin = UnityEngine.Random.Range(600f, 1250f) * (float)(-facing);
		nextBasicShell++;
		if (nextBasicShell >= Extensions.get_length(basicShells))
		{
			nextBasicShell = 0;
		}
	}

	public virtual void spawnSniperShell(Vector3 startPos, Vector3 offset, int facing)
	{
		sniperShells[nextSniperShell].life = 1.6f;
		sniperShells[nextSniperShell].myTransform.position = startPos;
		float x = sniperShells[nextSniperShell].myTransform.position.x + offset.x * (float)facing;
		Vector3 position = sniperShells[nextSniperShell].myTransform.position;
		float num = (position.x = x);
		Vector3 vector2 = (sniperShells[nextSniperShell].myTransform.position = position);
		float z = sniperShells[nextSniperShell].myTransform.position.z + offset.z;
		Vector3 position2 = sniperShells[nextSniperShell].myTransform.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (sniperShells[nextSniperShell].myTransform.position = position2);
		float y = sniperShells[nextSniperShell].myTransform.localPosition.y + offset.y;
		Vector3 localPosition = sniperShells[nextSniperShell].myTransform.localPosition;
		float num3 = (localPosition.y = y);
		Vector3 vector6 = (sniperShells[nextSniperShell].myTransform.localPosition = localPosition);
		sniperShells[nextSniperShell].movement = new Vector3(UnityEngine.Random.Range(2.7f, 3.7f) * (float)(-facing), UnityEngine.Random.Range(8.9f, 13.2f), UnityEngine.Random.Range(-0.2f, 0.2f));
		sniperShells[nextSniperShell].spin = UnityEngine.Random.Range(1600f, 2250f) * (float)(-facing);
		nextSniperShell++;
		if (nextSniperShell >= Extensions.get_length(sniperShells))
		{
			nextSniperShell = 0;
		}
	}

	public virtual void spawnShottyShell(Vector3 startPos, Vector3 offset, int facing)
	{
		shottyShells[nextShottyShell].life = 1.6f;
		shottyShells[nextShottyShell].myTransform.position = startPos;
		float x = shottyShells[nextShottyShell].myTransform.position.x + offset.x * (float)facing;
		Vector3 position = shottyShells[nextShottyShell].myTransform.position;
		float num = (position.x = x);
		Vector3 vector2 = (shottyShells[nextShottyShell].myTransform.position = position);
		float z = shottyShells[nextShottyShell].myTransform.position.z + offset.z;
		Vector3 position2 = shottyShells[nextShottyShell].myTransform.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (shottyShells[nextShottyShell].myTransform.position = position2);
		float y = shottyShells[nextShottyShell].myTransform.localPosition.y + offset.y;
		Vector3 localPosition = shottyShells[nextShottyShell].myTransform.localPosition;
		float num3 = (localPosition.y = y);
		Vector3 vector6 = (shottyShells[nextShottyShell].myTransform.localPosition = localPosition);
		shottyShells[nextShottyShell].movement = new Vector3(UnityEngine.Random.Range(2.9f, 4.7f) * (float)(-facing), UnityEngine.Random.Range(5.9f, 8.2f), UnityEngine.Random.Range(-0.2f, 0.2f));
		shottyShells[nextShottyShell].spin = UnityEngine.Random.Range(600f, 1250f) * (float)(-facing);
		nextShottyShell++;
		if (nextShottyShell >= Extensions.get_length(shottyShells))
		{
			nextShottyShell = 0;
		}
	}

	public virtual void spawnPin(Vector3 startPos, Vector3 offset, int facing)
	{
		pins[nextPin].life = 1.4f;
		pins[nextPin].myTransform.position = startPos;
		float x = pins[nextPin].myTransform.position.x + offset.x * (float)facing;
		Vector3 position = pins[nextPin].myTransform.position;
		float num = (position.x = x);
		Vector3 vector2 = (pins[nextPin].myTransform.position = position);
		float z = pins[nextPin].myTransform.position.z + offset.z;
		Vector3 position2 = pins[nextPin].myTransform.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (pins[nextPin].myTransform.position = position2);
		float y = pins[nextPin].myTransform.localPosition.y + offset.y;
		Vector3 localPosition = pins[nextPin].myTransform.localPosition;
		float num3 = (localPosition.y = y);
		Vector3 vector6 = (pins[nextPin].myTransform.localPosition = localPosition);
		pins[nextPin].movement = new Vector3(UnityEngine.Random.Range(-0.9f, 0.9f) * (float)facing, UnityEngine.Random.Range(6.9f, 9.2f), UnityEngine.Random.Range(-0.2f, 0.2f));
		pins[nextPin].spin = UnityEngine.Random.Range(600f, 1250f) * (float)(-facing);
		nextPin++;
		if (nextPin >= Extensions.get_length(pins))
		{
			nextPin = 0;
		}
	}

	public virtual void spawnHeadExplosion(Vector3 startPos, Vector3 damageDirection)
	{
		for (int i = 0; i < 6; i++)
		{
			blood[nextBlood].life = UnityEngine.Random.Range(1.7f, 2.4f);
			blood[nextBlood].myTransform.position = startPos;
			blood[nextBlood].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(5.4f, 11f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			nextBlood++;
			if (nextBlood >= Extensions.get_length(blood))
			{
				nextBlood = 0;
			}
		}
		for (int i = 0; i < 4; i++)
		{
			meat[nextMeat].life = UnityEngine.Random.Range(1.7f, 2.4f);
			meat[nextMeat].myTransform.position = startPos;
			meat[nextMeat].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(7.1f, 14f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			meat[nextMeat].spin = UnityEngine.Random.Range(350f, 750f);
			if (!(meat[nextMeat].movement.x >= 0f))
			{
				meat[nextMeat].spin = meat[nextMeat].spin * -1f;
			}
			nextMeat++;
			if (nextMeat >= Extensions.get_length(meat))
			{
				nextMeat = 0;
			}
		}
		for (int i = 0; i < 3; i++)
		{
			bone[nextBone].life = UnityEngine.Random.Range(1.2f, 1.4f);
			bone[nextBone].myTransform.position = startPos;
			bone[nextBone].movement = new Vector3(UnityEngine.Random.Range(-4f, 4f), UnityEngine.Random.Range(8.1f, 16f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			bone[nextBone].spin = UnityEngine.Random.Range(1050f, 1250f);
			if (!(bone[nextBone].movement.x >= 0f))
			{
				bone[nextBone].spin = bone[nextBone].spin * -1f;
			}
			nextBone++;
			if (nextBone >= Extensions.get_length(bone))
			{
				nextBone = 0;
			}
		}
	}

	public virtual void spawnSelfDestruct(Vector3 startPos, Vector3 damageDirection)
	{
		for (int i = 0; i < 6; i++)
		{
			blood[nextBlood].life = UnityEngine.Random.Range(1.7f, 2.4f);
			blood[nextBlood].myTransform.position = startPos;
			blood[nextBlood].movement = new Vector3(UnityEngine.Random.Range(-8.5f, 8.5f), UnityEngine.Random.Range(10f, 25f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			nextBlood++;
			if (nextBlood >= Extensions.get_length(blood))
			{
				nextBlood = 0;
			}
		}
		for (int i = 0; i < 4; i++)
		{
			meat[nextMeat].life = UnityEngine.Random.Range(1.7f, 2.4f);
			meat[nextMeat].myTransform.position = startPos;
			meat[nextMeat].movement = new Vector3(UnityEngine.Random.Range(-8.5f, 8.5f), UnityEngine.Random.Range(11f, 22f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			meat[nextMeat].spin = UnityEngine.Random.Range(350f, 750f);
			if (!(meat[nextMeat].movement.x >= 0f))
			{
				meat[nextMeat].spin = meat[nextMeat].spin * -1f;
			}
			nextMeat++;
			if (nextMeat >= Extensions.get_length(meat))
			{
				nextMeat = 0;
			}
		}
		for (int i = 0; i < 3; i++)
		{
			bone[nextBone].life = UnityEngine.Random.Range(1.2f, 1.4f);
			bone[nextBone].myTransform.position = startPos;
			bone[nextBone].movement = new Vector3(UnityEngine.Random.Range(-6f, 6f), UnityEngine.Random.Range(9f, 19f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			bone[nextBone].spin = UnityEngine.Random.Range(1050f, 1250f);
			if (!(bone[nextBone].movement.x >= 0f))
			{
				bone[nextBone].spin = bone[nextBone].spin * -1f;
			}
			nextBone++;
			if (nextBone >= Extensions.get_length(bone))
			{
				nextBone = 0;
			}
		}
	}

	public virtual void spawnSlice(Vector3 startPos, Vector3 damageDirection)
	{
		for (int i = 0; i < 6; i++)
		{
			blood[nextBlood].life = UnityEngine.Random.Range(1.7f, 2.4f);
			blood[nextBlood].myTransform.position = startPos;
			blood[nextBlood].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(5.4f, 11f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			nextBlood++;
			if (nextBlood >= Extensions.get_length(blood))
			{
				nextBlood = 0;
			}
		}
		for (int i = 0; i < 2; i++)
		{
			meat[nextMeat].life = UnityEngine.Random.Range(1.7f, 2.4f);
			meat[nextMeat].myTransform.position = startPos;
			meat[nextMeat].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(7.1f, 14f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			meat[nextMeat].spin = UnityEngine.Random.Range(350f, 750f);
			if (!(meat[nextMeat].movement.x >= 0f))
			{
				meat[nextMeat].spin = meat[nextMeat].spin * -1f;
			}
			nextMeat++;
			if (nextMeat >= Extensions.get_length(meat))
			{
				nextMeat = 0;
			}
		}
	}

	public virtual void spawnAsh(Vector3 startPos, Vector3 damageDirection)
	{
		for (int i = 0; i < 3; i++)
		{
			ashes[nextAsh].life = UnityEngine.Random.Range(1.2f, 1.8f);
			ashes[nextAsh].myTransform.position = startPos;
			ashes[nextAsh].movement = new Vector3(UnityEngine.Random.Range(-2.4f, 2.4f), UnityEngine.Random.Range(4.1f, 10f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			ashes[nextAsh].spin = UnityEngine.Random.Range(350f, 950f);
			if (!(ashes[nextAsh].movement.x >= 0f))
			{
				ashes[nextAsh].spin = ashes[nextAsh].spin * -1f;
			}
			nextAsh++;
			if (nextAsh >= Extensions.get_length(ashes))
			{
				nextAsh = 0;
			}
		}
	}

	public virtual void spawnExplosiveAsh(Vector3 startPos)
	{
		for (int i = 0; i < 8; i++)
		{
			ashes[nextAsh].life = UnityEngine.Random.Range(1.2f, 1.8f);
			ashes[nextAsh].myTransform.position = startPos;
			ashes[nextAsh].movement = new Vector3(UnityEngine.Random.Range(-3.7f, 3.7f), UnityEngine.Random.Range(9.1f, 22f), UnityEngine.Random.Range(-2f, 2f));
			ashes[nextAsh].spin = UnityEngine.Random.Range(200f, 550f);
			if (!(ashes[nextAsh].movement.x >= 0f))
			{
				ashes[nextAsh].spin = ashes[nextAsh].spin * -1f;
			}
			nextAsh++;
			if (nextAsh >= Extensions.get_length(ashes))
			{
				nextAsh = 0;
			}
		}
	}

	public virtual void groundEruption(Vector3 startPos, float facingDirection)
	{
		for (int i = 0; i < 5; i++)
		{
			pebbles[nextPebble].life = UnityEngine.Random.Range(1.2f, 1.8f);
			pebbles[nextPebble].myTransform.position = startPos + new Vector3(0f, 0.1f, 0.1f);
			pebbles[nextPebble].movement = new Vector3(UnityEngine.Random.Range(-3.7f, 3.7f), UnityEngine.Random.Range(5.1f, 17f), UnityEngine.Random.Range(-2f, 2f));
			pebbles[nextPebble].spin = UnityEngine.Random.Range(200f, 550f);
			if (!(pebbles[nextPebble].movement.x >= 0f))
			{
				pebbles[nextPebble].spin = pebbles[nextPebble].spin * -1f;
			}
			nextPebble++;
			if (nextPebble >= Extensions.get_length(pebbles))
			{
				nextPebble = 0;
			}
		}
		dirt[nextDirt].tran.position = startPos;
		dirt[nextDirt].anim.Stop();
		dirt[nextDirt].anim.Play();
		float a = 1f;
		Color color = dirt[nextDirt].rend.material.color;
		float num = (color.a = a);
		Color color3 = (dirt[nextDirt].rend.material.color = color);
		dirt[nextDirt].life = 3.5f;
		nextDirt++;
		if (nextDirt >= Extensions.get_length(dirt))
		{
			nextDirt = 0;
		}
	}

	public virtual void spawnEscape(Vector3 startPos)
	{
		for (int i = 0; i < 5; i++)
		{
			iceSmall[nextIceSmall].life = UnityEngine.Random.Range(1.2f, 1.8f);
			iceSmall[nextIceSmall].myTransform.position = startPos + new Vector3(UnityEngine.Random.Range(-0.3f, 0.3f), UnityEngine.Random.Range(-0.4f, 0.4f), 0f);
			iceSmall[nextIceSmall].movement = new Vector3(UnityEngine.Random.Range(-3.7f, 3.7f), UnityEngine.Random.Range(3.1f, 10f), UnityEngine.Random.Range(-2f, 2f));
			iceSmall[nextIceSmall].spin = UnityEngine.Random.Range(200f, 550f);
			if (!(iceSmall[nextIceSmall].movement.x >= 0f))
			{
				iceSmall[nextIceSmall].spin = iceSmall[nextIceSmall].spin * -1f;
			}
			nextIceSmall++;
			if (nextIceSmall >= Extensions.get_length(iceSmall))
			{
				nextIceSmall = 0;
			}
		}
	}

	public virtual void spawnIceDeath(Vector3 startPos, Vector3 damageDirection)
	{
		for (int i = 0; i < 5; i++)
		{
			iceBig[nextIceBig].life = UnityEngine.Random.Range(1.2f, 1.8f);
			iceBig[nextIceBig].myTransform.position = startPos + new Vector3(UnityEngine.Random.Range(-0.3f, 0.3f), UnityEngine.Random.Range(-0.4f, 0.4f), 0f);
			iceBig[nextIceBig].movement = new Vector3(UnityEngine.Random.Range(-3.7f, 3.7f), UnityEngine.Random.Range(7.1f, 16f), UnityEngine.Random.Range(-2f, 2f)) + damageDirection;
			iceBig[nextIceBig].spin = UnityEngine.Random.Range(200f, 550f);
			if (!(iceBig[nextIceBig].movement.x >= 0f))
			{
				iceBig[nextIceBig].spin = iceBig[nextIceBig].spin * -1f;
			}
			nextIceBig++;
			if (nextIceBig >= Extensions.get_length(iceBig))
			{
				nextIceBig = 0;
			}
		}
		for (int i = 0; i < 4; i++)
		{
			iceSmall[nextIceSmall].life = UnityEngine.Random.Range(1.2f, 1.8f);
			iceSmall[nextIceSmall].myTransform.position = startPos + new Vector3(UnityEngine.Random.Range(-0.3f, 0.3f), UnityEngine.Random.Range(-0.4f, 0.4f), 0f);
			iceSmall[nextIceSmall].movement = new Vector3(UnityEngine.Random.Range(-3.7f, 3.7f), UnityEngine.Random.Range(5.1f, 18f), UnityEngine.Random.Range(-2f, 2f)) + damageDirection;
			iceSmall[nextIceSmall].spin = UnityEngine.Random.Range(200f, 550f);
			if (!(iceSmall[nextIceSmall].movement.x >= 0f))
			{
				iceSmall[nextIceSmall].spin = iceSmall[nextIceSmall].spin * -1f;
			}
			nextIceSmall++;
			if (nextIceSmall >= Extensions.get_length(iceSmall))
			{
				nextIceSmall = 0;
			}
		}
		for (int i = 0; i < 4; i++)
		{
			blood[nextBlood].life = UnityEngine.Random.Range(1.7f, 2.4f);
			blood[nextBlood].myTransform.position = startPos;
			blood[nextBlood].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(5.4f, 11f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			nextBlood++;
			if (nextBlood >= Extensions.get_length(blood))
			{
				nextBlood = 0;
			}
		}
		for (int i = 0; i < 2; i++)
		{
			meat[nextMeat].life = UnityEngine.Random.Range(1.7f, 2.4f);
			meat[nextMeat].myTransform.position = startPos;
			meat[nextMeat].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(7.1f, 14f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			meat[nextMeat].spin = UnityEngine.Random.Range(350f, 750f);
			if (!(meat[nextMeat].movement.x >= 0f))
			{
				meat[nextMeat].spin = meat[nextMeat].spin * -1f;
			}
			nextMeat++;
			if (nextMeat >= Extensions.get_length(meat))
			{
				nextMeat = 0;
			}
		}
		for (int i = 0; i < 2; i++)
		{
			bone[nextBone].life = UnityEngine.Random.Range(1.2f, 1.4f);
			bone[nextBone].myTransform.position = startPos;
			bone[nextBone].movement = new Vector3(UnityEngine.Random.Range(-4f, 4f), UnityEngine.Random.Range(8.1f, 16f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			bone[nextBone].spin = UnityEngine.Random.Range(1050f, 1250f);
			if (!(bone[nextBone].movement.x >= 0f))
			{
				bone[nextBone].spin = bone[nextBone].spin * -1f;
			}
			nextBone++;
			if (nextBone >= Extensions.get_length(bone))
			{
				nextBone = 0;
			}
		}
	}

	public virtual void spawnBloodSpurt(Vector3 startPos, Vector3 damageDirection, int quantity)
	{
		for (int i = 0; i < quantity; i++)
		{
			blood[nextBlood].life = UnityEngine.Random.Range(1.7f, 2.4f);
			blood[nextBlood].myTransform.position = startPos;
			blood[nextBlood].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(3.4f, 11f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			nextBlood++;
			if (nextBlood >= Extensions.get_length(blood))
			{
				nextBlood = 0;
			}
		}
	}

	public virtual void spawnRoofShatter(float startPos)
	{
		for (int i = 0; i < 18; i++)
		{
			glass[nextGlass].life = UnityEngine.Random.Range(2.2f, 2.9f);
			glass[nextGlass].myTransform.position = new Vector3(startPos, 0f, 0f);
			float y = -89.90675f;
			Vector3 localPosition = glass[nextGlass].myTransform.localPosition;
			float num = (localPosition.y = y);
			Vector3 vector2 = (glass[nextGlass].myTransform.localPosition = localPosition);
			float z = -0.3f;
			Vector3 localPosition2 = glass[nextGlass].myTransform.localPosition;
			float num2 = (localPosition2.z = z);
			Vector3 vector4 = (glass[nextGlass].myTransform.localPosition = localPosition2);
			glass[nextGlass].movement = new Vector3(UnityEngine.Random.Range(-4.5f, 4.5f), UnityEngine.Random.Range(1f, -4f), UnityEngine.Random.Range(-1.4f, 1.4f));
			glass[nextGlass].spin = UnityEngine.Random.Range(650f, 1750f);
			nextGlass++;
			if (nextGlass >= Extensions.get_length(glass))
			{
				nextGlass = 0;
			}
		}
	}

	public virtual void spawnCustom(Vector3 startPos, Vector3 damageDirection, int particleType, int howMany)
	{
		for (int i = 0; i < howMany; i++)
		{
			envParticles[particleType].theParticles[envParticles[particleType].nextMember].life = UnityEngine.Random.Range(1.3f, 2.2f);
			envParticles[particleType].theParticles[envParticles[particleType].nextMember].myTransform.position = startPos;
			envParticles[particleType].theParticles[envParticles[particleType].nextMember].movement = new Vector3(UnityEngine.Random.Range(-3.1f, 3.1f), UnityEngine.Random.Range(6.4f, 16f), UnityEngine.Random.Range(-1f, 1f)) + damageDirection;
			envParticles[particleType].theParticles[envParticles[particleType].nextMember].spin = UnityEngine.Random.Range(350f, 1550f);
			envParticles[particleType].nextMember = envParticles[particleType].nextMember + 1;
			if (envParticles[particleType].nextMember >= Extensions.get_length(envParticles[particleType].theParticles))
			{
				envParticles[particleType].nextMember = 0;
			}
		}
	}

	public virtual void ParticleAnimation()
	{
		for (int i = 0; i < Extensions.get_length(basicShells); i++)
		{
			if (basicShells[i].life <= 0f)
			{
				continue;
			}
			basicShells[i].life = basicShells[i].life - Time.deltaTime;
			if (!(basicShells[i].life > 0f))
			{
				basicShells[i].life = 0f;
				basicShells[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y = basicShells[i].myTransform.localPosition.y + basicShells[i].movement.y * Time.deltaTime;
			Vector3 localPosition = basicShells[i].myTransform.localPosition;
			float num = (localPosition.y = y);
			Vector3 vector2 = (basicShells[i].myTransform.localPosition = localPosition);
			float z = basicShells[i].myTransform.position.z + basicShells[i].movement.z * Time.deltaTime;
			Vector3 position = basicShells[i].myTransform.position;
			float num2 = (position.z = z);
			Vector3 vector4 = (basicShells[i].myTransform.position = position);
			float x = basicShells[i].myTransform.position.x + basicShells[i].movement.x * Time.deltaTime;
			Vector3 position2 = basicShells[i].myTransform.position;
			float num3 = (position2.x = x);
			Vector3 vector6 = (basicShells[i].myTransform.position = position2);
			basicShells[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), basicShells[i].spin * Time.deltaTime);
			basicShells[i].movement.y = basicShells[i].movement.y - Time.deltaTime * gravityConstant;
			if (!(basicShells[i].myTransform.position.y >= 0f))
			{
				int num4 = 0;
				Vector3 position3 = basicShells[i].myTransform.position;
				float num5 = (position3.y = num4);
				Vector3 vector8 = (basicShells[i].myTransform.position = position3);
				basicShells[i].movement.y = basicShells[i].movement.y * UnityEngine.Random.Range(-0.7f, -0.5f);
			}
		}
		for (int i = 0; i < Extensions.get_length(pins); i++)
		{
			if (pins[i].life <= 0f)
			{
				continue;
			}
			pins[i].life = pins[i].life - Time.deltaTime;
			if (!(pins[i].life > 0f))
			{
				pins[i].life = 0f;
				pins[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y2 = pins[i].myTransform.localPosition.y + pins[i].movement.y * Time.deltaTime;
			Vector3 localPosition2 = pins[i].myTransform.localPosition;
			float num6 = (localPosition2.y = y2);
			Vector3 vector10 = (pins[i].myTransform.localPosition = localPosition2);
			float z2 = pins[i].myTransform.position.z + pins[i].movement.z * Time.deltaTime;
			Vector3 position4 = pins[i].myTransform.position;
			float num7 = (position4.z = z2);
			Vector3 vector12 = (pins[i].myTransform.position = position4);
			float x2 = pins[i].myTransform.position.x + pins[i].movement.x * Time.deltaTime;
			Vector3 position5 = pins[i].myTransform.position;
			float num8 = (position5.x = x2);
			Vector3 vector14 = (pins[i].myTransform.position = position5);
			pins[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), pins[i].spin * Time.deltaTime);
			pins[i].movement.y = pins[i].movement.y - Time.deltaTime * gravityConstant;
			if (!(pins[i].myTransform.position.y >= 0f))
			{
				int num9 = 0;
				Vector3 position6 = pins[i].myTransform.position;
				float num10 = (position6.y = num9);
				Vector3 vector16 = (pins[i].myTransform.position = position6);
				pins[i].movement.y = pins[i].movement.y * UnityEngine.Random.Range(-0.7f, -0.5f);
			}
		}
		for (int i = 0; i < Extensions.get_length(shottyShells); i++)
		{
			if (shottyShells[i].life <= 0f)
			{
				continue;
			}
			shottyShells[i].life = shottyShells[i].life - Time.deltaTime;
			if (!(shottyShells[i].life > 0f))
			{
				shottyShells[i].life = 0f;
				shottyShells[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y3 = shottyShells[i].myTransform.localPosition.y + shottyShells[i].movement.y * Time.deltaTime;
			Vector3 localPosition3 = shottyShells[i].myTransform.localPosition;
			float num11 = (localPosition3.y = y3);
			Vector3 vector18 = (shottyShells[i].myTransform.localPosition = localPosition3);
			float z3 = shottyShells[i].myTransform.position.z + shottyShells[i].movement.z * Time.deltaTime;
			Vector3 position7 = shottyShells[i].myTransform.position;
			float num12 = (position7.z = z3);
			Vector3 vector20 = (shottyShells[i].myTransform.position = position7);
			float x3 = shottyShells[i].myTransform.position.x + shottyShells[i].movement.x * Time.deltaTime;
			Vector3 position8 = shottyShells[i].myTransform.position;
			float num13 = (position8.x = x3);
			Vector3 vector22 = (shottyShells[i].myTransform.position = position8);
			shottyShells[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), shottyShells[i].spin * Time.deltaTime);
			shottyShells[i].movement.y = shottyShells[i].movement.y - Time.deltaTime * gravityConstant;
			if (!(shottyShells[i].myTransform.position.y >= 0f))
			{
				int num14 = 0;
				Vector3 position9 = shottyShells[i].myTransform.position;
				float num15 = (position9.y = num14);
				Vector3 vector24 = (shottyShells[i].myTransform.position = position9);
				shottyShells[i].movement.y = shottyShells[i].movement.y * UnityEngine.Random.Range(-0.7f, -0.5f);
			}
		}
		for (int i = 0; i < Extensions.get_length(sniperShells); i++)
		{
			if (sniperShells[i].life <= 0f)
			{
				continue;
			}
			sniperShells[i].life = sniperShells[i].life - Time.deltaTime;
			if (!(sniperShells[i].life > 0f))
			{
				sniperShells[i].life = 0f;
				sniperShells[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y4 = sniperShells[i].myTransform.localPosition.y + sniperShells[i].movement.y * Time.deltaTime;
			Vector3 localPosition4 = sniperShells[i].myTransform.localPosition;
			float num16 = (localPosition4.y = y4);
			Vector3 vector26 = (sniperShells[i].myTransform.localPosition = localPosition4);
			float z4 = sniperShells[i].myTransform.position.z + sniperShells[i].movement.z * Time.deltaTime;
			Vector3 position10 = sniperShells[i].myTransform.position;
			float num17 = (position10.z = z4);
			Vector3 vector28 = (sniperShells[i].myTransform.position = position10);
			float x4 = sniperShells[i].myTransform.position.x + sniperShells[i].movement.x * Time.deltaTime;
			Vector3 position11 = sniperShells[i].myTransform.position;
			float num18 = (position11.x = x4);
			Vector3 vector30 = (sniperShells[i].myTransform.position = position11);
			sniperShells[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), sniperShells[i].spin * Time.deltaTime);
			sniperShells[i].movement.y = sniperShells[i].movement.y - Time.deltaTime * gravityConstant;
			if (!(sniperShells[i].myTransform.position.y >= 0f))
			{
				int num19 = 0;
				Vector3 position12 = sniperShells[i].myTransform.position;
				float num20 = (position12.y = num19);
				Vector3 vector32 = (sniperShells[i].myTransform.position = position12);
				sniperShells[i].movement.y = sniperShells[i].movement.y * UnityEngine.Random.Range(-0.7f, -0.5f);
			}
		}
		for (int i = 0; i < Extensions.get_length(blood); i++)
		{
			if (blood[i].life <= 0f)
			{
				continue;
			}
			blood[i].life = blood[i].life - Time.deltaTime;
			if (!(blood[i].life > 0f))
			{
				blood[i].life = 0f;
				blood[i].myTransform.position = new Vector3(0f, 50f, 0f);
				blood[i].puddle.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y5 = blood[i].myTransform.localPosition.y + blood[i].movement.y * Time.deltaTime;
			Vector3 localPosition5 = blood[i].myTransform.localPosition;
			float num21 = (localPosition5.y = y5);
			Vector3 vector34 = (blood[i].myTransform.localPosition = localPosition5);
			float z5 = blood[i].myTransform.position.z + blood[i].movement.z * Time.deltaTime;
			Vector3 position13 = blood[i].myTransform.position;
			float num22 = (position13.z = z5);
			Vector3 vector36 = (blood[i].myTransform.position = position13);
			float x5 = blood[i].myTransform.position.x + blood[i].movement.x * Time.deltaTime;
			Vector3 position14 = blood[i].myTransform.position;
			float num23 = (position14.x = x5);
			Vector3 vector38 = (blood[i].myTransform.position = position14);
			if (blood[i].movement != new Vector3(0f, 0f, 0f))
			{
				blood[i].movement.y = blood[i].movement.y - Time.deltaTime * gravityConstant;
				rotationHelper.rotation = Quaternion.LookRotation(new Vector3(blood[i].movement.x, blood[i].movement.y, 0f));
				if (!(blood[i].movement.x <= 0f))
				{
					float x6 = rotationHelper.localEulerAngles.x;
					Vector3 localEulerAngles = blood[i].myTransform.localEulerAngles;
					float num24 = (localEulerAngles.z = x6);
					Vector3 vector40 = (blood[i].myTransform.localEulerAngles = localEulerAngles);
				}
				else
				{
					float z6 = 0f - rotationHelper.localEulerAngles.x + 180f;
					Vector3 localEulerAngles2 = blood[i].myTransform.localEulerAngles;
					float num25 = (localEulerAngles2.z = z6);
					Vector3 vector42 = (blood[i].myTransform.localEulerAngles = localEulerAngles2);
				}
			}
			if (!(blood[i].myTransform.position.y >= 0f))
			{
				int num26 = 0;
				Vector3 position15 = blood[i].myTransform.position;
				float num27 = (position15.y = num26);
				Vector3 vector44 = (blood[i].myTransform.position = position15);
				blood[i].puddle.position = blood[i].myTransform.position;
				int num28 = 100;
				Vector3 position16 = blood[i].myTransform.position;
				float num29 = (position16.y = num28);
				Vector3 vector46 = (blood[i].myTransform.position = position16);
				blood[i].movement = new Vector3(0f, 0f, 0f);
			}
		}
		for (int i = 0; i < Extensions.get_length(meat); i++)
		{
			if (meat[i].life <= 0f)
			{
				continue;
			}
			meat[i].life = meat[i].life - Time.deltaTime;
			if (!(meat[i].life > 0f))
			{
				meat[i].life = 0f;
				meat[i].myTransform.position = new Vector3(0f, 50f, 0f);
				meat[i].puddle.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y6 = meat[i].myTransform.localPosition.y + meat[i].movement.y * Time.deltaTime;
			Vector3 localPosition6 = meat[i].myTransform.localPosition;
			float num30 = (localPosition6.y = y6);
			Vector3 vector48 = (meat[i].myTransform.localPosition = localPosition6);
			float z7 = meat[i].myTransform.position.z + meat[i].movement.z * Time.deltaTime;
			Vector3 position17 = meat[i].myTransform.position;
			float num31 = (position17.z = z7);
			Vector3 vector50 = (meat[i].myTransform.position = position17);
			float x7 = meat[i].myTransform.position.x + meat[i].movement.x * Time.deltaTime;
			Vector3 position18 = meat[i].myTransform.position;
			float num32 = (position18.x = x7);
			Vector3 vector52 = (meat[i].myTransform.position = position18);
			if (meat[i].movement != new Vector3(0f, 0f, 0f))
			{
				meat[i].movement.y = meat[i].movement.y - Time.deltaTime * gravityConstant;
				meat[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), meat[i].spin * Time.deltaTime);
			}
			if (!(meat[i].myTransform.position.y >= 0f))
			{
				int num33 = 0;
				Vector3 position19 = meat[i].myTransform.position;
				float num34 = (position19.y = num33);
				Vector3 vector54 = (meat[i].myTransform.position = position19);
				meat[i].puddle.position = meat[i].myTransform.position;
				int num35 = 100;
				Vector3 position20 = meat[i].myTransform.position;
				float num36 = (position20.y = num35);
				Vector3 vector56 = (meat[i].myTransform.position = position20);
				meat[i].movement = new Vector3(0f, 0f, 0f);
			}
		}
		for (int i = 0; i < Extensions.get_length(bone); i++)
		{
			if (bone[i].life <= 0f)
			{
				continue;
			}
			bone[i].life = bone[i].life - Time.deltaTime;
			if (!(bone[i].life > 0f))
			{
				bone[i].life = 0f;
				bone[i].myTransform.position = new Vector3(0f, 50f, 0f);
				bone[i].puddle.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y7 = bone[i].myTransform.localPosition.y + bone[i].movement.y * Time.deltaTime;
			Vector3 localPosition7 = bone[i].myTransform.localPosition;
			float num37 = (localPosition7.y = y7);
			Vector3 vector58 = (bone[i].myTransform.localPosition = localPosition7);
			float z8 = bone[i].myTransform.position.z + bone[i].movement.z * Time.deltaTime;
			Vector3 position21 = bone[i].myTransform.position;
			float num38 = (position21.z = z8);
			Vector3 vector60 = (bone[i].myTransform.position = position21);
			float x8 = bone[i].myTransform.position.x + bone[i].movement.x * Time.deltaTime;
			Vector3 position22 = bone[i].myTransform.position;
			float num39 = (position22.x = x8);
			Vector3 vector62 = (bone[i].myTransform.position = position22);
			if (bone[i].movement != new Vector3(0f, 0f, 0f))
			{
				bone[i].movement.y = bone[i].movement.y - Time.deltaTime * gravityConstant;
				bone[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), bone[i].spin * Time.deltaTime);
			}
			if (!(bone[i].myTransform.position.y >= 0f))
			{
				int num40 = 0;
				Vector3 position23 = bone[i].myTransform.position;
				float num41 = (position23.y = num40);
				Vector3 vector64 = (bone[i].myTransform.position = position23);
				bone[i].movement.y = bone[i].movement.y * UnityEngine.Random.Range(-0.65f, -0.35f);
			}
		}
		for (int i = 0; i < Extensions.get_length(teeth); i++)
		{
			if (teeth[i].life <= 0f)
			{
				continue;
			}
			teeth[i].life = teeth[i].life - Time.deltaTime;
			if (!(teeth[i].life > 0f))
			{
				teeth[i].life = 0f;
				teeth[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y8 = teeth[i].myTransform.localPosition.y + teeth[i].movement.y * Time.deltaTime;
			Vector3 localPosition8 = teeth[i].myTransform.localPosition;
			float num42 = (localPosition8.y = y8);
			Vector3 vector66 = (teeth[i].myTransform.localPosition = localPosition8);
			float z9 = teeth[i].myTransform.position.z + teeth[i].movement.z * Time.deltaTime;
			Vector3 position24 = teeth[i].myTransform.position;
			float num43 = (position24.z = z9);
			Vector3 vector68 = (teeth[i].myTransform.position = position24);
			float x9 = teeth[i].myTransform.position.x + teeth[i].movement.x * Time.deltaTime;
			Vector3 position25 = teeth[i].myTransform.position;
			float num44 = (position25.x = x9);
			Vector3 vector70 = (teeth[i].myTransform.position = position25);
			teeth[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), teeth[i].spin * Time.deltaTime);
			teeth[i].movement.y = teeth[i].movement.y - Time.deltaTime * gravityConstant;
			if (!(teeth[i].myTransform.position.y >= 0f))
			{
				int num45 = 0;
				Vector3 position26 = teeth[i].myTransform.position;
				float num46 = (position26.y = num45);
				Vector3 vector72 = (teeth[i].myTransform.position = position26);
				teeth[i].movement.y = teeth[i].movement.y * UnityEngine.Random.Range(-0.8f, -0.35f);
			}
		}
		for (int i = 0; i < Extensions.get_length(ashes); i++)
		{
			if (ashes[i].life <= 0f)
			{
				continue;
			}
			ashes[i].life = ashes[i].life - Time.deltaTime;
			if (!(ashes[i].life > 0f))
			{
				ashes[i].life = 0f;
				ashes[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y9 = ashes[i].myTransform.localPosition.y + ashes[i].movement.y * Time.deltaTime;
			Vector3 localPosition9 = ashes[i].myTransform.localPosition;
			float num47 = (localPosition9.y = y9);
			Vector3 vector74 = (ashes[i].myTransform.localPosition = localPosition9);
			float z10 = ashes[i].myTransform.position.z + ashes[i].movement.z * Time.deltaTime;
			Vector3 position27 = ashes[i].myTransform.position;
			float num48 = (position27.z = z10);
			Vector3 vector76 = (ashes[i].myTransform.position = position27);
			float x10 = ashes[i].myTransform.position.x + ashes[i].movement.x * Time.deltaTime;
			Vector3 position28 = ashes[i].myTransform.position;
			float num49 = (position28.x = x10);
			Vector3 vector78 = (ashes[i].myTransform.position = position28);
			if (ashes[i].movement != new Vector3(0f, 0f, 0f))
			{
				ashes[i].movement.y = ashes[i].movement.y - Time.deltaTime * gravityConstant;
				ashes[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), ashes[i].spin * Time.deltaTime);
			}
			if (!(ashes[i].myTransform.position.y >= 0f))
			{
				int num50 = 0;
				Vector3 position29 = ashes[i].myTransform.position;
				float num51 = (position29.y = num50);
				Vector3 vector80 = (ashes[i].myTransform.position = position29);
				ashes[i].movement.y = ashes[i].movement.y * UnityEngine.Random.Range(-0.75f, -0.45f);
			}
		}
		for (int i = 0; i < Extensions.get_length(iceBig); i++)
		{
			if (iceBig[i].life <= 0f)
			{
				continue;
			}
			iceBig[i].life = iceBig[i].life - Time.deltaTime;
			if (!(iceBig[i].life > 0f))
			{
				iceBig[i].life = 0f;
				iceBig[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y10 = iceBig[i].myTransform.localPosition.y + iceBig[i].movement.y * Time.deltaTime;
			Vector3 localPosition10 = iceBig[i].myTransform.localPosition;
			float num52 = (localPosition10.y = y10);
			Vector3 vector82 = (iceBig[i].myTransform.localPosition = localPosition10);
			float z11 = iceBig[i].myTransform.position.z + iceBig[i].movement.z * Time.deltaTime;
			Vector3 position30 = iceBig[i].myTransform.position;
			float num53 = (position30.z = z11);
			Vector3 vector84 = (iceBig[i].myTransform.position = position30);
			float x11 = iceBig[i].myTransform.position.x + iceBig[i].movement.x * Time.deltaTime;
			Vector3 position31 = iceBig[i].myTransform.position;
			float num54 = (position31.x = x11);
			Vector3 vector86 = (iceBig[i].myTransform.position = position31);
			if (iceBig[i].movement != new Vector3(0f, 0f, 0f))
			{
				iceBig[i].movement.y = iceBig[i].movement.y - Time.deltaTime * gravityConstant;
				iceBig[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), iceBig[i].spin * Time.deltaTime);
			}
			if (!(iceBig[i].myTransform.position.y >= 0f))
			{
				int num55 = 0;
				Vector3 position32 = iceBig[i].myTransform.position;
				float num56 = (position32.y = num55);
				Vector3 vector88 = (iceBig[i].myTransform.position = position32);
				iceBig[i].movement.y = iceBig[i].movement.y * UnityEngine.Random.Range(-0.75f, -0.45f);
			}
		}
		for (int i = 0; i < Extensions.get_length(iceSmall); i++)
		{
			if (iceSmall[i].life <= 0f)
			{
				continue;
			}
			iceSmall[i].life = iceSmall[i].life - Time.deltaTime;
			if (!(iceSmall[i].life > 0f))
			{
				iceSmall[i].life = 0f;
				iceSmall[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y11 = iceSmall[i].myTransform.localPosition.y + iceSmall[i].movement.y * Time.deltaTime;
			Vector3 localPosition11 = iceSmall[i].myTransform.localPosition;
			float num57 = (localPosition11.y = y11);
			Vector3 vector90 = (iceSmall[i].myTransform.localPosition = localPosition11);
			float z12 = iceSmall[i].myTransform.position.z + iceSmall[i].movement.z * Time.deltaTime;
			Vector3 position33 = iceSmall[i].myTransform.position;
			float num58 = (position33.z = z12);
			Vector3 vector92 = (iceSmall[i].myTransform.position = position33);
			float x12 = iceSmall[i].myTransform.position.x + iceSmall[i].movement.x * Time.deltaTime;
			Vector3 position34 = iceSmall[i].myTransform.position;
			float num59 = (position34.x = x12);
			Vector3 vector94 = (iceSmall[i].myTransform.position = position34);
			if (iceSmall[i].movement != new Vector3(0f, 0f, 0f))
			{
				iceSmall[i].movement.y = iceSmall[i].movement.y - Time.deltaTime * gravityConstant;
				iceSmall[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), iceSmall[i].spin * Time.deltaTime);
			}
			if (!(iceSmall[i].myTransform.position.y >= 0f))
			{
				int num60 = 0;
				Vector3 position35 = iceSmall[i].myTransform.position;
				float num61 = (position35.y = num60);
				Vector3 vector96 = (iceSmall[i].myTransform.position = position35);
				iceSmall[i].movement.y = iceSmall[i].movement.y * UnityEngine.Random.Range(-0.75f, -0.45f);
			}
		}
		for (int i = 0; i < Extensions.get_length(pebbles); i++)
		{
			if (pebbles[i].life <= 0f)
			{
				continue;
			}
			pebbles[i].life = pebbles[i].life - Time.deltaTime;
			if (!(pebbles[i].life > 0f))
			{
				pebbles[i].life = 0f;
				pebbles[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y12 = pebbles[i].myTransform.localPosition.y + pebbles[i].movement.y * Time.deltaTime;
			Vector3 localPosition12 = pebbles[i].myTransform.localPosition;
			float num62 = (localPosition12.y = y12);
			Vector3 vector98 = (pebbles[i].myTransform.localPosition = localPosition12);
			float z13 = pebbles[i].myTransform.position.z + pebbles[i].movement.z * Time.deltaTime;
			Vector3 position36 = pebbles[i].myTransform.position;
			float num63 = (position36.z = z13);
			Vector3 vector100 = (pebbles[i].myTransform.position = position36);
			float x13 = pebbles[i].myTransform.position.x + pebbles[i].movement.x * Time.deltaTime;
			Vector3 position37 = pebbles[i].myTransform.position;
			float num64 = (position37.x = x13);
			Vector3 vector102 = (pebbles[i].myTransform.position = position37);
			if (pebbles[i].movement != new Vector3(0f, 0f, 0f))
			{
				pebbles[i].movement.y = pebbles[i].movement.y - Time.deltaTime * gravityConstant;
				pebbles[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), pebbles[i].spin * Time.deltaTime);
			}
			if (!(pebbles[i].myTransform.position.y >= 0f))
			{
				int num65 = 0;
				Vector3 position38 = pebbles[i].myTransform.position;
				float num66 = (position38.y = num65);
				Vector3 vector104 = (pebbles[i].myTransform.position = position38);
				pebbles[i].movement.y = pebbles[i].movement.y * UnityEngine.Random.Range(-0.75f, -0.45f);
			}
		}
		for (int i = 0; i < Extensions.get_length(dirt); i++)
		{
			if (!(dirt[i].life <= 0f))
			{
				dirt[i].life = dirt[i].life - Time.deltaTime;
				if (!(dirt[i].life > 0.5f))
				{
					float a = dirt[i].rend.material.color.a - Time.deltaTime * 2f;
					Color color = dirt[i].rend.material.color;
					float num67 = (color.a = a);
					Color color3 = (dirt[i].rend.material.color = color);
				}
				if (!(dirt[i].life > 0f))
				{
					int num68 = 100;
					Vector3 position39 = dirt[i].tran.position;
					float num69 = (position39.y = num68);
					Vector3 vector106 = (dirt[i].tran.position = position39);
				}
			}
		}
		for (int i = 0; i < Extensions.get_length(glass); i++)
		{
			if (glass[i].life <= 0f)
			{
				continue;
			}
			glass[i].life = glass[i].life - Time.deltaTime;
			if (!(glass[i].life > 0f))
			{
				glass[i].life = 0f;
				glass[i].myTransform.position = new Vector3(0f, 50f, 0f);
				continue;
			}
			float y13 = glass[i].myTransform.localPosition.y + glass[i].movement.y * Time.deltaTime;
			Vector3 localPosition13 = glass[i].myTransform.localPosition;
			float num70 = (localPosition13.y = y13);
			Vector3 vector108 = (glass[i].myTransform.localPosition = localPosition13);
			float z14 = glass[i].myTransform.position.z + glass[i].movement.z * Time.deltaTime;
			Vector3 position40 = glass[i].myTransform.position;
			float num71 = (position40.z = z14);
			Vector3 vector110 = (glass[i].myTransform.position = position40);
			float x14 = glass[i].myTransform.position.x + glass[i].movement.x * Time.deltaTime;
			Vector3 position41 = glass[i].myTransform.position;
			float num72 = (position41.x = x14);
			Vector3 vector112 = (glass[i].myTransform.position = position41);
			if (glass[i].movement != new Vector3(0f, 0f, 0f))
			{
				glass[i].movement.y = glass[i].movement.y - Time.deltaTime * gravityConstant;
				glass[i].myTransform.Rotate(new Vector3(0f, 0f, 1f), glass[i].spin * Time.deltaTime);
			}
			if (!(glass[i].myTransform.position.y >= 0f))
			{
				int num73 = 0;
				Vector3 position42 = glass[i].myTransform.position;
				float num74 = (position42.y = num73);
				Vector3 vector114 = (glass[i].myTransform.position = position42);
				glass[i].movement.y = glass[i].movement.y * UnityEngine.Random.Range(-0.75f, -0.35f);
			}
		}
		for (int i = 0; i < Extensions.get_length(envParticles); i++)
		{
			if (envParticles[i].inUse)
			{
				for (int j = 0; j < 5; j++)
				{
					if (envParticles[i].theParticles[j].life <= 0f)
					{
						continue;
					}
					envParticles[i].theParticles[j].life = envParticles[i].theParticles[j].life - Time.deltaTime;
					if (!(envParticles[i].theParticles[j].life > 0f))
					{
						envParticles[i].theParticles[j].life = 0f;
						envParticles[i].theParticles[j].myTransform.position = new Vector3(0f, 50f, 0f);
						continue;
					}
					float y14 = envParticles[i].theParticles[j].myTransform.localPosition.y + envParticles[i].theParticles[j].movement.y * Time.deltaTime;
					Vector3 localPosition14 = envParticles[i].theParticles[j].myTransform.localPosition;
					float num75 = (localPosition14.y = y14);
					Vector3 vector116 = (envParticles[i].theParticles[j].myTransform.localPosition = localPosition14);
					float z15 = envParticles[i].theParticles[j].myTransform.position.z + envParticles[i].theParticles[j].movement.z * Time.deltaTime;
					Vector3 position43 = envParticles[i].theParticles[j].myTransform.position;
					float num76 = (position43.z = z15);
					Vector3 vector118 = (envParticles[i].theParticles[j].myTransform.position = position43);
					float x15 = envParticles[i].theParticles[j].myTransform.position.x + envParticles[i].theParticles[j].movement.x * Time.deltaTime;
					Vector3 position44 = envParticles[i].theParticles[j].myTransform.position;
					float num77 = (position44.x = x15);
					Vector3 vector120 = (envParticles[i].theParticles[j].myTransform.position = position44);
					if (envParticles[i].theParticles[j].movement != new Vector3(0f, 0f, 0f))
					{
						envParticles[i].theParticles[j].movement.y = envParticles[i].theParticles[j].movement.y - Time.deltaTime * gravityConstant;
						envParticles[i].theParticles[j].myTransform.Rotate(new Vector3(0f, 0f, 1f), envParticles[i].theParticles[j].spin * Time.deltaTime);
					}
					if (!(envParticles[i].theParticles[j].myTransform.position.y >= 0f))
					{
						int num78 = 0;
						Vector3 position45 = envParticles[i].theParticles[j].myTransform.position;
						float num79 = (position45.y = num78);
						Vector3 vector122 = (envParticles[i].theParticles[j].myTransform.position = position45);
						envParticles[i].theParticles[j].movement.y = envParticles[i].theParticles[j].movement.y * UnityEngine.Random.Range(-0.75f, -0.55f);
					}
				}
			}
			else
			{
				i = Extensions.get_length(envParticles);
			}
		}
	}

	public virtual IEnumerator Spawn()
	{
		return new _0024Spawn_00241669(this).GetEnumerator();
	}

	public virtual void spawnSync(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		activeEnemies++;
		nextZombie = UnityBuiltins.parseInt(array[0]);
		zombies[nextZombie].myTransform.position = new Vector3(UnityBuiltins.parseFloat(array[1]), 0f, UnityBuiltins.parseFloat(array[2]));
		zombies[nextZombie].reset();
		if (array[3] == "1")
		{
			zombies[nextZombie].myTarget = allyScript.myTransform;
			zombies[nextZombie].myTargetScript = allyScript;
		}
		else if (array[3] == "2")
		{
			zombies[nextZombie].myTarget = playerScript.myTransform;
			zombies[nextZombie].myTargetScript = playerScript;
		}
		if ((bool)zombies[nextZombie].myTarget && !(zombies[nextZombie].myTarget.position.x <= zombies[nextZombie].myTransform.position.x) && zombies[nextZombie].myTransform.localScale.x != 1f)
		{
			int num = 1;
			Vector3 localScale = zombies[nextZombie].myTransform.localScale;
			float num2 = (localScale.x = num);
			Vector3 vector2 = (zombies[nextZombie].myTransform.localScale = localScale);
		}
		else if ((bool)zombies[nextZombie].myTarget && !(zombies[nextZombie].myTarget.position.x >= zombies[nextZombie].myTransform.position.x) && zombies[nextZombie].myTransform.localScale.x != -1f)
		{
			int num3 = -1;
			Vector3 localScale2 = zombies[nextZombie].myTransform.localScale;
			float num4 = (localScale2.x = num3);
			Vector3 vector4 = (zombies[nextZombie].myTransform.localScale = localScale2);
		}
		if (array[4] == "1")
		{
			groundEruption(zombies[nextZombie].myTransform.position, zombies[nextZombie].myTransform.localScale.x);
			StartCoroutine(zombies[nextZombie].emerge());
		}
	}

	public virtual void debugTools()
	{
		if (Input.GetKey("z"))
		{
			Time.timeScale = 0.05f;
		}
		if (Input.GetKey("x"))
		{
			Time.timeScale = 1f;
		}
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

	public virtual void listen()
	{
		if ((bool)allyScript)
		{
			int num = 0;
			for (num = 0; num <= 2; num++)
			{
				if (messages[num].text != string.Empty)
				{
					allyScript.syncShot(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 3; num <= 4; num++)
			{
				if (messages[num].text != string.Empty)
				{
					allyScript.sync(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 5; num <= 7; num++)
			{
				if (messages[num].text != string.Empty)
				{
					allyScript.syncSimpleShot(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 8; num <= 10; num++)
			{
				if (messages[num].text != string.Empty)
				{
					ZombieSync(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 11; num <= 12; num++)
			{
				if (messages[num].text != string.Empty)
				{
					allyScript.syncExplosion(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 13; num <= 19; num++)
			{
				if (messages[num].text != string.Empty)
				{
					string[] array = messages[num].text.Split(" "[0]);
					int num2 = UnityBuiltins.parseInt(array[0]);
					zombies[num2].syncAttack(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 20; num <= 22; num++)
			{
				if (messages[num].text != string.Empty)
				{
					spawnSync(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			if (messages[23].text != string.Empty)
			{
				syncBuildings(messages[23].text.ToString());
				messages[23].text = string.Empty;
			}
			if (messages[24].text != string.Empty)
			{
				syncAlleys(messages[24].text.ToString());
				messages[24].text = string.Empty;
			}
			if (messages[25].text != string.Empty)
			{
				syncClutter(messages[25].text.ToString());
				messages[25].text = string.Empty;
			}
			if (messages[26].text != string.Empty && zombiesLoaded)
			{
				syncDestructibles(messages[26].text.ToString());
				messages[26].text = string.Empty;
			}
			for (num = 27; num <= 30; num++)
			{
				if (messages[num].text != string.Empty)
				{
					syncPickup(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 31; num <= 33; num++)
			{
				if (messages[num].text != string.Empty)
				{
					despawnPickup(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 34; num <= 35; num++)
			{
				if (messages[num].text != string.Empty)
				{
					allyScript.killWeaponLoop(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 36; num <= 38; num++)
			{
				if (messages[num].text != string.Empty)
				{
					string[] array = messages[num].text.Split(" "[0]);
					int num2 = UnityBuiltins.parseInt(array[0]);
					StartCoroutine(zombies[num2].syncSpit(messages[num].text.ToString()));
					messages[num].text = string.Empty;
				}
			}
			for (num = 39; num <= 40; num++)
			{
				if (messages[num].text != string.Empty)
				{
					string[] array = messages[num].text.Split(" "[0]);
					int num2 = UnityBuiltins.parseInt(array[0]);
					zombies[num2].syncDetonate(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			for (num = 41; num <= 44; num++)
			{
				if (messages[num].text != string.Empty)
				{
					int num2 = UnityBuiltins.parseInt(messages[num].text);
					zombies[num2].changeOwnership(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			if ((bool)allyScript && messages[45].text != string.Empty)
			{
				StartCoroutine(allyScript.die(string.Empty));
				messages[45].text = string.Empty;
			}
			if (messages[46].text != string.Empty)
			{
				spawnHelicopter(messages[46].text.ToString());
				messages[46].text = string.Empty;
			}
			if ((bool)allyScript && messages[47].text != string.Empty)
			{
				StartCoroutine(allyScript.grabHelicopter(string.Empty));
				messages[47].text = string.Empty;
			}
			if (messages[48].text != string.Empty)
			{
				learnAllyScore(messages[48].text.ToString());
				messages[48].text = string.Empty;
			}
			if ((bool)allyScript && messages[49].text != string.Empty)
			{
				allyScript.enterVehicle(messages[49].text.ToString());
				messages[49].text = string.Empty;
			}
			for (num = 50; num <= 53; num++)
			{
				if (messages[num].text != string.Empty)
				{
					allyScript.syncVehicularManslaughter(messages[num].text.ToString());
					messages[num].text = string.Empty;
				}
			}
			if ((bool)allyScript && messages[54].text != string.Empty)
			{
				allyScript.explodeVehicle(messages[54].text.ToString());
				messages[54].text = string.Empty;
			}
			if ((bool)allyScript && messages[58].text != string.Empty)
			{
				allyScript.syncEquip(messages[58].text.ToString());
				messages[58].text = string.Empty;
			}
			if ((bool)allyScript && messages[59].text != string.Empty)
			{
				allyScript.syncEquip(messages[59].text.ToString());
				messages[59].text = string.Empty;
			}
			if ((bool)allyScript && messages[60].text != string.Empty)
			{
				allyScript.syncHeal(messages[60].text.ToString());
				messages[60].text = string.Empty;
			}
			if ((bool)allyScript && messages[61].text != string.Empty)
			{
				allyScript.syncHeal(messages[61].text.ToString());
				messages[61].text = string.Empty;
			}
			if ((bool)allyScript && messages[62].text != string.Empty)
			{
				allyScript.syncAimRelease(messages[62].text.ToString());
				messages[62].text = string.Empty;
			}
			if ((bool)allyScript && messages[63].text != string.Empty)
			{
				allyScript.syncAimRelease(messages[63].text.ToString());
				messages[63].text = string.Empty;
			}
		}
		if (messages[56].text != string.Empty)
		{
			spawnOtherPlayer(messages[56].text.ToString());
			messages[56].text = string.Empty;
		}
		if (messages[55].text != string.Empty)
		{
			placeVehicles(messages[55].text.ToString());
			messages[55].text = string.Empty;
		}
		if (messages[57].text != string.Empty)
		{
			iGotTheWorld(string.Empty);
			messages[57].text = string.Empty;
		}
		if (messages[64].text != string.Empty)
		{
			int num3 = UnityBuiltins.parseInt(messages[64].text);
			zombies[num3].despawn(string.Empty);
			messages[64].text = string.Empty;
		}
		if (messages[65].text != string.Empty)
		{
			int num3 = UnityBuiltins.parseInt(messages[65].text);
			zombies[num3].despawn(string.Empty);
			messages[65].text = string.Empty;
		}
		if (messages[66].text != string.Empty)
		{
			int num3 = UnityBuiltins.parseInt(messages[66].text);
			zombies[num3].despawn(string.Empty);
			messages[66].text = string.Empty;
		}
	}

	public virtual void createEnvironment()
	{
		environmentExists = true;
		if (cameraHorizontalBounds.x == 0f)
		{
			cameraHorizontalBounds.x = -10f;
			characterHorizontalBounds.x = -10f;
		}
		cameraVerticalBounds = DB.environments[(int)DB.location].cameraVerticalBounds;
		characterVerticalBounds = DB.environments[(int)DB.location].characterVerticalBounds;
		basicFloorSize = DB.environments[(int)DB.location].basicFloorSize;
		groundPieces = new Transform[3];
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].basicFloorPiece));
		groundPieces[0] = tempGO.transform;
		float x = groundPieces[0].position.x - basicFloorSize;
		Vector3 position = groundPieces[0].position;
		float num = (position.x = x);
		Vector3 vector2 = (groundPieces[0].position = position);
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].basicFloorPiece));
		groundPieces[1] = tempGO.transform;
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].basicFloorPiece));
		groundPieces[2] = tempGO.transform;
		float x2 = groundPieces[2].position.x + basicFloorSize;
		Vector3 position2 = groundPieces[2].position;
		float num2 = (position2.x = x2);
		Vector3 vector4 = (groundPieces[2].position = position2);
		FGSize = DB.environments[(int)DB.location].FGSize;
		FGPieces = new Transform[3];
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].FGPiece));
		FGPieces[0] = tempGO.transform;
		float x3 = FGPieces[0].position.x - FGSize;
		Vector3 position3 = FGPieces[0].position;
		float num3 = (position3.x = x3);
		Vector3 vector6 = (FGPieces[0].position = position3);
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].FGPiece));
		FGPieces[1] = tempGO.transform;
		tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].FGPiece));
		FGPieces[2] = tempGO.transform;
		float x4 = FGPieces[2].position.x + FGSize;
		Vector3 position4 = FGPieces[2].position;
		float num4 = (position4.x = x4);
		Vector3 vector8 = (FGPieces[2].position = position4);
		SkylineSize = DB.environments[(int)DB.location].SkylineSize;
		SkylinePieces = new Transform[3];
		if (DB.environments[(int)DB.location].SkylinePiece != string.Empty)
		{
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].SkylinePiece));
			SkylinePieces[0] = tempGO.transform;
			float x5 = SkylinePieces[0].position.x - SkylineSize;
			Vector3 position5 = SkylinePieces[0].position;
			float num5 = (position5.x = x5);
			Vector3 vector10 = (SkylinePieces[0].position = position5);
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].SkylinePiece));
			SkylinePieces[1] = tempGO.transform;
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].SkylinePiece));
			SkylinePieces[2] = tempGO.transform;
			float x6 = SkylinePieces[2].position.x + SkylineSize;
			Vector3 position6 = SkylinePieces[2].position;
			float num6 = (position6.x = x6);
			Vector3 vector12 = (SkylinePieces[2].position = position6);
		}
		cloudSize = DB.environments[(int)DB.location].cloudSize;
		cloudPieces = new Transform[3];
		if (DB.environments[(int)DB.location].cloudPiece != string.Empty)
		{
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].cloudPiece));
			cloudPieces[0] = tempGO.transform;
			float x7 = cloudPieces[0].position.x - cloudSize;
			Vector3 position7 = cloudPieces[0].position;
			float num7 = (position7.x = x7);
			Vector3 vector14 = (cloudPieces[0].position = position7);
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].cloudPiece));
			cloudPieces[1] = tempGO.transform;
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].cloudPiece));
			cloudPieces[2] = tempGO.transform;
			float x8 = cloudPieces[2].position.x + cloudSize;
			Vector3 position8 = cloudPieces[2].position;
			float num8 = (position8.x = x8);
			Vector3 vector16 = (cloudPieces[2].position = position8);
		}
		if (DB.environments[(int)DB.location].backdrop != string.Empty)
		{
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].backdrop));
			backdrop = tempGO.transform;
		}
		for (int i = 0; i < Extensions.get_length(DB.environments[(int)DB.location].customParticles); i++)
		{
			envParticles[i].inUse = true;
			for (int j = 0; j < 5; j++)
			{
				tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].customParticles[i]));
				envParticles[i].theParticles[j].myTransform = tempGO.transform;
			}
		}
		int num9 = 30;
		for (int i = 0; i < Extensions.get_length(DB.environments[(int)DB.location].destructibles); i++)
		{
			for (int j = 0; j < 5; j++)
			{
				tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].destructibles[i]));
				zombies[num9] = (ZombieScript)tempGO.GetComponent(typeof(ZombieScript));
				tempGO.transform.name = num9.ToString();
				num9++;
			}
		}
		destructiblesLoaded = true;
		if (DB.whichPlayerAmI == 1)
		{
			placeVehicles(string.Empty);
			spawnLevelChunk();
		}
	}

	public virtual void SpawnNextChunk()
	{
		if (playerScript.myTransform.position.x > characterHorizontalBounds.y - 7f || ((bool)allyScript && !(allyScript.myTransform.position.x <= characterHorizontalBounds.y - 7f)))
		{
			spawnLevelChunk();
		}
	}

	public virtual void placeVehicles(string incomingData)
	{
		if (incomingData != string.Empty)
		{
			string[] array = incomingData.Split(" "[0]);
			for (int i = 0; i < Extensions.get_length(array); i += 3)
			{
				int num = UnityBuiltins.parseInt(array[i]);
				float num2 = UnityBuiltins.parseFloat(array[i + 1]);
				float num3 = UnityBuiltins.parseFloat(array[i + 2]);
				float x = num2;
				Vector3 position = vehicles[num].myTransform.position;
				float num4 = (position.x = x);
				Vector3 vector2 = (vehicles[num].myTransform.position = position);
				float z = num3;
				Vector3 position2 = vehicles[num].myTransform.position;
				float num5 = (position2.z = z);
				Vector3 vector4 = (vehicles[num].myTransform.position = position2);
				vehicles[num].inUse = true;
			}
		}
		if (DB.multiplayer && incomingData == string.Empty)
		{
			string empty = string.Empty;
			int num6 = UnityEngine.Random.Range(0, 4);
			empty = num6.ToString();
			vehicles[num6].inUse = true;
			float x2 = UnityEngine.Random.Range(30f, 100f);
			Vector3 position3 = vehicles[num6].myTransform.position;
			float num7 = (position3.x = x2);
			Vector3 vector6 = (vehicles[num6].myTransform.position = position3);
			empty = empty + " " + vehicles[num6].myTransform.position.x + " " + vehicles[num6].myTransform.position.z;
			Vector3 position4 = vehicles[num6].myTransform.position;
			while (vehicles[num6].inUse)
			{
				num6 = UnityEngine.Random.Range(0, 4);
			}
			vehicles[num6].inUse = true;
			vehicles[num6].myTransform.position = position4 - new Vector3(2f, 0f, 3f);
			empty = empty + " " + num6 + " " + vehicles[num6].myTransform.position.x + " " + vehicles[num6].myTransform.position.z;
			while (vehicles[num6].inUse)
			{
				num6 = UnityEngine.Random.Range(0, 4);
			}
			vehicles[num6].inUse = true;
			float x3 = position4.x + UnityEngine.Random.Range(170f, 260f);
			Vector3 position5 = vehicles[num6].myTransform.position;
			float num8 = (position5.x = x3);
			Vector3 vector8 = (vehicles[num6].myTransform.position = position5);
			position4 = vehicles[num6].myTransform.position;
			empty = empty + " " + num6 + " " + vehicles[num6].myTransform.position.x + " " + vehicles[num6].myTransform.position.z;
			while (vehicles[num6].inUse)
			{
				num6 = UnityEngine.Random.Range(0, 4);
			}
			vehicles[num6].inUse = true;
			vehicles[num6].myTransform.position = position4 - new Vector3(2f, 0f, 3f);
			empty = empty + " " + num6 + " " + vehicles[num6].myTransform.position.x + " " + vehicles[num6].myTransform.position.z;
			broadcast("**MOTHERBRAIN", "placeVehicles", empty, true);
		}
		else if (incomingData == string.Empty)
		{
			int num6 = UnityEngine.Random.Range(0, 4);
			vehicles[num6].inUse = true;
			float x4 = UnityEngine.Random.Range(30f, 100f);
			Vector3 position6 = vehicles[num6].myTransform.position;
			float num9 = (position6.x = x4);
			Vector3 vector10 = (vehicles[num6].myTransform.position = position6);
			Vector3 position4 = vehicles[num6].myTransform.position;
			while (vehicles[num6].inUse)
			{
				num6 = UnityEngine.Random.Range(0, 4);
			}
			vehicles[num6].inUse = true;
			float x5 = position4.x + UnityEngine.Random.Range(170f, 260f);
			Vector3 position7 = vehicles[num6].myTransform.position;
			float num10 = (position7.x = x5);
			Vector3 vector12 = (vehicles[num6].myTransform.position = position7);
			position4 = vehicles[num6].myTransform.position;
			while (vehicles[num6].inUse)
			{
				num6 = UnityEngine.Random.Range(0, 4);
			}
			vehicles[num6].inUse = true;
			float x6 = position4.x + UnityEngine.Random.Range(170f, 260f);
			Vector3 position8 = vehicles[num6].myTransform.position;
			float num11 = (position8.x = x6);
			Vector3 vector14 = (vehicles[num6].myTransform.position = position8);
			position4 = vehicles[num6].myTransform.position;
			while (vehicles[num6].inUse)
			{
				num6 = UnityEngine.Random.Range(0, 4);
			}
			vehicles[num6].inUse = true;
			float x7 = position4.x + UnityEngine.Random.Range(170f, 260f);
			Vector3 position9 = vehicles[num6].myTransform.position;
			float num12 = (position9.x = x7);
			Vector3 vector16 = (vehicles[num6].myTransform.position = position9);
		}
	}

	public virtual void spawnLevelChunk()
	{
		fade = false;
		buildingMessage = string.Empty;
		alleyMessage = string.Empty;
		clutterMessage = string.Empty;
		destructibleMessage = string.Empty;
		for (int i = 0; i < 5; i++)
		{
			for (randomRoll = UnityEngine.Random.Range(0, Extensions.get_length(DB.environments[(int)DB.location].parts)); randomRoll == previousRoll; randomRoll = UnityEngine.Random.Range(0, Extensions.get_length(DB.environments[(int)DB.location].parts)))
			{
			}
			previousRoll = randomRoll;
			if (alleyRoll != -1 && !DB.environments[(int)DB.location].parts[randomRoll].flushFront)
			{
				tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].alleys[alleyRoll].prefabName));
				tempTransform = tempGO.transform;
				float x = buildingSpawnPosition;
				Vector3 position = tempTransform.position;
				float num = (position.x = x);
				Vector3 vector2 = (tempTransform.position = position);
				buildingSpawnPosition += DB.environments[(int)DB.location].alleys[alleyRoll].prefabSize;
				if (DB.multiplayer)
				{
					if (alleyMessage == string.Empty)
					{
						alleyMessage = alleyRoll + " " + tempTransform.position.x;
					}
					else
					{
						alleyMessage = alleyMessage + " " + alleyRoll + " " + tempTransform.position.x;
					}
				}
			}
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].parts[randomRoll].prefabName));
			tempTransform = tempGO.transform;
			float x2 = buildingSpawnPosition;
			Vector3 position2 = tempTransform.position;
			float num2 = (position2.x = x2);
			Vector3 vector4 = (tempTransform.position = position2);
			buildingSpawnPosition += DB.environments[(int)DB.location].parts[randomRoll].prefabSize;
			if (DB.multiplayer)
			{
				if (buildingMessage == string.Empty)
				{
					buildingMessage = randomRoll + " " + tempTransform.position.x;
				}
				else
				{
					buildingMessage = buildingMessage + " " + randomRoll + " " + tempTransform.position.x;
				}
			}
			if (!DB.environments[(int)DB.location].parts[randomRoll].flushBack)
			{
				alleyRoll = UnityEngine.Random.Range(0, Extensions.get_length(DB.environments[(int)DB.location].alleys));
			}
			else
			{
				alleyRoll = -1;
			}
		}
		characterHorizontalBounds.y = buildingSpawnPosition;
		if (!DB.environments[(int)DB.location].noClutter)
		{
			previousRoll = -1;
			while (clutterSpawnPosition < buildingSpawnPosition)
			{
				clutterSpawnPosition += UnityEngine.Random.Range(1.3f, 6.3f);
				for (randomRoll = UnityEngine.Random.Range(0, Extensions.get_length(DB.environments[(int)DB.location].clutter)); randomRoll == previousRoll; randomRoll = UnityEngine.Random.Range(0, Extensions.get_length(DB.environments[(int)DB.location].clutter)))
				{
				}
				previousRoll = randomRoll;
				tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].clutter[randomRoll]));
				tempTransform = tempGO.transform;
				float x3 = clutterSpawnPosition;
				Vector3 position3 = tempTransform.position;
				float num3 = (position3.x = x3);
				Vector3 vector6 = (tempTransform.position = position3);
				if (DB.multiplayer)
				{
					if (clutterMessage == string.Empty)
					{
						clutterMessage = randomRoll + " " + tempTransform.position.x;
					}
					else
					{
						clutterMessage = clutterMessage + " " + randomRoll + " " + tempTransform.position.x;
					}
				}
			}
		}
		while (!(destructibleSpawnPosition >= buildingSpawnPosition) && !DB.tutorial)
		{
			destructibleSpawnPosition += UnityEngine.Random.Range(DB.environments[(int)DB.location].destructiblesSpawnRange.x, DB.environments[(int)DB.location].destructiblesSpawnRange.y);
			int num4 = UnityEngine.Random.Range(0, Extensions.get_length(DB.environments[(int)DB.location].destructibles));
			int i = 30 + num4 * 5;
			for (int num5 = i + 5; i < num5; i++)
			{
				if (!zombies[i] || zombies[i].enabled)
				{
					continue;
				}
				zombies[i].reset();
				if (zombies[i].forceSpawnPosition == 100f)
				{
					zombies[i].myTransform.position = new Vector3(destructibleSpawnPosition, 0f, UnityEngine.Random.Range(characterVerticalBounds.y + 2.2f, characterVerticalBounds.x - 0.2f));
				}
				else
				{
					zombies[i].myTransform.position = new Vector3(destructibleSpawnPosition, 0f, zombies[i].forceSpawnPosition);
				}
				if (DB.multiplayer)
				{
					if (destructibleMessage == string.Empty)
					{
						destructibleMessage = i + " " + zombies[i].myTransform.position.x + " " + zombies[i].myTransform.position.z;
					}
					else
					{
						destructibleMessage = destructibleMessage + " " + i + " " + zombies[i].myTransform.position.x + " " + zombies[i].myTransform.position.z;
					}
				}
				i = num5;
			}
		}
		if (DB.multiplayer)
		{
			buildingMessage = buildingMessage + " " + buildingSpawnPosition;
			if (alleyMessage != string.Empty)
			{
				alleyMessage = alleyMessage + " " + alleyRoll;
			}
			if (clutterMessage != string.Empty)
			{
				clutterMessage = clutterMessage + " " + clutterSpawnPosition;
			}
			if (destructibleMessage != string.Empty)
			{
				destructibleMessage = destructibleMessage + " " + destructibleSpawnPosition;
			}
		}
		if (DB.multiplayer && DB.whichPlayerAmI == 1)
		{
			broadcast("**MOTHERBRAIN", "syncBuildings", buildingMessage, true);
			if (alleyMessage != string.Empty)
			{
				broadcast("**MOTHERBRAIN", "syncAlleys", alleyMessage, true);
			}
			if (clutterMessage != string.Empty)
			{
				broadcast("**MOTHERBRAIN", "syncClutter", clutterMessage, true);
			}
			if (destructibleMessage != string.Empty)
			{
				broadcast("**MOTHERBRAIN", "syncDestructibles", destructibleMessage, true);
			}
		}
	}

	public virtual void syncBuildings(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		fade = false;
		for (int i = 0; i < Extensions.get_length(array); i += 2)
		{
			if (i == Extensions.get_length(array) - 1)
			{
				characterHorizontalBounds.y = UnityBuiltins.parseFloat(array[i]);
				buildingSpawnPosition = characterHorizontalBounds.y;
				continue;
			}
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].parts[UnityBuiltins.parseInt(array[i])].prefabName));
			float x = UnityBuiltins.parseFloat(array[i + 1]);
			Vector3 position = tempGO.transform.position;
			float num = (position.x = x);
			Vector3 vector2 = (tempGO.transform.position = position);
		}
		if (!player2RecievedEnvironment)
		{
			player2RecievedEnvironment = true;
			broadcast("**MOTHERBRAIN", "iGotTheWorld", "1", true);
		}
	}

	public virtual void syncAlleys(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		for (int i = 0; i < Extensions.get_length(array); i += 2)
		{
			if (i == Extensions.get_length(array) - 1)
			{
				alleyRoll = UnityBuiltins.parseInt(array[i]);
				continue;
			}
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].alleys[UnityBuiltins.parseInt(array[i])].prefabName));
			float x = UnityBuiltins.parseFloat(array[i + 1]);
			Vector3 position = tempGO.transform.position;
			float num = (position.x = x);
			Vector3 vector2 = (tempGO.transform.position = position);
		}
	}

	public virtual void syncClutter(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		for (int i = 0; i < Extensions.get_length(array); i += 2)
		{
			if (i == Extensions.get_length(array) - 1)
			{
				clutterSpawnPosition = UnityBuiltins.parseFloat(array[i]);
				continue;
			}
			tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(DB.environments[(int)DB.location].clutter[UnityBuiltins.parseInt(array[i])]));
			float x = UnityBuiltins.parseFloat(array[i + 1]);
			Vector3 position = tempGO.transform.position;
			float num = (position.x = x);
			Vector3 vector2 = (tempGO.transform.position = position);
		}
	}

	public virtual void syncDestructibles(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		for (int i = 0; i < Extensions.get_length(array); i += 3)
		{
			if (i == Extensions.get_length(array) - 1)
			{
				destructibleSpawnPosition = UnityBuiltins.parseFloat(array[i]);
				continue;
			}
			if (!zombies[UnityBuiltins.parseInt(array[i])])
			{
				Debug.Log("this zombie is null!");
				continue;
			}
			zombies[UnityBuiltins.parseInt(array[i])].reset();
			zombies[UnityBuiltins.parseInt(array[i])].myTransform.position = new Vector3(UnityBuiltins.parseFloat(array[i + 1]), 0f, UnityBuiltins.parseFloat(array[i + 2]));
		}
	}

	public virtual void loopingBG()
	{
		for (int i = 0; i < 3; i++)
		{
			if ((bool)groundPieces[i])
			{
				if (!(groundPieces[i].position.x >= gameCamera.position.x - basicFloorSize * 1.5f))
				{
					float x = groundPieces[i].position.x + basicFloorSize * 3f;
					Vector3 position = groundPieces[i].position;
					float num = (position.x = x);
					Vector3 vector2 = (groundPieces[i].position = position);
				}
				else if (!(groundPieces[i].position.x <= gameCamera.position.x + basicFloorSize * 1.5f))
				{
					float x2 = groundPieces[i].position.x - basicFloorSize * 3f;
					Vector3 position2 = groundPieces[i].position;
					float num2 = (position2.x = x2);
					Vector3 vector4 = (groundPieces[i].position = position2);
				}
			}
			if ((bool)FGPieces[i])
			{
				if (!(FGPieces[i].position.x >= gameCamera.position.x - FGSize * 1.5f))
				{
					float x3 = FGPieces[i].position.x + FGSize * 3f;
					Vector3 position3 = FGPieces[i].position;
					float num3 = (position3.x = x3);
					Vector3 vector6 = (FGPieces[i].position = position3);
				}
				else if (!(FGPieces[i].position.x <= gameCamera.position.x + FGSize * 1.5f))
				{
					float x4 = FGPieces[i].position.x - FGSize * 3f;
					Vector3 position4 = FGPieces[i].position;
					float num4 = (position4.x = x4);
					Vector3 vector8 = (FGPieces[i].position = position4);
				}
			}
			if ((bool)SkylinePieces[i])
			{
				if (!(SkylinePieces[i].position.x >= gameCamera.position.x - SkylineSize * 1.5f))
				{
					float x5 = SkylinePieces[i].position.x + SkylineSize * 3f;
					Vector3 position5 = SkylinePieces[i].position;
					float num5 = (position5.x = x5);
					Vector3 vector10 = (SkylinePieces[i].position = position5);
				}
				else if (!(SkylinePieces[i].position.x <= gameCamera.position.x + SkylineSize * 1.5f))
				{
					float x6 = SkylinePieces[i].position.x - SkylineSize * 3f;
					Vector3 position6 = SkylinePieces[i].position;
					float num6 = (position6.x = x6);
					Vector3 vector12 = (SkylinePieces[i].position = position6);
				}
			}
			if ((bool)cloudPieces[i])
			{
				if (!(cloudPieces[i].position.x >= gameCamera.position.x - cloudSize * 1.5f))
				{
					float x7 = cloudPieces[i].position.x + cloudSize * 3f;
					Vector3 position7 = cloudPieces[i].position;
					float num7 = (position7.x = x7);
					Vector3 vector14 = (cloudPieces[i].position = position7);
				}
				else if (!(cloudPieces[i].position.x <= gameCamera.position.x + cloudSize * 1.5f))
				{
					float x8 = cloudPieces[i].position.x - cloudSize * 3f;
					Vector3 position8 = cloudPieces[i].position;
					float num8 = (position8.x = x8);
					Vector3 vector16 = (cloudPieces[i].position = position8);
				}
			}
		}
	}

	public virtual void determineWhichPlayer()
	{
	}

	public virtual void HUDAnimation()
	{
		if (!(hideRunForIt <= 0f))
		{
			hideRunForIt -= Time.deltaTime;
			if (!(hideRunForIt > 0f))
			{
				int num = -20;
				Vector3 localPosition = runForIt.localPosition;
				float num2 = (localPosition.y = num);
				Vector3 vector2 = (runForIt.localPosition = localPosition);
			}
		}
		if ((bool)playerScript && !playerScript.alive)
		{
			HUDroot.localScale = Vector3.Lerp(HUDroot.localScale, new Vector3(3f, 3f, 3f), 10f * Time.deltaTime);
		}
		if (GOrenderer.enabled && !introSequence)
		{
			float a = GOrenderer.material.color.a - 4f * Time.deltaTime;
			Color color = GOrenderer.material.color;
			float num3 = (color.a = a);
			Color color3 = (GOrenderer.material.color = color);
			if (!(GOrenderer.material.color.a > 0f))
			{
				GOrenderer.enabled = false;
			}
		}
		if (multiplier > 1 && multiplier < 10 && multiplierWindow.localPosition.x != 3.5f)
		{
			float x = Mathf.Lerp(multiplierWindow.localPosition.x, 3.5f, 9f * Time.deltaTime);
			Vector3 localPosition2 = multiplierWindow.localPosition;
			float num4 = (localPosition2.x = x);
			Vector3 vector4 = (multiplierWindow.localPosition = localPosition2);
			if (!(multiplierWindow.localPosition.x < 3.49f))
			{
				float x2 = 3.5f;
				Vector3 localPosition3 = multiplierWindow.localPosition;
				float num5 = (localPosition3.x = x2);
				Vector3 vector6 = (multiplierWindow.localPosition = localPosition3);
			}
		}
		else if (multiplier >= 10 && multiplierWindow.localPosition.x != 3.78f)
		{
			float x3 = Mathf.Lerp(multiplierWindow.localPosition.x, 3.78f, 9f * Time.deltaTime);
			Vector3 localPosition4 = multiplierWindow.localPosition;
			float num6 = (localPosition4.x = x3);
			Vector3 vector8 = (multiplierWindow.localPosition = localPosition4);
			if (!(multiplierWindow.localPosition.x < 3.77f))
			{
				float x4 = 3.78f;
				Vector3 localPosition5 = multiplierWindow.localPosition;
				float num7 = (localPosition5.x = x4);
				Vector3 vector10 = (multiplierWindow.localPosition = localPosition5);
			}
		}
		else if (multiplier == 1 && multiplierWindow.localPosition.x != 3f)
		{
			float x5 = Mathf.Lerp(multiplierWindow.localPosition.x, 3f, 9f * Time.deltaTime);
			Vector3 localPosition6 = multiplierWindow.localPosition;
			float num8 = (localPosition6.x = x5);
			Vector3 vector12 = (multiplierWindow.localPosition = localPosition6);
			if (!(multiplierWindow.localPosition.x > 3.01f))
			{
				int num9 = 3;
				Vector3 localPosition7 = multiplierWindow.localPosition;
				float num10 = (localPosition7.x = num9);
				Vector3 vector14 = (multiplierWindow.localPosition = localPosition7);
			}
		}
		if (multiplier > 1)
		{
			multiplierTimer -= Time.deltaTime;
			if (!(multiplierTimer >= multiplierFlashThreshold))
			{
				multiplierFlash -= Time.deltaTime;
				if (!(multiplierFlash > 0f))
				{
					multiplierFlash = 0.05f;
					if (multiplierRoot.localPosition.y == 0f)
					{
						int num11 = 1;
						Vector3 localPosition8 = multiplierRoot.localPosition;
						float num12 = (localPosition8.y = num11);
						Vector3 vector16 = (multiplierRoot.localPosition = localPosition8);
					}
					else
					{
						int num13 = 0;
						Vector3 localPosition9 = multiplierRoot.localPosition;
						float num14 = (localPosition9.y = num13);
						Vector3 vector18 = (multiplierRoot.localPosition = localPosition9);
					}
				}
			}
			else if (multiplierRoot.localPosition.y != 0f)
			{
				int num15 = 0;
				Vector3 localPosition10 = multiplierRoot.localPosition;
				float num16 = (localPosition10.y = num15);
				Vector3 vector20 = (multiplierRoot.localPosition = localPosition10);
			}
			if (!(multiplierTimer > 0f))
			{
				multiplier = 1;
				int num17 = 1;
				Vector3 localPosition11 = multiplierRoot.localPosition;
				float num18 = (localPosition11.y = num17);
				Vector3 vector22 = (multiplierRoot.localPosition = localPosition11);
			}
		}
		if (multiplier != displayedMultiplier)
		{
			displayedMultiplier = multiplier;
			for (int i = 0; i < 10; i++)
			{
				int num19 = 1;
				Vector3 localPosition12 = multDigits1[i].localPosition;
				float num20 = (localPosition12.y = num19);
				Vector3 vector24 = (multDigits1[i].localPosition = localPosition12);
				int num21 = 1;
				Vector3 localPosition13 = multDigits2[i].localPosition;
				float num22 = (localPosition13.y = num21);
				Vector3 vector26 = (multDigits2[i].localPosition = localPosition13);
			}
			if (multiplier < 10)
			{
				int num23 = 0;
				Vector3 localPosition14 = multDigits1[multiplier].localPosition;
				float num24 = (localPosition14.y = num23);
				Vector3 vector28 = (multDigits1[multiplier].localPosition = localPosition14);
			}
			else if (multiplier >= 10)
			{
				int num25 = 0;
				Vector3 localPosition15 = multDigits1[multiplier / 10].localPosition;
				float num26 = (localPosition15.y = num25);
				Vector3 vector30 = (multDigits1[multiplier / 10].localPosition = localPosition15);
				int num27 = 0;
				Vector3 localPosition16 = multDigits2[multiplier - multiplier / 10 * 10].localPosition;
				float num28 = (localPosition16.y = num27);
				Vector3 vector32 = (multDigits2[multiplier - multiplier / 10 * 10].localPosition = localPosition16);
			}
		}
		updateScore();
		bool flag = false;
		for (int i = 0; i < 7; i++)
		{
			float num29 = -0.38f + (float)tumblerDigits[i] * -0.38f;
			if ((i == 0 && score < 1000000) || (i == 1 && score < 100000) || (i == 2 && score < 10000) || (i == 3 && score < 1000) || (i == 4 && score < 100) || (i == 5 && score < 10) || score == 0)
			{
				int num30 = 0;
				Vector3 localPosition17 = tumblers[i].localPosition;
				float num31 = (localPosition17.y = num30);
				Vector3 vector34 = (tumblers[i].localPosition = localPosition17);
			}
			else if (tumblers[i].localPosition.y != num29)
			{
				flag = ((!(tumblers[i].localPosition.y <= -0.38f + (float)tumblerDigits[i] * -0.38f)) ? true : false);
				float y = tumblers[i].localPosition.y - 5f * Time.deltaTime;
				Vector3 localPosition18 = tumblers[i].localPosition;
				float num32 = (localPosition18.y = y);
				Vector3 vector36 = (tumblers[i].localPosition = localPosition18);
				if (!(tumblers[i].localPosition.y > -4.14f))
				{
					float y2 = tumblers[i].localPosition.y + 3.8f;
					Vector3 localPosition19 = tumblers[i].localPosition;
					float num33 = (localPosition19.y = y2);
					Vector3 vector38 = (tumblers[i].localPosition = localPosition19);
				}
				if (flag && !(tumblers[i].localPosition.y > -0.38f + (float)tumblerDigits[i] * -0.38f))
				{
					float y3 = -0.38f + (float)tumblerDigits[i] * -0.38f;
					Vector3 localPosition20 = tumblers[i].localPosition;
					float num34 = (localPosition20.y = y3);
					Vector3 vector40 = (tumblers[i].localPosition = localPosition20);
				}
			}
		}
		if (!introSequence)
		{
			colonBlink -= Time.deltaTime;
			if (!(colonBlink > 0f))
			{
				colonBlink = 0.23f;
				if (clockColon.localPosition.y == 1f)
				{
					float y4 = -0.4658823f;
					Vector3 localPosition21 = clockColon.localPosition;
					float num35 = (localPosition21.y = y4);
					Vector3 vector42 = (clockColon.localPosition = localPosition21);
				}
				else
				{
					int num36 = 1;
					Vector3 localPosition22 = clockColon.localPosition;
					float num37 = (localPosition22.y = num36);
					Vector3 vector44 = (clockColon.localPosition = localPosition22);
				}
			}
			if (timeRemaining != 999f)
			{
				timeRemaining -= Time.deltaTime;
			}
			if (!(timeRemaining > 0f))
			{
				timeRemaining = 0f;
			}
		}
		if (timeRemaining != 999f)
		{
			int num38 = UnityBuiltins.parseInt(timeRemaining);
			if (displayedTime != num38)
			{
				displayedTime = num38;
				int num39 = num38 / 60;
				num38 -= 60 * num39;
				int num40 = num38 / 10;
				num38 -= 10 * num40;
				for (int i = 0; i < Extensions.get_length(clockDigits1); i++)
				{
					if (clockDigits1[i].localPosition.y != 1f)
					{
						int num41 = 1;
						Vector3 localPosition23 = clockDigits1[i].localPosition;
						float num42 = (localPosition23.y = num41);
						Vector3 vector46 = (clockDigits1[i].localPosition = localPosition23);
					}
					if (clockDigits2[i].localPosition.y != 1f)
					{
						int num43 = 1;
						Vector3 localPosition24 = clockDigits2[i].localPosition;
						float num44 = (localPosition24.y = num43);
						Vector3 vector48 = (clockDigits2[i].localPosition = localPosition24);
					}
					if (clockDigits3[i].localPosition.y != 1f)
					{
						int num45 = 1;
						Vector3 localPosition25 = clockDigits3[i].localPosition;
						float num46 = (localPosition25.y = num45);
						Vector3 vector50 = (clockDigits3[i].localPosition = localPosition25);
					}
				}
				int num47 = 0;
				Vector3 localPosition26 = clockDigits1[num39].localPosition;
				float num48 = (localPosition26.y = num47);
				Vector3 vector52 = (clockDigits1[num39].localPosition = localPosition26);
				int num49 = 0;
				Vector3 localPosition27 = clockDigits2[num40].localPosition;
				float num50 = (localPosition27.y = num49);
				Vector3 vector54 = (clockDigits2[num40].localPosition = localPosition27);
				int num51 = 0;
				Vector3 localPosition28 = clockDigits3[num38].localPosition;
				float num52 = (localPosition28.y = num51);
				Vector3 vector56 = (clockDigits3[num38].localPosition = localPosition28);
			}
		}
		else
		{
			for (int i = 0; i < Extensions.get_length(clockDigits1); i++)
			{
				if (clockDigits1[i].localPosition.y != 1f)
				{
					int num53 = 1;
					Vector3 localPosition29 = clockDigits1[i].localPosition;
					float num54 = (localPosition29.y = num53);
					Vector3 vector58 = (clockDigits1[i].localPosition = localPosition29);
				}
				if (clockDigits2[i].localPosition.y != 1f)
				{
					int num55 = 1;
					Vector3 localPosition30 = clockDigits2[i].localPosition;
					float num56 = (localPosition30.y = num55);
					Vector3 vector60 = (clockDigits2[i].localPosition = localPosition30);
				}
				if (clockDigits3[i].localPosition.y != 1f)
				{
					int num57 = 1;
					Vector3 localPosition31 = clockDigits3[i].localPosition;
					float num58 = (localPosition31.y = num57);
					Vector3 vector62 = (clockDigits3[i].localPosition = localPosition31);
				}
			}
			int num59 = 0;
			Vector3 localPosition32 = clockDigits1[9].localPosition;
			float num60 = (localPosition32.y = num59);
			Vector3 vector64 = (clockDigits1[9].localPosition = localPosition32);
			int num61 = 0;
			Vector3 localPosition33 = clockDigits2[9].localPosition;
			float num62 = (localPosition33.y = num61);
			Vector3 vector66 = (clockDigits2[9].localPosition = localPosition33);
			int num63 = 0;
			Vector3 localPosition34 = clockDigits3[9].localPosition;
			float num64 = (localPosition34.y = num63);
			Vector3 vector68 = (clockDigits3[9].localPosition = localPosition34);
		}
		if (!(timeRemaining > 30f))
		{
			clockFlash -= Time.deltaTime;
			if (!(clockFlash > 0f))
			{
				clockFlash = 0.1f;
				if (clockLight.localPosition.y == 0f)
				{
					int num65 = 1;
					Vector3 localPosition35 = clockLight.localPosition;
					float num66 = (localPosition35.y = num65);
					Vector3 vector70 = (clockLight.localPosition = localPosition35);
				}
				else
				{
					int num67 = 0;
					Vector3 localPosition36 = clockLight.localPosition;
					float num68 = (localPosition36.y = num67);
					Vector3 vector72 = (clockLight.localPosition = localPosition36);
				}
			}
		}
		if (!playerScript)
		{
			return;
		}
		if (!(lifeBarFlash <= 0f))
		{
			lifeBarFlash -= Time.deltaTime;
			if (!(lifeBarFlash > 0f))
			{
				int num69 = 1;
				Vector3 localPosition37 = healthLight.localPosition;
				float num70 = (localPosition37.y = num69);
				Vector3 vector74 = (healthLight.localPosition = localPosition37);
			}
			else
			{
				lifeBarFlashTimer -= Time.deltaTime;
				if (!(lifeBarFlashTimer > 0f))
				{
					lifeBarFlashTimer = 0.05f;
					if (healthLight.localPosition.y != 0f)
					{
						int num71 = 0;
						Vector3 localPosition38 = healthLight.localPosition;
						float num72 = (localPosition38.y = num71);
						Vector3 vector76 = (healthLight.localPosition = localPosition38);
					}
					else
					{
						int num73 = 1;
						Vector3 localPosition39 = healthLight.localPosition;
						float num74 = (localPosition39.y = num73);
						Vector3 vector78 = (healthLight.localPosition = localPosition39);
					}
				}
			}
		}
		float x6 = Mathf.Lerp(healthMask.localPosition.x, playerScript.health / playerScript.maxHealth * -2.17f, 9f * Time.deltaTime);
		Vector3 localPosition40 = healthMask.localPosition;
		float num75 = (localPosition40.x = x6);
		Vector3 vector80 = (healthMask.localPosition = localPosition40);
		if (activeAmmoDisplay != -1 && ammoDisplays[activeAmmoDisplay].localPosition.x != 0f)
		{
			float x7 = Mathf.Lerp(ammoDisplays[activeAmmoDisplay].localPosition.x, 0f, 13f * Time.deltaTime);
			Vector3 localPosition41 = ammoDisplays[activeAmmoDisplay].localPosition;
			float num76 = (localPosition41.x = x7);
			Vector3 vector82 = (ammoDisplays[activeAmmoDisplay].localPosition = localPosition41);
			if (!(ammoDisplays[activeAmmoDisplay].localPosition.x >= 0.007f))
			{
				int num77 = 0;
				Vector3 localPosition42 = ammoDisplays[activeAmmoDisplay].localPosition;
				float num78 = (localPosition42.x = num77);
				Vector3 vector84 = (ammoDisplays[activeAmmoDisplay].localPosition = localPosition42);
			}
		}
		if (playerScript.weapons[0] == 99 && redButton.localPosition.x != -3f)
		{
			int num79 = -3;
			Vector3 localPosition43 = redButton.localPosition;
			float num80 = (localPosition43.x = num79);
			Vector3 vector86 = (redButton.localPosition = localPosition43);
		}
		if (playerScript.weapons[1] == 99 && greenButton.localPosition.x != -3f)
		{
			int num81 = -3;
			Vector3 localPosition44 = greenButton.localPosition;
			float num82 = (localPosition44.x = num81);
			Vector3 vector88 = (greenButton.localPosition = localPosition44);
		}
		if (playerScript.weapons[2] == 99 && yellowButton.localPosition.x != -3f)
		{
			int num83 = -3;
			Vector3 localPosition45 = yellowButton.localPosition;
			float num84 = (localPosition45.x = num83);
			Vector3 vector90 = (yellowButton.localPosition = localPosition45);
		}
	}

	public virtual void updateMaxAmmo(int maxAmmo)
	{
		int num = maxAmmo / 100;
		int num2 = (maxAmmo - num * 100) / 10;
		int num3 = maxAmmo - num * 100 - num2 * 10;
		if (activeAmmoDisplay == 0)
		{
			for (int i = 0; i < 10; i++)
			{
				if (greenDigits1[0].digit[i].localPosition.y != 3f)
				{
					int num4 = 3;
					Vector3 localPosition = greenDigits1[0].digit[i].localPosition;
					float num5 = (localPosition.y = num4);
					Vector3 vector2 = (greenDigits1[0].digit[i].localPosition = localPosition);
				}
			}
			int num6 = 0;
			Vector3 localPosition2 = greenDigits1[0].digit[num3].localPosition;
			float num7 = (localPosition2.y = num6);
			Vector3 vector4 = (greenDigits1[0].digit[num3].localPosition = localPosition2);
		}
		else if (activeAmmoDisplay == 1)
		{
			for (int i = 0; i < 10; i++)
			{
				if (greenDigits2[0].digit[i].localPosition.y != 3f)
				{
					int num8 = 3;
					Vector3 localPosition3 = greenDigits2[0].digit[i].localPosition;
					float num9 = (localPosition3.y = num8);
					Vector3 vector6 = (greenDigits2[0].digit[i].localPosition = localPosition3);
				}
				if (greenDigits2[1].digit[i].localPosition.y != 3f)
				{
					int num10 = 3;
					Vector3 localPosition4 = greenDigits2[1].digit[i].localPosition;
					float num11 = (localPosition4.y = num10);
					Vector3 vector8 = (greenDigits2[1].digit[i].localPosition = localPosition4);
				}
			}
			int num12 = 0;
			Vector3 localPosition5 = greenDigits2[0].digit[num2].localPosition;
			float num13 = (localPosition5.y = num12);
			Vector3 vector10 = (greenDigits2[0].digit[num2].localPosition = localPosition5);
			int num14 = 0;
			Vector3 localPosition6 = greenDigits2[1].digit[num3].localPosition;
			float num15 = (localPosition6.y = num14);
			Vector3 vector12 = (greenDigits2[1].digit[num3].localPosition = localPosition6);
		}
		else
		{
			if (activeAmmoDisplay != 2)
			{
				return;
			}
			for (int i = 0; i < 10; i++)
			{
				if (greenDigits3[0].digit[i].localPosition.y != 3f)
				{
					int num16 = 3;
					Vector3 localPosition7 = greenDigits3[0].digit[i].localPosition;
					float num17 = (localPosition7.y = num16);
					Vector3 vector14 = (greenDigits3[0].digit[i].localPosition = localPosition7);
				}
				if (greenDigits3[1].digit[i].localPosition.y != 3f)
				{
					int num18 = 3;
					Vector3 localPosition8 = greenDigits3[1].digit[i].localPosition;
					float num19 = (localPosition8.y = num18);
					Vector3 vector16 = (greenDigits3[1].digit[i].localPosition = localPosition8);
				}
				if (greenDigits3[2].digit[i].localPosition.y != 3f)
				{
					int num20 = 3;
					Vector3 localPosition9 = greenDigits3[2].digit[i].localPosition;
					float num21 = (localPosition9.y = num20);
					Vector3 vector18 = (greenDigits3[2].digit[i].localPosition = localPosition9);
				}
			}
			int num22 = 0;
			Vector3 localPosition10 = greenDigits3[0].digit[num].localPosition;
			float num23 = (localPosition10.y = num22);
			Vector3 vector20 = (greenDigits3[0].digit[num].localPosition = localPosition10);
			int num24 = 0;
			Vector3 localPosition11 = greenDigits3[1].digit[num2].localPosition;
			float num25 = (localPosition11.y = num24);
			Vector3 vector22 = (greenDigits3[1].digit[num2].localPosition = localPosition11);
			int num26 = 0;
			Vector3 localPosition12 = greenDigits3[2].digit[num3].localPosition;
			float num27 = (localPosition12.y = num26);
			Vector3 vector24 = (greenDigits3[2].digit[num3].localPosition = localPosition12);
		}
	}

	public virtual void updateCurrentAmmo(int currentAmmo)
	{
		if (currentAmmo == 0 && redWeaponBG.localPosition.y != 0f)
		{
			int num = 0;
			Vector3 localPosition = redWeaponBG.localPosition;
			float num2 = (localPosition.y = num);
			Vector3 vector2 = (redWeaponBG.localPosition = localPosition);
			playerScript.weaponIcons[playerScript.equippedSlot].material.color = new Color(0.05f, 0.05f, 0.05f);
		}
		else if ((currentAmmo > 0 && redWeaponBG.localPosition.y != 1f) || (currentAmmo == -1 && redWeaponBG.localPosition.y != 1f) || (currentAmmo > 0 && playerScript.weaponIcons[playerScript.equippedSlot].material.color != new Color(0.25f, 0.25f, 0.25f)))
		{
			int num3 = 1;
			Vector3 localPosition2 = redWeaponBG.localPosition;
			float num4 = (localPosition2.y = num3);
			Vector3 vector4 = (redWeaponBG.localPosition = localPosition2);
			playerScript.weaponIcons[playerScript.equippedSlot].material.color = new Color(0.25f, 0.25f, 0.25f);
		}
		int num5 = currentAmmo / 100;
		int num6 = (currentAmmo - num5 * 100) / 10;
		int num7 = currentAmmo - num5 * 100 - num6 * 10;
		if (activeAmmoDisplay == 0)
		{
			for (int i = 0; i < 11; i++)
			{
				if (ammoDigits1[0].digit[i].localPosition.y != 3f)
				{
					int num8 = 3;
					Vector3 localPosition3 = ammoDigits1[0].digit[i].localPosition;
					float num9 = (localPosition3.y = num8);
					Vector3 vector6 = (ammoDigits1[0].digit[i].localPosition = localPosition3);
				}
			}
			int num10 = 0;
			Vector3 localPosition4 = ammoDigits1[0].digit[num7].localPosition;
			float num11 = (localPosition4.y = num10);
			Vector3 vector8 = (ammoDigits1[0].digit[num7].localPosition = localPosition4);
		}
		else if (activeAmmoDisplay == 1)
		{
			for (int i = 0; i < 11; i++)
			{
				if (ammoDigits2[0].digit[i].localPosition.y != 3f)
				{
					int num12 = 3;
					Vector3 localPosition5 = ammoDigits2[0].digit[i].localPosition;
					float num13 = (localPosition5.y = num12);
					Vector3 vector10 = (ammoDigits2[0].digit[i].localPosition = localPosition5);
				}
				if (ammoDigits2[1].digit[i].localPosition.y != 3f)
				{
					int num14 = 3;
					Vector3 localPosition6 = ammoDigits2[1].digit[i].localPosition;
					float num15 = (localPosition6.y = num14);
					Vector3 vector12 = (ammoDigits2[1].digit[i].localPosition = localPosition6);
				}
			}
			if (num6 == 0)
			{
				int num16 = 0;
				Vector3 localPosition7 = ammoDigits2[0].digit[10].localPosition;
				float num17 = (localPosition7.y = num16);
				Vector3 vector14 = (ammoDigits2[0].digit[10].localPosition = localPosition7);
			}
			else
			{
				int num18 = 0;
				Vector3 localPosition8 = ammoDigits2[0].digit[num6].localPosition;
				float num19 = (localPosition8.y = num18);
				Vector3 vector16 = (ammoDigits2[0].digit[num6].localPosition = localPosition8);
			}
			int num20 = 0;
			Vector3 localPosition9 = ammoDigits2[1].digit[num7].localPosition;
			float num21 = (localPosition9.y = num20);
			Vector3 vector18 = (ammoDigits2[1].digit[num7].localPosition = localPosition9);
		}
		else
		{
			if (activeAmmoDisplay != 2)
			{
				return;
			}
			for (int i = 0; i < 11; i++)
			{
				if (ammoDigits3[0].digit[i].localPosition.y != 3f)
				{
					int num22 = 3;
					Vector3 localPosition10 = ammoDigits3[0].digit[i].localPosition;
					float num23 = (localPosition10.y = num22);
					Vector3 vector20 = (ammoDigits3[0].digit[i].localPosition = localPosition10);
				}
				if (ammoDigits3[1].digit[i].localPosition.y != 3f)
				{
					int num24 = 3;
					Vector3 localPosition11 = ammoDigits3[1].digit[i].localPosition;
					float num25 = (localPosition11.y = num24);
					Vector3 vector22 = (ammoDigits3[1].digit[i].localPosition = localPosition11);
				}
				if (ammoDigits3[2].digit[i].localPosition.y != 3f)
				{
					int num26 = 3;
					Vector3 localPosition12 = ammoDigits3[2].digit[i].localPosition;
					float num27 = (localPosition12.y = num26);
					Vector3 vector24 = (ammoDigits3[2].digit[i].localPosition = localPosition12);
				}
			}
			if (num5 == 0)
			{
				int num28 = 0;
				Vector3 localPosition13 = ammoDigits3[0].digit[10].localPosition;
				float num29 = (localPosition13.y = num28);
				Vector3 vector26 = (ammoDigits3[0].digit[10].localPosition = localPosition13);
			}
			else
			{
				int num30 = 0;
				Vector3 localPosition14 = ammoDigits3[0].digit[num5].localPosition;
				float num31 = (localPosition14.y = num30);
				Vector3 vector28 = (ammoDigits3[0].digit[num5].localPosition = localPosition14);
			}
			if (num6 == 0 && num5 == 0)
			{
				int num32 = 0;
				Vector3 localPosition15 = ammoDigits3[1].digit[10].localPosition;
				float num33 = (localPosition15.y = num32);
				Vector3 vector30 = (ammoDigits3[1].digit[10].localPosition = localPosition15);
			}
			else
			{
				int num34 = 0;
				Vector3 localPosition16 = ammoDigits3[1].digit[num6].localPosition;
				float num35 = (localPosition16.y = num34);
				Vector3 vector32 = (ammoDigits3[1].digit[num6].localPosition = localPosition16);
			}
			int num36 = 0;
			Vector3 localPosition17 = ammoDigits3[2].digit[num7].localPosition;
			float num37 = (localPosition17.y = num36);
			Vector3 vector34 = (ammoDigits3[2].digit[num7].localPosition = localPosition17);
		}
	}

	public virtual void updateScore()
	{
		int num = score;
		tumblerDigits[0] = num / 1000000;
		num -= tumblerDigits[0] * 1000000;
		tumblerDigits[1] = num / 100000;
		num -= tumblerDigits[1] * 100000;
		tumblerDigits[2] = num / 10000;
		num -= tumblerDigits[2] * 10000;
		tumblerDigits[3] = num / 1000;
		num -= tumblerDigits[3] * 1000;
		tumblerDigits[4] = num / 100;
		num -= tumblerDigits[4] * 100;
		tumblerDigits[5] = num / 10;
		num -= tumblerDigits[5] * 10;
		tumblerDigits[6] = num;
	}

	public virtual void IntroSequence()
	{
		introTimer -= Time.deltaTime;
		if (DB.tutorial)
		{
			int num = 100;
			Vector3 position = GOanimation.gameObject.transform.position;
			float num2 = (position.y = num);
			Vector3 vector2 = (GOanimation.gameObject.transform.position = position);
		}
		if (!(introTimer > 2.2f) && !introDarkener.enabled && !(introTimer <= 0.9f) && !DB.tutorial)
		{
			introDarkener.enabled = true;
		}
		else if (!(introTimer > 2.2f) && currentBubble == -1 && DB.tutorial)
		{
			currentBubble++;
			showBubble(currentBubble);
		}
		if ((bool)getReady && !DB.tutorial)
		{
			getReadyAnim.Play();
		}
		if (!(introTimer > 0.9f) && !GOrenderer.enabled)
		{
			introDarkener.enabled = false;
			GOrenderer.enabled = true;
			GOrenderer.material.color = new Color(0.9f, 0.9f, 0.9f);
			GOanimation.Play();
		}
		if (GOrenderer.enabled && GOrenderer.material.color != new Color(0.25f, 0.25f, 0.25f))
		{
			float r = GOrenderer.material.color.r - 4f * Time.deltaTime;
			Color color = GOrenderer.material.color;
			float num3 = (color.r = r);
			Color color3 = (GOrenderer.material.color = color);
			float g = GOrenderer.material.color.g - 4f * Time.deltaTime;
			Color color4 = GOrenderer.material.color;
			float num4 = (color4.g = g);
			Color color6 = (GOrenderer.material.color = color4);
			float b = GOrenderer.material.color.b - 4f * Time.deltaTime;
			Color color7 = GOrenderer.material.color;
			float num5 = (color7.b = b);
			Color color9 = (GOrenderer.material.color = color7);
			if (!(GOrenderer.material.color.r > 0.25f))
			{
				GOrenderer.material.color = new Color(0.25f, 0.25f, 0.25f);
			}
		}
		if (GOrenderer.enabled)
		{
			HUDroot.localScale = Vector3.Lerp(HUDroot.localScale, HUDtargetScale, 10f * Time.deltaTime);
		}
		if (!(introTimer > 0f))
		{
			introSequence = false;
			if (DB.multiplayer)
			{
				allyScript.positionMagnet = allyScript.myTransform.position;
			}
			UnityEngine.Object.Destroy(getReady);
			HUDroot.localScale = HUDtargetScale;
		}
	}

	public virtual IEnumerator spawnPickup(int whichValue, Vector3 spawnPosition)
	{
		return new _0024spawnPickup_00241685(whichValue, spawnPosition, this).GetEnumerator();
	}

	public virtual void syncPickup(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		int num = UnityBuiltins.parseInt(array[0]);
		pickups[num].inUse = true;
		pickups[num].life = 0f;
		pickups[num].tran.position = new Vector3(UnityBuiltins.parseFloat(array[1]), 0f, UnityBuiltins.parseFloat(array[2]));
		pickups[num].anim.Play("start");
		pickups[num].anim.Play("loop");
	}

	public virtual void PickupCollection()
	{
		for (int i = 0; i < Extensions.get_length(pickups); i++)
		{
			if (pickups[i].inUse && !(pickups[i].tran.position.x >= characterHorizontalBounds.x - 3f))
			{
				pickups[i].inUse = false;
				int num = 100;
				Vector3 position = pickups[i].tran.position;
				float num2 = (position.y = num);
				Vector3 vector2 = (pickups[i].tran.position = position);
			}
		}
		if (DB.whichPlayerAmI != 1)
		{
			return;
		}
		if (!(pickupCollectionPulse <= 0f))
		{
			pickupCollectionPulse -= Time.deltaTime;
			return;
		}
		pickupCollectionPulse = 0.15f;
		for (int i = 0; i < Extensions.get_length(pickups); i++)
		{
			if (pickups[i].inUse)
			{
				if (!(Mathf.Abs(playerScript.myTransform.position.x - pickups[i].tran.position.x) >= 0.8f) && !(Mathf.Abs(playerScript.myTransform.position.z - pickups[i].tran.position.z) >= 0.8f))
				{
					textMessage = i.ToString() + " 1";
					despawnPickup(textMessage);
					broadcast("**MOTHERBRAIN", "despawnPickup", textMessage, true);
				}
				else if ((bool)allyScript && !(Mathf.Abs(allyScript.myTransform.position.x - pickups[i].tran.position.x) >= 0.8f) && !(Mathf.Abs(allyScript.myTransform.position.z - pickups[i].tran.position.z) >= 0.8f))
				{
					textMessage = i.ToString() + " 2";
					despawnPickup(textMessage);
					broadcast("**MOTHERBRAIN", "despawnPickup", textMessage, true);
				}
			}
		}
	}

	public virtual void despawnPickup(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		int num = 100;
		Vector3 position = pickups[UnityBuiltins.parseInt(array[0])].tran.position;
		float num2 = (position.y = num);
		Vector3 vector2 = (pickups[UnityBuiltins.parseInt(array[0])].tran.position = position);
		pickups[UnityBuiltins.parseInt(array[0])].inUse = false;
		if (Extensions.get_length(array) <= 1)
		{
			return;
		}
		if (pickups[UnityBuiltins.parseInt(array[0])].pickupValue == PickupValue.cash1 || pickups[UnityBuiltins.parseInt(array[0])].pickupValue == PickupValue.cash2 || pickups[UnityBuiltins.parseInt(array[0])].pickupValue == PickupValue.cash3)
		{
			sounds[6].Play();
		}
		else
		{
			pickupSound.Play();
		}
		if (array[1] == "1")
		{
			if (DB.whichPlayerAmI == 1)
			{
				StartCoroutine(playerScript.gainPickup(UnityBuiltins.parseInt(array[0]), 1f));
				for (int i = 0; i < 3; i++)
				{
					if (playerScript.perks[i] == 19 && (bool)allyScript)
					{
						StartCoroutine(allyScript.gainPickup(UnityBuiltins.parseInt(array[0]), DB.perks[19].rankBonuses[playerScript.perkRanks[i]]));
					}
				}
			}
			else
			{
				if (DB.whichPlayerAmI != 2)
				{
					return;
				}
				StartCoroutine(allyScript.gainPickup(UnityBuiltins.parseInt(array[0]), 1f));
				for (int i = 0; i < 3; i++)
				{
					if (allyScript.perks[i] == 19 && (bool)playerScript)
					{
						StartCoroutine(playerScript.gainPickup(UnityBuiltins.parseInt(array[0]), DB.perks[19].rankBonuses[playerScript.perkRanks[i]]));
					}
				}
			}
		}
		else
		{
			if (!(array[1] == "2"))
			{
				return;
			}
			if (DB.whichPlayerAmI == 1)
			{
				StartCoroutine(allyScript.gainPickup(UnityBuiltins.parseInt(array[0]), 1f));
				for (int i = 0; i < 3; i++)
				{
					if (allyScript.perks[i] == 19 && (bool)playerScript)
					{
						StartCoroutine(playerScript.gainPickup(UnityBuiltins.parseInt(array[0]), DB.perks[19].rankBonuses[playerScript.perkRanks[i]]));
					}
				}
			}
			else
			{
				if (DB.whichPlayerAmI != 2)
				{
					return;
				}
				StartCoroutine(playerScript.gainPickup(UnityBuiltins.parseInt(array[0]), 1f));
				for (int i = 0; i < 3; i++)
				{
					if (playerScript.perks[i] == 19 && (bool)allyScript)
					{
						StartCoroutine(allyScript.gainPickup(UnityBuiltins.parseInt(array[0]), DB.perks[19].rankBonuses[playerScript.perkRanks[i]]));
					}
				}
			}
		}
	}

	public virtual void muteSound()
	{
		for (int i = 0; i < Extensions.get_length(emergeSounds); i++)
		{
			emergeSounds[i].volume = 0f;
		}
		for (int i = 0; i < Extensions.get_length(sounds); i++)
		{
			sounds[i].volume = 0f;
		}
		pickupSound.volume = 0f;
	}

	public virtual void damagePulse(Vector3 where, Vector2 dimensions, int howMuchDamage, int appliedForce)
	{
		if ((bool)playerScript && !(Mathf.Abs(playerScript.myTransform.position.x - where.x) >= dimensions.x) && !(Mathf.Abs(playerScript.myTransform.position.z - where.z) >= dimensions.y))
		{
			playerScript.takeDamage(howMuchDamage, 0.2f);
			playerScript.slideVector = (playerScript.myTransform.position - where).normalized * appliedForce;
		}
		if ((bool)allyScript && !(Mathf.Abs(allyScript.myTransform.position.x - where.x) >= dimensions.x) && !(Mathf.Abs(allyScript.myTransform.position.z - where.z) >= dimensions.y))
		{
			allyScript.takeDamage(howMuchDamage, 0.2f);
			allyScript.slideVector = (allyScript.myTransform.position - where).normalized * appliedForce;
		}
	}

	public virtual void Helicopter()
	{
		if (!(timeRemaining > 0f) && !helicopterActive && DB.whichPlayerAmI == 1)
		{
			bool flag = false;
			if (((bool)playerScript && playerScript.inVehicle) || ((bool)allyScript && allyScript.inVehicle))
			{
				flag = true;
			}
			if (!flag)
			{
				float num = 0f;
				if (DB.multiplayer)
				{
					if ((bool)playerScript && (bool)allyScript && !(playerScript.myTransform.position.x < allyScript.myTransform.position.x))
					{
						num = playerScript.myTransform.position.x + 4.8f;
					}
					else if ((bool)allyScript)
					{
						num = allyScript.myTransform.position.x + 4.8f;
					}
				}
				else
				{
					num = playerScript.myTransform.position.x + 4.8f;
				}
				spawnHelicopter(num.ToString());
			}
		}
		if (helicopterActive && !helicopterDepart)
		{
			if (!(heliShadow.material.color.a >= 1f))
			{
				float a = heliShadow.material.color.a + Time.deltaTime;
				Color color = heliShadow.material.color;
				float num2 = (color.a = a);
				Color color3 = (heliShadow.material.color = color);
			}
			if (DB.soundEnabled && !(sounds[3].volume >= 1f))
			{
				sounds[3].volume = sounds[3].volume + Time.deltaTime;
				if (!(sounds[3].volume <= 1f))
				{
					sounds[3].volume = 1f;
				}
			}
			float x = windOpacity1.localScale.x;
			Color color4 = windRenderer1.material.color;
			float num3 = (color4.a = x);
			Color color6 = (windRenderer1.material.color = color4);
			float x2 = windOpacity2.localScale.x;
			Color color7 = windRenderer2.material.color;
			float num4 = (color7.a = x2);
			Color color9 = (windRenderer2.material.color = color7);
			float y = Mathf.Lerp(helicopterTransform.localPosition.y, 0f, 3f * Time.deltaTime);
			Vector3 localPosition = helicopterTransform.localPosition;
			float num5 = (localPosition.y = y);
			Vector3 vector2 = (helicopterTransform.localPosition = localPosition);
		}
		else if (helicopterActive && helicopterDepart)
		{
			if (!(heliShadow.material.color.a <= 0f))
			{
				float a2 = heliShadow.material.color.a - 0.5f * Time.deltaTime;
				Color color10 = heliShadow.material.color;
				float num6 = (color10.a = a2);
				Color color12 = (heliShadow.material.color = color10);
			}
			if (DB.soundEnabled && !(sounds[3].volume <= 0f))
			{
				sounds[3].volume = sounds[3].volume - 0.1f * Time.deltaTime;
			}
			if (!(helicopterTransform.localPosition.y >= 5f))
			{
				float a3 = windOpacity1.localScale.x - helicopterTransform.localPosition.y * 0.2f;
				Color color13 = windRenderer1.material.color;
				float num7 = (color13.a = a3);
				Color color15 = (windRenderer1.material.color = color13);
				float a4 = windOpacity2.localScale.x - helicopterTransform.localPosition.y * 0.2f;
				Color color16 = windRenderer2.material.color;
				float num8 = (color16.a = a4);
				Color color18 = (windRenderer2.material.color = color16);
			}
			else
			{
				int num9 = 0;
				Color color19 = windRenderer1.material.color;
				float num10 = (color19.a = num9);
				Color color21 = (windRenderer1.material.color = color19);
				int num11 = 0;
				Color color22 = windRenderer2.material.color;
				float num12 = (color22.a = num11);
				Color color24 = (windRenderer2.material.color = color22);
			}
			if (!(helicopterTransform.position.y >= 5f))
			{
				float y2 = helicopterTransform.position.y + 1.7f * Time.deltaTime;
				Vector3 position = helicopterTransform.position;
				float num13 = (position.y = y2);
				Vector3 vector4 = (helicopterTransform.position = position);
			}
		}
		if ((bool)playerScript && playerScript.alive && !(Mathf.Abs(playerScript.myTransform.position.x - helicopterGroup.position.x) >= 1.35f) && !(Mathf.Abs(playerScript.myTransform.position.z - helicopterGroup.position.z) >= 0.8f) && !(helicopterTransform.localPosition.y >= 1f))
		{
			StartCoroutine(playerScript.grabHelicopter(string.Empty));
		}
	}

	public virtual void handleVehicles()
	{
		for (int i = 0; i < Extensions.get_length(vehicles); i++)
		{
			if (vehicles[i].inUse && !(vehicles[i].remainingGas <= 0f) && !vehicles[i].occupied && (bool)playerScript && playerScript.alive && !playerScript.inVehicle && !(Mathf.Abs(playerScript.myTransform.position.x - vehicles[i].myTransform.position.x) >= 1.5f) && !(Mathf.Abs(playerScript.myTransform.position.z - vehicles[i].myTransform.position.z) >= 0.8f))
			{
				playerScript.enterVehicle(i.ToString());
			}
			if (!vehicles[i].myParent)
			{
				continue;
			}
			vehicles[i].myTransform.position = vehicles[i].myParent.position;
			if ((bool)playerScript && vehicles[i].myParent == playerScript.myTransform && !(playerScript.movementLockout > 0f))
			{
				if (vehicles[i].myAnimation["drive"].weight == 0f)
				{
					vehicles[i].myAnimation.Play("drive");
					sounds[11].Play();
				}
			}
			else if ((bool)allyScript && vehicles[i].myParent == allyScript.myTransform && !(allyScript.movementLockout > 0f) && vehicles[i].myAnimation["drive"].weight == 0f)
			{
				vehicles[i].myAnimation.Play("drive");
				sounds[11].Play();
			}
			if ((bool)playerScript && vehicles[i].myParent == playerScript.myTransform)
			{
				vehicles[i].remainingGas = vehicles[i].remainingGas - Time.deltaTime;
				if (!(vehicles[i].remainingGas > 0f))
				{
					playerScript.explodeVehicle(i.ToString());
				}
			}
		}
		if (DB.multiplayer && DB.whichPlayerAmI == 1 && (bool)allyScript && (bool)playerScript && allyScript.myVehicle == playerScript.myVehicle && allyScript.myVehicle != -1)
		{
			allyScript.eject(playerScript);
		}
		if (DB.multiplayer && DB.whichPlayerAmI == 2 && (bool)allyScript && (bool)playerScript && allyScript.myVehicle == playerScript.myVehicle && allyScript.myVehicle != -1)
		{
			playerScript.eject(allyScript);
		}
		if (((bool)playerScript && playerScript.inVehicle && playerScript.movementLockout <= 0f) || ((bool)allyScript && allyScript.inVehicle && !(allyScript.movementLockout > 0f)))
		{
			if (!sounds[10].isPlaying)
			{
				sounds[10].Play();
			}
		}
		else
		{
			sounds[10].Stop();
		}
	}

	public virtual void spawnHelicopter(string incomingData)
	{
		int num = 0;
		Vector3 localPosition = runForIt.localPosition;
		float num2 = (localPosition.y = num);
		Vector3 vector2 = (runForIt.localPosition = localPosition);
		runForItAnim.Play();
		hideRunForIt = 1.5f;
		float x = UnityBuiltins.parseFloat(incomingData);
		Vector3 position = helicopterGroup.position;
		float num3 = (position.x = x);
		Vector3 vector4 = (helicopterGroup.position = position);
		if (DB.location == Location.Mall)
		{
			spawnRoofShatter(helicopterGroup.position.x);
			sounds[4].Play();
		}
		helicopterActive = true;
		float a = 0f;
		Color color = heliShadow.material.color;
		float num4 = (color.a = a);
		Color color3 = (heliShadow.material.color = color);
		sounds[3].Play();
		sounds[3].volume = 0f;
		windAnimation1.Play();
		windAnimation2.Play();
		windAnimation2["loop"].normalizedTime = 0.5f;
		cameraHorizontalBounds.y = helicopterGroup.position.x + 0.5f;
		worldEnd = cameraHorizontalBounds.y + screenEdge - 0.4f;
		if (DB.whichPlayerAmI == 1 && DB.multiplayer)
		{
			broadcast("**MOTHERBRAIN", "spawnHelicopter", incomingData, true);
		}
	}

	public virtual void CheckForLevelComplete()
	{
		if (levelComplete)
		{
			return;
		}
		if (!DB.multiplayer && (bool)playerScript && !playerScript.alive)
		{
			if (DB.tutorial)
			{
				StartCoroutine(tutorialCompleteSequence());
			}
			else
			{
				StartCoroutine(levelCompleteSequence());
			}
		}
		else if (DB.multiplayer && (bool)playerScript && (bool)allyScript && !playerScript.alive && !allyScript.alive)
		{
			StartCoroutine(levelCompleteSequence());
		}
	}

	public virtual void levelCompleteAnimation()
	{
		if (fadeMusic && !(BGmusic.volume <= 0f))
		{
			BGmusic.volume -= Time.deltaTime;
		}
		if (showLevelComplete)
		{
			if (DB.multiplayer)
			{
				float y = Mathf.Lerp(levelCompletePage.localPosition.y, 0.4f, 12f * Time.deltaTime);
				Vector3 localPosition = levelCompletePage.localPosition;
				float num = (localPosition.y = y);
				Vector3 vector2 = (levelCompletePage.localPosition = localPosition);
			}
			else
			{
				float y2 = Mathf.Lerp(levelCompletePage.localPosition.y, 0f, 12f * Time.deltaTime);
				Vector3 localPosition2 = levelCompletePage.localPosition;
				float num2 = (localPosition2.y = y2);
				Vector3 vector4 = (levelCompletePage.localPosition = localPosition2);
			}
			float y3 = Mathf.Lerp(levelCompleteBG.localPosition.y, 0f, 12f * Time.deltaTime);
			Vector3 localPosition3 = levelCompleteBG.localPosition;
			float num3 = (localPosition3.y = y3);
			Vector3 vector6 = (levelCompleteBG.localPosition = localPosition3);
		}
		for (int i = 0; i < Extensions.get_length(stats); i++)
		{
			if (stats[i].slide)
			{
				float x = Mathf.Lerp(stats[i].leftSide.localPosition.x, 0.067f, 14f * Time.deltaTime);
				Vector3 localPosition4 = stats[i].leftSide.localPosition;
				float num4 = (localPosition4.x = x);
				Vector3 vector8 = (stats[i].leftSide.localPosition = localPosition4);
			}
			if (stats[i].scale)
			{
				float y4 = Mathf.Lerp(stats[i].rightSide.localScale.y, 0.0563f, 14f * Time.deltaTime);
				Vector3 localScale = stats[i].rightSide.localScale;
				float num5 = (localScale.y = y4);
				Vector3 vector10 = (stats[i].rightSide.localScale = localScale);
			}
			if (!stats[i].count)
			{
				continue;
			}
			if (!(stats[i].shown >= (float)stats[i].targetNumber))
			{
				stats[i].shown = stats[i].shown + UnityBuiltins.parseFloat(stats[i].targetNumber) * Time.deltaTime * 0.5f;
				if (!(stats[i].shown <= (float)stats[i].targetNumber))
				{
					stats[i].shown = stats[i].targetNumber;
				}
				stats[i].textMesh.text = Mathf.RoundToInt(stats[i].shown).ToString();
			}
			else if (stats[i].targetNumber == 0)
			{
				stats[i].textMesh.text = "0";
			}
		}
		if (!DB.multiplayer && stats[9].leftSide.localPosition.y != -50f)
		{
			int num6 = -50;
			Vector3 localPosition5 = stats[9].leftSide.localPosition;
			float num7 = (localPosition5.y = num6);
			Vector3 vector12 = (stats[9].leftSide.localPosition = localPosition5);
			int num8 = -50;
			Vector3 localPosition6 = stats[10].leftSide.localPosition;
			float num9 = (localPosition6.y = num8);
			Vector3 vector14 = (stats[10].leftSide.localPosition = localPosition6);
			int num10 = -50;
			Vector3 localPosition7 = stats[11].leftSide.localPosition;
			float num11 = (localPosition7.y = num10);
			Vector3 vector16 = (stats[11].leftSide.localPosition = localPosition7);
			int num12 = -50;
			Vector3 localPosition8 = stats[9].rightSide.localPosition;
			float num13 = (localPosition8.y = num12);
			Vector3 vector18 = (stats[9].rightSide.localPosition = localPosition8);
			int num14 = -50;
			Vector3 localPosition9 = stats[10].rightSide.localPosition;
			float num15 = (localPosition9.y = num14);
			Vector3 vector20 = (stats[10].rightSide.localPosition = localPosition9);
			int num16 = -50;
			Vector3 localPosition10 = stats[11].rightSide.localPosition;
			float num17 = (localPosition10.y = num16);
			Vector3 vector22 = (stats[11].rightSide.localPosition = localPosition10);
		}
	}

	public virtual void learnAllyScore(string incomingData)
	{
		allyScore = UnityBuiltins.parseInt(incomingData);
	}

	public virtual IEnumerator tutorialCompleteSequence()
	{
		return new _0024tutorialCompleteSequence_00241694(this).GetEnumerator();
	}

	public virtual IEnumerator levelCompleteSequence()
	{
		return new _0024levelCompleteSequence_00241697(this).GetEnumerator();
	}

	public virtual void freezeZombies()
	{
		for (int i = 0; i < Extensions.get_length(zombies); i++)
		{
			if ((bool)zombies[i] && zombies[i].enabled)
			{
				zombies[i].freeze();
			}
		}
	}

	public virtual IEnumerator goBackToMainMenu()
	{
		return new _0024goBackToMainMenu_00241729(this).GetEnumerator();
	}

	public virtual void OnApplicationPause(bool tempBool)
	{
		if (tempBool)
		{
			musicTime = BGmusic.time;
			if ((bool)DB && DB.multiplayer)
			{
				pausedMidCoop = true;
				disconnect();
			}
		}
		else if (pausedMidCoop)
		{
			DB.levelToLoad = "mainMenu";
			Application.LoadLevel("middleman");
		}
		else if (BGmusic.clip != null && !levelComplete && DB.musicEnabled)
		{
			BGmusic.Play();
			BGmusic.time = musicTime;
		}
	}

	public virtual void disconnect()
	{
		if (DB.multiplayer)
		{
			int num = -1;
			Vector3 position = disconnector.position;
			float num2 = (position.x = num);
			Vector3 vector2 = (disconnector.position = position);
			DB.multiplayer = false;
			DB.whichPlayerAmI = 1;
		}
	}

	public virtual void showBubble(int whichBubble)
	{
		if (whichBubble < 0)
		{
			int num = 100;
			Vector3 localPosition = bubbleTransform.localPosition;
			float num2 = (localPosition.y = num);
			Vector3 vector2 = (bubbleTransform.localPosition = localPosition);
			return;
		}
		bubbleRenderers[0].enabled = false;
		bubbleRenderers[1].enabled = false;
		bubbleRenderers[2].enabled = false;
		bubbleRenderers[(int)bubbles[whichBubble].bubbleType].enabled = true;
		tutorialTextMesh.text = bubbles[whichBubble].bubbleText;
		if (bubbles[whichBubble].leftJustify)
		{
			float x = 0f - screenEdge;
			Vector3 localPosition2 = bubbleTransform.localPosition;
			float num3 = (localPosition2.x = x);
			Vector3 vector4 = (bubbleTransform.localPosition = localPosition2);
		}
		else if (bubbles[whichBubble].rightJustify)
		{
			float x2 = screenEdge;
			Vector3 localPosition3 = bubbleTransform.localPosition;
			float num4 = (localPosition3.x = x2);
			Vector3 vector6 = (bubbleTransform.localPosition = localPosition3);
		}
		else
		{
			int num5 = 0;
			Vector3 localPosition4 = bubbleTransform.localPosition;
			float num6 = (localPosition4.x = num5);
			Vector3 vector8 = (bubbleTransform.localPosition = localPosition4);
		}
		if ((Screen.width == 1024 && Screen.height == 768) || (Screen.width == 2048 && Screen.height == 1536))
		{
			float y = bubbles[whichBubble].bubbleCenterPad.y;
			Vector3 localPosition5 = bubbleTransform.localPosition;
			float num7 = (localPosition5.y = y);
			Vector3 vector10 = (bubbleTransform.localPosition = localPosition5);
			float x3 = bubbleTransform.localPosition.x + bubbles[whichBubble].bubbleCenterPad.x;
			Vector3 localPosition6 = bubbleTransform.localPosition;
			float num8 = (localPosition6.x = x3);
			Vector3 vector12 = (bubbleTransform.localPosition = localPosition6);
		}
		else
		{
			float y2 = bubbles[whichBubble].bubbleCenter.y;
			Vector3 localPosition7 = bubbleTransform.localPosition;
			float num9 = (localPosition7.y = y2);
			Vector3 vector14 = (bubbleTransform.localPosition = localPosition7);
			float x4 = bubbleTransform.localPosition.x + bubbles[whichBubble].bubbleCenter.x;
			Vector3 localPosition8 = bubbleTransform.localPosition;
			float num10 = (localPosition8.x = x4);
			Vector3 vector16 = (bubbleTransform.localPosition = localPosition8);
		}
		bubbleAnimation.Stop();
		bubbleAnimation.Play();
		float width = bubbles[whichBubble].width;
		Vector3 localPosition9 = bubbleBoneTR.localPosition;
		float num11 = (localPosition9.x = width);
		Vector3 vector18 = (bubbleBoneTR.localPosition = localPosition9);
		float width2 = bubbles[whichBubble].width;
		Vector3 localPosition10 = bubbleBoneBR.localPosition;
		float num12 = (localPosition10.x = width2);
		Vector3 vector20 = (bubbleBoneBR.localPosition = localPosition10);
		float height = bubbles[whichBubble].height;
		Vector3 localPosition11 = bubbleBoneBR.localPosition;
		float num13 = (localPosition11.y = height);
		Vector3 vector22 = (bubbleBoneBR.localPosition = localPosition11);
		float height2 = bubbles[whichBubble].height;
		Vector3 localPosition12 = bubbleBoneB.localPosition;
		float num14 = (localPosition12.y = height2);
		Vector3 vector24 = (bubbleBoneB.localPosition = localPosition12);
		float height3 = bubbles[whichBubble].height;
		Vector3 localPosition13 = bubbleBoneBL.localPosition;
		float num15 = (localPosition13.y = height3);
		Vector3 vector26 = (bubbleBoneBL.localPosition = localPosition13);
		if (bubbles[whichBubble].bubbleType != 0)
		{
			float arrowPosition = bubbles[whichBubble].arrowPosition;
			Vector3 localPosition14 = bubbleBoneT.localPosition;
			float num16 = (localPosition14.x = arrowPosition);
			Vector3 vector28 = (bubbleBoneT.localPosition = localPosition14);
			float arrowPosition2 = bubbles[whichBubble].arrowPosition;
			Vector3 localPosition15 = bubbleBoneB.localPosition;
			float num17 = (localPosition15.x = arrowPosition2);
			Vector3 vector30 = (bubbleBoneB.localPosition = localPosition15);
		}
		float x5 = bubbles[whichBubble].colliderCenter.x;
		Vector3 center = bubbleCollider.center;
		float num18 = (center.x = x5);
		Vector3 vector32 = (bubbleCollider.center = center);
		float y3 = bubbles[whichBubble].colliderCenter.y;
		Vector3 center2 = bubbleCollider.center;
		float num19 = (center2.y = y3);
		Vector3 vector34 = (bubbleCollider.center = center2);
		float x6 = bubbles[whichBubble].colliderSize.x;
		Vector3 size = bubbleCollider.size;
		float num20 = (size.x = x6);
		Vector3 vector36 = (bubbleCollider.size = size);
		float y4 = bubbles[whichBubble].colliderSize.y;
		Vector3 size2 = bubbleCollider.size;
		float num21 = (size2.y = y4);
		Vector3 vector38 = (bubbleCollider.size = size2);
	}

	public virtual IEnumerator tutorialSequence()
	{
		return new _0024tutorialSequence_00241732(this).GetEnumerator();
	}

	public virtual IEnumerator showAchievementBubble(int whichAchievement)
	{
		return new _0024showAchievementBubble_00241737(whichAchievement, this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
