using System;
using System.Collections.Generic;
using System.Text;

namespace DataReadWright.Services
{
    public interface IDataManager 
    {
        List<Student> LoadData(string filePath);
        void SaveData(List<Student> std, string filePath);
    }
}
