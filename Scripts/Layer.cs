using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour
{
    public ProgressController pc;
    public List<ToBeRemoved> toBeRemoved;
    public void Remove(ToBeRemoved _toBeRemoved){
        _toBeRemoved.gameObject.SetActive(false);
        toBeRemoved.Remove(_toBeRemoved);
        if(toBeRemoved.Count == 0){
            pc.NextLayer();
            gameObject.SetActive(false);
        }
    }
}
