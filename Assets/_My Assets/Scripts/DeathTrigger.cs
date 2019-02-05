using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
	private BallSpawner _ballSpawner;
	private PinManager _pinManager;

	private void Start ()
	{
		_ballSpawner = GetComponentInParent<BallSpawner> ();
		_pinManager = FindObjectOfType<PinManager> ();
	}

	private void OnTriggerEnter (Collider other)
	{
		if (!other.CompareTag ("BowlingBall"))
			return;

		if (_pinManager != null)
			_pinManager.countTurn ();

		if (gameObject.transform.parent.name == "LANE 1")
			StartCoroutine (_ballSpawner.SpawnBall (_ballSpawner.Lane1Spawn));
		if (gameObject.transform.parent.name == "LANE 2")
			StartCoroutine (_ballSpawner.SpawnBall (_ballSpawner.Lane2Spawn));
		if (gameObject.transform.parent.name == "LANE 3")
			StartCoroutine (_ballSpawner.SpawnBall (_ballSpawner.Lane3Spawn));
		if (gameObject.transform.parent.name == "LANE 4")
			StartCoroutine (_ballSpawner.SpawnBall (_ballSpawner.Lane4Spawn));
		if (gameObject.transform.parent.name == "LANE 5")
			StartCoroutine (_ballSpawner.SpawnBall (_ballSpawner.Lane5Spawn));
		if (gameObject.transform.parent.name == "LANE 6")
			StartCoroutine (_ballSpawner.SpawnBall (_ballSpawner.Lane6Spawn));

	}
}