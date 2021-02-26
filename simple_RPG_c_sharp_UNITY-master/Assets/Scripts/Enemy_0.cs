using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_0 : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    public int damageToGive;

    public float moveSpeed;

    private bool moving;

    public float timeBetweenMove;

    private float timeBetweenMoveCounter;

    public float timeToMove;

    private float timeToMoveCounter;

    private Vector3 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.2f, timeBetweenMove * 1.8f);
        timeToMoveCounter = Random.Range(timeToMove * 0.2f, timeToMove * 1.8f);
        timeToMoveCounter = timeToMove;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;

            if(timeToMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.2f, timeBetweenMove * 1.8f);
            }
        } else
        {
            timeBetweenMoveCounter -= Time.deltaTime;

            myRigidBody.velocity = Vector2.zero;

            if(timeBetweenMoveCounter <= 0f)
            {
                moving = true;
                timeToMoveCounter = Random.Range(timeToMove * 0.2f, timeToMove * 1.8f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f,1f) * moveSpeed,0f);
            }
        }
      
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }
    }
}
