using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "VisualNovelInfo",
   menuName = "Pantheon/VisualNovelInfo",
   order = 9)
]

public class VisualNovelInfo : ScriptableObject
{
    public List<VisualNovelModel> VNInfoList = new List<VisualNovelModel>();

    [System.Serializable]
    public class VisualNovelModel
    {
        [SerializeField]
        [Tooltip("ノベルデータの説明等(自由欄)")]
        public string comment;


      

        [SerializeField] private string[] dialogue_;
        public string[] Dialogue
        {
            get { return dialogue_; }
            protected set { dialogue_ = value; }
        }


    }
}
