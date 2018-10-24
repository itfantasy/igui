using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

/// <summary>
/// 描述：
/// 作者： 
/// </summary>
public class Main : MonoBehaviour {

    IButton uBtn;
    IButton nBtn;

    ILabel uLabel;
    ILabel nLabel;

	// Use this for initialization
	void Start () {
        uBtn = IGUI.Button(GameObject.Find("URoot/Button"), UIType.UGUI);
        nBtn = IGUI.Button(GameObject.Find("NRoot/Button"), UIType.NGUI);

        uBtn.SetClick(this.OnClick);
        nBtn.SetClick(this.OnClick);

        uLabel = IGUI.Label(GameObject.Find("URoot/Label"), UIType.UGUI);
        nLabel = IGUI.Label(GameObject.Find("NRoot/Label"), UIType.NGUI);

        uLabel.text = "Fantasy!";
        nLabel.text = "Fantasy!";

	}
	
	void OnClick(GameObject go)
    {
        IGUI.Button(go).text = "Fantasy!";
    }
}
