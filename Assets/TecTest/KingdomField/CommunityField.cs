using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Field.Collider;

namespace Game.Field
{
    /// <summary>
    /// コミュニティのデータ
    /// </summary>
    public class CommunityField
    {
        int m_communityId;
        FieldCollider m_fieldCollider;

        public void Initialize(FieldScriptable fieldScriptable,int communityId)
        {
            m_communityId = communityId;
            m_fieldCollider = new FieldCollider();
            m_fieldCollider.SetPivot(fieldScriptable.GetColliderData(m_communityId));
        }

        /// <summary>
        /// フィールド内をクリックしたか
        /// </summary>
        /// <returns></returns>
        public bool IsHit(Vector2 checkPosition)
        {
            return m_fieldCollider.IsHit(checkPosition);
        }

        /// <summary>
        /// フィールドデータを取得
        /// </summary>
        /// <returns></returns>
        public CommunityField GetFieldData()
        {
            return this;
        }
    }
}
