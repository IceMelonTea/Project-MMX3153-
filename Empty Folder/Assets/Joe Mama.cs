using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeMama : MonoBehaviour
{
    // Start is called before the first frame update
    string myhouse = "JoeMama";
    char houseGrade = 'A';
    bool ownerIsMalaysian = true;
    string houseType = "concrete house";
    string homeAddress = "No.1, Jalan 1, Bandar 1, Negeri 1, Negara 1";
    float houseLength = 30.5f;
    float housewidth = 15.8f;
    int houseLevel = 3;
    string housecolor = "White";
    string welcomeMessage = "Welcome to my humble aboad";
    void Start()
    {
        Debug.Log(myhouse);
        Debug.Log(houseGrade);
        Debug.Log(ownerIsMalaysian);
        Debug.Log(houseType);
        Debug.Log(homeAddress);
        Debug.Log(houseLength);
        Debug.Log(housewidth);
        Debug.Log(houseLevel);
        Debug.Log(housecolor);
        Debug.Log(welcomeMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
