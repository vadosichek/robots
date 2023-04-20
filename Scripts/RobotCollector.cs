using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RobotCollector : MonoBehaviour{
    public int ScrapCount;
    public TMP_Text  tmp;
    public List<GameObject> parts;

    void Start(){
        UpdateScrapCount();
    }

    void Update()
    {
        
    }

    public void Collect(int n){
        parts[n].SetActive(true);
    }

    public void UpdateScrapCount(){
        tmp.text = "x"+ScrapCount;
    }
    public void IncrementScrap(){
        ScrapCount++;
        UpdateScrapCount();
    }
}
