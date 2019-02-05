using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static int NumberOfPlayers;
	[Range (0, 10)]
	public int number;
	public string[] PlayerNames = new string[NumberOfPlayers];

}