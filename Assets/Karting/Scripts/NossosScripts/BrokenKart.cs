using System.Collections;
using Codice.CM.Common;
using UnityEngine;

public class BrokenKart : MonoBehaviour
{
    public bool Broken;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Broken = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Broken = true;
            transform.position = new Vector3(0,-7,0);
            StartCoroutine(Volta());
        }
    }
        private IEnumerator Volta()
    {
        yield return new WaitForSeconds(3);
        Broken = false;
        
    }


}
