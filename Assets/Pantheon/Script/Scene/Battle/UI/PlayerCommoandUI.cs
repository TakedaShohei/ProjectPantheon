using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayerCommoandUI : MonoBehaviour
{
    BattleMain battle_main_ = null;
   
    [SerializeField] Transform skill_trans_ = null;
    [SerializeField] GameObject skill_set_prefab_ = null;
    [SerializeField] GameObject skill_panel_ = null;

    public void Setup(BattleMain  battle_main)
    {
        battle_main_ = battle_main;
    }

    public void AttackBtnClick()
    {
        if (battle_main_.UserList[0].State != BattlerBase.ActionState.Ready) return;

        AttackAction action = new AttackAction();
        action.Entity = battle_main_.UserList[0];
    
        action.Target = battle_main_.EnemyList[0];
        battle_main_.AddAction(action);
    }

    // スキルパネルを表示
   public void ShowSkillPannel(int user_id)
    {
        skill_panel_.SetActive(!skill_panel_.activeSelf);
        List<SkillInfo> skill_list = null;
        foreach(User user in battle_main_.UserList)
        {
            if (user.PlayerModel.Id == user_id) skill_list = user.PlayerModel.SkillList;
        }

        // スキルパネルにskill_listの情報を展開する
        foreach (SkillInfo skill in skill_list)
        {
            GameObject skill_set = Instantiate(skill_set_prefab_, skill_trans_);
            SkillSetUI skill_set_ui = skill_set.GetComponent<SkillSetUI>();
            
            skill_set_ui.Setup(skill);
            

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
