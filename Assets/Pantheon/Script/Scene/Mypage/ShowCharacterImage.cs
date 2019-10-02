using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCharacterImage : MonoBehaviour
{

    // Use this for initialization

    
    
    void Start()
    {
        
        CharacterImageInfo image_ = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        int id = image_.CharacterList[0].Id;
        Image background_image_=image_.CharacterList[0].Model;
        Sprite chara_ = image_.CharacterList[0].Show_Character;
       
        background_image_ = this.GetComponent<Image>();
        background_image_.sprite = chara_;
        //キャラクターの画像変更をユーザーに行わせたい



    }

    // Update is called once per frame
    void Update()
    {

    }
}
