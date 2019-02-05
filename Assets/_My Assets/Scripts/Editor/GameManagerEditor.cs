using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (GameManager))]
public class GameManagerEditor : Editor
{
	private GameManager mTarget;
	private SerializedObject sTarget;
	private SerializedProperty s_NumberOfPlayers;
	private SerializedProperty s_PlayerNames;
	private SerializedProperty s_number;

	private void OnEnable ()
	{
		sTarget = new SerializedObject (target);
		s_NumberOfPlayers = sTarget.FindProperty ("NumberOfPlayers");
		s_PlayerNames = sTarget.FindProperty ("PlayerNames");
		s_number = sTarget.FindProperty ("number");
		s_number.intValue = s_NumberOfPlayers.intValue;
	}

	public override void OnInspectorGUI ()
	{		
		Debug.Log (s_number.intValue);
		sTarget.Update ();
		//BEGIN CHANGE CHECK
		EditorGUI.BeginChangeCheck ();

		EditorGUILayout.Space ();

		EditorGUILayout.PropertyField (s_number);

		var count = 0;
		Debug.Log(s_PlayerNames.arraySize);
		foreach (string player in s_PlayerNames)
		{
			count++;

			EditorGUILayout.BeginHorizontal ();
			EditorGUILayout.LabelField ("Player " + count + ":", GUILayout.Width (65));
			EditorGUILayout.TextField (player);
			EditorGUILayout.EndHorizontal ();
		}

		//END CHANGE CHECK
		if (EditorGUI.EndChangeCheck ())
			sTarget.ApplyModifiedProperties ();
	}
}