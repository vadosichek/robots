using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLoc : MonoBehaviour
{
    public List<DragNdrop> instruments;
    public GameObject c_loc, n_loc;
    public ProgressController c_pc, n_pc;
    private void OnMouseDown(){
        foreach(DragNdrop dng in instruments){
            dng.pc = n_pc;
        }
        n_loc.SetActive(true);
        c_loc.SetActive(false);
    }
}
