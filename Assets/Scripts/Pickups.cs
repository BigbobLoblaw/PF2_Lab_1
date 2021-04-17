using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    Inventory Linkedlist;

    public enum Pickup
    {
        NAVYBOX,
        COIN,
        PILLAR,
    };

    public Pickup currentPickup;
    // Start is called before the first frame update
    void Start()
    {

        Linkedlist = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (currentPickup)
            {
                case Pickup.NAVYBOX:
                    Linkedlist.AddToList("Navybox");
                    Debug.Log("Navybox picked up");
                    Destroy(gameObject);
                    break;
                case Pickup.COIN:
                    Linkedlist.AddToList("Coin");
                    Debug.Log("Coin picked up");
                    Destroy(gameObject);
                    break;
                case Pickup.PILLAR:
                    Linkedlist.AddToList("Pillar");
                    Debug.Log("Pillar picked up");
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
/*
{
    public CollectibleType pickups;

    public enum CollectibleType
    {
        POWERUP,
        COIN,
        LIVES
    }

    void Start()
    {


    }


    void Update()
    {
   

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switch (pickups)
            {
                case CollectibleType.POWERUP:
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().Coin();
                    Debug.Log("PowerUp");
                    Destroy(gameObject);
                    break;
                case CollectibleType.LIVES:
                    Debug.Log("Lives");
                    Destroy(gameObject);
                    break;
                case CollectibleType.COIN:
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
                    Debug.Log("Coin");
                    Destroy(gameObject);
                    break;
            }
        }
    }
}*/