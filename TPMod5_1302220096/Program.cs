using System;

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public T Data
    {
        get {return data;}
        set {data = value;}
    }

    public void PrintData()
    {
        System.Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Kal");

        string NIM = "1302220096";
        DataGeneric<string> dataString = new DataGeneric<string>(NIM);
        dataString.PrintData();
    }
}