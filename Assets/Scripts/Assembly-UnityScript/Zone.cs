using System;
using UnityEngine;

[Serializable]
public class Zone
{
	public string zoneName;

	public int requiredKills;

	public Vector3 mapLocation;

	public Location location;

	public string music;

	public int maxEnemyCount;

	public float levelClock;

	public float[] enemyChance;

	public Vector2 spawnDelayRange;

	public Vector2 rearSpawnDelayRange;

	public float[] waveSize;

	public Zone()
	{
		enemyChance = new float[5];
		waveSize = new float[5];
	}
}
