using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb2D;

    /*private bool isMoving;
    
    private float timeToMove = 0.2f;

    private Vector3 origPos, targetPos;*/
    
    public float forceAmount = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(Vector2.left * forceAmount);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2D.AddForce(Vector2.right * forceAmount);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb2D.AddForce(Vector2.up * forceAmount);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2D.AddForce(Vector2.down * forceAmount);
        }
        
        //I think this game works best if the players are moving by grids but not sure how to achieve that
        /*if (Input.GetKey(KeyCode.W) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.up));
        }
        
        if (Input.GetKey(KeyCode.A) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }
        
        if (Input.GetKey(KeyCode.S) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.down));
        }
        
        if (Input.GetKey(KeyCode.D) && !isMoving)
        {
            StartCoroutine(MovePlayer(Vector3.right));
        }*/

        //players cannot move diagonally
        
    }

    /*private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;
        
        isMoving = false;
    }*/
}
