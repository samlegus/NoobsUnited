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

		Vector3 localPosition = t.localPosition;
		Vector3 eulerAngles = t.localEulerAngles;
		Vector3 scale = t.localScale;

		if(!showDefault)
		{
			// Replicate the standard transform inspector gui
			EditorGUI.indentLevel = 0;


			Vector3 oldLocalPos = localPosition;
			Vector3 oldEulerAngles = eulerAngles;
			Vector3 oldScale = scale;
			
			if(t.parent)
			{
				localPosition = EditorGUILayout.Vector2Field("Local Position", localPosition);
				localPosition.z = oldLocalPos.z;
				EditorGUI.indentLevel = 1;
				EditorGUILayout.LabelField ("Parent name: " + t.parent.name + " (" + t.parent.position.x + " , " + t.parent.position.y + " )");
				EditorGUI.indentLevel = 0;
			}
			else
			{
				localPosition = EditorGUILayout.Vector2Field("World Position", localPosition);
				localPosition.z = oldLocalPos.z;
			}

			scale = EditorGUILayout.Vector2Field("Scale", scale);
			scale.z = oldScale.z;

			eulerAngles = new Vector3(oldScale.x, oldScale.y, EditorGUILayout.FloatField("Rotation (Degrees)", eulerAngles.z));
			eulerAngles.x = oldEulerAngles.x;
			eulerAngles.y = oldEulerAngles.y;

		}
		else
		{
			EditorGUI.indentLevel = 0;
			localPosition = EditorGUILayout.Vector3Field("Local Position", localPosition);
			eulerAngles = EditorGUILayout.Vector3Field("Rotation", eulerAngles);
			scale = EditorGUILayout.Vector3Field("Scale", scale);
		}

		if (GUI.changed)
		{
			Undo.RecordObject(t, "Transform Change");
		
			t.localPosition = FixIfNaN(localPosition);
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