using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour

{

    

    

    

    // Update is called once per frame
    void Update()
    {
       GameObject player = GameObject.FindWithTag("Player");
        Rigidbody rb = this.GetComponent<Rigidbody>();

        this.transform.position = Vector3.MoveTowards(rb.position, player.GetComponent<Rigidbody>().position, 0.065f);
        this.transform.position = new Vector3(this.transform.position.x,0.5f,this.transform.position.z);
        
    }
}
