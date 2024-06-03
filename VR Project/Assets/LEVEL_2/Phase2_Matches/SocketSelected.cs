using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketSelected : MonoBehaviour
{
    public bool selected = false;

    public void SocketSelect()
    {
        selected = true;
    }

    public void SocketUnselect() 
    { 
        selected = false;
    }
}
