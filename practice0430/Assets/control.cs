using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour
{
   
    public monster bat;
    public monster slime;
    public Text message;
    public Button batatk;
    public Button batcure;
    public Button slimeatk;
    public Button slimecure;

    private void Start()
    {
        batatk.onClick.AddListener(BatAttack);
        batcure.onClick.AddListener(BatCure);
        slimeatk.onClick.AddListener(SlimeAttack);
        slimecure.onClick.AddListener(SlimeCure);
    }

    public void BatAttack()
    {
        // slime.hp = slime.hp - bat.atk;
        slime.hp -= bat.atk;
        message.text = slime.name + " - 受到傷害：" + bat.atk + "\n"
                     + slime.name + " - 血量剩下：" + slime.hp;
    }
    public void SlimeAttack()
    {
        bat.hp -= slime.atk;
        message.text = bat.name + " - 受到傷害：" + slime.atk + "\n"
                      + bat.name + " - 血量剩下：" + bat.hp;
    }
    public void BatCure()
    {
        bat.hp += bat.cure;
        message.text = bat.name + " - 收到治癒：" + bat.cure + "\n"
                     + bat.name + " - 血量剩下：" + bat.hp;
        
    }
    public void SlimeCure()
    {
        slime.hp += slime.cure;
        message.text = slime.name + " - 收到治癒：" + slime.cure + "\n"
                     + slime.name + " - 血量剩下：" + slime.hp;
    }

    //public void Hurt()
    //{
    //    if (batatk)
    //    {
    //        slime.hp -= bat.atk;
    //        message.text = slime.name + " - 受到傷害：" + bat.atk + "\n"
    //                      + slime.name + " - 血量剩下：" + slime.hp;
    //    }
    //    else if (slimeatk)
    //    {
    //        bat.hp -= slime.atk;
    //        message.text = bat.name + " - 受到傷害：" + slime.atk + "\n"
    //                      + bat.name + " - 血量剩下：" + bat.hp;
    //    }

    //}
    //public void cCure()
    //{
    //    if (batcure)
    //    {
    //        bat.hp += bat.cure;
    //        message.text = bat.name + " - 收到治癒：" + bat.cure + "\n"
    //                      + bat.name + " - 血量剩下：" + bat.hp;
    //    }
    //    else if (slimecure)
    //    {
    //        slime.hp += slime.cure;
    //        message.text = slime.name + " - 收到治癒：" + slime.cure + "\n"
    //                      + slime.name + " - 血量剩下：" + slime.hp;
    //    }
    //}
}
