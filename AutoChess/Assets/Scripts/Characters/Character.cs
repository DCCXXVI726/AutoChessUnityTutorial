using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Character
{
    List<Ability> abilities = new List<Ability>();
    
    public void AddAbility(List<Ability> newAbilities) {
        abilities.AddRange(newAbilities);
    }

    public void AddAbility(Ability newAbility) {
        abilities.Add(newAbility);
    }

    public Ability getAbility(Type typeOfAbility) {
        foreach(Ability i in abilities) {
            if (i.GetType() == typeOfAbility) {
                return i;
            }
        }
        return null;
    }
}
