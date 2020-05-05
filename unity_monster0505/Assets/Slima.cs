
using UnityEngine;
using UnityEngine.UI;

public class Slima : MonoBehaviour
{
    [Header("顯示訊息")]
    public Text message;
    [Header("蝙蝠")]
    public Bat bat;

    private float hp = 180;
    private float atk = 10;
    private float cure = 10;

    ///<summary>
    ///攻擊
    /// </summary>
    public void Attack()
    {
        bat.Damage(atk);
    }
    ///<summary>
    ///受傷
    /// </summary>
    /// <param name="damage">要接收的傷害值</param>
    public void Damage(float damage)
    {
        hp -= damage;
        message.text = gameObject.name + "-受到傷害:" + damage;
        message.text += "\n" + gameObject.name + "-血量剩下" + hp;
    }
    ///<summary>
    ///治療
    /// </summary>
    public void Cure()
    {
        hp += cure;
        message.text = gameObject.name + "受到治療" + cure;
        message.text += "\n" + gameObject.name + "血量剩下" + hp;


    }


}
