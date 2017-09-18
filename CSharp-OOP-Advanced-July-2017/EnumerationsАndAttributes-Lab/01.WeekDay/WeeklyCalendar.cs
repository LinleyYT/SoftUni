﻿using System;
using System.Collections.Generic;

public class WeeklyCalendar
{
    public WeeklyCalendar()
    {
        this.WeeklySchedule = new List<WeeklyEntry>();
    }

    public List<WeeklyEntry> WeeklySchedule { get; private set; }

    public void AddEntry(string weekday, string notes)
    {
        this.WeeklySchedule.Add(new WeeklyEntry((WeekDay) Enum.Parse(typeof(WeekDay), weekday), notes));
    }
}