using System;
using TMPro;
using UnityEngine;

public class Character : MonoBehaviour
{
    public SpriteRenderer eyes;

    public SpriteRenderer mouths;

    public SpriteRenderer weapon;

    public TextMeshPro txt;
    public string Charactername;

    public bool Compare(Character character)
    {
        return eyes.sprite.texture.Equals(character.eyes.sprite.texture) && mouths.sprite.texture.Equals(character.mouths.sprite.texture) && weapon.sprite.texture.Equals(character.weapon.sprite.texture);
    }

    public void SetAppearance(CharacterAppearance appearance)
    {
        eyes.sprite = appearance.eyes;
        weapon.sprite = appearance.weapon;
        mouths.sprite = appearance.mouths;
        Charactername = appearance.Charactername;
        txt.text = Charactername;
    }

    override public int GetHashCode()
    {
        return HashCode.Combine(eyes, mouths, weapon);

       // return eyes.GetHashCode() + mouths.GetHashCode() + weapon.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        if (!(obj is Character))
            return false;

        if (obj is Character)
        {
            var other = obj as Character;
            return eyes.Equals(other.eyes) && mouths.Equals(other.mouths) && weapon.Equals(other.weapon);
        }

        return false;
    }
    public CharacterMap ToCharacterMap()
    {
        return new CharacterMap(eyes.sprite, mouths.sprite, weapon.sprite, Charactername);
    }
}
