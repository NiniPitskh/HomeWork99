using HomeWork9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
    {    
        public abstract class FileWorker
    { 
        public int MaxSize { get; set; }
        public abstract string Extension { get; }
        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();
    }
}



public class TxtFileWorker : FileWorker
{   
    public override string Extension => "txt";

    public override void Read()
    {
        Console.WriteLine($"I can read from {Extension} file with max storage {MaxSize}");
    }

    public override void Write()
    {
        Console.WriteLine($"I can write to {Extension} file with max storage {MaxSize}");
    }

    public override void Edit()
    {
        Console.WriteLine($"I can edit {Extension} file with max storage {MaxSize}");
    }

    public override void Delete()
    {
        Console.WriteLine($"I can delete {Extension} file with max storage {MaxSize}");
    }
}