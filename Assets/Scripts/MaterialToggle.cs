using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialToggle : MonoBehaviour
{

    [SerializeField] Material material1;
    [SerializeField] Material material2;
    bool mat1 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer r = GetComponent<Renderer>();
        if (Input.GetKeyUp(KeyCode.T))
        {
            if(mat1)
            {
                r.material = material2;
                mat1 = false;
            }
            else
            {
                r.material = material1;
                mat1 = true;
            }
            
        }
    }
}
