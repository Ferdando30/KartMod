using System.Collections;
using KartGame.KartSystems;
using UnityEngine;

public class Drift : MonoBehaviour
{
    public ArcadeKart ArcadeKartScrpitP1;
    public ArcadeKart ArcadeKartScriptp2;
    public bool P1;
    public bool P2;
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
            ArcadeKartScrpitP1.baseStats.Grip = 0;
            P1 = true;
            StartCoroutine(GripCerto());
            transform.position = new Vector3(0, -10, 0);
        }
        if (collision.gameObject.tag == "Player2")
        {
            ArcadeKartScriptp2.baseStats.Grip = 0;
            P2 = true;
            StartCoroutine(GripCerto());
            transform.position = new Vector3(0, -10, 0);
        }

    }
    private IEnumerator GripCerto()
    {
        yield return new WaitForSeconds(2);
        if (P1 == true)
        {
            P1 = false;
            ArcadeKartScrpitP1.baseStats.Grip = 0.97f;
        }
        if (P2 == true)
        {
            P2 = false;
            ArcadeKartScriptp2.baseStats.Grip = 0.97f;
        }

    }
}
