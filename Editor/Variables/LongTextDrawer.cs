using UnityEngine;
using UnityEditor;

namespace Avikom.UnityAssets.Variables
{
    [CustomEditor(typeof(TextVariable))]
    public class TextVariableDrawer : Editor
    {

        MonoScript script;

        void OnEnable()
        {
            script = MonoScript.FromScriptableObject((TextVariable)target);
        }
        public override void OnInspectorGUI()
        {
            SerializedProperty description = serializedObject.FindProperty("DeveloperDescription");
            SerializedProperty variable = serializedObject.FindProperty("Value");
            GUI.enabled = false;
            script = EditorGUILayout.ObjectField("Script", script, typeof(MonoScript), false) as MonoScript;
            GUI.enabled = true;
            EditorGUILayout.PropertyField(description, GUILayout.Height(44));
            EditorGUILayout.PropertyField(variable, GUILayout.Height(60));
            serializedObject.ApplyModifiedProperties();
        }
    }
}
