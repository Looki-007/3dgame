using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class CoinUI : MonoBehaviour
{
    public Text text;
    public CoinTaker Player;

    public void Awake()
    {
        text = GetComponent<Text>();

    }
    private void Update()
    {
        text.text = "Монетки: " + Player.coins.ToString();
    }
}