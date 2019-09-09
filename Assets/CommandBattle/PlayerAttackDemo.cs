using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackDemo : HumanoidDemo
{
    EnemyAttackDemo enemy_demo_;
    
    
    // Start is called before the first frame update
    void Start()
    {
        int player_hp = base_hp_;
        player_hp = 100;
        int player_attack = base_attack;
        player_attack = 10;

    }
    public void AttackDemo()
    {
        Debug.Log("Attack!");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
