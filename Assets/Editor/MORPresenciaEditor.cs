using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MORPresencia))]
public class MORPresenciaEditor : Editor
{
	public override void OnInspectorGUI()
	{
		if (GUILayout.Button("Buscar los identificadores"))
		{
			MORPresencia mp = (MORPresencia)target;
			mp.BuscarIdentificadores();
		}
		base.OnInspectorGUI();
	}
}
