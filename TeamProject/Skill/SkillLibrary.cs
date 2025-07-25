﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{

    // 스킬 DB용, 현재 사용x
    internal class SkillLibrary
    {
        private static SkillLibrary? instance;

        public static SkillLibrary Instance
        {
            get
            {
                if (instance == null)
                    instance = new SkillLibrary();
                return instance;
            }

        }

        private Player player;
        private List<Skill> skills;

        private SkillLibrary()
        {
            this.player = Player.Instance;
            skills = new List<Skill>();
            CreateSkills();
        }

        private void CreateSkills()
        {
            skills.Add(new Skill());
            skills[0].Name = "기본 공격";
            skills[0].Atk = (int)player.AtkPower; // 기본 공격력
            skills[0].PP = 100; 
            skills[0].Description = "적에게 기본 공격을 한다.";
            skills[0].Type = Skill.SkillType.Normal;

            skills.Add(new Skill());
            skills[1].Name = "몸통 박치기";
            skills[1].Atk = (int)(player.AtkPower * 1.5f);
            skills[1].PP = 1;
            skills[1].Description = "상대를 향해서 몸 전체를 부딪쳐가며 공격한다.";
            skills[1].Type = Skill.SkillType.AttackSkill;

            skills.Add(new Skill());
            skills[2].Name = "뛰어오르기";
            skills[2].Atk = 1;
            skills[2].PP = 10;
            skills[2].Description = "팔딱거린다.";
            skills[2].Type = Skill.SkillType.AttackSkill;

        }

        public Skill GetSkill(int idx)
        {
            return skills[idx];
        }

        public List<Skill> GetAllSkills()
        {
            return new List<Skill>(skills);
        }


    }
}
