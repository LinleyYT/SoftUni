﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Family
{
    public Family()
    {
        this.People = new List<Person>();
    }

    public List<Person> People { get; set; }

    public void AddMember(Person person)
    {
        this.People.Add(person);
    }

    public Person GetOldestMember(List<Person> people)
    {
        return people.FirstOrDefault(x => x.age == people.Max(y => y.age));
    }
}
