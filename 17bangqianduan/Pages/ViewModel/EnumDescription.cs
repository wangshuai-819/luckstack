using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace _17bangqianduan.Pages.Problem
{
    public static class EnumDescription
    {
        public static string GetEnumDescription<T>(this T value)
        {
            Type typeInfo = typeof(T);
            FieldInfo EnumField = typeInfo.GetField(value.ToString());
            DescriptionAttribute attribute = (DescriptionAttribute)
                Attribute.GetCustomAttribute(EnumField, typeof(DescriptionAttribute));
            return attribute.Description;
        }
    }
}
