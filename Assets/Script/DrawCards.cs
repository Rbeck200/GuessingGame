using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    List<GameObject> cards = new List<GameObject>();

    void Start()
    {

        cards.Add(Card1);
        cards.Add(Card2);
        

    }

    public void createCard(GameObject playmat)
    {
        GameObject Card = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
        Card.transform.SetParent(playmat.transform, false);
    }

    public void onClick()
    {
        for (var i = 0; i < 5; i++)
        {
            createCard(PlayerArea);
            createCard(EnemyArea);
        }
    }

}
