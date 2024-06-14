using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Field.Collider;

namespace Game.Field
{
    /// <summary>
    /// �R�~���j�e�B�̃f�[�^
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
        /// �t�B�[���h�����N���b�N������
        /// </summary>
        /// <returns></returns>
        public bool IsHit(Vector2 checkPosition)
        {
            return m_fieldCollider.IsHit(checkPosition);
        }

        /// <summary>
        /// �t�B�[���h�f�[�^���擾
        /// </summary>
        /// <returns></returns>
        public CommunityField GetFieldData()
        {
            return this;
        }
    }
}
