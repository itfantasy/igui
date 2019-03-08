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

    ISlider uSlider;
    ISlider nSlider;

    IImage uImage;
    IImage nImage;

    IInput uInput;
    IInput nInput;

    IProgressBar uProgressBar;
    IProgressBar nProgressBar;

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

        uSlider = IGUI.Slider(GameObject.Find("URoot/Slider"), UIType.UGUI);
        nSlider = IGUI.Slider(GameObject.Find("NRoot/Slider"), UIType.NGUI);

        uImage = IGUI.Image(GameObject.Find("URoot/Image"), UIType.UGUI);
        nImage = IGUI.Image(GameObject.Find("NRoot/Image"), UIType.NGUI);

        uInput = IGUI.Input(GameObject.Find("URoot/Input"), UIType.UGUI);
        nInput = IGUI.Input(GameObject.Find("NRoot/Input"), UIType.NGUI);

        uProgressBar = IGUI.ProgressBar(GameObject.Find("URoot/ProgressBar"), UIType.UGUI);
        nProgressBar = IGUI.ProgressBar(GameObject.Find("NRoot/ProgressBar"), UIType.NGUI);
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

        uSlider.value = 0.5f;
        nSlider.value = 0.5f;

        uImage.texture = texture2;
        nImage.texture = texture1;

        uImage.alpha = 0.5f;
        nImage.alpha = 0.5f;

        uInput.text = "i'm UGUI";
        nInput.text = "i'm NGUI";

        uProgressBar.value = 0.6f;
        nProgressBar.value = 0.6f;
    }
	
	void OnClick(GameObject go)
    {
        IGUI.Button(go).text = "Fantasy!";
    }
}
