using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleUI : MonoBehaviour
{
    
    [SerializeField] BattleClearUI battle_clear_ui_ = null;
    [SerializeField] ExtinctionUI extinction_ui_ = null;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IndicateBattleClearUI()
    {
       // battle_clear_ui_ = gameObject.AddComponent<BattleClearUI>();
        
        battle_clear_ui_.Indicate();
        Debug.Log("CheckState");

    }

    public void IndicateExtinctionUI()
    {
        extinction_ui_.Indicate();
    }
}
