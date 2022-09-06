using Avikom.UnityAssets.Events;
using Avikom.UnityAssets.Sets;
using UnityEditor;
using UnityEngine;

namespace Avikom.UnityAssets.Variables
{


    [CustomEditor(typeof(VariableBase<>), true)]
    public class VariableBaseInspector : Editor
    {
        SerializedProperty m_useDefault;
        SerializedProperty m_value;
        private string m_fieldName;
        SerializedProperty m_defaultValue;

        SerializedProperty m_description;

        void OnEnable()
        {
            m_useDefault = serializedObject.FindProperty("useDefault");
            if (m_useDefault != null)
            {
                m_defaultValue = serializedObject.FindProperty("defaultValue");
                m_fieldName = "Value";
                m_value = serializedObject.FindProperty(m_fieldName);
                if (m_value == null)
                {
                    m_fieldName = "Items";
                    m_value = serializedObject.FindProperty(m_fieldName);
                }
                m_description = serializedObject.FindProperty("DeveloperDescription");
            }
        }

        public override void OnInspectorGUI()
        {
            if (m_value == null)
            {
                DrawDefaultInspector();
            }
            else
            {
                EditorGUILayout.PropertyField(m_description, new GUIContent("Description"));
                EditorGUILayout.PropertyField(m_value, new GUIContent(m_fieldName));
                EditorGUILayout.PropertyField(m_useDefault, new GUIContent("Initialize Default"));
                EditorGUILayout.PropertyField(m_defaultValue, new GUIContent("Default Value"));
            }
            serializedObject.ApplyModifiedProperties();
        }
    }

    [CustomEditor(typeof(RuntimeSet<>), true)]
    public class RuntimeSetInspector : VariableBaseInspector { }

}