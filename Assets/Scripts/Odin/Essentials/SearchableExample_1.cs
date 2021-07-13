using Sirenix.OdinInspector;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

[Searchable]
public class SearchableExample_1 : MonoBehaviour
{
    public List<string> strings = new List<string>(Enumerable.Range(1, 10).Select(i => "Str Element " + i));

    public List<ExampleStruct> searchableList = new List<ExampleStruct>(Enumerable.Range(1, 10).Select(i => new ExampleStruct(i)));
    [Serializable]
    public struct ExampleStruct
    {
        public string Name;
        public int Number;
        public ExampleEnum Enum;

        public ExampleStruct(int nr) : this()
        {
            this.Name = "Element " + nr;
            this.Number = nr;
            System.Random random = new System.Random((int)DateTime.Now.Ticks + nr);
            this.Enum = (ExampleEnum)random.Next(0, 5); 
        }
    }

    public enum ExampleEnum
    {
        One, Two, Three, Four, Five
    }
}
