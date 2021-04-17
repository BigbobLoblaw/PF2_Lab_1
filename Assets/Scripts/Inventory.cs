using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    LinkedList<string> invetory = new LinkedList<string>();
    // Start is called before the first frame update
    public void AddToList(string pItem)
    {
        invetory.AddLast(pItem);
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            if (invetory.Count > 0)
            {
                Debug.Log(invetory.First.Value + " used");
                invetory.RemoveFirst();
            }

            else
                invetory.Clear();
        }
    }

}
/*
{
    public LinkedList<string> CollectiblesInv = new LinkedList<string>();

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CollectiblesInv);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(CollectiblesInv.First);

        }
    }

    public void Coin()
    {
        CollectiblesInv.AddFirst("COIN");
        Debug.Log("CCCCCCCCCCCCCCCCCCC");
    }
}*/