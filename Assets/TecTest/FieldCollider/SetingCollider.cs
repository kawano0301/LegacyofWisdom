using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Field.Collider
{

    /// <summary>
    ///ゲーム中にコライダーを設定する
    /// </summary>
    public class SetingCollider : MonoBehaviour
    {
        [SerializeField] FieldScriptable m_fieldScriptable;
        FieldCollider m_fieldCollider;

        private void Start()
        {
            m_fieldCollider = new FieldCollider();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                m_fieldScriptable.AddPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                m_fieldCollider.SetPivot(m_fieldScriptable.GetColliderData(0));
            }

            m_fieldCollider.DebugDrawColliderLine();
        }
    }
}
