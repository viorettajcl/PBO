namespace Tugas_PBO_1
{
    class Vga
    {
        public string merk;
        public Vga(string merk)
        {
            this.merk = merk;
        }
    }

    class Nvidia : Vga
    {
        public string merk;
        public Nvidia(string merk) : base("Nvidia")
        {
        }
    }

    class AMD : Vga
    {
        public string merk;
        public AMD(string merk) : base("AMD")
        {
        }
    }

    class Processor
    {
        public string merk;
        public string tipe;
        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public string merk;
        public Intel(string tipe) : base("Intel", tipe)
        {
        }
    }

    class amd : Processor
    {
        public string merk;
        public amd(string tipe) : base("AMD", tipe)
        {
        }
    }

    class Corei3 : Intel
    {
        public string tipe;
        public Corei3() : base("Core i3")
        {
        }
    }

    class Corei5 : Intel
    {
        public string tipe;
        public Corei5() : base("Core i5")
        {
        }
    }

    class Corei7 : Intel
    {
        public string tipe;
        public Corei7() : base("Core i7")
        {
        }
    }

    class Ryzen : amd
    {
        public string tipe;
        public Ryzen() : base("RYZEN")
        {
        }
    }

    class Athlon : amd
    {
        public string tipe;
        public Athlon() : base("ATHALON")
        {
        }
    }

    class Laptop
    {
        public string Merk, Tipe, Vga, Processor;

        public Laptop(string merk, string tipe, string vga, string processor)
        {
            this.Merk = merk;
            this.Tipe = tipe;
            this.Vga = vga;
            this.Processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} mati");
        }
        public void Spesifikasi()
        {
            Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} menggunakan VGA {this.Vga} dan Processor {this.Processor}");
        }
    }

    class ASUS : Laptop
    {
        public string merk;
        public ASUS(string Tipe, string Vga, string Processor) : base("ASUS", Tipe, Vga, Processor)
        {
        }
    }

    class ACER : Laptop
    {
        public string merk;
        public ACER(string Tipe, string Vga, string Processor) : base("ACER", Tipe, Vga, Processor)
        {
        }
    }

    class Lenovo : Laptop
    {
        public string merk;
        public Lenovo(string Tipe, string Vga, string Processor) : base("Lenovo", Tipe, Vga, Processor)
        {
        }
    }

    class ROG : ASUS
    {
        public string tipe;
        public ROG(string Vga, string Processor) : base("ROG", Vga, Processor)
        {
        }
    }

    class Vivobook : ASUS
    {
        public string tipe;
        public Vivobook(string Vga, string Processor) : base("Vivobook", Vga, Processor)
        {
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Swift : ACER
    {
        public string tipe;
        public Swift(string Tipe, string Vga, string Processor) : base("Swift", Vga, Processor)
        {
        }
    }

    class Predator : ACER
    {
        public string tipe;
        public Predator(string Vga, string Processor) : base("Predator", Vga, Processor)
        {
        }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {this.Merk} bertipe {this.Tipe} sedang memainkan game");
        }
    }

    class IdeaPad : Lenovo
    {
        public string merk;
        public IdeaPad(string Vga, string Processor) : base("IdeaPad", Vga, Processor)
        {
        }
    }

    class Legion : Lenovo
    {
        public string merk;
        public Legion(string Vga, string Processor) : base("Legion", Vga, Processor)
        {
        }
    }

    internal class program
    {
        public static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook("Nvidia", "Core i5");
            ((Vivobook)laptop1).Ngoding();
            ((Vivobook)laptop1).Spesifikasi();

            Laptop laptop2 = new IdeaPad("AMD", "RYZEN");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Laptop predator = new Predator("AMD", "Core i7");
            ((Predator)predator).BermainGame();

            Laptop acer = new ACER("Predator", "AMD", "RYZEN");
            //((ACER)acer).BermainGame();
        }
    }
}