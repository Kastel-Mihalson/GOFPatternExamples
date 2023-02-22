using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    public interface IPrototype
    {
        IPrototype? MClone();
        IPrototype Clone();
        object DeepClone();
        void GetInfo();
    }

    [Serializable]
    public class SomePrototype : IPrototype
    {
        public string Name { get; set; }
        public SomePrototype(string name)
        {
            Name = name;
        }

        public IPrototype? MClone()
        {
            return MemberwiseClone() as IPrototype;
        }

        public IPrototype Clone()
        {
            return new SomePrototype(Name);
        }

        public object DeepClone()
        {
            object prototype = null;
            using(MemoryStream tempMemory = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(
                    null, new StreamingContext(StreamingContextStates.Clone));

                binaryFormatter.Serialize(tempMemory, this);
                tempMemory.Seek(0, SeekOrigin.Begin);

                prototype = binaryFormatter.Deserialize(tempMemory);
            }
            return prototype;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{nameof(SomePrototype)} {Name}");
        }
    }
}