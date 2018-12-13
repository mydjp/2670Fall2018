using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swtich : MonoBehaviour
{

    public int strength = 5;

    void Greet()
    {
        switch (strength)
        {
            case 5:
                print("wow you cant lift that boulder over your head");
                break;
            case 4:
                print("you can pick that boulder up and move it");
                break;
            case 3:
                print("you can roll that boulder");
                break;
            case 2:
                print("you cant put enough power into the boulder to see whats underneath");
                break;
            case 1:
                print("thats a big rock what do you think you can do ");
                break;
            default:
                print("Need more Strength ");
                break;
            
           
        }
    }

}
