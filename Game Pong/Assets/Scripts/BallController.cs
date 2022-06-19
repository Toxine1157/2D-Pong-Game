using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    public Collider2D LeftPaddle;
    public Collider2D RightPaddle;
    public int LastPaddleHit;
    

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        rig.velocity = speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision) //
    {
        if(collision.collider == LeftPaddle /* == "Padel Kiri"*/)
        {
            LastPaddleHit = 0; //LengthenScript.GetComponent<PULengthenPaddle>().LastPaddleHit = 0;
            Debug.Log("Last Hit by Left Paddle");
        }

        if(collision.collider == RightPaddle/*gameObject.tag == "Padel Kanan"/*collision == RightPaddle*/)
        {
            LastPaddleHit = 1; //LengthenScript.GetComponent<PULengthenPaddle>().LastPaddleHit = 1;
            Debug.Log("Last Hit by Right Paddle");
        }
    }                                                  //

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;

    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
