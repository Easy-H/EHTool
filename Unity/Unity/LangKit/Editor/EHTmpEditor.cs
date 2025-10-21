#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace EasyH.Unity.LangKit {


    [CustomEditor(typeof(EHTmp))]
    public class EHTmpEditor : TMPro.EditorUtilities.TMP_EditorPanelUI {
        SerializedProperty _key;
        protected override void OnEnable()
        {
            base.OnEnable();
            _key = serializedObject.FindProperty("_key");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_key);
            serializedObject.ApplyModifiedProperties();

            EHTmp t = target as EHTmp;
            if (GUILayout.Button("추가"))
            {
                t.AddKey();
            }

            base.OnInspectorGUI();
        }
    }
}
#endif