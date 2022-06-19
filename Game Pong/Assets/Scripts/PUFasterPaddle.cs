using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUFasterPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public int faster;
    public PaddleController leftPaddleScript;
    public PaddleController rightPaddleScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (ball.GetComponent<BallController>().LastPaddleHit == 0)
            {
                leftPaddleScript.GetComponent<PaddleController>().FasterPaddle(faster);
                manager.RemovePowerUp(gameObject);
            }

            if (ball.GetComponent<BallController>().LastPaddleHit == 1)
            {
                rightPaddleScript.GetComponent<PaddleController>().FasterPaddle(faster);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
