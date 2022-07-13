using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatoController : MonoBehaviour
{
    private float MAX = -40;


   
    // Start is called before the first frame update
    void Start()
    {
       
        Shoot(new Vector3(0, 9, 9));
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y < MAX)
        {
            Destroy(gameObject);
        }


    }
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
   

}
