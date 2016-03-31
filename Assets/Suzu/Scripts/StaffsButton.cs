using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StaffsButton : MonoBehaviour
{
    public Text memoPos;
    public Image rolePos;
    public Image namePos;
    public Image sushiPos;

    public void OnClick()
    {

        if (gameObject.name == "Mizuno")
        {
            //Resources内のすしネコのスプライトを配列で取得
            Sprite[] images = Resources.LoadAll<Sprite>("sb");
            sushiPos = sushiPos.GetComponent<Image>();
            sushiPos.sprite = images[12];


            Sprite[] nameImgs = Resources.LoadAll<Sprite>("Images/BG_Staffroll01");
            namePos = namePos.GetComponent<Image>();
            namePos.sprite = nameImgs[1];

            Sprite[] sp = Resources.LoadAll<Sprite>("Images/BG_Staffroll01");
            rolePos = rolePos.GetComponent<Image>();
            rolePos.sprite = sp[5];

            GameObject go = Resources.Load("Prefab/Memo_MizunoComment") as GameObject;
            memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;
        }

        if (gameObject.name == "Suzuki")
        {
            //Resources内のすしネコのスプライトを配列で取得
            Sprite[] images = Resources.LoadAll<Sprite>("sb");
            sushiPos = sushiPos.GetComponent<Image>();
            sushiPos.sprite = images[11];


            Sprite[] nameImgs = Resources.LoadAll<Sprite>("Images/BG_Staffroll01");
            namePos = namePos.GetComponent<Image>();
            namePos.sprite = nameImgs[2];

            Sprite[] sp = Resources.LoadAll<Sprite>("Images/BG_Staffroll02");
            rolePos = rolePos.GetComponent<Image>();
            rolePos.sprite = sp[1];

            GameObject go = Resources.Load("Prefab/Memo_SuzukiComment") as GameObject;
            memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;
        }

        if (gameObject.name == "Saito")
        {
            //Resources内のすしネコのスプライトを配列で取得
            Sprite[] images = Resources.LoadAll<Sprite>("sb");
            sushiPos = sushiPos.GetComponent<Image>();
            sushiPos.sprite = images[0];

            Sprite[] nameImgs = Resources.LoadAll<Sprite>("Images/BG_Staffroll01");
            namePos = namePos.GetComponent<Image>();
            namePos.sprite = nameImgs[3];

            Sprite[] sp = Resources.LoadAll<Sprite>("Images/BG_Staffroll01");
            rolePos = rolePos.GetComponent<Image>();
            rolePos.sprite = sp[6];

            GameObject go = Resources.Load("Prefab/Memo_SaitoComment") as GameObject;
            memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;
        }

        if (gameObject.name == "Nemoto")
        {
            //Resources内のすしネコのスプライトを配列で取得
            Sprite[] images = Resources.LoadAll<Sprite>("sb");
            sushiPos = sushiPos.GetComponent<Image>();
            sushiPos.sprite = images[1];


            Sprite[] nameImgs = Resources.LoadAll<Sprite>("Images/BG_Staffroll01");
            namePos = namePos.GetComponent<Image>();
            namePos.sprite = nameImgs[4];

            Sprite[] sp = Resources.LoadAll<Sprite>("Images/BG_Staffroll02");
            rolePos = rolePos.GetComponent<Image>();
            rolePos.sprite = sp[0];

            GameObject go = Resources.Load("Prefab/Memo_NemotoComment") as GameObject;
            memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;
        }

        if (gameObject.name == "Omake")
        {
            //Resources内のすしネコのスプライトを配列で取得
            Sprite[] images = Resources.LoadAll<Sprite>("sb");
            sushiPos = sushiPos.GetComponent<Image>();
            sushiPos.sprite = images[4];


            Sprite[] nameImgs = Resources.LoadAll<Sprite>("Images/BG_Staffroll03");
            namePos = namePos.GetComponent<Image>();
            namePos.sprite = nameImgs[0];

            Sprite[] sp = Resources.LoadAll<Sprite>("Images/BG_Staffroll03");
            rolePos = rolePos.GetComponent<Image>();
            rolePos.sprite = sp[1];

            GameObject go = Resources.Load("Prefab/Memo_OmakeComment") as GameObject;
            memoPos.GetComponent<Text>().text = go.GetComponent<Text>().text;
            Application.OpenURL("https://youtu.be/JtEnkMeWn-Y");
        }
    }

    public void Omake()
    {

    }


}
