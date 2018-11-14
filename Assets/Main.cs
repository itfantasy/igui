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

    IImage uImage;
    IImage nImage;

	// Use this for initialization
	void Start () {

        InitUI();
        LoadResource();
        SetUIConfig();

	}

    void InitUI()
    {
        uBtn = IGUI.Button(GameObject.Find("URoot/Button"), UIType.UGUI);
        nBtn = IGUI.Button(GameObject.Find("NRoot/Button"), UIType.NGUI);

        uLabel = IGUI.Label(GameObject.Find("URoot/Label"), UIType.UGUI);
        nLabel = IGUI.Label(GameObject.Find("NRoot/Label"), UIType.NGUI);

        uImage = IGUI.Image(GameObject.Find("URoot/Image"), UIType.UGUI);
        nImage = IGUI.Image(GameObject.Find("NRoot/Image"), UIType.NGUI);
    }

    Texture texture1 = null;
    Texture texture2 = null;

    void LoadResource()
    {
        texture1 = Resources.Load("img1") as Texture;
        texture2 = Resources.Load("img2") as Texture;
    }

    void SetUIConfig()
    {
        uBtn.SetClick(this.OnClick);
        nBtn.SetClick(this.OnClick);

        uLabel.text = "Fantasy!";
        nLabel.text = "Fantasy!";

        uImage.texture = texture2;
        nImage.texture = texture1;

        uImage.alpha = 0.5f;
        nImage.alpha = 0.5f;
    }
	
	void OnClick(GameObject go)
    {
        IGUI.Button(go).text = "Fantasy!";
    }
}
