﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(PolygonCollider2D))]
public class PolygonCollider2DInspector : Collider2DInspectorBase
{

	public override void OnInspectorGUI()
	{
		serializedObject.Update();

		EditorGUILayout.Separator();
		EditorGUILayout.PropertyField(serializedObject.FindProperty("m_IsTrigger"), new GUIContent("Is Trigger", triggerMessage));
		
		base.ShowExtrasBlock(new string[]{"m_Material", "m_UsedByEffector", "m_UsedByComposite", "m_Offset"});

		serializedObject.ApplyModifiedProperties();
	}
}
