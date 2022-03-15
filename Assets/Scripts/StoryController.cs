using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryController : MonoBehaviour
{
    [SerializeField] private GameObject[] texts = new GameObject[15];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onButton1Pressed()
    {
        texts[1].SetActive(false);
        texts[2].SetActive(true);
    }
    public void onButton2Pressed()
    {
        texts[2].SetActive(false);
        texts[3].SetActive(true);
    }
    public void onButton3Pressed()
    {
        texts[3].SetActive(false);
        texts[4].SetActive(true);
    }
    public void onButton4Pressed()
    {
        texts[4].SetActive(false);
        texts[5].SetActive(true);
    }
    public void onButton5Pressed()
    {
        texts[5].SetActive(false);
        texts[6].SetActive(true);
    }
    public void onButton6Pressed()
    {
        texts[6].SetActive(false);
        texts[7].SetActive(true);
    }
    public void onButton7Pressed()
    {
        texts[7].SetActive(false);
        texts[8].SetActive(true);
    }
    public void onButton8Pressed()
    {
        texts[8].SetActive(false);
        texts[9].SetActive(true);
    }
    public void onButton9Pressed()
    {
        texts[9].SetActive(false);
        texts[10].SetActive(true);
    }
    public void onButton10Pressed()
    {
        texts[10].SetActive(false);
        texts[11].SetActive(true);
    }
    public void onButton11Pressed()
    {
        texts[1].SetActive(false);
        texts[12].SetActive(true);
    }
    public void onButton12Pressed()
    {
        texts[12].SetActive(false);
        texts[13].SetActive(true);
    }
    public void onButton13Pressed()
    {
        texts[13].SetActive(false);
        texts[14].SetActive(true);
    }
    
    
    
}
