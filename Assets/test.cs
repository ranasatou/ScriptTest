using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;    // 体力
    private int power = 25;  // 攻撃力
    private int mp = 53;     // 魔法

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic(int mag)
    {
        // 残りmpを減らす
        this.mp -= mag;

            if (this.mp < 5)
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
            else
            {
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
    }

}


public class test : MonoBehaviour {


    void Start()
    {
        int[] array = new int[5];//初期化?

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int saru = 0; saru < 5; saru++){
            Debug.Log("お猿が" + array[saru] + "匹");
        }

        for (int saru = array.Length - 1; 0 <= saru;saru--){//逆順
            Debug.Log("お猿が" + array[saru] + "匹");
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);
        lastboss.Magic(5);


        /*for (int mp = 0; mp <= 10; mp++)
        {
            Debug.Log(mp);
        }*/
    }

    // Update is called once per frame
    void Update()
    {

    }
}
