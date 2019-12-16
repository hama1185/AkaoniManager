using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSend : MonoBehaviour
{
    public Canvas canvas;
    Toggle ogreSpawnToggle;
    Toggle villagerSpawnToggle;
    // Start is called before the first frame update
    void Start(){
        ogreSpawnToggle = canvas.transform.GetChild(2).GetChild(0).gameObject.GetComponent<Toggle>();
        villagerSpawnToggle = canvas.transform.GetChild(2).GetChild(1).gameObject.GetComponent<Toggle>();
    }

    // Update is called once per frame
    public void SpwanSend(){
        if(ogreSpawnToggle.isOn){
            OgreClient.SpawnSend();
        }
        if(villagerSpawnToggle.isOn){
            VillagerClient.SpawnSend();
        }
    }
}
