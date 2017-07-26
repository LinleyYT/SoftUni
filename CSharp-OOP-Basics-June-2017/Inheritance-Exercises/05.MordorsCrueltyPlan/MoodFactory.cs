﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MordorsCrueltyPlan
{
    using MoodModels;

    public class MoodFactory
    {
        public Mood GetMood(int points)
        {
            if (points < -5)
            {
                return new Angry();
            }
            if (points >= -5 && points <= 0)
            {
                return new Sad();
            }
            if (points <= 15)
            {
                return new Happy();
            }
            return new JavaScript();
        }
    }
}