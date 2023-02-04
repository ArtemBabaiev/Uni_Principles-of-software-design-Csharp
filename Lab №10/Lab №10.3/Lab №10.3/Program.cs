using System;

namespace Lab__10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть CPU: ");
            string proc = Console.ReadLine();
            Console.Write("Його частоту: ");
            int procFreq = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть GPU: ");
            string video = Console.ReadLine();
            Console.Write("Її вміст відео пам'яті: ");
            int Vmem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кіль-сть ОП: ");
            int ram = Convert.ToInt32(Console.ReadLine());
            Console.Write("Її частота: ");
            int ramfreq = Convert.ToInt32(Console.ReadLine());
            Console.Write("Чи добра сист. охолдження true/false: ");
            bool coolsyst = Convert.ToBoolean(Console.ReadLine());
            var comp = new Computer(proc, procFreq, video, Vmem, ram, ramfreq, coolsyst);
            comp.PrintChar();
            Console.WriteLine(comp.BoostCPU(25));
            Console.WriteLine(comp.ChangeVideoCard("560r", 2));
            if (comp.CompatibilityOfRAM(4500, 8))
            {
                Console.WriteLine("Додавання можливе");
            }
            else
            {
                Console.WriteLine("Додавання не рекомендується");
            }
            comp.PrintChar();
        }
    }
    public class Computer
    {
        private string processor;
        private int frequency;
        private string gpu;
        private int videoMemory;
        private int ram;
        private int frequencyOfRam;
        private bool isGoodCoolSystem;

        public Computer(string processor, int frequency, string gpu, int videoMemory, int ram, int frequencyOfRam, bool isGoodCoolSystem)
        {
            this.processor = processor;
            this.frequency = frequency;
            this.gpu = gpu;
            this.videoMemory = videoMemory;
            this.ram = ram;
            this.frequencyOfRam = frequencyOfRam;
            this.isGoodCoolSystem = isGoodCoolSystem;
        }
    
        public string BoostCPU(int increase)
        {
            if (isGoodCoolSystem)
            {
                frequency += increase;
                return $"Процессор розігнано до частоти {frequency}";
            }
            else
            {
                return "Система охолодження погана. Розгін не рекомендується";
            }
            
        }
        public string ChangeVideoCard(string newType, int capacity)
        {
            gpu = newType;
            videoMemory = capacity;
            return $"Виконано заміну відеокарти на {gpu} з об\'ємом відеопам\'яті {videoMemory}";
        }
        public bool CompatibilityOfRAM(int newRAMFreq, int newRAMCap)
        {
            bool good = true;
            if (newRAMFreq != frequencyOfRam)
            {
                good = false;
            }
            if (newRAMCap != ram)
            {
                good = false;
            }
            return good;
        }
        public void PrintChar()
        {
            Console.WriteLine($"CPU: {processor} | CPU freq: {frequency} | GPU: {gpu} | Video Memory: {videoMemory} | RAM: {ram} | Freq RAM: {frequencyOfRam} | IsCoolSystem: {isGoodCoolSystem}");
        }
    }
}
