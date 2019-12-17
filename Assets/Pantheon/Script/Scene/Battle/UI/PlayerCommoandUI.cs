using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCommoandUI : MonoBehaviour
{
    BattleMain battle_main_ = null;
   
    public void Setup(BattleMain  battle_main)
    {
        battle_main_ = battle_main;
    }

    public void AttackBtnClick()
    {
        AttackAction action = new AttackAction();
        action.Entity = battle_main_.UserList[0];
    
        action.Target = battle_main_.EnemyList[0];
        battle_main_.AddAction(action);
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
