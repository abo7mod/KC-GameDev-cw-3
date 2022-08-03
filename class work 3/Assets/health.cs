using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//health hero...
public class health : MonoBehaviour
{
    string heroName = "jassem";
    int heroPower = 80;
    string villainName = "jake";
    int villainPower = 90;
    float PlayerSpeed = 4.5f;
    float PlayerSpeed2 = 0f;

    void CompareSpeed()
    {
        if (PlayerSpeed > PlayerSpeed2)
        {
            print(PlayerSpeed);
        }
        else if(PlayerSpeed == PlayerSpeed2 )
        {
            print(PlayerSpeed);
            print(PlayerSpeed2);
        }
        else
        {
            print(PlayerSpeed2);
        }
    }
    void setSpeed(float speed )
    
    
    {
         PlayerSpeed2 = speed;
    }



    // Start is called before the first frame update
    void Start()
    {
        if (villainPower > heroPower)
        {
            print(villainPower);

            
        }

        else if (villainPower < heroPower)


        {
            print(heroPower);


        }

        else

        {

            print(villainPower + "=" + heroPower );



        }

        print(PlayerSpeed2);
        setSpeed(2.5f);
        print(PlayerSpeed2);
        CompareSpeed();


    }





    // Update is called once per frame
    void Update()
    {

    }







  }


