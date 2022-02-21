using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("hussain zaidi");
           gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10f * Time.deltaTime, ForceMode2D.Force);
            Destroy(gameObject, 3);
          
        }
    }
}
