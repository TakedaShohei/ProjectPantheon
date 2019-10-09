using System.Collections;

// AIの実行する条件の基底クラス.
public class AIConditionBase 
{
    virtual public bool CheckCOondition(AiSetting setting)
    {
        return false;
    }
}
