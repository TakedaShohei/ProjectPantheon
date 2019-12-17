using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VisualNovelSystem : MonoBehaviour
{
    //ScriptableObjectの制御。
    public string[] scenario_ = null;
    public int scenario_number_;
    public int name_number_;
    public int chara_number_;
    public string novel_info_ = null;//visualnovelinfoのデータを入力する場所
    StageModel stage_model_ = null;

    [SerializeField]
    TMP_Text uiText; // uiTextへの参照を保つ

    [SerializeField]
    TMP_Text uiName; // uiTextへの参照を保つ
   
   
   
    private string chara_image_2;


    /// <summary>
    /// 時間をかけた文章表示
    /// </summary>
    /// 
    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharacterDisplay = 0.05f;  // 1文字の表示にかかる時間

    private int currentLine = 0;
    private int currentName = 0;
    private string currentText = string.Empty;  // 現在の文字列
    private float timeUntilDisplay = 0;     // 表示にかかる時間
    private float timeElapsed = 1;          // 文字列の表示を開始した時間
    private int lastUpdateCharacter = -1;       // 表示中の文字数
                                                // 文字の表示が完了しているかどうか
    VisualNovelInfo novelData = null;

    CharacterImageInfo charaData = null;

  
    
    

    public bool IsCompleteDisplayText
    {
        get { return Time.time > timeElapsed + timeUntilDisplay; }
    }

    bool sw;
    public void Push()
    {
        sw = true;
    }
    public void noPush()
    {
        sw = false;
    }

    public void SetUp(StageModel stage_model)
    {
        //stage_model_ = stage_model;
        novelData = Resources.Load("ScriptableObject/VisualNovel/VisualNovelInfo1") as VisualNovelInfo;
       // novelData = stage_model_.NovelInfo;
        scenario_ = novelData.VNInfoList[scenario_number_].Dialogue;
        NameUpdate();
        SetNextLine();
        CharaUpdate(chara_number_);
    }

    void Start()
    {
        
    }

   public void OnClick()
    {
        Debug.Log("test");
        SetNextScenario();
    }
    public void Update()
    {
       

        if (IsCompleteDisplayText)
        {
            if(sw == true)
            {
                sw = false;
                if (currentLine < scenario_.Length)
                {
                    SetNextLine();
                    
                } else if (scenario_number_ + 1 < novelData.VNInfoList.Count)
                {
                    SetNextScenario();
                } else
                {
                    SceneManagerEx.LoadSceneWithArg("Battle", new object[] { stage_model_ }, LoadSceneMode.Single);
                }
            }
            

        }
        else
        {
            // 完了してないなら文字をすべて表示する
            if (sw==true)
            {
                timeUntilDisplay = 0;
                sw = false;
                    Debug.Log("Push");
                
            }
        }

        // クリックから経過した時間が想定表示時間の何%か確認し、表示文字数を出す
        int displayCharacterCount = (int)(Mathf.Clamp01((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);

        // 表示文字数が前回の表示文字数と異なるならテキストを更新する
        if (displayCharacterCount != lastUpdateCharacter)
        {
            uiText.text = currentText.Substring(0, displayCharacterCount);
            lastUpdateCharacter = displayCharacterCount;
        }

        if (currentName < name.Length )
        {
            NameUpdate();
            CharaUpdate(chara_number_);
        }


    }

    public void SetNextScenario()
    {
        
        scenario_number_++;
        scenario_ = novelData.VNInfoList[scenario_number_].Dialogue;

        currentLine = 0;


        NameUpdate();
        CharaUpdate(chara_number_);
        SetNextLine();
    }


    void SetNextLine()
    {
        currentText = scenario_[currentLine];
        currentLine++;

        // 想定表示時間と現在の時刻をキャッシュ
        timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
        timeElapsed = Time.time;

        // 文字カウントを初期化
        lastUpdateCharacter = -1;
    }

    void NameUpdate()
    {
        charaData = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        name_number_ = novelData.VNInfoList[scenario_number_].Name_Number;
        string name_ = charaData.CharacterList[name_number_].Name;

        
        
        //名前を格納する。
        // 現在の行のテキストをuiTextに流し込み、現在の行番号を一つ追加する
        uiName.text = name_;
    }

   
  void CharaUpdate(int chara_number_)
    {
        chara_number_ = novelData.VNInfoList[scenario_number_].Chara_Number;
        chara_image_2 = novelData.VNInfoList[scenario_number_].Chara_Image;
        
        Image background_image_ = charaData.CharacterList[chara_number_].Model;
        Sprite chara_ = charaData.CharacterList[chara_number_].Show_Character;

        background_image_ = GameObject.Find(chara_image_2).GetComponent<Image>();
        background_image_.sprite = chara_;

    }
       


}
