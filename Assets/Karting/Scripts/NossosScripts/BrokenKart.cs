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
            Destroy(gameObject);
        }
    }


}
