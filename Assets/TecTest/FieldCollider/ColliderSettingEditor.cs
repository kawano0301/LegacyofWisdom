using UnityEngine;
using UnityEditor;
using UnityEngine.Timeline;

namespace Game.Field.Collider.CustomEngine
{
    [CustomEditor(typeof(FieldScriptable))]
    public class ColliderSettingEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            //元のInspector部分を表示
            base.OnInspectorGUI();

            //targetを変換して対象を取得
            FieldScriptable fieldScriptable = target as FieldScriptable;

            if (GUILayout.Button("コライダー情報をリセット"))
            {
                fieldScriptable.Initialize();
            }
            if (GUILayout.Button("作業用の点情報を削除"))
            {
                fieldScriptable.WorkArrayReset();
            }
            if (GUILayout.Button("作業用の点情報をコライダー情報に格納"))
            {
                fieldScriptable.Set();
            }
        }
    }
}
