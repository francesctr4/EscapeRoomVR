using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marge_Objects_3 : MonoBehaviour
{
        // Referencias a los MeshRenderers y el objeto a activar
        public MeshRenderer meshRenderer1;
        public MeshRenderer meshRenderer2;
        public GameObject pieza_completa;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Circulo")
            {
                if (meshRenderer1 != null) meshRenderer1.enabled = false;
                if (meshRenderer2 != null) meshRenderer2.enabled = false;

                if (pieza_completa != null) pieza_completa.SetActive(true);
            }
        }
}

