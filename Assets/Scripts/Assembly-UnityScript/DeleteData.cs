using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Prime31;
using UnityEngine;

[Serializable]
public class DeleteData : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024playerInput_00241634 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024inputDetected_00241635;

			internal Vector2 _0024touchPosition_00241636;

			internal Ray _0024tempRay_00241637;

			internal RaycastHit _0024tempHit_00241638;

			internal DeleteData _0024self__00241639;

			public _0024(DeleteData self_)
			{
				_0024self__00241639 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024inputDetected_00241635 = false;
					_0024touchPosition_00241636 = default(Vector2);
					if (Input.GetMouseButtonDown(0) && !_0024self__00241639.lockInput)
					{
						_0024inputDetected_00241635 = true;
						_0024touchPosition_00241636 = Input.mousePosition;
					}
					else if (Input.touchCount > 0 && !_0024self__00241639.lockInput)
					{
						_0024inputDetected_00241635 = true;
						_0024touchPosition_00241636 = Input.GetTouch(0).position;
					}
					else
					{
						_0024self__00241639.holdingFingerDown = false;
					}
					if (_0024inputDetected_00241635)
					{
						_0024tempRay_00241637 = _0024self__00241639.cameraLens.ScreenPointToRay(_0024touchPosition_00241636);
						_0024tempHit_00241638 = default(RaycastHit);
						if (Physics.Raycast(_0024tempRay_00241637, out _0024tempHit_00241638, 100f, _0024self__00241639.HUDmask))
						{
							_0024self__00241639.tempTransform = _0024tempHit_00241638.transform;
							if (_0024self__00241639.tempTransform.name == "cancel")
							{
								_0024self__00241639.menuSound.Play();
								_0024self__00241639.lockInput = true;
								_0024self__00241639.fade = true;
								result = (Yield(2, new WaitForSeconds(1.3f)) ? 1 : 0);
								break;
							}
							if (_0024self__00241639.tempTransform.name == "deleteAllData")
							{
								_0024self__00241639.menuSound.Play();
								_0024self__00241639.lockInput = true;
								_0024self__00241639.fade = true;
								result = (Yield(3, new WaitForSeconds(1.3f)) ? 1 : 0);
								break;
							}
						}
					}
					goto IL_0203;
				case 2:
					Application.LoadLevel("title");
					goto IL_0203;
				case 3:
					_0024self__00241639.StartCoroutine_Auto(_0024self__00241639.DeleteAllData());
					goto IL_0203;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0203:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal DeleteData _0024self__00241640;

		public _0024playerInput_00241634(DeleteData self_)
		{
			_0024self__00241640 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241640);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024DeleteAllData_00241641 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal GameObject _0024tempGO_00241642;

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					P31Prefs.removeAll();
					PlayerPrefs.DeleteAll();
					if ((bool)GameObject.Find("**DATABASE"))
					{
						_0024tempGO_00241642 = GameObject.Find("**DATABASE");
						UnityEngine.Object.Destroy(_0024tempGO_00241642);
					}
					result = (Yield(2, new WaitForSeconds(2f)) ? 1 : 0);
					break;
				case 2:
					Application.LoadLevel("startup");
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			//yield-return decompiler failed: Method not found
			return new _0024();
		}
	}

	public Camera cameraLens;

	public LayerMask HUDmask;

	public AudioSource menuSound;

	private Transform tempTransform;

	public bool lockInput;

	public bool fade;

	public Renderer fader;

	public bool holdingFingerDown;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!lockInput)
		{
			StartCoroutine_Auto(playerInput());
		}
		fadeAnimation();
	}

	public virtual IEnumerator playerInput()
	{
		return new _0024playerInput_00241634(this).GetEnumerator();
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
				float a2 = fader.material.color.a - 0.8f * Time.deltaTime;
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

	public virtual IEnumerator DeleteAllData()
	{
		return new _0024DeleteAllData_00241641().GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
