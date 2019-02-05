using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
	public GameObject BowlingBall;

	public Transform Lane1Spawn;
	public Transform Lane2Spawn;
	public Transform Lane3Spawn;
	public Transform Lane4Spawn;
	public Transform Lane5Spawn;
	public Transform Lane6Spawn;

	[Range (0, 5f)]
	public float BallReturnTimeDelay = 2f;

	public IEnumerator SpawnBall (Transform spawnPos)
	{		
		yield return new WaitForSeconds(BallReturnTimeDelay);		
		Instantiate (BowlingBall, spawnPos.position, Quaternion.identity);		
	}
}