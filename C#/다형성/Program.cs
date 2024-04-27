namespace 다형성
{
    // 다형성(Polymorpism) : 예시. 반지의 제왕 용 -> 인간 폴리모프
    // 동일한 이름의 클래스가 다양한 형태의 클래스로 변환할 수 있음.
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal eagle = new Animal_Eagle();
            Animal tiger = new Animal_Tiger();
            Animal shark = new Animal_Shark();

            Worker worker = new Worker();

            worker.CareAnimal(eagle);
            worker.CareAnimal(tiger);
            worker.CareAnimal(shark);

            worker.Function(eagle);
            worker.Function(tiger);
            worker.Function(shark);
        }
    }
}
