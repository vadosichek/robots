using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNdrop : MonoBehaviour
{
    public bool EnableOffset = true;
    public ProgressController pc;
    public Remover remover;
    public Camera mainCam;
    private Vector3 _offset;
    private Vector3 _startPos;

    private void Start(){
        _startPos = transform.position;
    }

    private void OnMouseDown(){
        _offset = transform.position - GetMousePos();
    }
    private void OnMouseDrag(){
        if(EnableOffset) transform.position = GetMousePos() + _offset;
        else transform.position = GetMousePos();
    }
    private void OnMouseUp(){
        pc.Remove(remover); 
        transform.position = _startPos;
    }

    private Vector3 GetMousePos(){
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
