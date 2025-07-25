﻿using System;

namespace TeamProject
{
    public class Monster : Character
    {
        public Monster() : base() 
        {}

        public Monster(string name, int level, float maxHp, float atkPower, float defPower, MonsterIndex index, string description = "")
            : base(name, level, maxHp, atkPower, defPower, index, description)
        {}
        public Monster(Character unit) : base(unit) {}

        /*public string GetStatus()
        {
            if (isDie)
                return $"Lv.{Level} {Name} Dead";
            else
                return $"Lv.{Level} {Name} HP {Hp}";
        }

        public void PrintStatus()
        {
            if (isDie)
                Console.ForegroundColor = ConsoleColor.Gray;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(GetStatus());
            Console.ResetColor();
        }*/
    }
}

