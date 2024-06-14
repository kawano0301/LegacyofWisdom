using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Field.Collider
{
    [CreateAssetMenu(menuName = "Scriptable/FieldColliderScriptable")]
    public class FieldScriptable : ScriptableObject
    {
        [Header("保存したコライダー情報")]
        [SerializeField] public List<ColliderPositionInfo> colliderPivot;

        [Header("作業用の点情報")]
        public List<Vector2> workPivot;
        public int listIndex = 0;

        public void Initialize()
        {
            colliderPivot = new List<ColliderPositionInfo>();
            listIndex = 0;
        }

        public void WorkArrayReset()
        {
            workPivot = new List<Vector2>();
        }

        public void AddPosition(Vector2 position)
        {
            workPivot.Add(position);
        }

        public void Set()
        {
            colliderPivot.Add(new ColliderPositionInfo(listIndex,workPivot.ToArray()));
            listIndex++;
        }

        public ColliderPositionInfo GetColliderData(int data)
        {
            for (int i = 0; i < colliderPivot.Count; i++)
            {
                if(colliderPivot[i].colliderId == data)
                {
                    return colliderPivot[i];
                }
            }

            Debug.Log("Cant GetColliderId"　+ data);
            return null;
        }

    }

    [System.Serializable]
    public class ColliderPositionInfo
    {
        public ColliderPositionInfo(int index,Vector2[] positions)
        {
            this.positions = positions;
            colliderId = index;
        }

        public int colliderId;
        public Vector2[] positions;
    }
}
