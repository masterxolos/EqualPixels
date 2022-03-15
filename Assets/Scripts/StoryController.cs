using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoryController : MonoBehaviour
{
    [SerializeField] private GameObject[] texts = new GameObject[15];
    [SerializeField] private GameObject[] pcyaziları = new GameObject[15];
    [SerializeField] private GameObject[] sahneler = new GameObject[15];
    [SerializeField] private GameObject[] pacmanButtons = new GameObject[15];
    [SerializeField] private GameObject[] pacmans = new GameObject[15];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onSahne1Buttonpressed()
    {
        sahneler[0].SetActive(false);
        sahneler[1].SetActive(true);
        texts[1].SetActive(true);
    }

    public void onButton1Pressed()
    {
        Debug.Log("asd");
        texts[1].SetActive(false);
        texts[2].SetActive(true);
    }
    public void onButton2Pressed()
    {
        texts[2].SetActive(false);
        texts[3].SetActive(true);
        sahneler[1].SetActive(false);
        sahneler[2].SetActive(true);
        
        pcyaziları[0].SetActive(true);
        pcyaziları[1].SetActive(true);
        //pcyaziları[2].SetActive(true);
        //pcyaziları[3].SetActive(true);
    }
    public void onButton3Pressed()
    {
        texts[3].SetActive(false);
        texts[4].SetActive(true);
        pcyaziları[4].SetActive(true);
        pcyaziları[6].SetActive(true);
    }
    public void onButton4Pressed()
    {
        texts[4].SetActive(false);
        texts[5].SetActive(true);
        texts[6].SetActive(true);
        texts[7].SetActive(true);
    }
    public void onButton5Pressed()
    {
        texts[5].SetActive(false);
        texts[6].SetActive(false);
        texts[7].SetActive(false);
        
        pcyaziları[7].SetActive(true);
        pcyaziları[8].SetActive(true);
        pacmanButtons[0].SetActive(true);
        pacmans[0].SetActive(true);
        
    }
    public void onButton6Pressed()
    {
        texts[5].SetActive(false);
        texts[6].SetActive(false);
        texts[7].SetActive(false);

        pcyaziları[7].SetActive(true);
        pcyaziları[8].SetActive(true);
        pacmanButtons[0].SetActive(true);
        pacmans[0].SetActive(true);
    }
    public void onButton7Pressed()
    {
        texts[5].SetActive(false);
        texts[6].SetActive(false);
        texts[7].SetActive(false);

        pcyaziları[7].SetActive(true);
        pcyaziları[8].SetActive(true);
        pacmanButtons[0].SetActive(true);
        pacmans[0].SetActive(true);
    }

    public void onPacmanButton1Pressed()
    {
        pcyaziları[8].GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
        pcyaziları[5].SetActive(true);
        pacmans[0].SetActive(false);
        texts[8].SetActive(true);
        pacmanButtons[0].SetActive(false);
    }
    public void onButton8Pressed()
    {
        texts[8].SetActive(false);
        texts[9].SetActive(true);
        texts[10].SetActive(true);
        texts[11].SetActive(true);
    }
    public void onButton9Pressed()
    {
        pcyaziları[9].SetActive(true);
        pcyaziları[10].SetActive(true);
        texts[9].SetActive(false);
        texts[10].SetActive(false);
        texts[11].SetActive(false);
        pacmanButtons[1].SetActive(true);
        pacmans[1].SetActive(true);
    }
    public void onPacmanButton2Pressed()
    {
        pcyaziları[10].GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
        pcyaziları[11].SetActive(true);
        pacmans[1].SetActive(false);
        texts[12].SetActive(true);
        pacmanButtons[1].SetActive(false);
    }
    public void onButton10Pressed()
    {
        pcyaziları[9].SetActive(true);
        pcyaziları[10].SetActive(true);
        texts[9].SetActive(false);
        texts[10].SetActive(false);
        texts[11].SetActive(false);
        pacmanButtons[1].SetActive(true);
        pacmans[1].SetActive(true);
    }
    public void onButton11Pressed()
    {
        pcyaziları[9].SetActive(true);
        pcyaziları[10].SetActive(true);
        texts[9].SetActive(false);
        texts[10].SetActive(false);
        texts[11].SetActive(false);
        pacmanButtons[1].SetActive(true);
        pacmans[1].SetActive(true);
    }
    public void onButton12Pressed()
    {
        texts[12].SetActive(false);
        texts[13].SetActive(true);
        texts[14].SetActive(true);
    }
    public void onButton13Pressed()
    {
        pcyaziları[12].SetActive(true);
        pcyaziları[13].SetActive(true);
        texts[13].SetActive(false);
        texts[14].SetActive(false);
        //texts[15].SetActive(true);
        pacmanButtons[2].SetActive(true);
        pacmans[2].SetActive(true);
    }
    public void onButton14Pressed()
    {
        pcyaziları[12].SetActive(true);
        pcyaziları[13].SetActive(true);
        texts[13].SetActive(false);
        texts[14].SetActive(false);
        
        pacmanButtons[2].SetActive(true);
        pacmans[2].SetActive(true);
    }
    public void onPacmanButton3Pressed()
    {
        texts[15].SetActive(true);
        pcyaziları[13].GetComponent<TextMeshProUGUI>().fontStyle = FontStyles.Strikethrough;
        pcyaziları[14].SetActive(true);
        pacmans[2].SetActive(false);
        pacmanButtons[2].SetActive(false);
    }
    public void onButton15Pressed()
    {
        //texts[15].SetActive(false);
        //sahneler[2].SetActive(false);
        //sahneler[3].SetActive(true);
    }
    
}
