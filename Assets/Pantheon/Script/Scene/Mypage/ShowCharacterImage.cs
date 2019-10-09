using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCharacterImage : MonoBehaviour
{

    // Use this for initialization
  

    public int number;
   

    void Start()
    {
        /*CharacterImageInfo image_ = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        //   novelData = Resources.Load("ScriptableObject/" + novel_info_) as VisualNovelInfo;

       

        Image background_image_ = image_.CharacterList[number].Model;
        Sprite chara_ = image_.CharacterList[number].Show_Character;

        background_image_ = this.GetComponent<Image>();
        background_image_.sprite = chara_;*/

       



    }

    // Update is called once per frame
    void Update()
    {
        CharacterImageInfo image_ = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        //   novelData = Resources.Load("ScriptableObject/" + novel_info_) as VisualNovelInfo;

      //  novelSystem.CharaUpdate(number);

        //novelSystem.CharaUpdate(number);
        Image background_image_ = image_.CharacterList[number].Model;
        Sprite chara_ = image_.CharacterList[number].Show_Character;

        background_image_ = this.GetComponent<Image>();
        background_image_.sprite = chara_;

    }
}
