using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{

    bool isAttacking;
    bool hitting;
    Component weapon;

    // Start is called before the first frame update
    void Start()
    {
  //      GameObject.Find("Weapon").SetActive(false);
 /*       isAttacking = GetComponent<PlayerController>().attacking;
        hitting = false;
        weapon = GetComponent("Weapon");
        */
    }

    // Update is called once per frame
    void Update()
    {
/*
        if (!isAttacking && !hitting)
        {
            Destroy(GetComponent("Weapon"));
        }
        if (isAttacking && !hitting) {
            Instantiate(GetComponent("Weapon"));
            hitting = true;
        }
        if(!isAttacking && hitting)
        {
            hitting = false;
        }
        */
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
    }


}
