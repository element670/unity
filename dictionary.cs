using System;
using UnityEngine;

public class CharacterMap 
{
    private Sprite eyes;

    private Sprite mouths;

    private Sprite weapon;
    public string Charactername;
    public CharacterMap(Sprite eyes, Sprite mouths, Sprite weapon, string name)
    {
        this.eyes = eyes;
        this.mouths = mouths;
        this.weapon = weapon;
        Charactername = name;
    }
    override  public int GetHashCode()
    {
        return HashCode.Combine(eyes, mouths, weapon);
        //return eyes.GetHashCode() + mouths.GetHashCode() + weapon.GetHashCode();

    }
    public override bool Equals(object obj)
    {
        if(!(obj is CharacterMap) )
            return false;
        
        if(obj is CharacterMap)
        {
            var other = obj as CharacterMap;
            return eyes.Equals(other.eyes) && mouths.Equals(other.mouths) && weapon.Equals(other.weapon);
        }

        return false;
    }
}
