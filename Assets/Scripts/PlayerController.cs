using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    [SerializeField] TextMeshProUGUI overText;
    Rigidbody rb;
    



    void Start()
    {

        overText.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        


        rb = this.GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.D))
        {

            rb.velocity = new Vector3(7, rb.velocity.y, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {

            rb.velocity = new Vector3(-7, rb.velocity.y, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {

            rb.velocity = new Vector3(0, rb.velocity.y, 7);
        }

        if (Input.GetKey(KeyCode.S))
        {

            rb.velocity = new Vector3(0, rb.velocity.y, -7);

        }

        if (Input.GetKey(KeyCode.Space) && rb.position.y <= 0.5)
        {
            rb.velocity = new Vector3(rb.velocity.x, 8, rb.velocity.z);
        }

        if (rb.position.y <= -30)
        {
            overText.enabled = true;
            Invoke("End", 5);

            //Application.Quit();


            
        }
        if (GameObject.FindWithTag("Enemy") == null)
        {

            overText.text = "You Won!";
            overText.enabled = true;
            Invoke("End", 5);
        }

    }

      

        private void OnCollisionEnter(Collision collision)
        {

            if (collision.collider.tag == "Enemy")
            {
                if (rb.position.y > .65)
                {
                    Destroy(collision.collider.gameObject);
                }
                else
                {

                Invoke("End", 5);
                Destroy(this);
                    this.enabled = false;
                    overText.enabled = true;
                    
                }
            }

            else if(collision.collider.tag == "Trap")
        {
            Invoke("End", 5);
            Destroy(this);
            this.enabled = false;
            overText.enabled = true;
        }

        }
    void End()
    {
       
        Application.Quit();
    }
}

