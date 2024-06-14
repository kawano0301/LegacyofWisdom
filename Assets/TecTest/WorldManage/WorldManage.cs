using Game.Field.Collider;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Game.Field
{
    /// <summary>
    /// ���[���h�̃R�~���j�e�B�Ǘ��N���X
    /// </summary>
    public class WorldManage : MonoBehaviour
    {
        [SerializeField] FieldScriptable m_fieldScriptable;
        const int KINDDOM_COUNT = 1;

        CommunityField[] m_communities;

        private void Start()
        {
            GenerateKingdom(KINDDOM_COUNT);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                IsHit(position);
            }
        }

        /// <summary>
        /// �R�~���j�e�B�����
        /// </summary>
        public void GenerateKingdom(int generateCount)
        {
            m_communities = new CommunityField[KINDDOM_COUNT];

            for (int i = 0; i < m_communities.Length; i++)
            {
                m_communities[i] = new CommunityField();
                m_communities[i].Initialize(m_fieldScriptable, i);
            }
        }

        /// <summary>
        /// �ǂꂩ�̃R���C�_�[�Ƀq�b�g���Ă��邩
        /// </summary>
        /// <param name="checkPosition">�J�������W</param>
        /// <returns>null �q�b�g�Ȃ� : CommunityField& �q�b�g</returns>
        public CommunityField IsHit(Vector2 checkPosition)
        {
            for (int i = 0; i < m_communities.Length; i++)
            {
                if (m_communities[i].IsHit(checkPosition))
                {
                    Debug.Log("HIT");
                    return m_communities[i];
                }
            }
            return null;
        }
    }
}
