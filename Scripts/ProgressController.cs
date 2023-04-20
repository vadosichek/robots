using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : MonoBehaviour
{
    public List<Layer> layers;
    public List<int> toolsForLayers;
    public int cLayer = 0;
    public Material Normal, Outlined;
    public List<GameObject> transfers;
    
    void Start(){
        ColorCurrentLayer();
    }

    public void Remove(Remover remover){
        if(toolsForLayers[cLayer] == remover.layerId){
            Collider2D rCol = remover.gameObject.GetComponent<Collider2D>();
            foreach(ToBeRemoved tbr in layers[cLayer].toBeRemoved){
                Collider2D nCol = tbr.gameObject.GetComponent<Collider2D>();
                if(rCol.bounds.Intersects(nCol.bounds)){
                    layers[cLayer].Remove(tbr);
                    break;
                }
            }
        }
    }

    private void ColorCurrentLayer(){
        if(layers.Count > 0){
            foreach(ToBeRemoved tbr in layers[cLayer].toBeRemoved){
                SpriteRenderer sr = tbr.gameObject.GetComponent<SpriteRenderer>();
                sr.material = Outlined;
            }
        }
    }

    public void NextLayer(){
        cLayer++;
        if(cLayer >= layers.Count){
            Debug.Log("Area cleared");
            foreach(GameObject transfer in transfers){
                transfer.GetComponent<SpriteRenderer>().material = Outlined;
            }
            return;
        }
        ColorCurrentLayer();
    }
}
