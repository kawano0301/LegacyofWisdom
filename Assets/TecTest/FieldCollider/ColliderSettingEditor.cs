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
            //����Inspector������\��
            base.OnInspectorGUI();

            //target��ϊ����đΏۂ��擾
            FieldScriptable fieldScriptable = target as FieldScriptable;

            if (GUILayout.Button("�R���C�_�[�������Z�b�g"))
            {
                fieldScriptable.Initialize();
            }
            if (GUILayout.Button("��Ɨp�̓_�����폜"))
            {
                fieldScriptable.WorkArrayReset();
            }
            if (GUILayout.Button("��Ɨp�̓_�����R���C�_�[���Ɋi�["))
            {
                fieldScriptable.Set();
            }
        }
    }
}
