namespace Memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 10;

            value = SomeFunction(value);

            Console.ReadLine();
            Console.WriteLine(value);

            Memory myMemory = new Memory();
            myMemory.SomeFunction(value);
            Console.WriteLine("myMemory의 value: " + myMemory.value);
        }


        static void SomeFunction(int value)
        {
            value = 100;
        }

        static void OtherFunction(int value, Memory _memory)
        {

        }
    }
}
