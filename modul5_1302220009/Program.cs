﻿using modul5_1302220009;

public class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<long>data = new SimpleDataBase <long>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(22);
        data.PrintAllData();
    }
}
