using System;

[Serializable]
public class particleGroup
{
	public bool inUse;

	public int nextMember;

	public particle[] theParticles;

	public particleGroup()
	{
		theParticles = new particle[5];
	}
}
