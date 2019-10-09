// 乱数でチェック
public class AICondtion_Randam : AIConditionBase
{
    // ボーダー以上が成功(0～100)
    protected int border_ = 0;

    // コンストラクタ
    public AICondtion_Randam(int border)
    {
        border_ = border;
    }

    public override bool CheckCOondition(AiSetting setting)
    {
        System.Random r = new System.Random();
        int i = r.Next(100);
        if (border_ > i)
        {
            return true;
        }
        return false;
    }
}