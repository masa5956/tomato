using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomatoGenerator : MonoBehaviour
{
    public GameObject tomatoPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GameObject tomato =
                Instantiate(tomatoPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            tomato.GetComponent<tomatoController>().Shoot(worldDir.normalized * 2000);
        }
    }
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
