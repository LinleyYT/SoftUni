﻿using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                                                      | BindingFlags.NonPublic | BindingFlags.Public);
        var stringBuilder = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return stringBuilder.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        var stringBuilder = new StringBuilder();

        Type classType = Type.GetType(className);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (FieldInfo field in classFields)
        {
            stringBuilder.AppendLine($"{field.Name} must be private!");
        }

        foreach (MethodInfo method in classNonPublicMethods.Where(p => p.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in classPublicMethods.Where(p => p.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine($"{method.Name} have to be private!");
        }

        return stringBuilder.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        var stringBuilder = new StringBuilder();
        Type classType = Type.GetType(className);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        stringBuilder.AppendLine($"All Private Methods of Class: {className}");
        stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in classNonPublicMethods)
        {
            stringBuilder.AppendLine(method.Name);
        }
        return stringBuilder.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        var stringBuilder = new StringBuilder();
        Type classType = Type.GetType(className);
        MethodInfo[] classProperties =
            classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (MethodInfo getterInfo in classProperties.Where(x => x.Name.StartsWith("get")))
        {
            stringBuilder.AppendLine($"{getterInfo.Name} will return {getterInfo.ReturnType}");
        }

        foreach (MethodInfo setterInfo in classProperties.Where(x => x.Name.StartsWith("set")))
        {
            stringBuilder.AppendLine(
                $"{setterInfo.Name} will set field of {setterInfo.GetParameters().First().ParameterType}");
        }

        return stringBuilder.ToString().Trim();
    }
}