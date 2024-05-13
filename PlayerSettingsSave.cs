using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static Player instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            // If an instance already exists and it's not this object, destroy this object
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
}
