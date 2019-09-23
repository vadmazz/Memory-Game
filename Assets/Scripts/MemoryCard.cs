using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] private GameObject cardBack;
    [SerializeField] private SceneController controller;
    private int _id;
    public int Id
    {
        get { return _id; }
    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.CanReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
        
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    public void SetCard(int id, Sprite sprite)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
