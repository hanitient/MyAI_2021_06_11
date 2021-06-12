using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    int value;
    CardColor color;

    public int Value { get => value; set => this.value = value; }
    public CardColor Color { get => color; set => color = value; }
    public Card(int v, CardColor c)
    {
        Value = v;
        Color = c;
    }
}
