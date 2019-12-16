using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    public Dropdown SelectButton;
    GameObject spawnSelect;
    GameObject fieldSizeSelect;
    GameObject gameFinishSelect;
    GameObject statusSelect;
    void Start(){
        spawnSelect = canvas.transform.GetChild(2).gameObject;
        fieldSizeSelect = canvas.transform.GetChild(3).gameObject;
        gameFinishSelect = canvas.transform.GetChild(4).gameObject;
        statusSelect = canvas.transform.GetChild(5).gameObject;
    }
    // Update is called once per frame
    void Update(){
        switch(SelectButton.value){
            case 0:
                spawnSelect.SetActive(false);
                fieldSizeSelect.SetActive(false);
                gameFinishSelect.SetActive(false);
                statusSelect.SetActive(false);
                break;
            case 1:
                spawnSelect.SetActive(true);
                fieldSizeSelect.SetActive(false);
                gameFinishSelect.SetActive(false);
                statusSelect.SetActive(false);
                break;
            case 2:
                spawnSelect.SetActive(false);
                fieldSizeSelect.SetActive(true);
                gameFinishSelect.SetActive(false);
                statusSelect.SetActive(false);
                break;
            case 3:
                spawnSelect.SetActive(false);
                fieldSizeSelect.SetActive(false);
                gameFinishSelect.SetActive(true);
                statusSelect.SetActive(false);
                break;
            case 4:
                spawnSelect.SetActive(false);
                fieldSizeSelect.SetActive(false);
                gameFinishSelect.SetActive(false);
                statusSelect.SetActive(true);
                break;
        }
    }
}
