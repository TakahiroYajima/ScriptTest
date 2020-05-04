using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void Start()
    {
        //配列の課題----------------------------
        int[] array = new int[] { 10, 20, 30, 40, 50 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        //--------------------------------------

        //発展課題------------------------------
        Boss boss = new Boss();
        for(int i = 0; i < 11; i++)
        {
            boss.Magic();
        }
        //--------------------------------------
    }
}

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;//MP

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

    public void Magic()
    {
        if(mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは " + mp + "。");
        }
    }
}