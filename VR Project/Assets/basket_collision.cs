using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket_collision : MonoBehaviour
{
    public GameObject basket;
    public GameObject door;
    public GameObject particulas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision other)
    {
        if (basket != null) 
        {
            if(other.gameObject == basket) 
            { 
                door.SetActive(true); 
                particulas.SetActive(true); 
            }
          
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (basket != null)
        {
            if (other.gameObject == basket)
            {
                door.SetActive(false);
                particulas.SetActive(false);
            }

        }
    }
}
