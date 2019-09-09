using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(
   fileName = "NovelInfo",
   menuName = "Pantheon/NovelInfo",
   order = 8)
]

public class NovelInfo : ScriptableObject
{
    public List<NovelModel> NovelInfoList = new List<NovelModel>();

}
[System.Serializable]

public class NovelModel
{

}


