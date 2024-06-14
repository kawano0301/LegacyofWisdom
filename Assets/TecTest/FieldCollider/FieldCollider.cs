using Game.Field.Collider;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 島のコライダー
/// </summary>
public class FieldCollider
{
    ColliderPositionInfo m_pivotPosition;

    public void SetPivot(ColliderPositionInfo colliderInfo)
    {
        m_pivotPosition = colliderInfo;
    }

    public bool IsHit(Vector2 checkPosition)
    {
        Vector2[] position = m_pivotPosition.positions;

        for (int i = 0; i < position.Length; i++)
        {
            Vector2 startPos = position[i];

            int next = i + 1;
            if (next == position.Length) next = 0;

            //中心ベクトル
            Vector2 endPos = position[next];
            Vector2 lhs = endPos - startPos;

            Vector2 rhs = startPos - checkPosition;

           
            Vector3 result = Vector3.Cross((Vector3)lhs.normalized, (Vector3)rhs.normalized);

            if(result.z < 0)
            {
                return false;
            }
        }

        return true;
    }

    public void DebugDrawColliderLine()
    {
        if (m_pivotPosition == null) return;
        Vector2[] position = m_pivotPosition.positions;

        for (int i = 0; i < position.Length; i++)
        {
            Vector2 startPos = position[i];

            int next = i + 1;
            if (next == position.Length) next = 0;

            //中心ベクトル
            Vector2 endPos = position[next];
            Vector2 lhs = startPos + (endPos - startPos);

            Debug.DrawLine(startPos, lhs,Color.green);
        }
    }
}
