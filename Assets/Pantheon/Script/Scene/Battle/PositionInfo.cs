using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "PositionInfo",
   menuName = "Pantheon/PositionInfo",
   order = 1)
]

public class PositionInfo : ScriptableObject
{
    public List<PositionModel> PositionInfoList = new List<PositionModel>();


}

[System.Serializable]

public class PositionModel
{
    public int id_;
    public Vector3 pos_;

}
