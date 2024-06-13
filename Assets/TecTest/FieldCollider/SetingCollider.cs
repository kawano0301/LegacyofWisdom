using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///ゲーム中にコライダーを設定する
/// </summary>
public class SetingCollider : MonoBehaviour
{
    [SerializeField] FieldScriptable m_fieldScriptable;
    FieldCollider m_fieldCollider;

    private void Start()
    {
        m_fieldScriptable.Start();
        m_fieldCollider = new FieldCollider();
        m_fieldScriptable.Initialize();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_fieldScriptable.AddPosition(Input.mousePosition);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_fieldScriptable.Set();
            m_fieldScriptable.Initialize();
            m_fieldCollider.SetPivot(m_fieldScriptable.colliderPivot[0]);
        }

        m_fieldCollider.DebugDrawColliderLine();
    }
}
