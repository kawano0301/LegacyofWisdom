using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/FieldColliderScriptable")]
public class FieldScriptable : ScriptableObject
{
    public List<Vector2> workPivot;

    public List<Vector2[]> colliderPivot;

    public int listIndex = 0;

    public void Start()
    {
        colliderPivot = new List<Vector2[]>();
    }

    public void Initialize()
    {
        workPivot.Clear();
    }

    public void AddPosition(Vector2 position)
    {
        workPivot.Add(position);
    }

    public void Set()
    {
        listIndex++;

        colliderPivot.Add(workPivot.ToArray());
    }
}
