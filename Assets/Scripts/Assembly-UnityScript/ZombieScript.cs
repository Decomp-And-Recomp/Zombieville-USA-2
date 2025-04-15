using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class ZombieScript : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024flashingDeath_00241941 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_00241576_00241942;

			internal Vector3 _0024_00241577_00241943;

			internal int _0024_00241578_00241944;

			internal Vector3 _0024_00241579_00241945;

			internal int _0024_00241580_00241946;

			internal Vector3 _0024_00241581_00241947;

			internal int _0024_00241582_00241948;

			internal Vector3 _0024_00241583_00241949;

			internal int _0024_00241584_00241950;

			internal Vector3 _0024_00241585_00241951;

			internal int _0024_00241586_00241952;

			internal Vector3 _0024_00241587_00241953;

			internal int _0024_00241588_00241954;

			internal Vector3 _0024_00241589_00241955;

			internal int _0024_00241590_00241956;

			internal Vector3 _0024_00241591_00241957;

			internal int _0024_00241592_00241958;

			internal Vector3 _0024_00241593_00241959;

			internal int _0024_00241594_00241960;

			internal Vector3 _0024_00241595_00241961;

			internal int _0024_00241596_00241962;

			internal Vector3 _0024_00241597_00241963;

			internal int _0024_00241598_00241964;

			internal Vector3 _0024_00241599_00241965;

			internal int _0024_00241600_00241966;

			internal Vector3 _0024_00241601_00241967;

			internal int _0024_00241602_00241968;

			internal Vector3 _0024_00241603_00241969;

			internal int _0024_00241604_00241970;

			internal Vector3 _0024_00241605_00241971;

			internal int _0024_00241606_00241972;

			internal Vector3 _0024_00241607_00241973;

			internal int _0024_00241608_00241974;

			internal Vector3 _0024_00241609_00241975;

			internal int _0024_00241610_00241976;

			internal Vector3 _0024_00241611_00241977;

			internal ZombieScript _0024self__00241978;

			public _0024(ZombieScript self_)
			{
				_0024self__00241978 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(2.5f)) ? 1 : 0);
					break;
				case 2:
					if (!_0024self__00241978.alive)
					{
						int num31 = (_0024_00241576_00241942 = -100);
						Vector3 vector46 = (_0024_00241577_00241943 = _0024self__00241978.myTransform.position);
						float num32 = (_0024_00241577_00241943.y = _0024_00241576_00241942);
						Vector3 vector48 = (_0024self__00241978.myTransform.position = _0024_00241577_00241943);
						result = (Yield(3, new WaitForSeconds(0.05f)) ? 1 : 0);
						break;
					}
					goto case 3;
				case 3:
				{
					int num15 = (_0024_00241578_00241944 = 0);
					Vector3 vector22 = (_0024_00241579_00241945 = _0024self__00241978.myTransform.position);
					float num16 = (_0024_00241579_00241945.y = _0024_00241578_00241944);
					Vector3 vector24 = (_0024self__00241978.myTransform.position = _0024_00241579_00241945);
					result = (Yield(4, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 4:
					if (!_0024self__00241978.alive)
					{
						int num25 = (_0024_00241580_00241946 = -100);
						Vector3 vector37 = (_0024_00241581_00241947 = _0024self__00241978.myTransform.position);
						float num26 = (_0024_00241581_00241947.y = _0024_00241580_00241946);
						Vector3 vector39 = (_0024self__00241978.myTransform.position = _0024_00241581_00241947);
					}
					result = (Yield(5, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 5:
				{
					int num5 = (_0024_00241582_00241948 = 0);
					Vector3 vector7 = (_0024_00241583_00241949 = _0024self__00241978.myTransform.position);
					float num6 = (_0024_00241583_00241949.y = _0024_00241582_00241948);
					Vector3 vector9 = (_0024self__00241978.myTransform.position = _0024_00241583_00241949);
					result = (Yield(6, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 6:
					if (!_0024self__00241978.alive)
					{
						int num33 = (_0024_00241584_00241950 = -100);
						Vector3 vector49 = (_0024_00241585_00241951 = _0024self__00241978.myTransform.position);
						float num34 = (_0024_00241585_00241951.y = _0024_00241584_00241950);
						Vector3 vector51 = (_0024self__00241978.myTransform.position = _0024_00241585_00241951);
					}
					result = (Yield(7, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 7:
				{
					int num23 = (_0024_00241586_00241952 = 0);
					Vector3 vector34 = (_0024_00241587_00241953 = _0024self__00241978.myTransform.position);
					float num24 = (_0024_00241587_00241953.y = _0024_00241586_00241952);
					Vector3 vector36 = (_0024self__00241978.myTransform.position = _0024_00241587_00241953);
					result = (Yield(8, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 8:
					if (!_0024self__00241978.alive)
					{
						int num17 = (_0024_00241588_00241954 = -100);
						Vector3 vector25 = (_0024_00241589_00241955 = _0024self__00241978.myTransform.position);
						float num18 = (_0024_00241589_00241955.y = _0024_00241588_00241954);
						Vector3 vector27 = (_0024self__00241978.myTransform.position = _0024_00241589_00241955);
					}
					result = (Yield(9, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 9:
				{
					int num7 = (_0024_00241590_00241956 = 0);
					Vector3 vector10 = (_0024_00241591_00241957 = _0024self__00241978.myTransform.position);
					float num8 = (_0024_00241591_00241957.y = _0024_00241590_00241956);
					Vector3 vector12 = (_0024self__00241978.myTransform.position = _0024_00241591_00241957);
					result = (Yield(10, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 10:
					if (!_0024self__00241978.alive)
					{
						int num9 = (_0024_00241592_00241958 = -100);
						Vector3 vector13 = (_0024_00241593_00241959 = _0024self__00241978.myTransform.position);
						float num10 = (_0024_00241593_00241959.y = _0024_00241592_00241958);
						Vector3 vector15 = (_0024self__00241978.myTransform.position = _0024_00241593_00241959);
					}
					result = (Yield(11, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 11:
				{
					int num35 = (_0024_00241594_00241960 = 0);
					Vector3 vector52 = (_0024_00241595_00241961 = _0024self__00241978.myTransform.position);
					float num36 = (_0024_00241595_00241961.y = _0024_00241594_00241960);
					Vector3 vector54 = (_0024self__00241978.myTransform.position = _0024_00241595_00241961);
					result = (Yield(12, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 12:
					if (!_0024self__00241978.alive)
					{
						int num29 = (_0024_00241596_00241962 = -100);
						Vector3 vector43 = (_0024_00241597_00241963 = _0024self__00241978.myTransform.position);
						float num30 = (_0024_00241597_00241963.y = _0024_00241596_00241962);
						Vector3 vector45 = (_0024self__00241978.myTransform.position = _0024_00241597_00241963);
					}
					result = (Yield(13, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 13:
				{
					int num27 = (_0024_00241598_00241964 = 0);
					Vector3 vector40 = (_0024_00241599_00241965 = _0024self__00241978.myTransform.position);
					float num28 = (_0024_00241599_00241965.y = _0024_00241598_00241964);
					Vector3 vector42 = (_0024self__00241978.myTransform.position = _0024_00241599_00241965);
					result = (Yield(14, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 14:
					if (!_0024self__00241978.alive)
					{
						int num21 = (_0024_00241600_00241966 = -100);
						Vector3 vector31 = (_0024_00241601_00241967 = _0024self__00241978.myTransform.position);
						float num22 = (_0024_00241601_00241967.y = _0024_00241600_00241966);
						Vector3 vector33 = (_0024self__00241978.myTransform.position = _0024_00241601_00241967);
					}
					result = (Yield(15, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 15:
				{
					int num19 = (_0024_00241602_00241968 = 0);
					Vector3 vector28 = (_0024_00241603_00241969 = _0024self__00241978.myTransform.position);
					float num20 = (_0024_00241603_00241969.y = _0024_00241602_00241968);
					Vector3 vector30 = (_0024self__00241978.myTransform.position = _0024_00241603_00241969);
					result = (Yield(16, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 16:
					if (!_0024self__00241978.alive)
					{
						int num13 = (_0024_00241604_00241970 = -100);
						Vector3 vector19 = (_0024_00241605_00241971 = _0024self__00241978.myTransform.position);
						float num14 = (_0024_00241605_00241971.y = _0024_00241604_00241970);
						Vector3 vector21 = (_0024self__00241978.myTransform.position = _0024_00241605_00241971);
					}
					result = (Yield(17, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				case 17:
				{
					int num11 = (_0024_00241606_00241972 = 0);
					Vector3 vector16 = (_0024_00241607_00241973 = _0024self__00241978.myTransform.position);
					float num12 = (_0024_00241607_00241973.y = _0024_00241606_00241972);
					Vector3 vector18 = (_0024self__00241978.myTransform.position = _0024_00241607_00241973);
					result = (Yield(18, new WaitForSeconds(0.05f)) ? 1 : 0);
					break;
				}
				case 18:
					if (!_0024self__00241978.alive)
					{
						_0024self__00241978.enabled = false;
						if (_0024self__00241978.zombieType == EnemyType.Spitter)
						{
							_0024self__00241978.mySpit.life = -10f;
							int num = (_0024_00241608_00241974 = 100);
							Vector3 vector = (_0024_00241609_00241975 = _0024self__00241978.mySpit.tran.position);
							float num2 = (_0024_00241609_00241975.y = _0024_00241608_00241974);
							Vector3 vector3 = (_0024self__00241978.mySpit.tran.position = _0024_00241609_00241975);
						}
						int num3 = (_0024_00241610_00241976 = 100);
						Vector3 vector4 = (_0024_00241611_00241977 = _0024self__00241978.myTransform.position);
						float num4 = (_0024_00241611_00241977.y = _0024_00241610_00241976);
						Vector3 vector6 = (_0024self__00241978.myTransform.position = _0024_00241611_00241977);
						_0024self__00241978.availableForSpawning = true;
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

		internal ZombieScript _0024self__00241979;

		public _0024flashingDeath_00241941(ZombieScript self_)
		{
			_0024self__00241979 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241979);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024emerge_00241980 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ZombieScript _0024self__00241981;

			public _0024(ZombieScript self_)
			{
				_0024self__00241981 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241981.motherBrain.emergeSounds[_0024self__00241981.motherBrain.emergeSound].Play();
					_0024self__00241981.motherBrain.emergeSound = _0024self__00241981.motherBrain.emergeSound + 1;
					if (_0024self__00241981.motherBrain.emergeSound == Extensions.get_length((Array)_0024self__00241981.motherBrain.emergeSounds))
					{
						_0024self__00241981.motherBrain.emergeSound = 0;
					}
					_0024self__00241981.emerging = true;
					_0024self__00241981.gameObject.layer = 13;
					_0024self__00241981.myAnimation.Play("emerge");
					result = (Yield(2, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241981.health > 0)
					{
						_0024self__00241981.gameObject.layer = 12;
					}
					result = (Yield(3, new WaitForSeconds(0.4f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241981.emerging = false;
					if (_0024self__00241981.health > 0)
					{
						_0024self__00241981.myAnimation.CrossFade("run");
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

		internal ZombieScript _0024self__00241982;

		public _0024emerge_00241980(ZombieScript self_)
		{
			_0024self__00241982 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241982);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024delayedSound_00241983 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AudioSource _0024whichSound_00241984;

			internal float _0024howLong_00241985;

			public _0024(AudioSource whichSound, float howLong)
			{
				_0024whichSound_00241984 = whichSound;
				_0024howLong_00241985 = howLong;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(_0024howLong_00241985)) ? 1 : 0);
					break;
				case 2:
					_0024whichSound_00241984.pitch = UnityEngine.Random.Range(0.92f, 1.08f);
					_0024whichSound_00241984.Play();
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal AudioSource _0024whichSound_00241986;

		internal float _0024howLong_00241987;

		public _0024delayedSound_00241983(AudioSource whichSound, float howLong)
		{
			_0024whichSound_00241986 = whichSound;
			_0024howLong_00241987 = howLong;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichSound_00241986, _0024howLong_00241987);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024spit_00241988 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal float _0024_00241616_00241989;

			internal Vector3 _0024_00241617_00241990;

			internal float _0024_00241618_00241991;

			internal Color _0024_00241619_00241992;

			internal ZombieScript _0024self__00241993;

			public _0024(ZombieScript self_)
			{
				_0024self__00241993 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241993.DB.multiplayer)
					{
						_0024self__00241993.stateSyncDelay = 1.3f;
						_0024self__00241993.textMessage = _0024self__00241993.myTransform.name + " " + Mathf.Round(_0024self__00241993.myTransform.position.x * 100f) / 100f + " " + Mathf.Round(_0024self__00241993.myTransform.position.z * 100f) / 100f + " " + _0024self__00241993.myTransform.localScale.x;
						_0024self__00241993.broadcast(_0024self__00241993.myTransform.name, "syncSpit", _0024self__00241993.textMessage, true);
					}
					_0024self__00241993.spitting = true;
					_0024self__00241993.spitDelay = UnityEngine.Random.Range(_0024self__00241993.spitCooldown.x, _0024self__00241993.spitCooldown.y);
					_0024self__00241993.motionDelay = 1.3f;
					_0024self__00241993.myAnimation.Play("windup");
					result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241993.health > 0 && !(_0024self__00241993.onFire > 0f) && !(_0024self__00241993.stunned > 0f) && !(_0024self__00241993.frozen > 0f) && !_0024self__00241993.emerging)
					{
						_0024self__00241993.spitSound.pitch = UnityEngine.Random.Range(0.92f, 1.08f);
						_0024self__00241993.spitSound.Play();
						_0024self__00241993.myAnimation.Play("spit");
						if (_0024self__00241993.mySpit.tran.localScale.x != _0024self__00241993.myTransform.localScale.x)
						{
							float num = (_0024_00241616_00241989 = _0024self__00241993.myTransform.localScale.x);
							Vector3 vector = (_0024_00241617_00241990 = _0024self__00241993.mySpit.tran.localScale);
							float num2 = (_0024_00241617_00241990.x = _0024_00241616_00241989);
							Vector3 vector3 = (_0024self__00241993.mySpit.tran.localScale = _0024_00241617_00241990);
						}
						_0024self__00241993.mySpit.tran.position = _0024self__00241993.myTransform.position + new Vector3(_0024self__00241993.myTransform.localScale.x * 1f, 0f, -0.1f);
						_0024self__00241993.mySpit.anim.Stop();
						_0024self__00241993.mySpit.anim.Play("idle");
						float num3 = (_0024_00241618_00241991 = 1f);
						Color color = (_0024_00241619_00241992 = _0024self__00241993.mySpit.rend.material.color);
						float num4 = (_0024_00241619_00241992.a = _0024_00241618_00241991);
						Color color3 = (_0024self__00241993.mySpit.rend.material.color = _0024_00241619_00241992);
						_0024self__00241993.mySpit.vector = new Vector3(_0024self__00241993.myTransform.localScale.x * 3.5f, 0f, 0f);
						_0024self__00241993.mySpit.life = 3f;
					}
					result = (Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00241993.spitting = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal ZombieScript _0024self__00241994;

		public _0024spit_00241988(ZombieScript self_)
		{
			_0024self__00241994 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241994);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024syncSpit_00241995 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal string[] _0024words_00241996;

			internal int _0024_00241620_00241997;

			internal Vector3 _0024_00241621_00241998;

			internal float _0024_00241622_00241999;

			internal Vector3 _0024_00241623_00242000;

			internal float _0024_00241624_00242001;

			internal Color _0024_00241625_00242002;

			internal string _0024incomingData_00242003;

			internal ZombieScript _0024self__00242004;

			public _0024(string incomingData, ZombieScript self_)
			{
				_0024incomingData_00242003 = incomingData;
				_0024self__00242004 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
				{
					_0024self__00242004.timeSinceLastSync = 0f;
					_0024words_00241996 = _0024incomingData_00242003.Split(" "[0]);
					_0024self__00242004.movementVector = new Vector3(0f, 0f, 0f);
					_0024self__00242004.positionMagnet = new Vector3(UnityBuiltins.parseFloat(_0024words_00241996[1]), 0f, UnityBuiltins.parseFloat(_0024words_00241996[2]));
					int num5 = (_0024_00241620_00241997 = UnityBuiltins.parseInt(_0024words_00241996[3]));
					Vector3 vector4 = (_0024_00241621_00241998 = _0024self__00242004.myTransform.localScale);
					float num6 = (_0024_00241621_00241998.x = _0024_00241620_00241997);
					Vector3 vector6 = (_0024self__00242004.myTransform.localScale = _0024_00241621_00241998);
					_0024self__00242004.spitting = true;
					_0024self__00242004.myAnimation.Play("windup");
					result = (Yield(2, new WaitForSeconds(0.7f)) ? 1 : 0);
					break;
				}
				case 2:
					if (_0024self__00242004.health > 0)
					{
						_0024self__00242004.spitSound.pitch = UnityEngine.Random.Range(0.92f, 1.08f);
						_0024self__00242004.spitSound.Play();
						_0024self__00242004.myAnimation.Play("spit");
						if (_0024self__00242004.mySpit.tran.localScale.x != _0024self__00242004.myTransform.localScale.x)
						{
							float num = (_0024_00241622_00241999 = _0024self__00242004.myTransform.localScale.x);
							Vector3 vector = (_0024_00241623_00242000 = _0024self__00242004.mySpit.tran.localScale);
							float num2 = (_0024_00241623_00242000.x = _0024_00241622_00241999);
							Vector3 vector3 = (_0024self__00242004.mySpit.tran.localScale = _0024_00241623_00242000);
						}
						_0024self__00242004.mySpit.tran.position = _0024self__00242004.myTransform.position + new Vector3(_0024self__00242004.myTransform.localScale.x * 1f, 0f, -0.1f);
						_0024self__00242004.mySpit.anim.Stop();
						_0024self__00242004.mySpit.anim.Play("idle");
						float num3 = (_0024_00241624_00242001 = 1f);
						Color color = (_0024_00241625_00242002 = _0024self__00242004.mySpit.rend.material.color);
						float num4 = (_0024_00241625_00242002.a = _0024_00241624_00242001);
						Color color3 = (_0024self__00242004.mySpit.rend.material.color = _0024_00241625_00242002);
						_0024self__00242004.mySpit.vector = new Vector3(_0024self__00242004.myTransform.localScale.x * 3.5f, 0f, 0f);
						_0024self__00242004.mySpit.life = 3f;
					}
					result = (Yield(3, new WaitForSeconds(0.6f)) ? 1 : 0);
					break;
				case 3:
					_0024self__00242004.spitting = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal string _0024incomingData_00242005;

		internal ZombieScript _0024self__00242006;

		public _0024syncSpit_00241995(string incomingData, ZombieScript self_)
		{
			_0024incomingData_00242005 = incomingData;
			_0024self__00242006 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024incomingData_00242005, _0024self__00242006);
		}
	}

	public bool alive;

	public bool availableForSpawning;

	public int AIType;

	public float forceSpawnPosition;

	public EnemyType zombieType;

	public float ammoMoneyBias;

	public float[] ammoChance;

	public float[] moneyChance;

	public bool noHitEffects;

	public int pointValue;

	public int[] pointValueArray;

	public int health;

	public int maxHealth;

	public int[] maxHealthArray;

	public int specialSpawnChance;

	public int power;

	public int[] powerArray;

	public float enemySize;

	public death[] myDeaths;

	public subArray[] deathsByDamageType;

	public Renderer[] charredRenderer;

	public Animation charredAnimation;

	public Renderer stunnedRenderer;

	public Animation stunnedAnimation;

	public Renderer frozenRenderer;

	public Animation frozenAnimation;

	private AnimationState stunnedAnimationState;

	public AudioSource[] meleeSounds;

	public AudioSource[] pounceSounds;

	public Transform myTransform;

	public Animation myAnimation;

	public GameObject myGameObject;

	public Renderer myRenderer;

	public MotherBrain motherBrain;

	public Database DB;

	private float stateSyncDelay;

	public float timeSinceLastSync;

	public float ignoreSync;

	private AnimationState runState;

	public AudioSource escapeSound;

	private bool emerging;

	public Spit mySpit;

	public AudioSource spitSound;

	public AudioSource spitHitSound;

	public Transform myTarget;

	public PlayerScript myTargetScript;

	public int AIState;

	public float moveSpeed;

	public float[] moveSpeedArray;

	public float runAnimBaseline;

	public float meleeRange;

	public float knockbackMod;

	public float attackCooldown;

	public Vector3 movementVector;

	private float attackDelay;

	private string textMessage;

	private RaycastHit tempHit;

	private float collisionCheck;

	private float motionDelay;

	private float collisionFrequency;

	public float recentAttack;

	private Vector3 chewingPosition;

	private float chewingTimer;

	private float onFire;

	private float stunned;

	private float frozen;

	private float spitDelay;

	public Vector2 spitCooldown;

	public Vector2[] spitCooldownArray;

	private bool spitting;

	private float retargetPulse;

	public float retargetRange;

	private float retargetCooldown;

	private float spitCollisionPulse;

	public Vector3 slideVector;

	public bool redAnim;

	public bool greenAnim;

	public bool blueAnim;

	private float colorSpeed;

	public Vector3 positionMagnet;

	public Transform hitTransform;

	public Animation hitAnimation;

	public Transform hitTransform2;

	public Animation hitAnimation2;

	public bool hitToggle;

	public float[] hitReset;

	public EffectMachine myExplosion;

	public AudioSource myExplosionSound;

	public ZombieScript()
	{
		availableForSpawning = true;
		AIType = 1;
		forceSpawnPosition = 100f;
		ammoMoneyBias = 0.5f;
		ammoChance = new float[3];
		moneyChance = new float[3];
		pointValue = 2;
		pointValueArray = new int[9];
		health = 100;
		maxHealth = 100;
		maxHealthArray = new int[9];
		specialSpawnChance = 50;
		power = 10;
		powerArray = new int[9];
		moveSpeed = 1.5f;
		moveSpeedArray = new float[9];
		runAnimBaseline = 0.7f;
		meleeRange = 1.15f;
		knockbackMod = 1f;
		attackCooldown = 0.4f;
		movementVector = new Vector3(0f, 0f, 0f);
		textMessage = string.Empty;
		collisionFrequency = 0.5f;
		chewingPosition = new Vector3(9f, 9f, 9f);
		spitDelay = 5f;
		retargetPulse = 0.3f;
		retargetRange = 1.8f;
		spitCollisionPulse = 0.1f;
		colorSpeed = 5f;
		hitToggle = true;
	}

	public virtual void Initialize(Database linkToDB, MotherBrain linkToMB)
	{
		myGameObject = gameObject;
		motherBrain = linkToMB;
		DB = linkToDB;
		myTransform = transform;
		if (zombieType != EnemyType.Container)
		{
			myAnimation = (Animation)myTransform.Find("MayaFile").GetComponent(typeof(Animation));
			myRenderer = (Renderer)myTransform.Find("MayaFile/geometry").GetComponent(typeof(Renderer));
			myAnimation["hit1"].layer = 1;
			myAnimation["hit1"].blendMode = AnimationBlendMode.Additive;
			if ((bool)stunnedAnimation)
			{
				stunnedAnimationState = stunnedAnimation["stunned"];
				stunnedAnimation["hit1"].layer = 1;
				stunnedAnimation["hit1"].blendMode = AnimationBlendMode.Additive;
			}
			runState = myAnimation["run"];
			if (zombieType == EnemyType.Exploder)
			{
				Transform mix = myTransform.Find("MayaFile/GAS");
				myAnimation["gasloop"].AddMixingTransform(mix);
				myAnimation["gasloop"].layer = 2;
				mix = myTransform.Find("zombie5_stunned/GAS");
				if ((bool)stunnedAnimation)
				{
					stunnedAnimation["gasloop"].AddMixingTransform(mix);
					stunnedAnimation["gasloop"].layer = 2;
				}
			}
		}
		else
		{
			myRenderer = (Renderer)myTransform.Find("Geo").GetComponent(typeof(Renderer));
		}
		if (!DB.soundEnabled)
		{
			muteSounds();
		}
		interpretDifficulty();
	}

	public virtual void RemoteUpdate()
	{
		if (!(ignoreSync <= 0f))
		{
			ignoreSync -= Time.deltaTime;
			if (!(ignoreSync > 0f))
			{
				positionMagnet = myTransform.position;
				chewingPosition = myTransform.position;
				timeSinceLastSync = 0f;
			}
		}
		timeSinceLastSync += Time.deltaTime;
		if (health > 0)
		{
			if (onFire > 0f || stunned > 0f || frozen > 0f || emerging)
			{
				disabled();
			}
			else if (zombieType != EnemyType.Container)
			{
				AI();
				characterAnimation();
			}
		}
		spitAnimation();
		shaderAnimation();
		slidingAnimation();
		handleEffects();
	}

	public virtual void AI()
	{
		if (AIType == 1)
		{
			basicAI();
		}
	}

	public virtual void basicAI()
	{
		if (!(retargetCooldown <= 0f))
		{
			retargetCooldown -= Time.deltaTime;
		}
		retargetPulse -= Time.deltaTime;
		if (!(retargetPulse > 0f) && !(retargetCooldown > 0f))
		{
			retargetPulse = 0.3f;
			if (DB.multiplayer && (bool)motherBrain.playerScript && (bool)motherBrain.allyScript && motherBrain.playerScript.alive && motherBrain.allyScript.alive && !spitting && (bool)myTargetScript && myTargetScript == motherBrain.allyScript && motherBrain.allyScript.alive && !(Vector3.Distance(myTransform.position, motherBrain.playerScript.myTransform.position) >= retargetRange))
			{
				bool flag = false;
				for (int i = 0; i < 3; i++)
				{
					if (motherBrain.playerScript.perks[i] == 21 && !((float)UnityEngine.Random.Range(0, 101) >= DB.perks[21].rankBonuses[motherBrain.playerScript.perkRanks[i]]))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					myTargetScript = motherBrain.playerScript;
					myTarget = motherBrain.playerScript.myTransform;
					broadcast(myTransform.name, "changeOwnership", myTransform.name, true);
					positionMagnet = myTransform.position;
					chewingPosition = myTransform.position;
					attackDelay = 0.1f;
					retargetCooldown = 1f;
				}
			}
		}
		if (!myTarget || !myTargetScript)
		{
			targetNearest();
		}
		else if ((bool)myTargetScript && myTargetScript == motherBrain.playerScript)
		{
			if (!(attackDelay <= 0f))
			{
				attackDelay -= Time.deltaTime;
			}
			if (zombieType == EnemyType.Spitter && !(spitDelay <= 0f) && !(recentAttack > 0f) && !spitting)
			{
				spitDelay -= Time.deltaTime;
				if (!(spitDelay > 0f))
				{
					StartCoroutine_Auto(spit());
				}
			}
			if (!spitting && !(Vector3.Distance(myTarget.position, myTransform.position) <= meleeRange))
			{
				movementVector = (myTarget.position - myTransform.position).normalized;
			}
			else if (!spitting)
			{
				if (zombieType == EnemyType.Exploder && !myTargetScript.invincible)
				{
					attack();
				}
				else if (zombieType == EnemyType.Exploder && myTargetScript.invincible)
				{
					recentAttack = 0.4f;
				}
				else
				{
					if (runState.weight == 1f && !myTargetScript.invincible)
					{
						movementVector = myTarget.position - myTransform.position;
						chewingPosition = myTransform.position + movementVector * 0.4f;
						chewingTimer = 0.8f;
					}
					movementVector = new Vector3(0f, 0f, 0f);
					if (!(attackDelay > 0f))
					{
						attackDelay = attackCooldown;
						if (!myTargetScript.invincible)
						{
							attack();
						}
					}
				}
			}
			collisionCheck -= Time.deltaTime;
			if (!(collisionCheck > 0f))
			{
				collisionCheck = collisionFrequency;
				if (movementVector != new Vector3(0f, 0f, 0f) && zombieType != EnemyType.Feral && Physics.Raycast(myTransform.position, movementVector, out tempHit, 0.7f, motherBrain.zombieMask))
				{
					movementVector = new Vector3(0f, 0f, 0f);
					motionDelay = collisionFrequency;
				}
			}
			if (!(motionDelay <= 0f))
			{
				motionDelay -= Time.deltaTime;
				movementVector = new Vector3(0f, 0f, 0f);
			}
			if (!(recentAttack <= 0f))
			{
				recentAttack -= Time.deltaTime;
				movementVector = new Vector3(0f, 0f, 0f);
			}
		}
		else if (myTargetScript == motherBrain.allyScript && !(ignoreSync > 0f))
		{
			if (movementVector == new Vector3(0f, 0f, 0f))
			{
				myTransform.position = Vector3.Lerp(myTransform.position, positionMagnet, Time.deltaTime * 12f);
			}
			else
			{
				myTransform.position = Vector3.Lerp(myTransform.position, positionMagnet + movementVector * moveSpeed * timeSinceLastSync, Time.deltaTime * 5f);
			}
		}
	}

	public virtual void disabled()
	{
		int num = 0;
		if (!(frozen <= 0f))
		{
			onFire = 0f;
			stunned = 0f;
			if (stunnedRenderer.enabled)
			{
				stunnedRenderer.enabled = false;
				stunned = 0f;
			}
			if (charredRenderer[0].enabled)
			{
				charredRenderer[0].enabled = false;
				charredRenderer[1].enabled = false;
			}
			if (!frozenRenderer.enabled)
			{
				myRenderer.enabled = false;
				frozenRenderer.enabled = true;
				frozenRenderer.material.color = new Color(1f, 1f, 1f);
				frozenAnimation.Play("idle");
			}
			frozen -= Time.deltaTime;
			if (!(frozen > 1f))
			{
				frozenAnimation.Play("escape");
			}
			else
			{
				frozenAnimation.Play("idle");
			}
			if (!(frozen > 0f))
			{
				myRenderer.enabled = true;
				frozenRenderer.enabled = false;
				myRenderer.material.color = new Color(0.1f, 0.25f, 0.9f);
				activateColors();
				colorSpeed = 4f;
				escapeSound.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
				escapeSound.Play();
				motherBrain.spawnEscape(myTransform.position + new Vector3(0f, 0.6f, 0.2f));
			}
		}
		else if (!(onFire <= 0f))
		{
			stunned = 0f;
			if (stunnedRenderer.enabled)
			{
				stunnedRenderer.enabled = false;
			}
			if (!charredRenderer[0].enabled)
			{
				num = UnityEngine.Random.Range(0, Extensions.get_length((Array)pounceSounds));
				pounceSounds[num].pitch = UnityEngine.Random.Range(0.85f, 1.15f);
				pounceSounds[num].Play();
				myRenderer.enabled = false;
				charredRenderer[0].enabled = true;
				charredRenderer[0].material.color = new Color(0.8f, 0f, 0f);
				charredRenderer[1].enabled = true;
				charredAnimation.Play();
			}
			onFire -= Time.deltaTime;
			if (!(stunned <= 0f))
			{
				stunned -= Time.deltaTime;
			}
			if (!(onFire > 0f))
			{
				myRenderer.enabled = true;
				myRenderer.material.color = new Color(0f, 0f, 0f);
				activateColors();
				colorSpeed = 4f;
				charredRenderer[0].enabled = false;
				charredRenderer[1].enabled = false;
			}
		}
		else if (!(stunned <= 0f))
		{
			if (!stunnedRenderer.enabled)
			{
				num = UnityEngine.Random.Range(0, Extensions.get_length((Array)pounceSounds));
				pounceSounds[num].pitch = UnityEngine.Random.Range(0.85f, 1.15f);
				pounceSounds[num].Play();
				myRenderer.enabled = false;
				stunnedRenderer.enabled = true;
				stunnedRenderer.material.color = new Color(1f, 1f, 1f);
				stunnedAnimation.Play("stunned");
				stunnedAnimationState.normalizedTime = UnityEngine.Random.Range(0f, 1f);
			}
			stunned -= Time.deltaTime;
			if (!(stunned > 0f))
			{
				myRenderer.enabled = true;
				stunnedRenderer.enabled = false;
			}
		}
	}

	public virtual void characterAnimation()
	{
		if (AIState != 0)
		{
			return;
		}
		if (movementVector.y != 0f)
		{
			movementVector.y = 0f;
		}
		if (!(chewingTimer <= 0f))
		{
			chewingTimer -= Time.deltaTime;
			myTransform.position = Vector3.Lerp(myTransform.position, chewingPosition, Time.deltaTime * 12f);
		}
		if (movementVector != new Vector3(0f, 0f, 0f))
		{
			myAnimation.CrossFade("run", 0.15f);
			myTransform.position += movementVector * Time.deltaTime * moveSpeed;
			if (runState.speed != moveSpeed / runAnimBaseline)
			{
				runState.speed = moveSpeed / runAnimBaseline;
			}
		}
		if (!spitting)
		{
			if ((bool)myTarget && !(myTarget.position.x <= myTransform.position.x) && myTransform.localScale.x != 1f)
			{
				int num = 1;
				Vector3 localScale = myTransform.localScale;
				float num2 = (localScale.x = num);
				Vector3 vector2 = (myTransform.localScale = localScale);
			}
			else if ((bool)myTarget && !(myTarget.position.x >= myTransform.position.x) && myTransform.localScale.x != -1f)
			{
				int num3 = -1;
				Vector3 localScale2 = myTransform.localScale;
				float num4 = (localScale2.x = num3);
				Vector3 vector4 = (myTransform.localScale = localScale2);
			}
		}
	}

	public virtual void spitAnimation()
	{
		if (zombieType != EnemyType.Spitter)
		{
			return;
		}
		if (!(mySpit.life <= 0f))
		{
			mySpit.tran.position = mySpit.tran.position + mySpit.vector * Time.deltaTime;
			if ((bool)myTargetScript && myTargetScript == motherBrain.playerScript)
			{
				mySpit.life -= Time.deltaTime;
				spitCollisionPulse -= Time.deltaTime;
				if (!(spitCollisionPulse > 0f))
				{
					spitCollisionPulse = 0.1f;
					if ((bool)motherBrain.allyScript && !motherBrain.allyScript.invincible && !(Mathf.Abs(mySpit.tran.position.x - motherBrain.allyScript.myTransform.position.x) >= 1f) && !(Mathf.Abs(mySpit.tran.position.z - motherBrain.allyScript.myTransform.position.z) >= 0.7f) && mySpit.tran.position.y == 0f)
					{
						mySpit.life = 0f;
					}
					else if ((bool)motherBrain.playerScript && !motherBrain.playerScript.invincible && !(Mathf.Abs(mySpit.tran.position.x - motherBrain.playerScript.myTransform.position.x) >= 1f) && !(Mathf.Abs(mySpit.tran.position.z - motherBrain.playerScript.myTransform.position.z) >= 0.7f) && mySpit.tran.position.y == 0f)
					{
						mySpit.life = 0f;
					}
				}
				if (!(mySpit.life > 0f) && mySpit.tran.position.y == 0f)
				{
					spitDetonate();
				}
			}
		}
		if (!(mySpit.life > 0f) && !(mySpit.life <= -1.5f))
		{
			float x = mySpit.opacity.localScale.x;
			Color color = mySpit.rend.material.color;
			float num = (color.a = x);
			Color color3 = (mySpit.rend.material.color = color);
			mySpit.life -= Time.deltaTime;
			if (!(mySpit.life > -1.5f))
			{
				mySpit.life = -10f;
				int num2 = 100;
				Vector3 position = mySpit.tran.position;
				float num3 = (position.y = num2);
				Vector3 vector2 = (mySpit.tran.position = position);
			}
		}
	}

	public virtual void targetNearest()
	{
		if ((bool)motherBrain.playerScript && (bool)motherBrain.allyScript && motherBrain.playerScript.alive && motherBrain.allyScript.alive)
		{
			if (!(Vector3.Distance(motherBrain.playerScript.myTransform.position, myTransform.position) >= Vector3.Distance(motherBrain.allyScript.myTransform.position, myTransform.position)))
			{
				myTargetScript = motherBrain.playerScript;
				if (myTargetScript.perks[0] == 21)
				{
					int num = UnityEngine.Random.Range(0, 101);
					if (!((float)num >= DB.perks[21].rankBonuses[myTargetScript.perkRanks[0]]))
					{
						myTargetScript = myTargetScript.motherBrain.allyScript;
					}
				}
				else if (myTargetScript.perks[1] == 21)
				{
					int num = UnityEngine.Random.Range(0, 101);
					if (!((float)num >= DB.perks[21].rankBonuses[myTargetScript.perkRanks[1]]))
					{
						myTargetScript = myTargetScript.motherBrain.allyScript;
					}
				}
				else if (myTargetScript.perks[2] == 21)
				{
					int num = UnityEngine.Random.Range(0, 101);
					if (!((float)num >= DB.perks[21].rankBonuses[myTargetScript.perkRanks[2]]))
					{
						myTargetScript = myTargetScript.motherBrain.allyScript;
					}
				}
			}
			else
			{
				myTargetScript = motherBrain.allyScript;
				if (myTargetScript.perks[0] == 21)
				{
					int num = UnityEngine.Random.Range(0, 101);
					if (!((float)num >= DB.perks[21].rankBonuses[myTargetScript.perkRanks[0]]))
					{
						myTargetScript = myTargetScript.motherBrain.playerScript;
					}
				}
				else if (myTargetScript.perks[1] == 21)
				{
					int num = UnityEngine.Random.Range(0, 101);
					if (!((float)num >= DB.perks[21].rankBonuses[myTargetScript.perkRanks[1]]))
					{
						myTargetScript = myTargetScript.motherBrain.playerScript;
					}
				}
				else if (myTargetScript.perks[2] == 21)
				{
					int num = UnityEngine.Random.Range(0, 101);
					if (!((float)num >= DB.perks[21].rankBonuses[myTargetScript.perkRanks[2]]))
					{
						myTargetScript = myTargetScript.motherBrain.playerScript;
					}
				}
			}
			myTarget = myTargetScript.myTransform;
		}
		else if ((bool)motherBrain.allyScript && (bool)motherBrain.playerScript)
		{
			if (!motherBrain.allyScript.alive)
			{
				myTargetScript = motherBrain.playerScript;
			}
			else
			{
				myTargetScript = motherBrain.allyScript;
			}
			myTarget = myTargetScript.myTransform;
		}
		else if ((bool)motherBrain.playerScript)
		{
			myTargetScript = motherBrain.playerScript;
			myTarget = myTargetScript.myTransform;
		}
		if ((bool)myTarget && !(myTarget.position.x <= myTransform.position.x) && myTransform.localScale.x != 1f)
		{
			int num2 = 1;
			Vector3 localScale = myTransform.localScale;
			float num3 = (localScale.x = num2);
			Vector3 vector2 = (myTransform.localScale = localScale);
		}
		else if ((bool)myTarget && !(myTarget.position.x >= myTransform.position.x) && myTransform.localScale.x != -1f)
		{
			int num4 = -1;
			Vector3 localScale2 = myTransform.localScale;
			float num5 = (localScale2.x = num4);
			Vector3 vector4 = (myTransform.localScale = localScale2);
		}
	}

	public virtual void takeDamage(float damage, int damageType, Vector3 damageDirection, PlayerScript whoHitMe)
	{
		if (health <= 0)
		{
			return;
		}
		if (damageType == 5 && !(onFire <= 0f) && !(DB.achievements[6].counter >= (float)DB.achievements[6].threshold))
		{
			DB.achievements[6].counter = DB.achievements[6].counter + 1f;
			if (DB.achievements[6].counter == (float)DB.achievements[6].threshold)
			{
				DB.announceAchievement(6);
			}
		}
		if (damageType != 4)
		{
			if (stunned > 0f || frozen > 0f || (!(onFire <= 0f) && damageType != 2))
			{
				health = (int)((float)health - damage * whoHitMe.victimizer());
			}
			else
			{
				health = (int)((float)health - damage);
			}
		}
		activateColors();
		colorSpeed = 5f;
		if (zombieType == EnemyType.Container)
		{
			damageType = 0;
		}
		if (health > 0)
		{
			slideVector = damageDirection;
			if (slideVector.x > 10f || slideVector.x < -10f || slideVector.z > 10f || !(slideVector.z >= -10f))
			{
				ignoreSync = 0.5f;
				chewingTimer = 0f;
			}
			if (damageType != 4 && damageType != 5)
			{
				if (zombieType != EnemyType.Container)
				{
					myRenderer.material.color = new Color(0.8f, 0f, 0f);
				}
				else
				{
					myRenderer.material.color = new Color(0.8f, 0.8f, 0.3f);
				}
			}
			else
			{
				switch (damageType)
				{
				case 4:
					myRenderer.material.color = new Color(1f, 1f, 1f);
					colorSpeed = 1f;
					if (zombieType != EnemyType.Container)
					{
						stunned = damage + UnityEngine.Random.Range(0f, 0.8f) + whoHitMe.bonusControl();
						if (!(damageDirection.x <= 0f) && myTransform.localScale.x != -1f)
						{
							int num = -1;
							Vector3 localScale = myTransform.localScale;
							float num2 = (localScale.x = num);
							Vector3 vector2 = (myTransform.localScale = localScale);
						}
						else if (!(damageDirection.x >= 0f) && myTransform.localScale.x != 1f)
						{
							int num3 = 1;
							Vector3 localScale2 = myTransform.localScale;
							float num4 = (localScale2.x = num3);
							Vector3 vector4 = (myTransform.localScale = localScale2);
						}
					}
					break;
				case 5:
					myRenderer.material.color = new Color(1f, 1f, 1f);
					colorSpeed = 2f;
					frozen = 4f + UnityEngine.Random.Range(0f, 0.8f) + whoHitMe.bonusControl();
					break;
				}
			}
			if (!(stunned <= 0f))
			{
				stunnedAnimation.Stop("hit1");
				stunnedAnimation.Play("hit1");
			}
			else if (zombieType != EnemyType.Container)
			{
				myAnimation.Stop("hit1");
				myAnimation.Play("hit1");
			}
			if (damageType == 2)
			{
				onFire = 0.8f + whoHitMe.bonusControl() * 0.5f;
			}
			return;
		}
		alive = false;
		dropItem();
		ignoreSync = 0.5f;
		if (zombieType != EnemyType.Container)
		{
			motherBrain.endlessModeKills++;
		}
		if ((bool)whoHitMe && !whoHitMe.ally && zombieType != EnemyType.Container)
		{
			motherBrain.kills++;
			DB.gainKill();
			motherBrain.score += pointValue * motherBrain.multiplier;
			if (motherBrain.multiplier < 99)
			{
				motherBrain.multiplier++;
			}
			motherBrain.multiplierTimer = motherBrain.multiplierTimerDefault;
			if (motherBrain.multiplier == 10 && DB.achievements[15].counter != (float)DB.achievements[15].threshold)
			{
				DB.achievements[15].counter = DB.achievements[15].threshold;
				DB.announceAchievement(15);
			}
			else if (motherBrain.multiplier == 20 && DB.achievements[16].counter != (float)DB.achievements[16].threshold)
			{
				DB.achievements[16].counter = DB.achievements[16].threshold;
				DB.announceAchievement(16);
			}
			else if (motherBrain.multiplier == 30 && DB.achievements[17].counter != (float)DB.achievements[17].threshold)
			{
				DB.achievements[17].counter = DB.achievements[17].threshold;
				DB.announceAchievement(17);
			}
			if (damageType == 6 && !(frozen <= 0f) && !(DB.achievements[5].counter >= (float)DB.achievements[5].threshold))
			{
				DB.achievements[5].counter = DB.achievements[5].counter + 1f;
				if (DB.achievements[5].counter == (float)DB.achievements[5].threshold)
				{
					DB.announceAchievement(5);
				}
			}
			if (damageType == 6 && !(DB.achievements[9].counter >= (float)DB.achievements[9].threshold))
			{
				DB.achievements[9].counter = DB.achievements[9].counter + 1f;
				if (DB.achievements[9].counter == (float)DB.achievements[9].threshold)
				{
					DB.announceAchievement(9);
				}
			}
			if (!(stunned <= 0f) && !(DB.achievements[18].counter >= (float)DB.achievements[18].threshold))
			{
				DB.achievements[18].counter = DB.achievements[18].counter + 1f;
				if (DB.achievements[18].counter == (float)DB.achievements[18].threshold)
				{
					DB.announceAchievement(18);
				}
			}
			if (damageType == 2 && !(DB.achievements[7].counter >= (float)DB.achievements[7].threshold))
			{
				DB.achievements[7].counter = DB.achievements[7].counter + 1f;
				if (DB.achievements[7].counter == (float)DB.achievements[7].threshold)
				{
					DB.announceAchievement(7);
				}
			}
			if (!(DB.achievements[12].counter >= (float)DB.achievements[12].threshold))
			{
				if (!(whoHitMe.health / whoHitMe.maxHealth > 0.2f))
				{
					DB.achievements[12].counter = DB.achievements[12].counter + 1f;
					if (DB.achievements[12].counter == (float)DB.achievements[12].threshold)
					{
						DB.announceAchievement(12);
					}
				}
				else
				{
					DB.achievements[12].counter = 0f;
				}
			}
			if (!(DB.achievements[13].counter >= (float)DB.achievements[13].threshold))
			{
				DB.achievements[13].counter = 0f;
			}
			if (DB.achievements[21].counter != (float)DB.achievements[21].threshold && !(recentAttack <= 0f) && myTargetScript != whoHitMe)
			{
				DB.achievements[21].counter = DB.achievements[21].threshold;
				DB.announceAchievement(21);
			}
		}
		else if ((bool)whoHitMe && !whoHitMe.ally && zombieType == EnemyType.Container && !(DB.achievements[24].counter >= (float)DB.achievements[24].threshold))
		{
			DB.achievements[24].counter = DB.achievements[24].counter + 1f;
			if (DB.achievements[24].counter == (float)DB.achievements[24].threshold)
			{
				DB.announceAchievement(24);
			}
		}
		if (zombieType != EnemyType.Container)
		{
			motherBrain.activeEnemies--;
			slideVector = damageDirection.normalized * 8f;
			if (!(damageDirection.x <= 0f) && myTransform.localScale.x != -1f)
			{
				int num5 = -1;
				Vector3 localScale3 = myTransform.localScale;
				float num6 = (localScale3.x = num5);
				Vector3 vector6 = (myTransform.localScale = localScale3);
			}
			else if (!(damageDirection.x >= 0f) && myTransform.localScale.x != 1f)
			{
				int num7 = 1;
				Vector3 localScale4 = myTransform.localScale;
				float num8 = (localScale4.x = num7);
				Vector3 vector8 = (myTransform.localScale = localScale4);
			}
		}
		gameObject.layer = 13;
		if (!(frozen <= 0f))
		{
			damageType = 5;
		}
		int num9 = deathsByDamageType[damageType].contents[UnityEngine.Random.Range(0, Extensions.get_length((Array)deathsByDamageType[damageType].contents))];
		Vector3 position = myTransform.position;
		position.x += myDeaths[num9].explosionOffset.x * myTransform.localScale.x;
		position.y += myDeaths[num9].explosionOffset.y;
		position.z += myDeaths[num9].explosionOffset.z;
		if (myDeaths[num9].goreType == 0)
		{
			motherBrain.spawnHeadExplosion(position, damageDirection.normalized * myDeaths[num9].goreVelocity);
		}
		else if (myDeaths[num9].goreType == 1)
		{
			motherBrain.spawnSlice(position, damageDirection.normalized * myDeaths[num9].goreVelocity);
		}
		else if (myDeaths[num9].goreType == 2)
		{
			motherBrain.spawnAsh(position, damageDirection.normalized * myDeaths[num9].goreVelocity);
		}
		else if (myDeaths[num9].goreType == 3)
		{
			motherBrain.spawnIceDeath(position, damageDirection.normalized * myDeaths[num9].goreVelocity);
		}
		else if (myDeaths[num9].goreType == 4)
		{
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 0, 3);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 1, 2);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 2, 2);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 3, 3);
		}
		else if (myDeaths[num9].goreType == 5)
		{
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 0, 2);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 1, 2);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 6, 5);
		}
		else if (myDeaths[num9].goreType == 6)
		{
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 4, 4);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 5, 4);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 2, 2);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 3, 2);
		}
		else if (myDeaths[num9].goreType == 7)
		{
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 7, 4);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 8, 4);
		}
		else if (myDeaths[num9].goreType == 8)
		{
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 6, 4);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 7, 3);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 0, 3);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 1, 2);
		}
		else if (myDeaths[num9].goreType == 9)
		{
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 8, 3);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 9, 3);
			motherBrain.spawnCustom(position, damageDirection.normalized * myDeaths[num9].goreVelocity, 10, 3);
		}
		myDeaths[num9].deathRenderer.enabled = true;
		myDeaths[num9].deathRenderer.material.color = new Color(0.8f, 0f, 0f);
		if (myDeaths[num9].deathBackupRenderer != null)
		{
			myDeaths[num9].deathBackupRenderer.enabled = true;
		}
		myDeaths[num9].deathAnimation.Stop();
		myDeaths[num9].deathAnimation.Play();
		myDeaths[num9].deathSound.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
		myDeaths[num9].deathSound.Play();
		if ((bool)myDeaths[num9].collapseSound)
		{
			StartCoroutine_Auto(delayedSound(myDeaths[num9].collapseSound, myDeaths[num9].collapseDelay));
		}
		myRenderer.enabled = false;
		if (zombieType != EnemyType.Container)
		{
			charredRenderer[0].enabled = false;
			charredRenderer[1].enabled = false;
			stunnedRenderer.enabled = false;
			frozenRenderer.enabled = false;
		}
		if (zombieType == EnemyType.Exploder && num9 == 2)
		{
			explode();
		}
		StartCoroutine_Auto(flashingDeath());
	}

	public virtual void slidingAnimation()
	{
		if (slideVector != new Vector3(0f, 0f, 0f))
		{
			Vector3 vector = slideVector * knockbackMod;
			if (!(vector.x <= 30f))
			{
				vector.x = 30f;
			}
			if (!(vector.x >= -30f))
			{
				vector.x = -30f;
			}
			if (!(vector.z <= 20f))
			{
				vector.z = 20f;
			}
			if (!(vector.z >= -20f))
			{
				vector.z = -20f;
			}
			myTransform.position += vector * Time.deltaTime;
			slideVector = Vector3.Lerp(slideVector, new Vector3(0f, 0f, 0f), Time.deltaTime * 25f);
			if (!(slideVector.x >= 0.005f) && !(slideVector.x <= -0.005f))
			{
				slideVector.x = 0f;
			}
			if (!(slideVector.z >= 0.005f) && !(slideVector.z <= -0.005f))
			{
				slideVector.z = 0f;
			}
			if (!(myTransform.position.z <= motherBrain.characterVerticalBounds.x))
			{
				float x = motherBrain.characterVerticalBounds.x;
				Vector3 position = myTransform.position;
				float num = (position.z = x);
				Vector3 vector3 = (myTransform.position = position);
			}
			else if (!(myTransform.position.z >= motherBrain.characterVerticalBounds.y))
			{
				float y = motherBrain.characterVerticalBounds.y;
				Vector3 position2 = myTransform.position;
				float num2 = (position2.z = y);
				Vector3 vector5 = (myTransform.position = position2);
			}
		}
	}

	public virtual void shaderAnimation()
	{
		if (redAnim && health > 0)
		{
			if (!(myRenderer.material.color.r <= 0.25f))
			{
				float r = myRenderer.material.color.r - Time.deltaTime * colorSpeed;
				Color color = myRenderer.material.color;
				float num = (color.r = r);
				Color color3 = (myRenderer.material.color = color);
				if (!(myRenderer.material.color.r >= 0.25f))
				{
					float r2 = 0.25f;
					Color color4 = myRenderer.material.color;
					float num2 = (color4.r = r2);
					Color color6 = (myRenderer.material.color = color4);
					redAnim = false;
				}
			}
			else if (!(myRenderer.material.color.r >= 0.25f))
			{
				float r3 = myRenderer.material.color.r + Time.deltaTime * colorSpeed;
				Color color7 = myRenderer.material.color;
				float num3 = (color7.r = r3);
				Color color9 = (myRenderer.material.color = color7);
				if (!(myRenderer.material.color.r <= 0.25f))
				{
					float r4 = 0.25f;
					Color color10 = myRenderer.material.color;
					float num4 = (color10.r = r4);
					Color color12 = (myRenderer.material.color = color10);
					redAnim = false;
				}
			}
			else
			{
				redAnim = false;
			}
		}
		if (greenAnim && health > 0)
		{
			if (!(myRenderer.material.color.g <= 0.25f))
			{
				float g = myRenderer.material.color.g - Time.deltaTime * colorSpeed;
				Color color13 = myRenderer.material.color;
				float num5 = (color13.g = g);
				Color color15 = (myRenderer.material.color = color13);
				if (!(myRenderer.material.color.g >= 0.25f))
				{
					float g2 = 0.25f;
					Color color16 = myRenderer.material.color;
					float num6 = (color16.g = g2);
					Color color18 = (myRenderer.material.color = color16);
					greenAnim = false;
				}
			}
			else if (!(myRenderer.material.color.g >= 0.25f))
			{
				float g3 = myRenderer.material.color.g + Time.deltaTime * colorSpeed;
				Color color19 = myRenderer.material.color;
				float num7 = (color19.g = g3);
				Color color21 = (myRenderer.material.color = color19);
				if (!(myRenderer.material.color.g <= 0.25f))
				{
					float g4 = 0.25f;
					Color color22 = myRenderer.material.color;
					float num8 = (color22.g = g4);
					Color color24 = (myRenderer.material.color = color22);
					greenAnim = false;
				}
			}
			else
			{
				greenAnim = false;
			}
		}
		if (blueAnim && health > 0)
		{
			if (!(myRenderer.material.color.b <= 0.25f))
			{
				float b = myRenderer.material.color.b - Time.deltaTime * colorSpeed;
				Color color25 = myRenderer.material.color;
				float num9 = (color25.b = b);
				Color color27 = (myRenderer.material.color = color25);
				if (!(myRenderer.material.color.b >= 0.25f))
				{
					float b2 = 0.25f;
					Color color28 = myRenderer.material.color;
					float num10 = (color28.b = b2);
					Color color30 = (myRenderer.material.color = color28);
					blueAnim = false;
				}
			}
			else if (!(myRenderer.material.color.b >= 0.25f))
			{
				float b3 = myRenderer.material.color.b + Time.deltaTime * colorSpeed;
				Color color31 = myRenderer.material.color;
				float num11 = (color31.b = b3);
				Color color33 = (myRenderer.material.color = color31);
				if (!(myRenderer.material.color.b <= 0.25f))
				{
					float b4 = 0.25f;
					Color color34 = myRenderer.material.color;
					float num12 = (color34.b = b4);
					Color color36 = (myRenderer.material.color = color34);
					blueAnim = false;
				}
			}
			else
			{
				blueAnim = false;
			}
		}
		if (Extensions.get_length((Array)charredRenderer) != 0 && charredRenderer[0].enabled && charredRenderer[0].material.color != myRenderer.material.color)
		{
			charredRenderer[0].material.color = myRenderer.material.color;
		}
		else if ((bool)stunnedRenderer && stunnedRenderer.enabled && stunnedRenderer.material.color != myRenderer.material.color)
		{
			stunnedRenderer.material.color = myRenderer.material.color;
		}
		else if ((bool)frozenRenderer && frozenRenderer.enabled && frozenRenderer.material.color != myRenderer.material.color)
		{
			frozenRenderer.material.color = myRenderer.material.color;
		}
		if (health > 0)
		{
			return;
		}
		for (int i = 0; i < Extensions.get_length((Array)myDeaths); i++)
		{
			if (!myDeaths[i].deathRenderer.enabled)
			{
				continue;
			}
			if (redAnim)
			{
				if (!(myDeaths[i].deathRenderer.material.color.r <= 0.25f))
				{
					float r5 = myDeaths[i].deathRenderer.material.color.r - Time.deltaTime * colorSpeed;
					Color color37 = myDeaths[i].deathRenderer.material.color;
					float num13 = (color37.r = r5);
					Color color39 = (myDeaths[i].deathRenderer.material.color = color37);
					if (!(myDeaths[i].deathRenderer.material.color.r >= 0.25f))
					{
						float r6 = 0.25f;
						Color color40 = myDeaths[i].deathRenderer.material.color;
						float num14 = (color40.r = r6);
						Color color42 = (myDeaths[i].deathRenderer.material.color = color40);
						redAnim = false;
					}
				}
				else if (!(myDeaths[i].deathRenderer.material.color.r >= 0.25f))
				{
					float r7 = myDeaths[i].deathRenderer.material.color.r + Time.deltaTime * colorSpeed;
					Color color43 = myDeaths[i].deathRenderer.material.color;
					float num15 = (color43.r = r7);
					Color color45 = (myDeaths[i].deathRenderer.material.color = color43);
					if (!(myDeaths[i].deathRenderer.material.color.r <= 0.25f))
					{
						float r8 = 0.25f;
						Color color46 = myDeaths[i].deathRenderer.material.color;
						float num16 = (color46.r = r8);
						Color color48 = (myDeaths[i].deathRenderer.material.color = color46);
						redAnim = false;
					}
				}
				else
				{
					redAnim = false;
				}
			}
			if (greenAnim)
			{
				if (!(myDeaths[i].deathRenderer.material.color.g <= 0.25f))
				{
					float g5 = myDeaths[i].deathRenderer.material.color.g - Time.deltaTime * colorSpeed;
					Color color49 = myDeaths[i].deathRenderer.material.color;
					float num17 = (color49.g = g5);
					Color color51 = (myDeaths[i].deathRenderer.material.color = color49);
					if (!(myDeaths[i].deathRenderer.material.color.g >= 0.25f))
					{
						float g6 = 0.25f;
						Color color52 = myDeaths[i].deathRenderer.material.color;
						float num18 = (color52.g = g6);
						Color color54 = (myDeaths[i].deathRenderer.material.color = color52);
						greenAnim = false;
					}
				}
				else if (!(myDeaths[i].deathRenderer.material.color.g >= 0.25f))
				{
					float g7 = myDeaths[i].deathRenderer.material.color.g + Time.deltaTime * colorSpeed;
					Color color55 = myDeaths[i].deathRenderer.material.color;
					float num19 = (color55.g = g7);
					Color color57 = (myDeaths[i].deathRenderer.material.color = color55);
					if (!(myDeaths[i].deathRenderer.material.color.g <= 0.25f))
					{
						float g8 = 0.25f;
						Color color58 = myDeaths[i].deathRenderer.material.color;
						float num20 = (color58.g = g8);
						Color color60 = (myDeaths[i].deathRenderer.material.color = color58);
						greenAnim = false;
					}
				}
				else
				{
					greenAnim = false;
				}
			}
			if (!blueAnim)
			{
				continue;
			}
			if (!(myDeaths[i].deathRenderer.material.color.b <= 0.25f))
			{
				float b5 = myDeaths[i].deathRenderer.material.color.b - Time.deltaTime * colorSpeed;
				Color color61 = myDeaths[i].deathRenderer.material.color;
				float num21 = (color61.b = b5);
				Color color63 = (myDeaths[i].deathRenderer.material.color = color61);
				if (!(myDeaths[i].deathRenderer.material.color.b >= 0.25f))
				{
					float b6 = 0.25f;
					Color color64 = myDeaths[i].deathRenderer.material.color;
					float num22 = (color64.b = b6);
					Color color66 = (myDeaths[i].deathRenderer.material.color = color64);
					blueAnim = false;
				}
			}
			else if (!(myDeaths[i].deathRenderer.material.color.b >= 0.25f))
			{
				float b7 = myDeaths[i].deathRenderer.material.color.b + Time.deltaTime * colorSpeed;
				Color color67 = myDeaths[i].deathRenderer.material.color;
				float num23 = (color67.b = b7);
				Color color69 = (myDeaths[i].deathRenderer.material.color = color67);
				if (!(myDeaths[i].deathRenderer.material.color.b <= 0.25f))
				{
					float b8 = 0.25f;
					Color color70 = myDeaths[i].deathRenderer.material.color;
					float num24 = (color70.b = b8);
					Color color72 = (myDeaths[i].deathRenderer.material.color = color70);
					blueAnim = false;
				}
			}
			else
			{
				blueAnim = false;
			}
		}
	}

	public virtual void activateColors()
	{
		redAnim = true;
		blueAnim = true;
		greenAnim = true;
	}

	public virtual void broadcast(string whichObject, string whichFunction, string message, bool reliable)
	{
		if (!DB.multiplayer)
		{
			return;
		}
		for (int i = 0; i < Extensions.get_length((Array)motherBrain.messageSlots); i++)
		{
			if (motherBrain.messageSlots[i].whichObject.text == string.Empty)
			{
				motherBrain.messageSlots[i].whichObject.text = whichObject;
				motherBrain.messageSlots[i].whichFunction.text = whichFunction;
				motherBrain.messageSlots[i].message.text = message;
				i = Extensions.get_length((Array)motherBrain.messageSlots);
			}
		}
	}

	public virtual string createSyncMessage()
	{
		return (chewingTimer <= 0f) ? (myTransform.name + " " + Mathf.Round(movementVector.x * 1000f) / 1000f + " " + Mathf.Round(movementVector.z * 1000f) / 1000f + " " + Mathf.Round(myTransform.position.x * 100f) / 100f + " " + Mathf.Round(myTransform.position.z * 100f) / 100f) : (myTransform.name + " " + Mathf.Round(movementVector.x * 1000f) / 1000f + " " + Mathf.Round(movementVector.z * 1000f) / 1000f + " " + Mathf.Round(chewingPosition.x * 100f) / 100f + " " + Mathf.Round(chewingPosition.z * 100f) / 100f);
	}

	public virtual void reset()
	{
		if (zombieType != EnemyType.Container)
		{
			if (motherBrain.timeRemaining == 999f)
			{
				interpretDifficulty();
			}
			if (zombieType == EnemyType.Spitter)
			{
				spitDelay = UnityEngine.Random.Range(spitCooldown.x, spitCooldown.y);
			}
			alive = true;
			availableForSpawning = false;
			onFire = 0f;
			stunned = 0f;
			frozen = 0f;
			chewingTimer = 0f;
			recentAttack = 0f;
			ignoreSync = 0f;
			slideVector = new Vector3(0f, 0f, 0f);
			movementVector = new Vector3(0f, 0f, 0f);
			chewingPosition = myTransform.position;
			positionMagnet = myTransform.position;
			timeSinceLastSync = 0f;
			myAnimation.Stop();
			myAnimation.Play("run");
			if (zombieType == EnemyType.Exploder)
			{
				myAnimation.Play("gasloop");
				stunnedAnimation.Stop();
				stunnedAnimation.Play("gasloop");
			}
			myRenderer.material.color = new Color(0.25f, 0.25f, 0.25f);
			health = maxHealth;
			AIState = 0;
			gameObject.layer = 12;
			for (int i = 0; i < Extensions.get_length((Array)myDeaths); i++)
			{
				myDeaths[i].deathRenderer.enabled = false;
				if (myDeaths[i].deathBackupRenderer != null)
				{
					myDeaths[i].deathBackupRenderer.enabled = false;
				}
				float a = 1f;
				Color color = myDeaths[i].deathRenderer.material.color;
				float num = (color.a = a);
				Color color3 = (myDeaths[i].deathRenderer.material.color = color);
			}
			charredRenderer[0].enabled = false;
			charredRenderer[1].enabled = false;
			stunnedRenderer.enabled = false;
			frozenRenderer.enabled = false;
			myRenderer.enabled = true;
			enabled = true;
			return;
		}
		if (myTransform == null)
		{
			myTransform = transform;
			myRenderer = (Renderer)myTransform.Find("Geo").GetComponent(typeof(Renderer));
		}
		alive = true;
		onFire = 0f;
		stunned = 0f;
		frozen = 0f;
		chewingTimer = 0f;
		recentAttack = 0f;
		ignoreSync = 0f;
		slideVector = new Vector3(0f, 0f, 0f);
		movementVector = new Vector3(0f, 0f, 0f);
		chewingPosition = myTransform.position;
		positionMagnet = myTransform.position;
		timeSinceLastSync = 0f;
		myRenderer.material.color = new Color(0.25f, 0.25f, 0.25f);
		health = maxHealth;
		AIState = 0;
		gameObject.layer = 12;
		for (int i = 0; i < Extensions.get_length((Array)myDeaths); i++)
		{
			myDeaths[i].deathRenderer.enabled = false;
			if (myDeaths[i].deathBackupRenderer != null)
			{
				myDeaths[i].deathBackupRenderer.enabled = false;
			}
			float a2 = 1f;
			Color color4 = myDeaths[i].deathRenderer.material.color;
			float num2 = (color4.a = a2);
			Color color6 = (myDeaths[i].deathRenderer.material.color = color4);
		}
		myRenderer.enabled = true;
		enabled = true;
	}

	public virtual void bloodSplat()
	{
		if ((bool)myTarget && (bool)hitTransform && hitToggle)
		{
			hitToggle = false;
			hitTransform.position = myTarget.position;
			float x = hitTransform.localPosition.x + UnityEngine.Random.Range(-0.3f, 0.3f);
			Vector3 localPosition = hitTransform.localPosition;
			float num = (localPosition.x = x);
			Vector3 vector2 = (hitTransform.localPosition = localPosition);
			float y = hitTransform.localPosition.y + UnityEngine.Random.Range(-0.1f, 0.6f);
			Vector3 localPosition2 = hitTransform.localPosition;
			float num2 = (localPosition2.y = y);
			Vector3 vector4 = (hitTransform.localPosition = localPosition2);
			float z = hitTransform.position.z + -0.2f;
			Vector3 position = hitTransform.position;
			float num3 = (position.z = z);
			Vector3 vector6 = (hitTransform.position = position);
			float x2 = 0f - myTransform.localScale.x;
			Vector3 localScale = hitTransform.localScale;
			float num4 = (localScale.x = x2);
			Vector3 vector8 = (hitTransform.localScale = localScale);
			hitAnimation.Stop();
			hitAnimation.Play();
			hitReset[0] = 0.3f;
		}
		else if ((bool)myTarget && (bool)hitTransform2 && !hitToggle)
		{
			hitToggle = true;
			hitTransform2.position = myTarget.position;
			float x3 = hitTransform2.localPosition.x + UnityEngine.Random.Range(-0.3f, 0.3f);
			Vector3 localPosition3 = hitTransform2.localPosition;
			float num5 = (localPosition3.x = x3);
			Vector3 vector10 = (hitTransform2.localPosition = localPosition3);
			float y2 = hitTransform2.localPosition.y + UnityEngine.Random.Range(-0.1f, 0.6f);
			Vector3 localPosition4 = hitTransform2.localPosition;
			float num6 = (localPosition4.y = y2);
			Vector3 vector12 = (hitTransform2.localPosition = localPosition4);
			float z2 = hitTransform2.position.z + -0.2f;
			Vector3 position2 = hitTransform2.position;
			float num7 = (position2.z = z2);
			Vector3 vector14 = (hitTransform2.position = position2);
			float x4 = 0f - myTransform.localScale.x;
			Vector3 localScale2 = hitTransform2.localScale;
			float num8 = (localScale2.x = x4);
			Vector3 vector16 = (hitTransform2.localScale = localScale2);
			hitAnimation2.Stop();
			hitAnimation2.Play();
			hitReset[1] = 0.3f;
		}
	}

	public virtual void handleEffects()
	{
		if (Extensions.get_length((Array)hitReset) != 0)
		{
			if (!(hitReset[0] <= 0f))
			{
				hitReset[0] = hitReset[0] - Time.deltaTime;
				if (!(hitReset[0] > 0f))
				{
					int num = 100;
					Vector3 position = hitTransform.position;
					float num2 = (position.y = num);
					Vector3 vector2 = (hitTransform.position = position);
				}
			}
			if (!(hitReset[1] <= 0f))
			{
				hitReset[1] = hitReset[1] - Time.deltaTime;
				if (!(hitReset[1] > 0f))
				{
					int num3 = 100;
					Vector3 position2 = hitTransform2.position;
					float num4 = (position2.y = num3);
					Vector3 vector4 = (hitTransform2.position = position2);
				}
			}
		}
		if (health > 0)
		{
			return;
		}
		int num5 = 0;
		for (num5 = 0; num5 < Extensions.get_length((Array)myDeaths); num5++)
		{
			if (myDeaths[num5] != null && myDeaths[num5].deathRenderer.enabled && (bool)myDeaths[num5].deathOpacity)
			{
				float x = myDeaths[num5].deathOpacity.localScale.x;
				Color color = myDeaths[num5].deathRenderer.material.color;
				float num6 = (color.a = x);
				Color color3 = (myDeaths[num5].deathRenderer.material.color = color);
			}
		}
	}

	public virtual void attack()
	{
		if (myTransform.position.y != 0f)
		{
			return;
		}
		if (zombieType == EnemyType.Exploder)
		{
			takeDamage(10000f, 0, new Vector3(0f, 0f, 0f), null);
			if (DB.multiplayer)
			{
				textMessage = myTransform.name + " " + Mathf.Round(myTransform.position.x * 100f) / 100f + " " + Mathf.Round(myTransform.position.z * 100f) / 100f;
				broadcast(myTransform.name, "syncAttack", textMessage, true);
			}
			return;
		}
		int num = 0;
		if (runState.weight == 1f)
		{
			num = UnityEngine.Random.Range(0, Extensions.get_length((Array)pounceSounds));
			pounceSounds[num].pitch = UnityEngine.Random.Range(0.85f, 1.15f);
			pounceSounds[num].Play();
		}
		recentAttack = 0.4f;
		myAnimation.CrossFade("attack", 0.1f);
		myTargetScript.takeDamage(power, 0.2f);
		num = UnityEngine.Random.Range(0, Extensions.get_length((Array)meleeSounds));
		meleeSounds[num].pitch = UnityEngine.Random.Range(0.85f, 1.15f);
		meleeSounds[num].Play();
		bloodSplat();
		motherBrain.spawnBloodSpurt(myTarget.position + new Vector3(0f, 0.6f, 0.25f), new Vector3(0f, 0f, 0f), 2);
		if (DB.multiplayer)
		{
			stateSyncDelay = 0.7f;
			textMessage = myTransform.name + " " + Mathf.Round(chewingPosition.x * 100f) / 100f + " " + Mathf.Round(chewingPosition.z * 100f) / 100f;
			broadcast(myTransform.name, "syncAttack", textMessage, true);
		}
	}

	public virtual void syncAttack(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		if (zombieType == EnemyType.Exploder)
		{
			myTransform.position = new Vector3(UnityBuiltins.parseFloat(array[1]), 0f, UnityBuiltins.parseFloat(array[2]));
			takeDamage(10000f, 0, new Vector3(0f, 0f, 0f), null);
			return;
		}
		int num = 0;
		if (runState.weight == 1f)
		{
			num = UnityEngine.Random.Range(0, Extensions.get_length((Array)pounceSounds));
			pounceSounds[num].pitch = UnityEngine.Random.Range(0.85f, 1.15f);
			pounceSounds[num].Play();
		}
		myAnimation.CrossFade("attack", 0.1f);
		myTargetScript.takeDamage(power, 0.2f);
		num = UnityEngine.Random.Range(0, Extensions.get_length((Array)meleeSounds));
		meleeSounds[num].pitch = UnityEngine.Random.Range(0.85f, 1.15f);
		meleeSounds[num].Play();
		bloodSplat();
		motherBrain.spawnBloodSpurt(myTarget.position + new Vector3(0f, 0.6f, 0.25f), new Vector3(0f, 0f, 0f), 2);
		timeSinceLastSync = 0f;
		movementVector = new Vector3(0f, 0f, 0f);
		positionMagnet = new Vector3(UnityBuiltins.parseFloat(array[1]), 0f, UnityBuiltins.parseFloat(array[2]));
	}

	public virtual IEnumerator flashingDeath()
	{
		return new _0024flashingDeath_00241941(this).GetEnumerator();
	}

	public virtual void despawn(string emptyArgument)
	{
		alive = false;
		availableForSpawning = true;
		if (zombieType != EnemyType.Container)
		{
			motherBrain.activeEnemies--;
		}
		int num = 100;
		Vector3 position = myTransform.position;
		float num2 = (position.y = num);
		Vector3 vector2 = (myTransform.position = position);
		if ((bool)mySpit.tran)
		{
			mySpit.life = -10f;
			int num3 = 100;
			Vector3 position2 = mySpit.tran.position;
			float num4 = (position2.y = num3);
			Vector3 vector4 = (mySpit.tran.position = position2);
		}
		enabled = false;
	}

	public virtual IEnumerator emerge()
	{
		return new _0024emerge_00241980(this).GetEnumerator();
	}

	public virtual IEnumerator delayedSound(AudioSource whichSound, float howLong)
	{
		return new _0024delayedSound_00241983(whichSound, howLong).GetEnumerator();
	}

	public virtual void dropItem()
	{
		if (DB.whichPlayerAmI != 1)
		{
			return;
		}
		int num = UnityEngine.Random.Range(0, 100);
		int num2 = default(int);
		if (!(UnityEngine.Random.Range(0f, 1f) <= ammoMoneyBias))
		{
			if (!((float)num >= moneyChance[2]))
			{
				StartCoroutine_Auto(motherBrain.spawnPickup(5, myTransform.position));
			}
			else if (!((float)num >= moneyChance[1]))
			{
				StartCoroutine_Auto(motherBrain.spawnPickup(4, myTransform.position));
			}
			else if (!((float)num >= moneyChance[0]))
			{
				StartCoroutine_Auto(motherBrain.spawnPickup(3, myTransform.position));
			}
		}
		else if (!((float)num >= ammoChance[2]))
		{
			StartCoroutine_Auto(motherBrain.spawnPickup(2, myTransform.position));
		}
		else if (!((float)num >= ammoChance[1]))
		{
			StartCoroutine_Auto(motherBrain.spawnPickup(1, myTransform.position));
		}
		else if (!((float)num >= ammoChance[0]))
		{
			StartCoroutine_Auto(motherBrain.spawnPickup(0, myTransform.position));
		}
	}

	public virtual void muteSounds()
	{
		for (int i = 0; i < Extensions.get_length((Array)meleeSounds); i++)
		{
			meleeSounds[i].volume = 0f;
		}
		for (int i = 0; i < Extensions.get_length((Array)pounceSounds); i++)
		{
			pounceSounds[i].volume = 0f;
		}
		if ((bool)escapeSound)
		{
			escapeSound.volume = 0f;
		}
		for (int i = 0; i < Extensions.get_length((Array)myDeaths); i++)
		{
			if ((bool)myDeaths[i].deathSound)
			{
				myDeaths[i].deathSound.volume = 0f;
			}
			if ((bool)myDeaths[i].collapseSound)
			{
				myDeaths[i].collapseSound.volume = 0f;
			}
		}
		if ((bool)spitSound)
		{
			spitSound.volume = 0f;
		}
		if ((bool)spitHitSound)
		{
			spitHitSound.volume = 0f;
		}
		if ((bool)myExplosionSound)
		{
			myExplosionSound.volume = 0f;
		}
	}

	public virtual IEnumerator spit()
	{
		return new _0024spit_00241988(this).GetEnumerator();
	}

	public virtual IEnumerator syncSpit(string incomingData)
	{
		return new _0024syncSpit_00241995(incomingData, this).GetEnumerator();
	}

	public virtual void spitDetonate()
	{
		mySpit.anim.Play("hit");
		mySpit.life = 0f;
		motherBrain.damagePulse(mySpit.tran.position, new Vector2(1.5f, 1f), power * 2, 13);
		spitHitSound.Play();
		if (DB.multiplayer)
		{
			textMessage = myTransform.name + " " + mySpit.tran.position.x + " " + mySpit.tran.position.z;
			broadcast(myTransform.name, "syncDetonate", textMessage, true);
		}
	}

	public virtual void syncDetonate(string incomingData)
	{
		string[] array = incomingData.Split(" "[0]);
		float x = UnityBuiltins.parseFloat(array[1]);
		Vector3 position = mySpit.tran.position;
		float num = (position.x = x);
		Vector3 vector2 = (mySpit.tran.position = position);
		float z = UnityBuiltins.parseFloat(array[2]);
		Vector3 position2 = mySpit.tran.position;
		float num2 = (position2.z = z);
		Vector3 vector4 = (mySpit.tran.position = position2);
		mySpit.life = 0f;
		mySpit.anim.Play("hit");
		motherBrain.damagePulse(mySpit.tran.position, new Vector2(1.5f, 1f), power * 2, 13);
		spitHitSound.Play();
	}

	public virtual void explode()
	{
		myExplosionSound.Play();
		myExplosion.explode(myTransform.position);
		motherBrain.spawnExplosiveAsh(myTransform.position + new Vector3(0f, 0.5f, 0f));
		motherBrain.spawnSelfDestruct(myTransform.position + new Vector3(0f, 1f, 0f), new Vector3(0f, 0f, 0f));
		motherBrain.cameraShaker.Stop();
		motherBrain.cameraShaker.Play();
		motherBrain.damagePulse(myTransform.position, new Vector2(2.1f, 1.5f), power, 20);
	}

	public virtual void changeOwnership(string incomingData)
	{
		if ((bool)motherBrain.allyScript)
		{
			retargetCooldown = 1f;
			attackDelay = 0.1f;
			myTargetScript = motherBrain.allyScript;
			myTarget = motherBrain.allyScript.myTransform;
			chewingPosition = myTransform.position;
			positionMagnet = myTransform.position;
			timeSinceLastSync = 0f;
		}
	}

	public virtual void freeze()
	{
		if ((bool)myAnimation)
		{
			myAnimation.enabled = false;
		}
	}

	public virtual void interpretDifficulty()
	{
		if (zombieType == EnemyType.Container)
		{
			return;
		}
		if (motherBrain.timeRemaining != 999f)
		{
			maxHealth = maxHealthArray[DB.difficulty - 1];
			power = powerArray[DB.difficulty - 1];
			pointValue = pointValueArray[DB.difficulty - 1];
			moveSpeed = moveSpeedArray[DB.difficulty - 1];
			if (zombieType == EnemyType.Spitter)
			{
				spitCooldown.x = spitCooldownArray[DB.difficulty - 1].x;
				spitCooldown.y = spitCooldownArray[DB.difficulty - 1].y;
			}
			return;
		}
		int num = 3;
		num += motherBrain.endlessModeKills / 25;
		if (num > 19)
		{
			num = 19;
		}
		maxHealth = maxHealthArray[num];
		power = powerArray[num];
		pointValue = pointValueArray[num];
		moveSpeed = moveSpeedArray[num];
		if (zombieType == EnemyType.Spitter)
		{
			spitCooldown.x = spitCooldownArray[num].x;
			spitCooldown.y = spitCooldownArray[num].y;
		}
	}

	public virtual void Main()
	{
	}
}
