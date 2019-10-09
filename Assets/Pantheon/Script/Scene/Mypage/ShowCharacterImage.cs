using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCharacterImage : MonoBehaviour
{

    // Use this for initialization
  

    public int number;
   
    VisualNovelSystem novelSystem = null;
    VisualNovelInfo novelData = null;
    

    void Start()
    {

       
        CharacterImageInfo image_ = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        //   novelData = Resources.Load("ScriptableObject/" + novel_info_) as VisualNovelInfo;
        // number = novelData.VNInfoList[1].Chara_Number;
       // byte color_ = image_.CharacterList[number].Color;
        
        Image background_image_=image_.CharacterList[number].Model;
        Sprite chara_ = image_.CharacterList[number].Show_Character;
       
        background_image_ = this.GetComponent<Image>();
        background_image_.sprite = chara_;
       



    }

    // Update is called once per frame
    void Update()
    {

    }
}
