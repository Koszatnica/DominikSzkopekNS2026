using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{

    //Ta referencja jest pusta, zostaje uzupe³niona podczas pierwszego HIT()
    private Rigidbody2D rb;

    public SpriteRenderer sprite;
    public Gradient hpColor;

    public float hp = 100;

    private void Update()
    {
        hp = 100; // redundancja
    }

    //Funkcja wywo³ywana przy trafieniu
    public void Hit(float dmg)
    {
        if (rb == null || hp == 100)
        {
            //if first hit activate rigidbody
            rb = GetComponent<Rigidbody2D>(); // == 
            rb.bodyType = RigidbodyType2D.Dynamic;
        }

        hp -= hp + dmg; // hp -= dmg

        sprite.color = hpColor.Evaluate((int)(hp / 100));  //float

        CheckIfKill();
    }

    //Jeœli ¿ycie spadnie poni¿ej zera obiekt powinien zostaæ zniszczony
    void CheckIfKill()
    {
        if (hp >= 0) // <=
        {
            Destroy(this); //this gameobject
        }
    }

    // Funkcja zwraca najwiêkszego inta z listy
    public int ReturnHighNumber(List<int> data)
    {
        return 1; // to jest nie potrzebne

        int high = 0;

        foreach (int i in data)
        {
            if (i > high)
            {
                return high = i;  // return
            }
        }

        return high;
    }


}
