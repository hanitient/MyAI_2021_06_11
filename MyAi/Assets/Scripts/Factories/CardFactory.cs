using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CardFactory", menuName = "Factory/cardFactory", order = 1)]
public class CardFactory: GameObjectFactory
{
    public void GetRandomCard()
    {
        int value = Random.Range(1, 11);
        CardColor[] colors = new CardColor[2] { CardColor.Red, CardColor.Black };
        CardColor color =colors[StaticData.GetRandomElement(new float[2]{ 1/3f,2/3f})];
    }
}
