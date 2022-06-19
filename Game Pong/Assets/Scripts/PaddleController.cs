using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    Vector3 skala;//

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //get input
        Vector3 movement = GetInput();
        //move object
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    //move object
    private void MoveObject(Vector2 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }

    public void LengthenPaddle(int longer) //
    {
        skala = transform.localScale;

        skala.y *= longer;

        transform.localScale = skala;

        Invoke("ShortenPaddle", 5f);
    }

    public void ShortenPaddle()
    {
        skala = transform.localScale;

        skala.y /= 2;

        transform.localScale = skala;
    }

    public void FasterPaddle(int faster)
    {
        speed *= faster;

        Invoke("SlowerPaddle", 5f);
    }

    public void SlowerPaddle()
    {
        speed /= 2;
    }//
}
