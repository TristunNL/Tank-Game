using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Speler : MonoBehaviour
{
    public int spelerNummer;
    bool IsAanDeBeurt = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space) && IsAanDeBeurt == true)
        {

            Invoke("WisselBeurt", 0.1f);


        }*/
    }





    /*void WisselBeurt()
    {

        GameObject.Find("GameManager").GetComponent<TurnManager>().WisselBeurt();



    }*/
    public void ZetActief(bool b)

    {
        if (b == true)
        {
            IsAanDeBeurt = true;
            GetComponent<TankController>().enabled = true;
        }
        else
        {
            IsAanDeBeurt = false;
            GetComponent<TankController>().enabled = false;
        }

    }


}