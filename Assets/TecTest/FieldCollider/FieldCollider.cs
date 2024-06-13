using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 島のコライダー
/// </summary>
public class FieldCollider : MonoBehaviour
{
    Vector2[] m_pivotPosition;

    public void SetPivot(Vector2[] vector)
    {
        m_pivotPosition = vector;
    }

    public bool IsHit(Vector2 checkPosition)
    {
        for (int i = 0; i < m_pivotPosition.Length; i++)
        {
            Vector2 startPos = m_pivotPosition[i];

            int next = i + 1;
            if (next == m_pivotPosition.Length) next = 0;

            //中心ベクトル
            Vector2 endPos = m_pivotPosition[next];
            Vector2 lhs = endPos - startPos;

            Vector2 rhs = startPos - checkPosition;

            float result = Vector2.Dot(lhs, rhs);

            if(result < 0)
            {
                return false;
            }
        }

        return true;
    }

    public void DebugDrawColliderLine()
    {
        if (m_pivotPosition == null) return;
        for (int i = 0; i < m_pivotPosition.Length; i++)
        {
            Vector2 startPos = m_pivotPosition[i];

            int next = i + 1;
            if (next == m_pivotPosition.Length) next = 0;

            //中心ベクトル
            Vector2 endPos = m_pivotPosition[next];
            Vector2 lhs = startPos + (endPos - startPos);

            Debug.DrawLine(startPos, lhs,Color.green);
        }
    }
}
