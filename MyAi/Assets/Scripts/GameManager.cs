using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] 
    CardFactory cardFactory;

    // Start is called before the first frame update
    void Start()
    {
        cardFactory.GetRandomCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
