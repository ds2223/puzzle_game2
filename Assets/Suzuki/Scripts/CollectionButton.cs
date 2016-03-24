using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectionButton : MonoBehaviour
{
   // Oshinagakis
    public Text memoPos;
    public Image placePos;
    public Image namePos;
    public Image sushiPos;

    public void OnClick()
    {
        Debug.Log(gameObject.name);
        GameObject go = Resources.Load("Prefab/Memo_" + gameObject.name) as GameObject;

        //Resources内のすしネコのスプライトを配列で取得
        Sprite[] images = Resources.LoadAll<Sprite>("sb");
        //sushiPosのimageを取得
        sushiPos = sushiPos.GetComponent<Image>();
        //sushiPosの画像を差し替える
        sushiPos.sprite = images[int.Parse(gameObject.name)];

        Sprite[] nameImgs = Resources.LoadAll<Sprite>("Images/Oshinagakis");
        namePos = namePos.GetComponent<Image>();
        namePos.sprite = nameImgs[int.Parse(gameObject.name)];

        //一言メモのテキストを差し替える
        memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;

        if (transform.parent.gameObject.name == "Nami")
        {
            Sprite sp = Resources.Load<Sprite>("Images/BG_Zukan_" + 100 + "en");
            placePos = placePos.GetComponent<Image>();
            placePos.sprite = sp;
        }
        if (transform.parent.gameObject.name == "Jou")
        {
            Sprite sp = Resources.Load<Sprite>("Images/BG_Zukan_" + 200 + "en");
            placePos = placePos.GetComponent<Image>();
            placePos.sprite = sp;
        }
        if (transform.parent.gameObject.name == "Tokujou")
        {
            Sprite sp = Resources.Load<Sprite>("Images/BG_Zukan_" + 300 + "en");
            placePos = placePos.GetComponent<Image>();
            placePos.sprite = sp;
        }

    }

}
