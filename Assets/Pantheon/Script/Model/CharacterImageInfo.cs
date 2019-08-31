using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(
   fileName = "CharacterImage",
   menuName = "Pantheon/CharacterImage",
   order = 5)
]

public class CharacterImageInfo : MonoBehaviour
{
    public List<CharacterModel> CharacterList = new List<CharacterModel>();
    

}

public class CharacterModel
{
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
