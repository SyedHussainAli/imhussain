using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private int move=7;
    private float horizontalInput;
    private Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * move * Time.deltaTime * horizontalInput);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector2.up * 10, ForceMode2D.Impulse);

        }
        
    }

}
