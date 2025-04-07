using System.Collections;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public bool P1;
    public bool P2;
    public bool P1Shielded;
    public bool P2Shielded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        P1 = false;
        P2 = false;
        P1Shielded = false;
        P2Shielded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            P1 = true;
            P1Shielded = true;
            StartCoroutine(ShieldDuration());
            transform.position = new Vector3(0, -10, 0);
        }
        if (collision.gameObject.tag == "Player2")
        {
            P2 = true;
            P2Shielded = true; 
            StartCoroutine(ShieldDuration());
            transform.position = new Vector3(0, -10, 0);
        }

    }
    private IEnumerator ShieldDuration()
    {
        yield return new WaitForSeconds(15);
        if (P1 == true)
        {
            P1Shielded = false;
            P1 = false;
        }
        if (P2 == true)
        {
            P2Shielded = false;
            P2 = false;
        }
    }
}
