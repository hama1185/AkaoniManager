﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityOSC;
using System.Text;
using System.Threading.Tasks;

public class OgreRealSenseClient : MonoBehaviour
{
    #region Network Settings //----------追記
    public string ip;
    public int port;
	#endregion //----------追記
    // Start is called before the first frame update
    public Dropdown dropdown;
    bool flag = false;
    public Canvas canvas;
    public void InitClient(){
        if(dropdown.value == 1){
            ip = HostList.phone1.ip_raspberrypi;
            port = HostList.phone1.port_raspberrypi;
        }
        if(dropdown.value == 2){
            ip = HostList.phone2.ip_raspberrypi;
            port = HostList.phone2.port_raspberrypi;
        }
        if(dropdown.value == 0){
            flag = false;
        }
        // Debug.Log("client IP : " + ip + "   port : " + port);
        try{
            OSCHandler.Instance.clientInit("RealSenseOgre", ip,port);//ipには接続先のipアドレスの文字列を入れる。
            flag = true; 
        }
        catch (System.FormatException){
        }
    }
    // Start is called before the first frame update
}
