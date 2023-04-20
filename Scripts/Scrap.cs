using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap : MonoBehaviour
{
    public RobotCollector rc;
    private void OnMouseDown(){
        rc.IncrementScrap();
        gameObject.SetActive(false);
    }
}
