using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class EffectMachine : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024loopActivate_00241643 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024242_00241644;

			internal Vector3 _0024_0024243_00241645;

			internal Vector3 _0024where_00241646;

			internal int _0024flip_00241647;

			internal EffectMachine _0024self__00241648;

			public _0024(Vector3 where, int flip, EffectMachine self_)
			{
				_0024where_00241646 = where;
				_0024flip_00241647 = flip;
				_0024self__00241648 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241648.fireTransform.position = _0024where_00241646 + new Vector3(_0024self__00241648.muzzleOffset.x * _0024self__00241648.myOwner.localScale.x, _0024self__00241648.muzzleOffset.y, _0024self__00241648.muzzleOffset.z);
					if (_0024self__00241648.fireTransform.localScale.x != (float)_0024flip_00241647)
					{
						int num = (_0024_0024242_00241644 = _0024flip_00241647);
						Vector3 vector = (_0024_0024243_00241645 = _0024self__00241648.fireTransform.localScale);
						float num2 = (_0024_0024243_00241645.x = _0024_0024242_00241644);
						Vector3 vector3 = (_0024self__00241648.fireTransform.localScale = _0024_0024243_00241645);
					}
					if (_0024self__00241648.loopActive)
					{
						goto IL_0188;
					}
					_0024self__00241648.loopActive = true;
					_0024self__00241648.enabled = true;
					_0024self__00241648.fireAnimation.Play("start");
					result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				case 2:
					if (_0024self__00241648.startState.weight == 1f)
					{
						_0024self__00241648.fireAnimation.Play("loop");
					}
					goto IL_0188;
				case 1:
					{
						result = 0;
						break;
					}
					IL_0188:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal Vector3 _0024where_00241649;

		internal int _0024flip_00241650;

		internal EffectMachine _0024self__00241651;

		public _0024loopActivate_00241643(Vector3 where, int flip, EffectMachine self_)
		{
			_0024where_00241649 = where;
			_0024flip_00241650 = flip;
			_0024self__00241651 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024where_00241649, _0024flip_00241650, _0024self__00241651);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024endLoop_00241652 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal int _0024_0024244_00241653;

			internal Vector3 _0024_0024245_00241654;

			internal EffectMachine _0024self__00241655;

			public _0024(EffectMachine self_)
			{
				_0024self__00241655 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241655.loopActive)
					{
						_0024self__00241655.loopActive = false;
						_0024self__00241655.fireAnimation.Play("stop");
						result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
						break;
					}
					goto IL_00d1;
				case 2:
					if (!_0024self__00241655.loopActive)
					{
						int num = (_0024_0024244_00241653 = 100);
						Vector3 vector = (_0024_0024245_00241654 = _0024self__00241655.fireTransform.position);
						float num2 = (_0024_0024245_00241654.y = _0024_0024244_00241653);
						Vector3 vector3 = (_0024self__00241655.fireTransform.position = _0024_0024245_00241654);
						_0024self__00241655.enabled = false;
					}
					goto IL_00d1;
				case 1:
					{
						result = 0;
						break;
					}
					IL_00d1:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal EffectMachine _0024self__00241656;

		public _0024endLoop_00241652(EffectMachine self_)
		{
			_0024self__00241656 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241656);
		}
	}

	public Transform myOwner;

	public Transform fireTransform;

	public Animation fireAnimation;

	public Renderer fireRenderer;

	public Transform fireOpacity;

	private bool flashToggle;

	public Transform tracerStart;

	public Transform tracerEnd;

	public Vector2 tracerOffset;

	public float tracerTermination;

	public float verticalSpread;

	public float tracerVariance;

	private float fireReset;

	private float explosionReset;

	public Transform muzzleParent;

	public Vector3 muzzleOffset;

	public bool matchFlip;

	public hitEffect[] hitEffects;

	public Vector2 hitSpread;

	public bool hitMatchFlip;

	private int nextHitEffect;

	private bool firstTracerFrame;

	public Transform laserTransform;

	public Animation laserAnimation;

	public Vector3 laserOffset;

	private bool laserActive;

	private Vector3 tracerVector;

	private bool loopActive;

	public bool hasLoop;

	private AnimationState startState;

	public Transform[] explosionTransforms;

	public Animation[] explosionAnims;

	public Renderer[] explosionRenderers;

	public Transform[] explosionOpacities;

	public Transform smokeTransform;

	public Animation smokeAnimation;

	public Renderer smokeRenderer;

	public Transform smokeOpacity;

	private float smokeReset;

	public float hitEffectDuration;

	public bool paleSmoke;

	public int flipExplosionCommand;

	public Transform healTransform;

	public Animation healAnimation;

	public Renderer healRenderer;

	public Transform healOpacity;

	private float healReset;

	public EffectMachine()
	{
		flashToggle = true;
		verticalSpread = 0.4f;
		hitMatchFlip = true;
		hitEffectDuration = 0.3f;
	}

	public virtual void Awake()
	{
		if ((bool)fireAnimation && (bool)fireAnimation["start"])
		{
			startState = fireAnimation["start"];
		}
	}

	public virtual void fire(Vector3 where, int flip)
	{
		if ((bool)fireTransform)
		{
			fireTransform.position = where + new Vector3(muzzleOffset.x * myOwner.localScale.x, muzzleOffset.y, muzzleOffset.z);
			if (fireTransform.localScale.x != (float)flip)
			{
				Vector3 localScale = fireTransform.localScale;
				float num = (localScale.x = flip);
				Vector3 vector2 = (fireTransform.localScale = localScale);
			}
			fireAnimation.Stop();
			if (flashToggle)
			{
				fireAnimation.Play("effect");
				flashToggle = false;
			}
			else
			{
				fireAnimation.Play("effect2");
				flashToggle = true;
			}
			if ((bool)tracerStart)
			{
				firstTracerFrame = true;
				tracerStart.position = where;
				float x = tracerStart.localPosition.x - tracerOffset.x;
				Vector3 localPosition = tracerStart.localPosition;
				float num2 = (localPosition.x = x);
				Vector3 vector4 = (tracerStart.localPosition = localPosition);
				float y = tracerStart.localPosition.y + (tracerOffset.y + UnityEngine.Random.Range(0f - tracerVariance, tracerVariance));
				Vector3 localPosition2 = tracerStart.localPosition;
				float num3 = (localPosition2.y = y);
				Vector3 vector6 = (tracerStart.localPosition = localPosition2);
				tracerEnd.position = tracerStart.position;
				float x2 = tracerEnd.localPosition.x - 3f;
				Vector3 localPosition3 = tracerEnd.localPosition;
				float num4 = (localPosition3.x = x2);
				Vector3 vector8 = (tracerEnd.localPosition = localPosition3);
				float y2 = tracerEnd.localPosition.y + UnityEngine.Random.Range(0f - verticalSpread, verticalSpread);
				Vector3 localPosition4 = tracerEnd.localPosition;
				float num5 = (localPosition4.y = y2);
				Vector3 vector10 = (tracerEnd.localPosition = localPosition4);
				tracerVector = tracerEnd.position - tracerStart.position;
				tracerTermination = myOwner.localScale.x * 1000f;
			}
			fireReset = 0.25f;
			enabled = true;
		}
		if ((bool)smokeTransform)
		{
			smokeTransform.position = where + new Vector3(0f, -0.3f, 0.4f);
			if (smokeTransform.localScale.x != (float)flip)
			{
				Vector3 localScale2 = smokeTransform.localScale;
				float num6 = (localScale2.x = flip);
				Vector3 vector12 = (smokeTransform.localScale = localScale2);
			}
			smokeAnimation.Stop();
			smokeAnimation.Play();
			smokeReset = 0.9f;
			enabled = true;
		}
	}

	public virtual IEnumerator loopActivate(Vector3 where, int flip)
	{
		return new _0024loopActivate_00241643(where, flip, this).GetEnumerator();
	}

	public virtual IEnumerator endLoop()
	{
		return new _0024endLoop_00241652(this).GetEnumerator();
	}

	public virtual void dualFire(Vector3 where, int flip, bool whichHand)
	{
		fireTransform.position = where;
		if (fireTransform.localScale.x != (float)flip)
		{
			Vector3 localScale = fireTransform.localScale;
			float num = (localScale.x = flip);
			Vector3 vector2 = (fireTransform.localScale = localScale);
		}
		fireAnimation.Stop();
		if (whichHand)
		{
			fireAnimation.Play("effect");
		}
		else
		{
			fireAnimation.Play("effect2");
		}
		if ((bool)tracerStart)
		{
			firstTracerFrame = true;
			tracerStart.position = where;
			float x = tracerStart.localPosition.x - tracerOffset.x;
			Vector3 localPosition = tracerStart.localPosition;
			float num2 = (localPosition.x = x);
			Vector3 vector4 = (tracerStart.localPosition = localPosition);
			float y = tracerStart.localPosition.y + (tracerOffset.y + UnityEngine.Random.Range(0f - tracerVariance, tracerVariance));
			Vector3 localPosition2 = tracerStart.localPosition;
			float num3 = (localPosition2.y = y);
			Vector3 vector6 = (tracerStart.localPosition = localPosition2);
			tracerEnd.position = tracerStart.position;
			float x2 = tracerEnd.localPosition.x - 3f;
			Vector3 localPosition3 = tracerEnd.localPosition;
			float num4 = (localPosition3.x = x2);
			Vector3 vector8 = (tracerEnd.localPosition = localPosition3);
			float y2 = tracerEnd.localPosition.y + UnityEngine.Random.Range(0f - verticalSpread, verticalSpread);
			Vector3 localPosition4 = tracerEnd.localPosition;
			float num5 = (localPosition4.y = y2);
			Vector3 vector10 = (tracerEnd.localPosition = localPosition4);
			tracerVector = tracerEnd.position - tracerStart.position;
			tracerTermination = myOwner.localScale.x * 1000f;
		}
		fireReset = 0.25f;
		enabled = true;
	}

	public virtual void swing(Vector3 where, int flip)
	{
		fireTransform.position = where;
		if (fireTransform.localScale.x != (float)flip)
		{
			Vector3 localScale = fireTransform.localScale;
			float num = (localScale.x = flip);
			Vector3 vector2 = (fireTransform.localScale = localScale);
		}
		fireAnimation.Stop();
		fireAnimation.Play();
		fireReset = 0.65f;
		enabled = true;
	}

	public virtual void hitEffect(ZombieScript theVictim)
	{
		if (Extensions.get_length((Array)hitEffects) == 0 || theVictim.noHitEffects)
		{
			return;
		}
		hitEffects[nextHitEffect].Tran.position = theVictim.myTransform.position;
		float x = hitEffects[nextHitEffect].Tran.localPosition.x + UnityEngine.Random.Range(0f - hitSpread.x, hitSpread.x);
		Vector3 localPosition = hitEffects[nextHitEffect].Tran.localPosition;
		float num = (localPosition.x = x);
		Vector3 vector2 = (hitEffects[nextHitEffect].Tran.localPosition = localPosition);
		float x2 = hitEffects[nextHitEffect].Tran.position.x - 0.2f * theVictim.myTransform.localScale.x;
		Vector3 position = hitEffects[nextHitEffect].Tran.position;
		float num2 = (position.x = x2);
		Vector3 vector4 = (hitEffects[nextHitEffect].Tran.position = position);
		float y = hitEffects[nextHitEffect].Tran.localPosition.y + UnityEngine.Random.Range(0f - hitSpread.y, hitSpread.y);
		Vector3 localPosition2 = hitEffects[nextHitEffect].Tran.localPosition;
		float num3 = (localPosition2.y = y);
		Vector3 vector6 = (hitEffects[nextHitEffect].Tran.localPosition = localPosition2);
		float z = hitEffects[nextHitEffect].Tran.position.z + (UnityEngine.Random.Range(-0.2f, 0.08f) + theVictim.enemySize);
		Vector3 position2 = hitEffects[nextHitEffect].Tran.position;
		float num4 = (position2.z = z);
		Vector3 vector8 = (hitEffects[nextHitEffect].Tran.position = position2);
		if (hitMatchFlip)
		{
			if (!(hitEffects[nextHitEffect].Tran.position.x >= myOwner.position.x) && hitEffects[nextHitEffect].Tran.localScale.x != 1f)
			{
				int num5 = 1;
				Vector3 localScale = hitEffects[nextHitEffect].Tran.localScale;
				float num6 = (localScale.x = num5);
				Vector3 vector10 = (hitEffects[nextHitEffect].Tran.localScale = localScale);
			}
			else if (!(hitEffects[nextHitEffect].Tran.position.x <= myOwner.position.x) && hitEffects[nextHitEffect].Tran.localScale.x != -1f)
			{
				int num7 = -1;
				Vector3 localScale2 = hitEffects[nextHitEffect].Tran.localScale;
				float num8 = (localScale2.x = num7);
				Vector3 vector12 = (hitEffects[nextHitEffect].Tran.localScale = localScale2);
			}
		}
		hitEffects[nextHitEffect].Anim.Stop();
		hitEffects[nextHitEffect].Anim.Play();
		hitEffects[nextHitEffect].life = hitEffectDuration;
		nextHitEffect++;
		if (nextHitEffect >= Extensions.get_length((Array)hitEffects))
		{
			nextHitEffect = 0;
		}
	}

	public virtual void Update()
	{
		if (fireReset > 0f || loopActive)
		{
			if ((bool)muzzleParent)
			{
				fireTransform.position = muzzleParent.position + new Vector3(muzzleOffset.x * myOwner.localScale.x, muzzleOffset.y, muzzleOffset.z);
				if (fireTransform.localScale.x != muzzleParent.localScale.x && matchFlip)
				{
					float x = muzzleParent.localScale.x;
					Vector3 localScale = fireTransform.localScale;
					float num = (localScale.x = x);
					Vector3 vector2 = (fireTransform.localScale = localScale);
				}
			}
			fireReset -= Time.deltaTime;
			if ((bool)tracerStart)
			{
				if (!firstTracerFrame)
				{
					tracerStart.position += tracerVector * Time.deltaTime * 25f;
					tracerEnd.position += tracerVector * Time.deltaTime * 20f;
				}
				else
				{
					firstTracerFrame = false;
				}
				cropTracer();
			}
			if ((bool)fireOpacity)
			{
				float x2 = fireOpacity.localScale.x;
				Color color = fireRenderer.material.color;
				float num2 = (color.a = x2);
				Color color3 = (fireRenderer.material.color = color);
			}
		}
		if (!(smokeReset <= 0f))
		{
			smokeReset -= Time.deltaTime;
			if ((bool)smokeOpacity)
			{
				float x3 = smokeOpacity.localScale.x;
				Color color4 = smokeRenderer.material.color;
				float num3 = (color4.a = x3);
				Color color6 = (smokeRenderer.material.color = color4);
			}
			if (!(smokeReset > 0f))
			{
				int num4 = 100;
				Vector3 position = smokeTransform.position;
				float num5 = (position.y = num4);
				Vector3 vector4 = (smokeTransform.position = position);
			}
		}
		if (!(healReset <= 0f))
		{
			healReset -= Time.deltaTime;
			if ((bool)healOpacity)
			{
				float x4 = healOpacity.localScale.x;
				Color color7 = healRenderer.material.color;
				float num6 = (color7.a = x4);
				Color color9 = (healRenderer.material.color = color7);
			}
			if (!(healReset > 0f))
			{
				int num7 = 100;
				Vector3 position2 = healTransform.position;
				float num8 = (position2.y = num7);
				Vector3 vector6 = (healTransform.position = position2);
			}
		}
		if (!(fireReset > 0f) && (bool)fireTransform && fireTransform.position.y != 100f && !hasLoop)
		{
			int num9 = 100;
			Vector3 position3 = fireTransform.position;
			float num10 = (position3.y = num9);
			Vector3 vector8 = (fireTransform.position = position3);
		}
		bool flag = false;
		for (int i = 0; i < Extensions.get_length((Array)hitEffects); i++)
		{
			if (!(hitEffects[i].life <= 0f))
			{
				flag = true;
				hitEffects[i].life = hitEffects[i].life - Time.deltaTime;
				if (!(hitEffects[i].life > 0f))
				{
					int num11 = 100;
					Vector3 position4 = hitEffects[i].Tran.position;
					float num12 = (position4.y = num11);
					Vector3 vector10 = (hitEffects[i].Tran.position = position4);
				}
				if ((bool)hitEffects[i].opacity)
				{
					float x5 = hitEffects[i].opacity.localScale.x;
					Color color10 = hitEffects[i].Rend.material.color;
					float num13 = (color10.a = x5);
					Color color12 = (hitEffects[i].Rend.material.color = color10);
				}
			}
		}
		if (!(fireReset > 0f) && !hasLoop && !(explosionReset > 0f) && !(smokeReset > 0f) && !(healReset > 0f) && !flag)
		{
			enabled = false;
		}
		if (laserActive)
		{
			if (laserTransform.position != myOwner.position)
			{
				laserTransform.position = myOwner.position;
			}
			if (laserTransform.localScale.x != myOwner.localScale.x)
			{
				float x6 = myOwner.localScale.x;
				Vector3 localScale2 = laserTransform.localScale;
				float num14 = (localScale2.x = x6);
				Vector3 vector12 = (laserTransform.localScale = localScale2);
			}
		}
		if (Extensions.get_length((Array)explosionTransforms) == 0)
		{
			return;
		}
		if (!(explosionReset <= 0f))
		{
			explosionReset -= Time.deltaTime;
		}
		for (int i = 0; i < 4; i++)
		{
			if (((bool)explosionRenderers[i] && explosionRenderers[i].material.color.a != explosionOpacities[i].localScale.x) || ((bool)explosionRenderers[i] && i == 2 && paleSmoke && (bool)explosionRenderers[i] && explosionRenderers[i].material.color.a != explosionOpacities[i].localScale.x * 0.6f))
			{
				if (i == 2 && paleSmoke)
				{
					float a = explosionOpacities[i].localScale.x * 0.6f;
					Color color13 = explosionRenderers[i].material.color;
					float num15 = (color13.a = a);
					Color color15 = (explosionRenderers[i].material.color = color13);
				}
				else
				{
					float x7 = explosionOpacities[i].localScale.x;
					Color color16 = explosionRenderers[i].material.color;
					float num16 = (color16.a = x7);
					Color color18 = (explosionRenderers[i].material.color = color16);
				}
			}
		}
		if (!(explosionReset > 2.1f) && (bool)explosionTransforms[1] && explosionTransforms[1].position.y != 100f)
		{
			int num17 = 100;
			Vector3 position5 = explosionTransforms[1].position;
			float num18 = (position5.y = num17);
			Vector3 vector14 = (explosionTransforms[1].position = position5);
		}
		if (!(explosionReset > 1.6f) && (bool)explosionTransforms[0] && explosionTransforms[0].position.y != 100f)
		{
			int num19 = 100;
			Vector3 position6 = explosionTransforms[0].position;
			float num20 = (position6.y = num19);
			Vector3 vector16 = (explosionTransforms[0].position = position6);
		}
		if (!(explosionReset > 0.4f) && (bool)explosionTransforms[2] && explosionTransforms[2].position.y != 100f)
		{
			int num21 = 100;
			Vector3 position7 = explosionTransforms[2].position;
			float num22 = (position7.y = num21);
			Vector3 vector18 = (explosionTransforms[2].position = position7);
		}
		if (!(explosionReset > 0f))
		{
			int num23 = 100;
			Vector3 position8 = explosionTransforms[3].position;
			float num24 = (position8.y = num23);
			Vector3 vector20 = (explosionTransforms[3].position = position8);
		}
	}

	public virtual void cropTracer()
	{
		if ((bool)tracerEnd)
		{
			if (!(tracerVector.x <= 0f) && !(tracerEnd.position.x <= tracerTermination))
			{
				float x = tracerTermination;
				Vector3 position = tracerEnd.position;
				float num = (position.x = x);
				Vector3 vector2 = (tracerEnd.position = position);
			}
			else if (!(tracerVector.x >= 0f) && !(tracerEnd.position.x >= tracerTermination))
			{
				float x2 = tracerTermination;
				Vector3 position2 = tracerEnd.position;
				float num2 = (position2.x = x2);
				Vector3 vector4 = (tracerEnd.position = position2);
			}
		}
		if ((bool)tracerStart)
		{
			if (!(tracerVector.x <= 0f) && !(tracerStart.position.x <= tracerTermination))
			{
				float x3 = tracerTermination;
				Vector3 position3 = tracerStart.position;
				float num3 = (position3.x = x3);
				Vector3 vector6 = (tracerStart.position = position3);
			}
			else if (!(tracerVector.x >= 0f) && !(tracerStart.position.x >= tracerTermination))
			{
				float x4 = tracerTermination;
				Vector3 position4 = tracerStart.position;
				float num4 = (position4.x = x4);
				Vector3 vector8 = (tracerStart.position = position4);
			}
		}
	}

	public virtual void laserSight(bool onOrOff)
	{
		if (onOrOff && (bool)laserTransform)
		{
			laserActive = true;
			laserTransform.position = myOwner.position + new Vector3(laserOffset.x * myOwner.localScale.x, laserOffset.y, laserOffset.z);
			float x = myOwner.localScale.x;
			Vector3 localScale = laserTransform.localScale;
			float num = (localScale.x = x);
			Vector3 vector2 = (laserTransform.localScale = localScale);
			laserAnimation.Play();
		}
		else if (!onOrOff && (bool)laserTransform)
		{
			laserActive = false;
			int num2 = 100;
			Vector3 position = laserTransform.position;
			float num3 = (position.y = num2);
			Vector3 vector4 = (laserTransform.position = position);
		}
	}

	public virtual void explode(Vector3 where)
	{
		if (flipExplosionCommand != 0)
		{
			flipExplosion(flipExplosionCommand);
		}
		enabled = true;
		explosionReset = 2.4f;
		for (int i = 0; i < 4; i++)
		{
			if ((bool)explosionTransforms[i])
			{
				explosionTransforms[i].position = where + new Vector3(0f, 0.3f, -0.3f);
			}
			if ((bool)explosionAnims[i])
			{
				explosionAnims[i].Stop();
				explosionAnims[i].Play();
			}
			if ((bool)explosionRenderers[i])
			{
				float a = 1f;
				Color color = explosionRenderers[i].material.color;
				float num = (color.a = a);
				Color color3 = (explosionRenderers[i].material.color = color);
			}
		}
	}

	public virtual void flipExplosion(int whichDirection)
	{
		for (int i = 0; i < 4; i++)
		{
			if ((bool)explosionTransforms[i] && !(explosionTransforms[i].localScale.x >= 0f) && whichDirection > 0)
			{
				float x = explosionTransforms[i].localScale.x * -1f;
				Vector3 localScale = explosionTransforms[i].localScale;
				float num = (localScale.x = x);
				Vector3 vector2 = (explosionTransforms[i].localScale = localScale);
			}
			else if ((bool)explosionTransforms[i] && !(explosionTransforms[i].localScale.x <= 0f) && whichDirection < 0)
			{
				float x2 = explosionTransforms[i].localScale.x * -1f;
				Vector3 localScale2 = explosionTransforms[i].localScale;
				float num2 = (localScale2.x = x2);
				Vector3 vector4 = (explosionTransforms[i].localScale = localScale2);
			}
		}
		flipExplosionCommand = 0;
	}

	public virtual void heal(Vector3 where)
	{
		enabled = true;
		healReset = 1f;
		if ((bool)healTransform)
		{
			healTransform.position = where + new Vector3(0f, 0.3f, -0.3f);
			healAnimation.Stop();
			healAnimation.Play();
			float a = 1f;
			Color color = healRenderer.material.color;
			float num = (color.a = a);
			Color color3 = (healRenderer.material.color = color);
		}
	}

	public virtual void teslaArc(Vector3 where, int flip)
	{
		if ((bool)fireTransform)
		{
			fireTransform.position = where + new Vector3(muzzleOffset.x * myOwner.localScale.x, muzzleOffset.y, muzzleOffset.z);
			if (fireTransform.localScale.x != (float)flip * 1.6f)
			{
				float x = (float)flip * 1.6f;
				Vector3 localScale = fireTransform.localScale;
				float num = (localScale.x = x);
				Vector3 vector2 = (fireTransform.localScale = localScale);
			}
			fireAnimation.Stop();
			fireAnimation.Play();
			fireReset = 0.4f;
			enabled = true;
		}
		if ((bool)smokeTransform)
		{
			smokeTransform.position = where + new Vector3(0f, -0.3f, 0.4f);
			if (smokeTransform.localScale.x != (float)flip)
			{
				Vector3 localScale2 = smokeTransform.localScale;
				float num2 = (localScale2.x = flip);
				Vector3 vector4 = (smokeTransform.localScale = localScale2);
			}
			smokeAnimation.Stop();
			smokeAnimation.Play();
			smokeReset = 0.9f;
			enabled = true;
		}
	}

	public virtual void cropArc()
	{
		if (!(fireTransform.localScale.x <= 0f))
		{
			if (!(tracerTermination <= fireTransform.position.x))
			{
				float x = (tracerTermination - fireTransform.position.x) * 0.5f;
				Vector3 localScale = fireTransform.localScale;
				float num = (localScale.x = x);
				Vector3 vector2 = (fireTransform.localScale = localScale);
				if (!(fireTransform.localScale.x >= 0.6f))
				{
					float x2 = 0.6f;
					Vector3 localScale2 = fireTransform.localScale;
					float num2 = (localScale2.x = x2);
					Vector3 vector4 = (fireTransform.localScale = localScale2);
				}
			}
			else
			{
				int num3 = 0;
				Vector3 localScale3 = fireTransform.localScale;
				float num4 = (localScale3.x = num3);
				Vector3 vector6 = (fireTransform.localScale = localScale3);
			}
		}
		if (fireTransform.localScale.x >= 0f)
		{
			return;
		}
		if (!(tracerTermination >= fireTransform.position.x))
		{
			float x3 = (tracerTermination - fireTransform.position.x) * 0.5f;
			Vector3 localScale4 = fireTransform.localScale;
			float num5 = (localScale4.x = x3);
			Vector3 vector8 = (fireTransform.localScale = localScale4);
			if (!(fireTransform.localScale.x <= -0.6f))
			{
				float x4 = -0.6f;
				Vector3 localScale5 = fireTransform.localScale;
				float num6 = (localScale5.x = x4);
				Vector3 vector10 = (fireTransform.localScale = localScale5);
			}
		}
		else
		{
			int num7 = 0;
			Vector3 localScale6 = fireTransform.localScale;
			float num8 = (localScale6.x = num7);
			Vector3 vector12 = (fireTransform.localScale = localScale6);
		}
	}

	public virtual void Main()
	{
	}
}
