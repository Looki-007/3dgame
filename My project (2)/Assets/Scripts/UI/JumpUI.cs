using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class JumpUI : MonoBehaviour
{
    public Text text;
    public JumpMovement Player;

    public void Awake()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = "Прыжки:" + Player.jump.ToString();
    }
}
