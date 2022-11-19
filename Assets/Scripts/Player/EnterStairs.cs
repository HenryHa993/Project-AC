using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStairs : MonoBehaviour
{
    private bool enterStairs;
    private Transform destStairs;
    // Start is called before the first frame update
    void Start()
    {
        enterStairs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(enterStairs == true && Input.GetKey(KeyCode.Space))
        {
            transform.position = destStairs.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Stairs")
        {
            enterStairs = true;
            destStairs = collision.GetComponent<Staircase>().otherStairs;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Stairs")
        {
            enterStairs = false;
        }
    }
}
