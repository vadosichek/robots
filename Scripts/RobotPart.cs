using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPart : MonoBehaviour
{
    public RobotCollector rc;
    public int n;
    private void OnMouseDown(){
        rc.Collect(n);
        gameObject.SetActive(false);
    }
}
