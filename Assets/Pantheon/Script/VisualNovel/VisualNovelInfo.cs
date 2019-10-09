using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using UnityEngine.UI;
[CreateAssetMenu(
   fileName = "VisualNovelInfo",
   menuName = "Pantheon/VisualNovelInfo",
   order = 9)
]

public class VisualNovelInfo : ScriptableObject
{
    [SerializeField]
    public string comment;
 

    public List<VisualNovelModel> VNInfoList = new List<VisualNovelModel>();
   
    [System.Serializable]
    public class VisualNovelModel
    {
        [SerializeField]
        private int name_number;
        public int Name_Number
        {
            get { return name_number; }
            protected set { name_number = value; }
        }
        [SerializeField]
        private int chara_number;
        public int Chara_Number
        {
            get { return chara_number; }
            protected set { chara_number = value; }
        }

      /*  [SerializeField]
        private Image chara_image_;
        public Image Chara_Image
        {
            get { return chara_image_; }
            protected set { chara_image_ = value; }
        }
        */

        [SerializeField] private string[] dialogue_;
        public string[] Dialogue
        {
            get { return dialogue_; }
            protected set { dialogue_ = value; }
        }


    }
}
