using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cake : MonoBehaviour
{
    public GameObject cake;
    public float turnspeed = 4.5f;

    [Space]
    [Space]
    [Space]
    [Header("Object Reference")]
    public GameObject firstlayerDecoration;
    public GameObject SecondLayerCake;
    public GameObject secondlayerDecoration;
    [Space]
    public GameObject[] cherryLayer;
    public GameObject[] creamLayer;
    public GameObject[] cherrycreamLayer;
    public GameObject[] strawberryLayer;
    public GameObject[] chocolateLayer;
    public GameObject[] birthdaynameLayer;

    [Space]
    [Space]
    [Space]
    [Header("Properties of Cake")]
    public int cakeLayer=1;
    public bool has_Cherry;
    public bool has_Cream;
    public bool has_strawberry;
    public bool has_chocolate;
    public bool has_birthdayname;


    void applyDecorCake()
    {
        if (cakeLayer == 1)
        {
            firstlayerDecoration.SetActive(true); 
            secondlayerDecoration.SetActive(false);
        }
        if(cakeLayer == 2)
        {
            firstlayerDecoration.SetActive(false);
            SecondLayerCake.SetActive(true);
            secondlayerDecoration.SetActive(true);
        }

        if (has_Cherry && !has_Cream)
        {
            cherryLayer[0].gameObject.SetActive(true);
            cherryLayer[1].gameObject.SetActive(true);
        }
        if (has_Cream && !has_Cherry)
        {
            creamLayer[0].gameObject.SetActive(true);
            creamLayer[1].gameObject.SetActive(true);
        }
        if(has_Cherry && has_Cream)
        {
            cherryLayer[0].gameObject.SetActive(false);
            cherryLayer[1].gameObject.SetActive(false);

            creamLayer[0].gameObject.SetActive(true);
            creamLayer[1].gameObject.SetActive(true);

            cherrycreamLayer[0].gameObject.SetActive(true);
            cherrycreamLayer[1].gameObject.SetActive(true);
            
        }
        if (has_strawberry)
        {
            strawberryLayer[0].gameObject.SetActive(true);
            strawberryLayer[1].gameObject.SetActive(true);
        }
        if (has_chocolate)
        {
            chocolateLayer[0].gameObject.SetActive(true);
            chocolateLayer[1].gameObject.SetActive(true);
        }
        if (has_birthdayname)
        {
            birthdaynameLayer[0].gameObject.SetActive(true);
            birthdaynameLayer[1].gameObject.SetActive (true);
        }
    }

    private void Update()
    {
        applyDecorCake();

        cake.transform.Rotate(Vector3.up * Time.deltaTime * turnspeed);
    }

    
}
