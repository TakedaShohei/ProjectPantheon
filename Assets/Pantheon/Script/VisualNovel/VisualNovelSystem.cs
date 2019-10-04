using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VisualNovelSystem : MonoBehaviour
{
    //ScriptableObjectの制御。
    public string[] scenario_ = null;
    public int scenario_number_;
    public int name_number_;
    [SerializeField]
    TMP_Text uiText; // uiTextへの参照を保つ

    [SerializeField]
    TMP_Text uiName; // uiTextへの参照を保つ


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

    void Start()
    {
        VisualNovelInfo novelData = Resources.Load("ScriptableObject/VisualNovelInfo") as VisualNovelInfo;
        
        scenario_ = novelData.VNInfoList[scenario_number_].Dialogue;
        NameUpdate();
        SetNextLine();
    }

   public void OnClick()
    {
        Debug.Log("test");
    }
    public void Update()
    {
       

        if (IsCompleteDisplayText)
        {
            if (currentLine < scenario_.Length && sw==true)
            {
                SetNextLine();
                sw = false;
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
        }


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
        CharacterImageInfo charaData_ = Resources.Load("ScriptableObject/CharaImageInfo") as CharacterImageInfo;
        VisualNovelInfo novelData = Resources.Load("ScriptableObject/VisualNovelInfo") as VisualNovelInfo;
        name_number_ = novelData.VNInfoList[0].Name_Number;
        string name_ = charaData_.CharacterList[name_number_].Name;
        //名前を格納する。
        // 現在の行のテキストをuiTextに流し込み、現在の行番号を一つ追加する
        uiName.text = name_;
    }
}
