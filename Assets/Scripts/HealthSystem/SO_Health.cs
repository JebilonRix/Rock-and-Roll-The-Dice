using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Health", menuName = "Systems/Health")]
public class SO_Health : ScriptableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private string _name = "Player";
    [SerializeField] private UIHandler _uihandler;
    [SerializeField] private SO_SpriteHolder _spriteHolder;

    private int _health;
    private Image _image;

    public int Health { get => _health; private set => _health = value; }

    private void OnDisable()
    {
        ResetHealth();
    }
    public void ResetHealth()
    {
        Health = _maxHealth;
        SetSprite();
    }
    public void HealthBarIn�t(Image image)
    {
        Debug.Log("bar setted");
        _image = image;
        SetSprite();
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;

        SetSprite();

        if (Health <= 0)
        {
            WinLoseCondition();
        }
    }
    public void WinLoseCondition()
    {
        if (_name == "Player")
        {
            //lose
            _uihandler.ChangeActivePanel(3);
        }
        else
        {
            //win
            _uihandler.ChangeActivePanel(2);
        }
    }

    private void SetSprite()
    {
        if (_image == null)
        {
            return;
        }

        if (Health <= _maxHealth && Health > _maxHealth * 0.8f)
        {
            _image.sprite = _spriteHolder.Sprites[0];
        }
        else if (Health < _maxHealth * 0.8f && Health > _maxHealth * 0.6f)
        {
            _image.sprite = _spriteHolder.Sprites[1];
        }
        else if (Health < _maxHealth * 0.6f && Health > _maxHealth * 0.4f)
        {
            _image.sprite = _spriteHolder.Sprites[2];
        }
        else if (Health < _maxHealth * 0.4f && Health > _maxHealth * 0.2f)
        {
            _image.sprite = _spriteHolder.Sprites[3];
        }
        else if (Health < _maxHealth * 0.2f)
        {
            _image.sprite = _spriteHolder.Sprites[4];
        }
        else if (Health <= 0)
        {
            _image.sprite = _spriteHolder.Sprites[5];
        }
    }
}