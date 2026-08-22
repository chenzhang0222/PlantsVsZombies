using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{   
    public static SunManager Instance
    {
        get;
        private set;
    }
    private void Awake()
    {
        Instance = this;
    }

    [SerializeField]
    private int sunPiont;
    public int SunPoint
    {
        get 
            { return sunPiont; }
    }
}
