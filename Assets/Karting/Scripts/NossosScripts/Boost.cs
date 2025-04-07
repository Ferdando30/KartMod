using System.Collections;
using System.Collections.Generic;
using KartGame.KartSystems;
using UnityEngine;

public class Boost : MonoBehaviour
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
            ArcadeKartScrpitP1.baseStats.TopSpeed = ArcadeKartScrpitP1.baseStats.TopSpeed * 2;
            ArcadeKartScrpitP1.baseStats.Acceleration = ArcadeKartScrpitP1.baseStats.Acceleration * 2;
            P1 = true;
            StartCoroutine(VezesUm());
            transform.position = new Vector3(0, -10, 0);
        }
        if (collision.gameObject.tag == "Player2")
        {
            ArcadeKartScriptp2.baseStats.TopSpeed = ArcadeKartScriptp2.baseStats.TopSpeed * 2;
            ArcadeKartScriptp2.baseStats.Acceleration = ArcadeKartScriptp2.baseStats.Acceleration * 2;
            P2 = true;
            StartCoroutine(VezesUm());
            transform.position = new Vector3(0, -10, 0);
        }

    }
    private IEnumerator VezesUm()
    {
        yield return new WaitForSeconds(2);
        if(P1 == true)
        {
            P1 = false;
            ArcadeKartScrpitP1.baseStats.TopSpeed = ArcadeKartScrpitP1.baseStats.TopSpeed / 2;
            ArcadeKartScrpitP1.baseStats.Acceleration = ArcadeKartScrpitP1.baseStats.Acceleration / 2;
        }
        if (P2 == true)
        {
            P2 = false;
            ArcadeKartScriptp2.baseStats.TopSpeed = ArcadeKartScriptp2.baseStats.TopSpeed / 2;
            ArcadeKartScriptp2.baseStats.Acceleration = ArcadeKartScriptp2.baseStats.Acceleration / 2;
        }

    }
}
