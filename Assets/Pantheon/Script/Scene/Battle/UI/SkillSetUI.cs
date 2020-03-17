using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class SkillSetUI : MonoBehaviour
{
    //スキル所持
    [SerializeField] Image skill_image_=null;
    [SerializeField] TextMeshProUGUI skill_tittle_=null;
    [SerializeField] TextMeshProUGUI skill_explain_=null;
    [SerializeField] TextMeshProUGUI skill_number_=null;
    [SerializeField] TextMeshProUGUI skill_wait_ =null;
    [SerializeField] int skill_style_ = 0;
    [SerializeField] Transform skill_effect_trans_ = null;
    [SerializeField] GameObject skill_effect_prehab_ = null;
   
    // スキルを決定した時に呼ぶコールバック関数
    System.Action skill_set_callback_ = null;

    //
    BattleMain battle_main_ = null;
    float skill_damage_ = 0;

    SkillInfo skill_info_ = null;
    
    // Use this for initialization
    void Start()
    {

    }
    public void SkillOrderClick()
    {
        // スキルの待ち時間がある場合
        if (skill_info_.CurrentWaitTurn > 0) return;
       
        if (skill_style_ == 1)
        {
            //instance skillAction
            SkillAction skill_action = this.gameObject.AddComponent<SkillAction>();
            //impleachment parcticle
            /* GameObject skill_effect_go = Instantiate(skill_effect_prehab_, skill_effect_trans_);
             skill_effect_go.transform.localPosition = Vector3.zero;
             skill_effect_go.transform.localRotation = new Quaternion();
             */
            //スキルの効果を発動
            skill_action.Setuo(skill_info_);
            skill_action.Setvalue(skill_damage_);
            skill_action.Entity = battle_main_.UserList[0];
            skill_action.Target = battle_main_.UserList[0];
            battle_main_.AddAction(skill_action);
        }
        else if(skill_style_ == 2)
        {

            SkillDefence skill_deffence = this.gameObject.AddComponent<SkillDefence>();


            //スキルの効果を発動
            skill_deffence.Setuo(skill_info_);
            skill_deffence.Setvalue(skill_damage_);
            skill_deffence.Entity = battle_main_.UserList[0];
            skill_deffence.Target = battle_main_.UserList[0];
            battle_main_.AddAction(skill_deffence);
        }
        else if(skill_style_ == 3)
        {
            SkillDebuff skill_debuff = this.gameObject.AddComponent<SkillDebuff>();
            /*GameObject skill_effect_go = Instantiate(skill_effect_prehab_, skill_effect_trans_);
            skill_effect_go.transform.localPosition = Vector3.zero;
            skill_effect_go.transform.localRotation = new Quaternion();
            */
            //スキルの効果を発動
            skill_debuff.Setuo(skill_info_);
            skill_debuff.Setvalue(skill_damage_);
            skill_debuff.Entity = battle_main_.EnemyList[0];
            skill_debuff.Target = battle_main_.EnemyList[0];
            battle_main_.AddAction(skill_debuff);
        }
        else if(skill_style_ == 4)
        {
            SkillHeal skill_heal = this.gameObject.AddComponent<SkillHeal>();
            skill_heal.Setuo(skill_info_);
            skill_heal.Entity = battle_main_.UserList[0];
            skill_heal.Target = battle_main_.UserList[0];
            battle_main_.AddAction(skill_heal);
        }
        else if(skill_style_ == 0)
        {
            Debug.Log("null!");
           
        }


        if (skill_set_callback_ != null)
        {
            skill_set_callback_();
        }

        // スキル実行後はスキルの待機時間を設定
        skill_info_.CurrentWaitTurn = skill_info_.WaitTurn;


    }
    // Update is called once per frame
    void Update()
    {
        Display();
    }

    public void Setup(SkillInfo skill_info , BattleMain battle_main , System.Action skill_set_callback)
    {
       
        Debug.Log(skill_info.Name);
        //スキル情報の反映
        skill_tittle_.text = skill_info.Name;
        skill_number_.text = skill_info.IdNumber.ToString();
        skill_explain_.text = skill_info.Explain;
        skill_image_.sprite = skill_info.SkillImage;
        skill_damage_ = skill_info.DamageValue;
        skill_style_ = skill_info.SkillTypeName;
        //スキル作成
        //skill_effect_trans_ = GameObject.Find(skill_info.EffectTransform).transform;
        skill_effect_prehab_ = skill_info.EffectPrehab;
        
        battle_main_ = battle_main;
        skill_set_callback_ = skill_set_callback;

        skill_info_ = skill_info;
        

    }

    void Display()
    {
        // スキル待ち時間がある場合
        if (skill_info_.CurrentWaitTurn > 0)
        {
            //this.gameObject.SetActive(false);
        }
        else
        {
            // スキル待ち時間がない場合
            //this.gameObject.SetActive(true);
        }

        UpdateWaitText();
    }

    void UpdateWaitText()
    {
        if(skill_info_.CurrentWaitTurn > 0)
        {
            skill_wait_.text = "待ちターン：" + skill_info_.CurrentWaitTurn;

        } else
        {
            skill_wait_.text = "";
        }
    }

    
}
