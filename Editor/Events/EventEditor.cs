using UnityEditor;
using UnityEngine;

namespace Avikom.UnityAssets.Events
{
    [CustomEditor(typeof(GameEvent), true)]
    public class EventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GameEvent e = target as GameEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }

    [CustomEditor(typeof(GameEvent<>), true)]
    public class GenericEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;
            var e = target as IGameEvent;
            if (GUILayout.Button("Raise") && e != null)
                e.Raise();
        }
    }
}
