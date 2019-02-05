using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinManager : MonoBehaviour
{
	public GameObject PinHolder;
	public GameObject PinsPrefab;

	[Range(0,3)]
	public float SpawnDelay;

	private int _count = 0;

	public void countTurn ()
	{
		_count++;		
		if (_count >= 2)
			ResetPins ();
	}

	private void ResetPins ()
	{
		print("resetting pins");
		_count = 0;

		var pins = PinHolder.transform.GetChild (0);				
		Destroy (pins.gameObject);

		SpawnPins(SpawnDelay);
	}

	private IEnumerator SpawnPins (float time)
	{
		yield return new WaitForSeconds(time);
		Instantiate (PinsPrefab, PinHolder.transform.position, Quaternion.identity, PinHolder.transform);
	}
}