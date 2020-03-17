using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CharacterManager : MonoBehaviour
{
    [SerializeField] GameObject chara_image_prehab_ = null;
    [SerializeField] Image chara_image_prehab_ui_ = null;
    [SerializeField] PlayerInfo player_info_ = null;
    [SerializeField] Transform chara_list_trans_ = null;
    private Sprite sprite;
    public int number_ = 0;
    // Use this for initialization
    void Start()
    {

        Setup();

    }

    void Setup()
    {
        player_info_ = Resources.Load("ScriptableObject/Battle/PlayerInfo") as PlayerInfo;
        CreateCharaImage();
    }


    void CreateCharaImage()
    {
        float x = 0;
        float y = 0;
       
            for(int i = 0; i< player_info_.PlayerInfoList.Count; i++)
            {
                GameObject chara_image_go = Instantiate(chara_image_prehab_, chara_list_trans_);

                    if (i % 5 ==0)
                    {
                        x = 0;
                        y = -100;
                    }
                chara_list_trans_.position = new Vector2(x, y);
                x = +100;
                sprite = Resources.Load<Sprite>(player_info_.PlayerInfoList[i].PlayerImage);
                chara_image_prehab_ui_ = chara_image_go.GetComponent<Image>();
                chara_image_prehab_ui_.sprite = sprite;
                number_ = i;
            }
           // int i= player_info_.PlayerInfoList.Count;
      

    }
    // Update is called once per frame
    void Update()
    {

    }
}
