using System.Collections;
using Codice.CM.Common;
using UnityEngine;

public class BrokenKart : MonoBehaviour
{
    public bool Broken;
    public Shield ShieldScript;

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
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2" && ShieldScript.P1Shielded == false)
        {
            Broken = true;
            transform.position = new Vector3(0,-7,0);
            StartCoroutine(Volta());
            
        }
        else if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2" && ShieldScript.P1Shielded == true)
            transform.position = new Vector3(0, -7, 0);

    }
        private IEnumerator Volta()
    {
        yield return new WaitForSeconds(3);
        Broken = false;
        
    }


}
