using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectionButton : MonoBehaviour
{
    public Text memoPos;
    public Image placePos;
    public GameObject sushiPos;

    public void OnClick()
    {
        Debug.Log(gameObject.name);
        GameObject go = Resources.Load("Prefab/Memo_" + gameObject.name) as GameObject;

        Sprite[] images = Resources.LoadAll<Sprite>("sb");
        memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;
        Image img = sushiPos.GetComponent<Image>();
        img.sprite = images[int.Parse(gameObject.name)];
        if (transform.parent.gameObject.name == "Nami")
        {
            Sprite sp = Resources.Load<Sprite>("Image/BG_Zukan_" + 100 + "en");
            placePos = placePos.GetComponent<Image>();
            placePos.sprite = sp;
        }
        if (transform.parent.gameObject.name == "Jou")
        {
            Sprite sp = Resources.Load<Sprite>("Image/BG_Zukan_" + 200 + "en");
            placePos = placePos.GetComponent<Image>();
            placePos.sprite = sp;
        }
        if (transform.parent.gameObject.name == "Tokujou")
        {
            Sprite sp = Resources.Load<Sprite>("Image/BG_Zukan_" + 300 + "en");
            placePos = placePos.GetComponent<Image>();
            placePos.sprite = sp;
        }
    }

}
