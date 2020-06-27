using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Object fireRef;
    
    // Start is called before the first frame update
    void Start()
    {
        fireRef = Resources.Load("fireball");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            GameObject fireball = (GameObject)Instantiate(fireRef);
            fireball.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -3);
             
        }
        
    }
}
