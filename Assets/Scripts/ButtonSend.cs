using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSend : MonoBehaviour
{
    public bool spawnFlag;
    public bool fieldFlag;
    public bool realSenseFlag;
    public Canvas canvas;
    public Toggle ogreSpawnToggle;
    public Toggle villagerSpawnToggle;
    public Toggle ogreRealSenseToggle;
    public Toggle villagerRealSenseToggle;
    public Dropdown sendStatusDropDown;
    // Start is called before the first frame update
    void Start(){
        ogreSpawnToggle = canvas.transform.GetChild(2).GetChild(0).gameObject.GetComponent<Toggle>();
        villagerSpawnToggle = canvas.transform.GetChild(2).GetChild(1).gameObject.GetComponent<Toggle>();
        ogreRealSenseToggle = canvas.transform.GetChild(6).GetChild(0).gameObject.GetComponent<Toggle>();
        villagerRealSenseToggle = canvas.transform.GetChild(6).GetChild(1).gameObject.GetComponent<Toggle>();
        sendStatusDropDown = canvas.transform.GetChild(6).GetChild(2).gameObject.GetComponent<Dropdown>();
        spawnFlag = true;
        fieldFlag = true;
        realSenseFlag = true;
    }

    // Update is called once per frame
    public void SpwanSend(){
        if(spawnFlag){
            if(ogreSpawnToggle.isOn){
                OgreClient.SpawnSend();
            }
            if(villagerSpawnToggle.isOn){
                VillagerClient.SpawnSend();
            }
            spawnFlag = false;
        }
    }
    public void PlayareaSizeSend(){
        if(fieldFlag){
            OgreClient.PlayareaSend();
            VillagerClient.PlayareaSend();
            fieldFlag = false;
        }
    }
    public void RealSenseMove(){
        if(realSenseFlag){
            if(sendStatusDropDown.value == 1){
                if(ogreRealSenseToggle.isOn){
                OgreRealSenseClient.RealSenseStartSend();
            }
                if(villagerRealSenseToggle.isOn){
                    VillagerRealSenseClient.RealSenseStartSend();
                }
            }
            if(sendStatusDropDown.value == 2){
                if(ogreRealSenseToggle.isOn){
                OgreRealSenseClient.RealSenseStopSend();
            }
                if(villagerRealSenseToggle.isOn){
                    VillagerRealSenseClient.RealSenseStopSend();
                }
            }
            realSenseFlag = false;
        }
    }
    public void resetSpwanFlag(){
        spawnFlag = true;
        Debug.Log("up");
    }
    public void resetFieldFlag(){
        fieldFlag = true;
        Debug.Log("up");
    }
    public void resetRealSenseFlag(){
        realSenseFlag = true;
        Debug.Log("up");
    }
}
