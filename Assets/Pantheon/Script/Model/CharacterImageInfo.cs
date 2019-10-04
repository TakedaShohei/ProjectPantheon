using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(
   fileName = "CharaImageInfo",
   menuName = "Pantheon/CharaImageInfo",
   order = 7)
]

public class CharacterImageInfo : ScriptableObject
{
    public List<CharacterModel> CharacterList = new List<CharacterModel>();
    [System.Serializable]
    public class CharacterModel
    {
        [SerializeField]
        public string comment;

        [SerializeField] private int id_;
        public int Id
        {
            get { return id_; }
            protected set { id_ = value; }
        }
        [SerializeField] private string name_;
        public string Name
        {
            get { return name_; }
            protected set { name_ = value; }
        }

        [SerializeField] private Image model_;
        public Image Model
        {
            get { return model_; }
            protected set { model_ = value; }
        }

        [SerializeField] private Sprite character_;
        public Sprite Show_Character
        {
            get { return character_; }
            set { character_ = value; }
        }
    }
}



