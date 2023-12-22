using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScen : MonoBehaviour
{
    private int next;
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
        GetComponent<MeshRenderer>().enabled = false;
    }

   private void OnTriggerEnter(Collider other)
   {
        if (other.tag=="Player")
        {
            SceneManager.LoadScene(next);
        }
   }
}
