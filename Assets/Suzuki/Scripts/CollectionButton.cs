using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectionButton : MonoBehaviour
{
    public Text memoPos;
    public GameObject sushiPos;

    public void OnClick()
    {
        Debug.Log(gameObject.name);

        Sprite[] images = Resources.LoadAll<Sprite>("sb");
        //Texture2D texture = Resources.Load("sb_"+ gameObject.name) as Texture2D;
        Image img = sushiPos.GetComponent<Image>();
        img.sprite = images[int.Parse(gameObject.name)];
        //Debug.Log(Resources.Load("sb_" + gameObject.name));
    }

}
