using System.Collections;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public bool P1;
    public bool P2;
    public GameObject Kart1;
    public GameObject Kart2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        P1 = false;
        P2 = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Kart1 = collision.gameObject;
            collision.gameObject.transform.localScale = new Vector3(2, 2, 2);
            P1 = true;
            StartCoroutine(Small());
            transform.position = new Vector3(0, -10, 0);
        }
        if (collision.gameObject.tag == "Player2")
        {
            Kart2 = collision.gameObject;
            collision.gameObject.transform.localScale = new Vector3(2, 2, 2);
            P2 = true;
            StartCoroutine(Small());
            transform.position = new Vector3(0, -10, 0);
        }

    }
    private IEnumerator Small()
    {
        yield return new WaitForSeconds(2);
        if (P1 == true)
        {
            P1 = false;
            Kart1.transform.localScale = new Vector3(1, 1, 1);
        }
        if (P2 == true)
        {
            P2 = false;
            Kart2.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
