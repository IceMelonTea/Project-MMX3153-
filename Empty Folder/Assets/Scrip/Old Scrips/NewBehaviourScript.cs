using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string myHouse = "Battle Arena";
    char houseGrade = 'A';
    bool ownerIsMalaysian = true;
    string houseType = "Raid";
    string homeAddress = "No.1, Jalan Sana Sini, Taman Pembunuhan, 911999 Konoha, Jakarta";
    float houseLenght = 30.5f;
    float houseWidth = 15.8f;
    int houseLevel = 3;
    string houseColor = "white";
    string welcomeMessage = "Welcome to DeathMatch";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myHouse);
        Debug.Log(houseGrade);
        Debug.Log(ownerIsMalaysian);
        Debug.Log(houseType);
        Debug.Log(homeAddress);
        Debug.Log(houseLenght);
        Debug.Log(houseWidth);
        Debug.Log(houseLevel);
        Debug.Log(houseColor);
        Debug.Log(welcomeMessage);
    }


   


    // Update is called once per frame
    void Update()
    {
       
    }
}
