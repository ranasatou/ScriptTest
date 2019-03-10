using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;

    public void Attack(){
        Debug.Log( this.power + "のダメージを与えた");
    }

    public void Defence(int damage){
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}

public class MidBoss{
    private int hp = 80;
    private int power = 15;

    public void Attack()
    {
        Debug.Log(this.power + "くらいの攻撃");
    }

    /*public void Defence(int damage)
    {
        Debug.Log("がんばって" + damage + "のダメージに抑えた");
        this.hp -= damage;
    }*/
}

public class test : MonoBehaviour {


    void Start()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();

        lastboss.Defence(3);

        MidBoss midBoss = new MidBoss();
        Boss midBoss = new Boss();

        midBoss.Attack();
        midBoss.Defence(1);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
