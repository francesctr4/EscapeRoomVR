using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket_collision : MonoBehaviour
{
    public GameObject basket;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (basket != null) 
        {
            if(other.gameObject == basket) 
            { 
                door.SetActive(true); 
            }
          
        }
    }
}
