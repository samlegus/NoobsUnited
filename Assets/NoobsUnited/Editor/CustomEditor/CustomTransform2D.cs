using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Transform))]
public class TransformInspector : Editor
{
	static bool showDefault = false;
	
	public override void OnInspectorGUI()
	{		
		Transform t = (Transform)target;

		Vector3 position = t.position;
		Vector3 eulerAngles = t.localEulerAngles;
		Vector3 scale = t.localScale;

		if(!showDefault)
		{
			// Replicate the standard transform inspector gui
			EditorGUI.indentLevel = 0;

			Vector3 oldPos = position;
			Vector3 oldEulerAngles = eulerAngles;
			Vector3 oldScale = scale;

			position = EditorGUILayout.Vector2Field("Position", position);
			position.z = oldPos.z;

			scale = EditorGUILayout.Vector2Field("Scale", scale);
			scale.z = oldScale.z;

			eulerAngles = new Vector3(oldScale.x, oldScale.y, EditorGUILayout.FloatField("Rotation (Degrees)", eulerAngles.z));
			eulerAngles.x = oldEulerAngles.x;
			eulerAngles.y = oldEulerAngles.y;

		}
		else
		{
			EditorGUI.indentLevel = 0;
			position = EditorGUILayout.Vector3Field("Position", position);
			eulerAngles = EditorGUILayout.Vector3Field("Rotation", eulerAngles);
			scale = EditorGUILayout.Vector3Field("Scale", scale);;
		}

		if (GUI.changed)
		{
			Undo.RecordObject(t, "Transform Change");
			
			t.localPosition = FixIfNaN(position);
			t.localEulerAngles = FixIfNaN(eulerAngles);
			t.localScale = FixIfNaN(scale);
		}

		showDefault = EditorGUILayout.Toggle ("3D Mode", showDefault);
	}
	
	private Vector3 FixIfNaN(Vector3 v)
	{
		if (float.IsNaN(v.x))
		{
			v.x = 0;
		}
		if (float.IsNaN(v.y))
		{
			v.y = 0;
		}
		if (float.IsNaN(v.z))
		{
			v.z = 0;
		}
		return v;
	}
}