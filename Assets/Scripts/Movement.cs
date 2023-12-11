using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 100;
    public Rigidbody2D player;
    void Start()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    { 
        Debug.Log("Works!");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.moveSpeed = 100;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            this.moveSpeed = 20;
        }
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Vector3 tempVect = new Vector3(h, v, 0);
        //tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
        //player.velocity = tempVect;
        Vector2 moveDirection = new Vector2(h, v).normalized;
        Vector2 moveVelocity = moveDirection * moveSpeed;
        player.velocity = moveVelocity;
        //this.player.MovePosition(this.player.transform.position + tempVect);
    }
}
