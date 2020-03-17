using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerCommoandUI : MonoBehaviour
{
    BattleMain battle_main_ = null;
    [SerializeField] bool once = true;
    [SerializeField] Transform skill_trans_ = null;
    [SerializeField] GameObject skill_set_prefab_ = null;
    [SerializeField] GameObject skill_panel_ = null;
    RectTransform skill_set_rect_ = null;

    List<SkillSetUI> skill_set_list_ = null;
    

    public void Setup(BattleMain  battle_main)
    {
        battle_main_ = battle_main;
        skill_set_list_ = new List<SkillSetUI>();


    }

    public void AttackBtnClick()
    {
        if (battle_main_.UserList[0].State != BattlerBase.ActionState.Ready) return;

        AttackAction action = new AttackAction();
        action.Entity = battle_main_.UserList[0];    
        action.Target = battle_main_.EnemyList[0];
        battle_main_.AddAction(action);
    }

    // スキルパネルを非表示にする
    public void HideSkillPannerl()
    {
        if (skill_panel_ == null) return;

        skill_panel_.SetActive(false);
    }
  

    // スキルパネルを表示
   public void ShowSkillPannel(int user_id)
    {
       
        if (skill_panel_ == null) return;

        // パネルが表示されていた場合は閉じる
        if (skill_panel_.activeSelf)
        {
            HideSkillPannerl();
            return;
        }

        skill_panel_.SetActive(true);
        foreach(SkillSetUI ui in skill_set_list_)
        {
            ui.gameObject.SetActive(true);
        }

        
        List<SkillInfo> skill_list = null;
        

        foreach (User user in battle_main_.UserList)
        {
            if (user.PlayerModel.Id == user_id) skill_list = user.PlayerModel.SkillList;
            
        }


        // スキルパネルにskill_listの情報を展開する
        if (once == true)
        {
            int count = 0;
            foreach (SkillInfo skill in skill_list)
            {
                
                GameObject skill_set = Instantiate(skill_set_prefab_, skill_trans_.transform);
                skill_set_rect_ = skill_set.GetComponent<RectTransform>();

                float y = skill_set_rect_.transform.position.y;
                float x = skill_set_rect_.transform.position.x;
                skill_set_rect_.transform.position = new Vector3(x, (count * -100)+430);
                count++;
               

                SkillSetUI skill_set_ui = skill_set.GetComponent<SkillSetUI>();

                skill_set_ui.Setup(skill, battle_main_, HideSkillPannerl);

                skill_set_list_.Add(skill_set_ui);

                once = false;
                

            }
        }
        

    }

    void Setup()
    {
        
       
    }
   
    void Start()
    {
        Setup();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
