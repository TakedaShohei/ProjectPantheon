using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCharacterImage : MonoBehaviour
{

    // Use this for initialization
    
    void Start()
    {
        CharacterImageInfo image_ = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        Image background_image_=image_.CharacterList[0].Model;
        Sprite chara_ = image_.CharacterList[0].Show_Character;
       
        background_image_ = this.GetComponent<Image>();
        background_image_.sprite = chara_;




    }

    // Update is called once per frame
    void Update()
    {

    }
}
