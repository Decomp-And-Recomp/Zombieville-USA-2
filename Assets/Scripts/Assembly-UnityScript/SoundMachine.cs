using System;
using UnityEngine;

[Serializable]
public class SoundMachine : MonoBehaviour
{
	public AudioSource fireSound;

	public AudioSource fireSoundAlt;

	public bool fireSoundToggle;

	public Vector2 firePitchRange;

	public AudioSource activateSound;

	public AudioSource stopSound;

	public AudioSource hitSound;

	public AudioSource hitSoundAlt;

	public bool hitSoundToggle;

	public Vector2 hitPitchRange;

	public AudioSource aimSound;

	public AudioSource laserSound;

	public AudioSource reloadSound;

	public AudioSource idleSound;

	public AudioSource aimLoopSound;

	private float loopTime;

	public bool muted;

	public virtual void fire()
	{
		if (!muted)
		{
			if ((bool)fireSoundAlt && fireSoundToggle)
			{
				fireSoundToggle = false;
				fireSoundAlt.pitch = UnityEngine.Random.Range(firePitchRange.x, firePitchRange.y);
				fireSoundAlt.Play();
			}
			else if ((bool)fireSound)
			{
				fireSoundToggle = true;
				fireSound.pitch = UnityEngine.Random.Range(firePitchRange.x, firePitchRange.y);
				fireSound.Play();
			}
		}
	}

	public virtual void hit()
	{
		if (!muted)
		{
			if ((bool)hitSoundAlt && hitSoundToggle)
			{
				hitSoundToggle = false;
				hitSoundAlt.pitch = UnityEngine.Random.Range(hitPitchRange.x, hitPitchRange.y);
				hitSoundAlt.Play();
			}
			else if ((bool)hitSound)
			{
				hitSoundToggle = true;
				hitSound.pitch = UnityEngine.Random.Range(hitPitchRange.x, hitPitchRange.y);
				hitSound.Play();
			}
		}
	}

	public virtual void aim()
	{
		if (!muted && (bool)aimSound)
		{
			aimSound.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
			aimSound.Play();
		}
	}

	public virtual void stopAim()
	{
		if (!muted && (bool)aimSound)
		{
			aimSound.Stop();
		}
	}

	public virtual void laser()
	{
		if (!muted && (bool)laserSound)
		{
			laserSound.Play();
		}
	}

	public virtual void triggerLoop()
	{
		if (!muted && !fireSound.isPlaying)
		{
			fireSound.Play();
			activateSound.Play();
		}
	}

	public virtual void endLoop()
	{
		if (!muted && (bool)stopSound && fireSound.isPlaying)
		{
			stopSound.Play();
			fireSound.Stop();
		}
	}

	public virtual void reload()
	{
		if (!muted && (bool)reloadSound && !reloadSound.isPlaying)
		{
			reloadSound.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
			reloadSound.Play();
		}
	}

	public virtual void idleLoop(bool activate)
	{
		if (!muted && (bool)idleSound)
		{
			if (activate)
			{
				idleSound.Play();
			}
			else
			{
				idleSound.Stop();
			}
		}
	}

	public virtual void aimLoop(bool activate)
	{
		if (!muted)
		{
			if ((bool)aimLoopSound && activate)
			{
				aimLoopSound.Play();
			}
			else if ((bool)aimLoopSound && !activate)
			{
				aimLoopSound.Stop();
			}
		}
	}

	public virtual void Main()
	{
	}
}
